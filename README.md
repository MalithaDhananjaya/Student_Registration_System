# Student Registration System - Skills International School

A comprehensive desktop-based management application developed as the Final Project for the Level 3 Diploma in Information Technology at ESOFT Metro Campus (Graded Distinction). The system is designed to streamline administrative workflows by securely managing student enrollments and records.

## 🚀 Features

- **Secure Authentication:** Multi-user login system protecting unauthorized database access.
- **Full CRUD Functionality:** Seamlessly Register, Read, Update, and Delete student records.
- **Smart Search:** Quick search dropdown that automatically populates the form with existing student details.
- **Data Validation:** Strict client-side validation to ensure clean input and data integrity.
- **Relational Backend:** Fully integrated with Microsoft SQL Server for robust data handling.

## 🛠️ Tech Stack

- **Frontend/UI:** C# Windows Forms (.NET 8.0)
- **Backend Language:** C# .NET
- **Database:** Microsoft SQL Server (MSSQL)
- **Database Tools:** SQL Server Management Studio (SSMS)

## 📊 Database Architecture

The system utilizes a relational database structure consisting of two core tables:
- `Logins`: Stores administrator credentials (Primary Key: `username`).
- `Registration`: Stores extensive student profiles including personal, contact, and parental details (Primary Key: `regNo`).

---

## 💻 Form Previews

### 1. Secure Login Form

An intuitive login interface validating administrative access against database credentials. Includes built-in error handling for invalid entries.
<img width="513" height="549" alt="Screenshot 2026-07-09 203406" src="https://github.com/user-attachments/assets/feb251b8-5271-4890-a8a6-ec30874710bf" />

### 2. Main Registration Dashboard
<img width="1049" height="1020" alt="Screenshot 2026-07-09 203458" src="https://github.com/user-attachments/assets/35cae69f-28db-4b82-bc18-1ed5efb625d7" />

A cohesive administrative dashboard with tabbed/grouped layouts for Basic Details, Contact Details, and Parent Details, along with action triggers for database transactions.

---

## ⚙️ Setup & Installation

### 1. Database Setup
1. Open **SQL Server Management Studio (SSMS)**.
2. Create a database named `StudentDB` and execute your database scripts to create the required tables.
3. Insert the default administrator credentials into your database.

### 2. Configure Connection String
1. Open the project in **Visual Studio**.
2. Locate the `App.config` file in the Solution Explorer.
3. Update the `connectionString` to match your local SQL Server instance name (Replace `YOUR_SERVER_NAME` with your computer's SQL server name):

```xml
<connectionStrings>
  <add name="StudentDB" connectionString="Data Source=YOUR_SERVER_NAME; Database=StudentDB; Trusted_Connection=True; TrustServerCertificate=True;" providerName="Microsoft.Data.SqlClient"/>
</connectionStrings>m
