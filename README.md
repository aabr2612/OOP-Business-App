# Order Management System

The **Order Management System** is a robust desktop application built using **C#** and **.NET Framework 4.8**, offering both a user-friendly **WinForms UI** for customers and employees, and a **Console UI** for admin testing. It efficiently manages employees, customers, products, and orders with a modular backend and hybrid storage approach.

## Table of Contents

1. [Features](#features)  
   - [Employee Management](#employee-management)  
   - [Customer Management](#customer-management)  
   - [Order Processing](#order-processing)  
   - [Product Inventory](#product-inventory)  
   - [Hybrid Storage Model](#hybrid-storage-model)  
2. [Dual User Interfaces](#dual-user-interfaces)  
   - [WinForms UI](#winforms-ui)  
   - [Console UI](#console-ui)  
3. [Backend Overview](#backend-overview)  
   - [Business Logic Layer](#business-logic-layer)  
   - [Data Layer](#data-layer)  
   - [Validation System](#validation-system)  
4. [Installation](#installation)  
   - [Clone the Repository](#1-clone-the-repository)  
   - [Set Up SQL Server Database](#2-set-up-sql-server-database)  
   - [Open in Visual Studio](#3-open-in-visual-studio)  
   - [Configure Database Connection](#4-configure-database-connection)  
   - [Set Up File Storage](#5-set-up-file-storage)  
   - [Build and Run the Solution](#6-build-and-run-the-solution)  
5. [Usage](#usage)  
   - [WinForms UI](#winforms-ui-1)  
   - [Console UI](#console-ui-1)  
6. [Contact](#contact)

## Features

### Employee Management
- Add, update, and remove employees with roles like Admin, SalesPerson, and Technician.
- Activate or deactivate accounts and manage employment details (designation, hire/resignation dates).

### Customer Management
- Register new customers and manage their profiles.
- Track order history and account status.

### Order Processing
- Create new orders and associate them with employees and customers.
- Automatically calculate total prices and update product stock levels.

### Product Inventory
- Add, update, and remove products.
- Maintain product information including name, price, and stock.

### Hybrid Storage Model
- **Employees**: Stored in a file-based system (`employee.txt`).
- **Customers, Products, Orders**: Stored in **SQL Server** for persistent and relational data handling.

## Dual User Interfaces

### WinForms UI
A graphical user interface that offers a rich experience with features tailored to each user role.

- **Customers**: Browse products, place orders, manage profiles, and view order history.
- **SalesPerson**: Manage customers, view order statistics, and handle account activities.
- **Admin**: Full access to employee, customer, product, and order management, including deactivated account oversight.
- Features include:
  - Role-based navigation.
  - DataGridViews for visual data representation.
  - Input validations and error notifications through MessageBox.

### Console UI
A lightweight interface primarily used for backend testing and validation of employee-related operations.

- Admin menu to add, update, remove, and view employees.
- Guided prompts for input and validation.
- Displays employee data in tabular format.

## Backend Overview

The backend, implemented in a reusable library, provides a structured approach to business logic and data operations.

### Business Logic Layer
- Manages all core entities such as Users, Employees, Customers, Products, Orders, and Order Details.
- Implements CRUD operations, validations, price calculations, and stock updates.

### Data Layer

- **File-Based Layer**: Manages employee data via text file storage, supporting all employee-related operations.
- **Database Layer (SQL Server)**:
  - Customer management with status control and order tracking.
  - Product and order handling with automatic stock adjustments.
  - Secure operations through parameterized SQL queries.

### Validation System
Centralized and consistent input validation applied across both UIs.

- **User Validations**:
  - Username: Alphanumeric, ≤20 characters, must be unique.
  - Email: Valid format, must be unique.
  - Password: 6-20 characters, must include letters and digits.
  - Contact: Numeric, 4-15 digits.
  - DOB: Must be over 16 years old.
- **Product Validations**:
  - Name: Alphanumeric, ≤20 characters, must be unique.
  - Price: Greater than 0.
  - Stock: 0 or higher.

Validation errors are returned as descriptive messages, aiding users and admins in correcting input quickly.

## Installation

### 1. Clone the Repository
```bash
git clone https://github.com/aabr2612/oop-business-app.git
```
### 2. Set Up SQL Server Database

Create a SQL Server database manually or using the provided SQL script:

- Open SQL Server Management Studio (SSMS).
- Create a new database (e.g., `OrderManagement`).
- Run the `DellDB.sql` script located in the root of the repository to create the necessary tables.

 Ensure the database name in the connection string matches the one you created.

### 3. Open in Visual Studio

- Launch **Visual Studio 2019 or later**.
- Select `File > Open > Project/Solution`.
- Open the `.sln` file from the cloned repository.


### 4. Configure Database Connection

In `Configuration.cs`, verify and update the database connection string:

```csharp
return new SqlConnection("Server=(local);Database=OrderManagement;Trusted_Connection=True");
```
Replace (local) with your SQL Server instance and update the database name if different.
### 5. Set Up File Storage

Employee data is stored in a file-based system:

- Default file path: `D:\employee.txt`
- Ensure this file exists and is writable.
- If you wish to change the path:
  - Open `EmployeeDLFH.cs`
  - Update the file path in the code to your preferred location.

This allows the application to handle employee records even without SQL Server access.

### 6. Build and Run the Solution

To compile and run the application:

1. In Visual Studio, go to `Build > Build Solution` or press `Ctrl + Shift + B`.
2. Set the desired startup project:
   - Use the WinForms project for a graphical interface.
   - Use the Console project for a terminal-based admin interface.
3. Press `F5` to launch the application.

## Usage

### WinForms UI

This is the main interface intended for daily use:

- **Sign In** with existing credentials to access the system.
- **Sign Up** to register as a new customer.
- Depending on the signed-in role:
  - **Customer**:
    - Browse and search products
    - Add products to cart
    - Place orders
    - View past orders
    - Update profile information
  - **SalesPerson**:
    - View customer list and their orders
    - Register new customers
    - View sales and customer statistics
  - **Admin**:
    - Add, update, deactivate, or delete employees
    - Manage products and stock levels
    - View all customers and orders
    - Reactivate deactivated accounts

All interactions include validation, feedback through message boxes, and proper form navigation.

### Console UI

The Console UI serves to demonstrate and test the modular backend. It shares the same business logic and data access layers as the WinForms interface:

- Navigate through text-based menus.
- Perform CRUD operations on employees.
- View employee data with formatted outputs.
- Validate backend logic independently of the GUI.

This is especially useful for debugging or working in environments where a GUI is not available.

## Contact

For questions or feedback, feel free to reach out:
- GitHub: [aabr2612](https://github.com/aabr2612)
- Email: aabr2612@gmail.com
