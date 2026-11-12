# 🎓 Goldfields Connect - College Learning Management System

![Goldfields TVET College](https://img.shields.io/badge/Institution-Goldfields_TVET_College-purple)
![ASP.NET Core](https://img.shields.io/badge/.NET-8.0-blue)
![Supabase](https://img.shields.io/badge/Backend-Supabase-green)
![Bootstrap](https://img.shields.io/badge/UI-Bootstrap_5-purple)

**Goldfields Connect** is a centralized, role-based College Management and Learning Management System (LMS). It is designed to bring students, lecturers, Heads of Department (HODs), and administrators together on a single, secure web platform. 

The system supports the entire student lifecycle—from registration and enrolment to teaching, assessment, results, and academic progression—with a modern, responsive UI aligned with the Goldfields TVET College brand (Deep Purple, Warm Gold, and White).

---

## 🚀 Key Features

### 🔐 Secure Authentication & Role Management
*   Powered by **Supabase Auth** (JWT & secure HTTP-only cookies).
*   Five distinct user roles, each with a customized dashboard and navigation menu:
    *   **System Administrator** (Full system access, user management, audit logs).
    *   **Academic Administrator** (Student registrations, courses, enrolments, results).
    *   **Head of Department (HOD)** (Moderation of marks, departmental oversight).
    *   **Lecturer** (Course materials, grading, attendance).
    *   **Student** (View courses, submit assessments, view results).

### 📚 Academic & Learning Modules
*   **Student Management:** Register students, assign to programmes, track academic history.
*   **Course & Subject Management:** Create programmes, subjects, and allocate lecturers.
*   **Unified Assessments:** A seamless module for both **File Upload Assignments** and **Live Timed Online Tests** (featuring a JavaScript countdown timer).
*   **Results & Moderation:** Lecturers capture marks, HODs moderate, and Admins publish final results.
*   **Attendance Tracking:** Lecturers record attendance; students view their history.
*   **Timetables & Rooms:** Manage schedules and detect venue clashes.

### 📊 Reporting & Integrations
*   **PDF & Excel Generation:** Export academic reports and transcripts using `IronPDF` and `IronXL`.
*   **Cloud Storage:** Secure file uploads (learning materials, assignment submissions) via **Supabase Storage**.
*   **Real-time Updates:** Powered by Supabase Realtime.

---

## 🛠️ Technology Stack

*   **Framework:** ASP.NET Core MVC (.NET 8)
*   **Database:** PostgreSQL (Hosted on Supabase)
*   **ORM:** Entity Framework Core (Npgsql)
*   **Authentication:** Supabase Auth & ASP.NET Core Cookie Authentication
*   **Frontend:** Razor Views, HTML5, CSS3, Bootstrap 5, FontAwesome
*   **Reporting:** IronPDF & IronXL
*   **Live Features:** JavaScript (Timers), Supabase Realtime

---

## ⚙️ Getting Started (Local Development)

### Prerequisites
*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
*   [Visual Studio 2022](https://visualstudio.microsoft.com/) (or VS Code)
*   A [Supabase](https://supabase.com/) account.

### 1. Clone the Repository
```bash
git clone https://github.com/your-username/Goldfields-Connect.git
cd Goldfields-Connect
