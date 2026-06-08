# User Guide — University Management System

## Team Members
| Name | Student ID |
|------|------------|
| Bai Ran-Hao | 25101318 |
| Chen Zhi-Kai | 25101309 |
| Gao Ming-Jie | 25101305 |
| Kang Rui-Le | 25101329 |

---

## Getting Started

### Setup Instructions
1. Open **SSMS** and run `database/schema.sql` to create the database
2. Run `database/seed_data.sql` to insert sample data
3. Open `src/UniversitySystemManagement2026.slnx` in Visual Studio 2022
4. Press **F5** to run the application

### Sample Login Credentials
| Role | Username | Password |
|------|----------|----------|
| Administrator | admin | administrator |
| Student | 00128 | 12345 |

---

## Login Form

1. Enter your **username** and **password**
2. Click **LOGIN**
3. You will be redirected to your role-specific form
4. If credentials are wrong, an error message will appear

---

## Student Guide

### Profile Tab
- View your personal information: ID, name, department, total credits

### Enroll Tab
- **Enroll in a course:**
  1. Select a course from the course dropdown
  2. Select sec_id, semester, and year
  3. Click **ENROLL**
  4. A success message will appear

- **Drop a course:**
  1. Click on the course row in the grid
  2. Click **DROP**
  3. The course will be removed from your enrollment

---

## Instructor Guide

### Profile Tab
- View your personal information: ID, name, department, salary

### Student Rosters Tab
- View all courses you are currently teaching

### Grades Tab
- View all student enrollments
- Click any **grade cell** to edit it
- Click **Save Grades** to save changes to the database

---

## Admin Guide

### User Management Tab
- View all system users
- Add a new user by filling in the empty row at the bottom
- Edit any cell directly by clicking on it
- Delete a row by selecting it and pressing **Delete**
- Click the 💾 **save button** in the toolbar to save all changes

### Course Management Tab
- View, add, edit, and delete courses
- Click 💾 to save changes

### Department Management Tab
- View, add, edit, and delete departments
- Click 💾 to save changes

### Reporting & Analytics Tab
- View enrollment statistics and course performance charts

---

## Common Issues

| Problem | Solution |
|---------|----------|
| Login not working | Check username/password and role in the user table |
| Enroll fails | Make sure the course/section/semester/year combination exists in the section table |
| Changes not saving | Click the 💾 save button in the BindingNavigator toolbar |
| Form shows no data | Check database connection string in App.config |
