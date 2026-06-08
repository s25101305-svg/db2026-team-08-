# System Architecture — University Management System

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

---

## Architecture Overview

The system follows a 3-layer architecture:

### 1. Presentation Layer
Windows Forms handles all user interfaces:
- `LoginForm` — entry point for all users
- `StudentForm` — student profile and enrollment
- `InstructorForm` — instructor profile, rosters, and grades
- `AdminForm` — full system management

### 2. Business Logic Layer
C# event handlers manage:
- User authentication and role-based routing
- Course enrollment and drop logic
- Grade submission
- CRUD operations for admin management

### 3. Data Access Layer
ADO.NET Entity Framework (.edmx) handles:
- Auto-generated data objects from MS-SQL tables
- BindingSource and TableAdapter for data binding
- SaveChanges() for persisting data

---

## Database Schema

| Table | Key Columns |
|-------|-------------|
| user | ID, username, password, role |
| student | ID, name, dept_name, tot_cred |
| instructor | ID, name, dept_name, salary |
| department | dept_name, building, budget |
| course | course_id, title, dept_name, credits |
| section | course_id, sec_id, semester, year, building, room_number, time_slot_id |
| takes | ID, course_id, sec_id, semester, year, grade |
| teaches | ID, course_id, sec_id, semester, year |
| time_slot | time_slot_id, day, start_time, end_time |
| classroom | building, room_number, capacity |

---

## Application Flow

```
Launch App
    ↓
LoginForm
    ↓ (role check)
    ├── administrator → AdminForm
    │       ├── User Management Tab
    │       ├── Course Management Tab
    │       ├── Department Management Tab
    │       └── Reporting & Analytics Tab
    │
    ├── instructor → InstructorForm
    │       ├── Profile Tab
    │       ├── Student Rosters Tab
    │       └── Grades Tab
    │
    └── student → StudentForm
            ├── Profile Tab
            └── Enroll Tab (enroll/drop courses)
```

---

## Design Decisions

- **ADO.NET Entity Framework** was chosen for rapid data binding without writing manual SQL queries
- **TabControl** was used in each form to organize features cleanly
- **Role-based routing** ensures each user only sees relevant features
- **BindingNavigator** provides built-in add/edit/delete/save functionality for admin grids
