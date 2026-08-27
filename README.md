# ClinicBooking 🏥

A full-stack **ASP.NET Core MVC** web application for managing doctor directories and appointment requests, featuring custom authentication, authorization, and session middleware.

---

## 🚀 Key Features

* **Authentication & Authorization**: Built-in Register and Login flows using ASP.NET Core Cookie Authentication and `PasswordHasher`.
* **Role-Based Access Control (RBAC)**: 
  * **Admin**: Full access to Create, Edit, and Delete doctor profiles.
  * **Receptionist / Patient**: Read-only access to doctor directories.
  * Custom **403 Access Denied** handling for unauthorized requests.
* **Custom Middleware & Session Handling**: 
  * Automatic logout after **15 minutes of inactivity** managed via custom HTTP pipeline middleware.
* **Architecture**: Repository Pattern for data access separation using Entity Framework Core.

---

## 🛠️ Tech Stack

* **Framework**: ASP.NET Core MVC (.NET 8)
* **Database**: SQL Server & Entity Framework Core
* **Authentication**: Cookie-based Authentication
* **UI**: Bootstrap 5 & Razor Views

---

## 👤 Pre-configured Accounts (Seed Data)

| Role | Email | Password |
| :--- | :--- | :--- |
| **Admin** | `admin@clinic.com` | `Admin123!` |
| **Receptionist** | `rec1@clinic.com` | `Rec12345!` |
