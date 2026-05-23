# 🏬 Enterprise E-Commerce Management System

## 🚀 Overview

Enterprise-level E-Commerce Management System built with **ASP.NET MVC**, focused on **scalable architecture**, **clean separation of concerns**, and **performance-aware data access**.

---

## 🧰 Tech Stack

* ASP.NET MVC
* Entity Framework Core
* Dapper
* SQL Server
* ASP.NET Identity
* LINQ (Dynamic Querying)
* AJAX + Partial Views

---

## 🧠 Architecture

### High-Level Architecture Diagram

```
        ┌──────────────────────┐
        │   Presentation Layer │
        │   (MVC Controllers)  │
        └─────────┬────────────┘
                  ↓
        ┌──────────────────────┐
        │    Service Layer     │
        │  (Business Logic)    │
        └─────────┬────────────┘
                  ↓
        ┌──────────────────────┐
        │  Repository Layer    │
        │ (Data Abstraction)   │
        └─────────┬────────────┘
                  ↓
   ┌──────────────────────────────────┐
   │       Data Access Layer          │
   │  EF Core | Dapper | SQL Server  │
   └──────────────────────────────────┘
```

### Key Design Patterns

* Repository Pattern (Generic + Custom)
* Unit of Work
* Service Layer
* Dependency Injection
* DTOs & ViewModels Separation
* Soft Delete (Global Query Filters)
* Role-Based Authorization (RBAC)

---

## ⚡ Key Highlights

* Hybrid EF Core + Dapper data access
* Advanced SQL (CTEs, Views, Functions, Transactions)
* Clean separation of concerns
* Scalable and maintainable design

---

## 🛒 Order Lifecycle

1. Cart Creation
2. Checkout
3. Courier Assignment
4. Delivery
5. Returns Handling

---

## 📄 Pagination & Filtering

* Server-side pagination
* Dynamic LINQ filtering
* State-based page management

---

## 🔐 Authentication & Authorization

* ASP.NET Identity
* Role-based access control
* Business-layer validation

---

## 🛠️ How to Run

```bash
Update-Database
```

* Ensure SQL Server is running
* Update connection string if needed

---

## 🔄 Version Control

* Git-based workflow with feature branching strategy
* Structured commits for incremental and traceable development
* Isolated feature development across services and modules

---

## 🎯 What This Project Demonstrates

* Enterprise backend architecture
* Hybrid ORM strategy
* Advanced SQL usage
* Real-world system design

---
