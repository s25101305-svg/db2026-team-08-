# User Guide — University Management System 2026

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

This guide covers how to log in and use each screen in the application.

## Getting started

1. Launch the application — the **Login** screen appears first.
2. Enter your **Username** and **Password**.
3. Click **LOGIN**.
4. Depending on your account's role, you'll be taken to a different screen:
   - **Administrator** → the main Admin Dashboard, with access to everything below.
   - **Instructor** → the Instructor screen.
   - **Student** → the Student screen.

If your username or password is wrong, you'll see an "invalid username or password!" message — double-check your credentials and try again.

## Admin Dashboard

If you log in as an administrator, you'll land on a dashboard with one button per area of the system:

| Button | Opens |
|---|---|
| STUDENT | Student management |
| INSTRUCTORS | Instructor management |
| DEPARTMENT | Department management |
| COURSE | Course management |
| ENROLLMENT | Enrollment management |
| SCHEDULING | Time slot scheduling & conflict checking |
| REPORT AND ANALYTICS | Reports and charts |
| LOGOUT | Signs you out and returns to the Login screen |

You can open multiple screens at once from the dashboard — they don't replace each other. Each screen has a **BACK** button that returns you to this dashboard.

## Student management

Use this screen to view, add, update, or delete student records.

- **LOAD** — refreshes the grid with the current list of students.
- **ADD** — fill in **ID**, **name**, **dept name**, and **tot cred**, then click ADD.
  - All four fields are required except tot cred.
  - The department you enter must already exist — add it first under Department management if it doesn't.
  - The student ID must not already be in use.
- **UPDATE** — enter the student's **ID** along with the new values for the other fields, then click UPDATE to save changes to that student.
- **DELETE** — enter the student's **ID** and click DELETE (you'll be asked to confirm).
- **BACK** — return to the dashboard.

Tip: clicking a row in the grid fills in the text boxes above it with that student's data, so you can quickly load a record before updating or deleting it.

## Instructor management

Use this screen to view instructor records.

- **LOAD** — refreshes the grid with the current list of instructors.
- You can edit values directly in the grid. Click the **Save** toolbar button (above the grid) to write your changes back to the database.
- **BACK** — return to the dashboard.

> Note: unlike the other management screens, Instructor management doesn't have separate ADD / UPDATE / DELETE buttons wired up yet — use direct grid editing plus the Save button for changes.

## Department management

- **LOAD** — refreshes the grid with the current list of departments.
- **ADD** — fill in **dept name**, **building**, and **budget**, then click ADD. If the department name already exists, you'll be told instead of getting a duplicate.
- **UPDATE** — enter the department name plus updated building/budget, then click UPDATE.
- **DELETE** — enter the department name and click DELETE (confirmation required).
- **BACK** — return to the dashboard.

Clicking a row in the grid fills in the fields above for editing.

## Course management

- **LOAD** — refreshes the grid with the current list of courses.
- **ADD** — fill in **course id**, **title**, **dept name**, and **credits**, then click ADD. Course IDs must be unique.
- **UPDATE** — enter the course id plus updated title/department/credits, then click UPDATE.
- **DELETE** — enter the course id and click DELETE (confirmation required).
- **BACK** — return to the dashboard.

Clicking a row in the grid loads that course's details into the fields above, and the UPDATE/DELETE buttons only become active once a course id is entered.

## Enrollment management

This screen manages which students are taking which course sections (the "takes" records), including grades.

- **LOAD** — refreshes the grid with current enrollments.
- **ADD** — fill in **ID** (student ID), **course id**, **sec id**, **semester**, **year**, and **grade**, then click ADD.
  - The student ID and course id must already exist in the system.
  - You can't create a duplicate enrollment (same student + course + section + semester + year).
- **UPDATE** — enter the student ID and course id (plus sec id/semester/year to identify the exact enrollment), update the grade or other fields, then click UPDATE.
- **DELETE** — enter the student ID and course id, click DELETE (confirmation required).
- **BACK** — return to the dashboard.

Clicking a row in the grid fills in all the fields above for that enrollment.

## Scheduling

This screen manages class time slots and helps you avoid scheduling conflicts.

- **time slot id**, **day**, **start hr**, **start min**, **end hr**, **end min** — the fields you fill in to define a time slot.
  - Hours must be 0–23, minutes 0–59, and the end time must be after the start time.
- **ADD** — creates a new time slot.
- **UPDATE** — enter the time slot id and the new day/time values, then click UPDATE.
- **DELETE** — enter the time slot id and click DELETE (confirmation required).
- **CLEAR** — empties all the input fields.
- **CHECK CONFLICTS** — enter a day and a start/end time, then click this to see whether any existing time slot on that day overlaps with the one you've entered. You'll get either "No conflicts found" or a list of the conflicting time slots and their times.
- **REFRESH** — reloads the grid.
- **BACK** — return to the dashboard.

Clicking a row in the grid loads that time slot's details into the fields above.

## Reports and Analytics

This screen has two tabs: **Report** and **Analytics**.

### Report tab

Three buttons load different tabular reports into the grid:
- **Student Report** — full list of students.
- **Course Report** — full list of courses.
- **Enrollment Report** — a combined view showing each student, the course they're taking, and their grade.

### Analytics tab

Three buttons draw different charts:
- A **pie chart** of student count by department.
- A **column chart** of credits per course.
- A **column chart** of enrollment count per course.

Click **CLOSE** to exit this screen.

## Logging out

From the Admin Dashboard, click **LOGOUT** to close all admin screens and return to the Login screen. If you logged in as an instructor or student, closing that form will similarly return you to the Login screen.

## A few things to keep in mind

- Most "Add" actions require the related record to already exist — for example, you must add a department before you can add a student in that department, and a student plus a course must both exist before you can enroll that student.
- Deletes always ask for confirmation, so you won't accidentally remove a record with one click.
- If something goes wrong on the database side (for example, a connection issue), you'll see a message box describing the database error rather than the app crashing.
