# University Management System — Team 08

## Team Members

| Name | Student ID |
|------|------------|
| Bai Ran-Hao | 25101318 |
| Chen Zhi-Kai | 25101309 |
| Gao Ming-Jie | 25101305 |
| Kang Rui-Le | 25101329 |

## Tech Stack

- Language: C# / .NET Framework
- Database: MS-SQL Server
- ORM: ADO.NET Entity Framework
- IDE: Visual Studio 2022

## Project Description

A comprehensive University Management System that facilitates the management of academic and administrative tasks. The system provides role-based access for administrators, instructors, and students.

## Features

- Role-based login (Administrator, Instructor, Student)
- Student course enrollment and drop
- Instructor grade submission
- Admin user, course, and department management
- Reporting and analytics dashboard

## How to Run

1. Open **SSMS** and run `database/schema.sql` to create the database
2. Run `database/seed_data.sql` to insert sample data
3. Open `src/UniversitySystemManagement2026.slnx` in Visual Studio 2022
4. Update the connection string in `App.config` if needed
5. Press **F5** to run the application

## Login Credentials (Sample)

| Role | Username | Password |
|------|----------|----------|
| Administrator | admin | administrator |
| Student | 00128 | 12345 |
| Instructor | 10101 | 12345 |
