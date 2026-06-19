# Architecture — University Management System 2026

## Team Members
| Name | Student ID |
|------|------------|
| Bai Ran-Hao | 25101318 |
| Chen Zhi-Kai | 25101309 |
| Gao Ming-Jie | 25101305 |
| Kang Rui-Le | 25101329 |

---

## Tech Stack

| Component | Technology |
|-----------|------------|
| Language | C# / .NET Framework |
| UI Framework | Windows Forms |
| Database | Microsoft SQL Server (MS-SQL) |
| ORM | ADO.NET Entity Framework (.edmx) |
| IDE | Visual Studio 2022 |

## Overview

This is a desktop application built with **C# WinForms** targeting **.NET Framework 4.7.2**. It provides role-based CRUD access (Admin / Instructor / Student) to a SQL Server database modeled on the classic university schema (students, instructors, courses, sections, departments, enrollments, time slots).

The app has no separate service or web layer — UI forms talk almost directly to the database. There are two parallel data-access styles in play, described below.

## Tech stack

| Layer | Technology |
|---|---|
| UI | Windows Forms (.NET Framework 4.7.2) |
| Data access (primary) | Raw ADO.NET (`SqlConnection` / `SqlCommand` / `SqlDataAdapter`) |
| Data access (secondary) | Entity Framework 5.0 + a typed DataSet (`UniversityDataSet1`) used by the WinForms Designer's data-binding |
| Database | SQL Server Express (`.\sqlexpress`), database name `University` |
| Charting | `System.Windows.Forms.DataVisualization.Charting` (built-in WinForms chart control) |

## Solution layout

```
University Management System 2026.csproj
Program.cs                      — entry point, launches LoginForm
App.config                      — connection strings, EF config

Forms (UI + per-form code-behind):
  LoginForm        — authentication, role-based routing
  AdminForm        — dashboard / launcher for all management forms
  StudentForm      — manage students
  InstructorForm   — manage instructors
  CourseForm       — manage courses
  DepartmentForm   — manage departments
  EnrollmentForm   — manage enrollments ("takes")
  SchedulingForm   — manage time slots, conflict checking
  Report&Analysis  — reports + charts (Report_Analysis class)

Entity / model classes (EF-generated, one per DB table):
  student.cs, instructor.cs, course.cs, department.cs, section.cs,
  classroom.cs, advisor.cs, time_slot.cs, take.cs, user.cs

EF plumbing:
  UniversityModel.edmx / .cs / .Context.cs / .Designer.cs   — EF model
  UniversityDataSet.xsd / UniversityDataSet1.xsd            — typed DataSets
                                                                bound to the
                                                                WinForms designer

Resources/
  bg.jpeg                       — background image asset
```

## Entry point and navigation flow

`Program.cs` starts the app by running `LoginForm` as the main form (`Application.Run(new LoginForm())`).

```
LoginForm (auth)
   │  on success, routed by user.role
   ├── role = "administrator" → AdminForm (ShowDialog)
   │                                │
   │                                ├── StudentForm
   │                                ├── InstructorForm
   │                                ├── DepartmentForm
   │                                ├── CourseForm
   │                                ├── EnrollmentForm
   │                                ├── SchedulingForm
   │                                └── Report_Analysis
   ├── role = "instructor"    → InstructorForm (ShowDialog)
   └── role = "student"       → StudentForm (ShowDialog)
```

- `AdminForm` is a dashboard/launcher: each button (`STUDENT`, `INSTRUCTORS`, `DEPARTMENT`, `COURSE`, `ENROLLMENT`, `SCHEDULING`, `REPORT AND ANALYTICS`) opens the corresponding form with `.Show()` (non-modal, so several can be open at once alongside the dashboard).
- Each sub-form's **BACK** button looks for an already-open `AdminForm` via `Application.OpenForms`, brings it to front, and closes itself — falling back to creating a new `AdminForm` if none is found.
- **LOGOUT** on `AdminForm` simply closes the form, which returns control to the hidden `LoginForm` (since `AdminForm` was opened with `ShowDialog()`), which then re-shows itself.

## Authentication

`LoginForm.button1_Click` queries the `user` table directly through the EF context (`UniversityEntities`):

```csharp
var user = db.users.Where(u => u.Username == usernameTextBox.Text
                             && u.Password == passwordTextBox.Text).FirstOrDefault();
```

The matched user's `role` field (`"administrator"`, `"instructor"`, or `"student"`, compared case-insensitively) determines which form opens next.

> **Security note:** Passwords are stored and compared in plain text, and the EF query above is safe from SQL injection (LINQ-to-Entities), but there's no hashing, salting, or input sanitization. This is fine for a learning project but should not be used as-is in production.

## Two data-access patterns

This is the most important thing to understand about the codebase: **forms don't all talk to the database the same way.**

### Pattern A — Typed DataSet + TableAdapter (Designer-bound)

Used by: `InstructorForm` (fully), and partially scaffolded into `StudentForm`, `CourseForm`, `DepartmentForm`, `EnrollmentForm`, `SchedulingForm` (each still has a `universityDataSet1`, a `*BindingSource`, a `*TableAdapter`, and a `*BindingNavigatorSaveItem_Click` handler left over from the Designer).

- On `Form_Load`, the relevant `TableAdapter.Fill(...)` populates the typed DataSet.
- A `DataGridView` is bound to a `BindingSource`, which is bound to the DataSet table.
- Editing grid cells and clicking the (Designer-generated) Save toolbar button calls `tableAdapterManager.UpdateAll(...)`, which pushes changes back to the DB.
- **`InstructorForm` only actually uses this pattern** — its LOAD button re-fills the adapter, and BACK returns to the dashboard. Its ADD/UPDATE/DELETE buttons exist in the designer layout but have **no click handlers wired up** (Designer and code-behind both leave them unconnected), so editing instructors currently has to happen via grid-cell edits + the Save toolbar button.

### Pattern B — Raw ADO.NET (hand-written SQL)

Used by: `StudentForm`, `CourseForm`, `DepartmentForm`, `EnrollmentForm`, `SchedulingForm`, `Report_Analysis` for their actual ADD / UPDATE / DELETE / LOAD logic (independent of the leftover DataSet plumbing above).

Typical shape, repeated per form:

```csharp
string conStr = @"Data Source=.\sqlexpress;Initial Catalog=University;Integrated Security=True";

using (SqlConnection con = new SqlConnection(conStr))
using (SqlCommand cmd = new SqlCommand("INSERT INTO ... VALUES (@p1, @p2, ...)", con))
{
    cmd.Parameters.AddWithValue("@p1", value1);
    con.Open();
    int rows = cmd.ExecuteNonQuery();
    con.Close();
}
```

Good practices observed consistently across these forms:
- All queries use **parameterized SQL** (`@param` + `AddWithValue`) — no string-concatenated SQL, so they're not vulnerable to SQL injection.
- Foreign-key existence is checked manually before inserts where relevant (e.g. `StudentForm` checks the department exists before inserting a student; `EnrollmentForm` checks both student and course exist before inserting a `takes` row).
- Duplicate-key checks happen before inserts (e.g. "Department already exists", "A student with this ID already exists").
- Destructive actions (DELETE) prompt for confirmation via `MessageBox.Show(..., MessageBoxButtons.YesNo)`.
- After every mutation, the grid is reloaded (usually by re-invoking the LOAD button's click handler) so the UI reflects the DB state.
- `SqlException` is caught and shown via `MessageBox`, so DB errors don't crash the form.

Clicking a row in a grid (`CellClick`) typically copies that row's values back into the text boxes above the grid, so the same fields double as both a search/filter input and an edit buffer for UPDATE/DELETE.

### Why two patterns exist

This looks like a project that started from Visual Studio's auto-generated "Data Source" scaffolding (TableAdapters + BindingSources, Pattern A), and was then extended with hand-written ADO.NET code (Pattern B) to add validation, FK checks, and confirmation dialogs that the scaffolded CRUD didn't have. The DataSet/TableAdapter wiring from Pattern A was left in place (it still runs on `Form_Load`) even on forms that now do their real work through Pattern B — it's effectively dead weight on those forms.

## Entity model

Both the EF model (`UniversityModel.edmx`) and the plain POCO classes mirror the same database schema (the classic Silberschatz "university" textbook schema, plus a `user` table added for app login).

```
department 1───* course
department 1───* instructor
department 1───* student

course 1───* section
course *───* course        (self-referencing — course prerequisites, via "prereq" table)

section *───* instructor    (via "teaches" table, exposed as section.instructors / instructor.sections)
section 1───* take
section *───1 classroom     (building + room_number)

student 1───* take
student 1───1 advisor *───1 instructor   (advisor is a join entity: s_ID + i_ID)

user  (standalone — ID, Username, Password, role; used only for login, not FK-linked to student/instructor)
```

Key tables and their primary identifying columns:

| Table | Primary key | Notable columns |
|---|---|---|
| `student` | `ID` | `name`, `dept_name` (FK), `tot_cred` |
| `instructor` | `ID` | `name`, `dept_name` (FK), `salary` |
| `department` | `dept_name` | `building`, `budget` |
| `course` | `course_id` | `title`, `dept_name` (FK), `credits` |
| `section` | `course_id` + `sec_id` + `semester` + `year` | `building`, `room_number`, `time_slot_id` |
| `takes` | `ID` + `course_id` + `sec_id` + `semester` + `year` | `grade` |
| `time_slot` | `time_slot_id` + `day` | `start_hr`, `start_min`, `end_hr`, `end_min` |
| `classroom` | `building` + `room_number` | `capacity` |
| `advisor` | `s_ID` + `i_ID` | — |
| `user` | `ID` | `Username`, `Password`, `role` |
| `prereq` | `course_id` + `prereq_id` | — (exists in DB; no dedicated management UI) |
| `teaches` | `ID` + `course_id` + `sec_id` + `semester` + `year` | — (exists in DB; managed implicitly via `section`/`instructor` navigation, no dedicated UI) |

> Note: `prereq` and `teaches` exist as real tables in the database (and in the EF model) but don't have their own management form — they're only reachable indirectly through navigation properties on `course`/`section`/`instructor`.

## Feature-specific notes

**SchedulingForm** includes a genuine conflict-detection feature: given a day and a start/end time, it queries existing `time_slot` rows on that day and flags any whose intervals overlap, using minute-of-day arithmetic:

```sql
WHERE day = @day
  AND NOT ((end_hr*60 + end_min) <= @newStart OR (start_hr*60 + start_min) >= @newEnd)
```

**Report_Analysis** provides tabular reports (full `student` list, full `course` list, a `takes ⨝ student ⨝ course` join showing grades) and three chart views built with the WinForms `Chart` control:
- Pie chart — student count by department
- Column chart — credits by course
- Column chart — enrollment count by course

## Configuration

Connection strings live in `App.config`:
- `UniversityEntities` — used by Entity Framework (EDM metadata + SqlClient provider).
- `University_Management_System_2026.Properties.Settings.UniversityConnectionString` — plain SqlClient connection string, same target DB.

Each form that uses raw ADO.NET also hardcodes its **own** copy of the connection string as a local field (`conStr`) rather than reading from `App.config` / `Properties.Settings`. They all point at the same place (`.\sqlexpress`, database `University`, integrated security), but this duplication means the connection string has to be updated in multiple files (every form with a `conStr` field) if the database location ever changes.

## Known gaps / things to be aware of

- **InstructorForm** has ADD/UPDATE/DELETE buttons in its layout with no event handlers wired — instructor edits currently only work through direct grid editing + the Save toolbar button.
- **Passwords** are plain text, compared with `==`, with no hashing.
- **Connection string duplication** across `StudentForm`, `CourseForm`, `DepartmentForm`, `EnrollmentForm`, `SchedulingForm`, and `Report_Analysis` — each has its own hardcoded copy instead of reading from config.
- **Leftover Designer scaffolding**: most forms still load and bind a typed DataSet via TableAdapter on `Form_Load`, even though their actual CRUD operations go through separate raw ADO.NET methods. This isn't broken, but it's redundant — the DataSet fill on load isn't used for anything once the form's own `Load...()` method runs and rebinds the grid to a fresh `DataTable`.
- **No dedicated UI** for the `prereq` (course prerequisites) or `teaches` (instructor-section assignment) tables, even though both exist in the database and the EF model.
