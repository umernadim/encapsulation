# 🧱 C# Properties and Encapsulation Practice

## 📘 Project Overview

This project is a **C# console application** designed to strengthen understanding of **Encapsulation** and **Properties** — two key principles of Object-Oriented Programming (OOP).

Through multiple real-world examples such as **Bank Account Management**, **Product Inventory**, and **Student Report Systems**, this project demonstrates how **private fields**, **getters/setters**, and **data validation** can be used to create secure and reliable C# applications.

---

## 🧩 Topics Covered

This project covers the following important C# OOP concepts:

* 🔒 **Encapsulation** — Protecting data using private fields.
* ⚙️ **Properties (Getters and Setters)** — Controlling how values are accessed and modified.
* 🧠 **Data Validation** — Ensuring only valid data is stored.
* 🏗️ **Constructors** — Initializing objects with required data.
* 🧾 **Computed Properties** — Automatically calculating values based on other fields.

---

## 🧠 Tasks & Concepts Demonstrated

### 👤 1. Person Class

**Purpose:** Demonstrates basic encapsulation using properties.

**Key Features:**

* Private fields: `name`, `age`.
* Property validation: Age resets to `0` if above 30.
* Computed property `FullName` returns a formatted string with name and age.

**Concepts Practiced:**
Encapsulation, data validation, read-only computed property.

---

### 🧍‍♂️ 2. Person Information System

**Purpose:** A simpler demonstration of properties and conditional validation.

**Key Features:**

* Ensures age is positive before assignment.
* Prints formatted name and age.

**Concepts Practiced:**
Basic input validation and use of public properties.

---

### 🌡️ 3. Temperature Control

**Purpose:** Simulates a room temperature control system.

**Key Features:**

* Uses a property `Temperature` to validate temperature range.
* Displays appropriate feedback:

  * “Too Cold!” for ≤ 16°C
  * “Too Hot!” for ≥ 30°C
  * Otherwise sets and displays temperature successfully

**Concepts Practiced:**
Conditional validation within property setters.

---

### 🏦 4. Bank Account System

**Purpose:** Demonstrates encapsulation and business logic through methods and properties.

**Key Features:**

* Properties: `AccountNumber`, `Balance`.
* Ensures balance cannot be negative.
* Includes methods:

  * `Deposit(double amount)` — Adds valid amounts to the balance.
  * `ShowInfo()` — Displays account details.

**Concepts Practiced:**
Encapsulation, validation, and method integration with properties.

---

### 💻 5. Product Inventory System

**Purpose:** Simulates an inventory tracking system.

**Key Features:**

* Properties: `Name`, `Price`, `Quantity`.
* Validation: Prevents negative or zero prices/quantities.
* Read-only property `TotalValue` calculates product’s total worth.

**Concepts Practiced:**
Read-only computed properties and validation.

---

### 🎓 6. Student Report System

**Purpose:** Displays how encapsulation and computed properties can be used for grading logic.

**Key Features:**

* Fields: `name`, `age`, `marks`.
* Constructor for easy initialization.
* Validation ensures marks are within 0–100 range and age is positive.
* Computed property `Grade` assigns:

  * A → Marks ≥ 80
  * B → Marks ≥ 60
  * C → Marks ≥ 40
  * F → Marks < 40

**Concepts Practiced:**
Constructors, encapsulation, computed properties, and grading logic.

---

## ⚙️ How to Run the Project

1. Open the project in **Visual Studio** or **VS Code**.
2. Make sure the **.NET SDK** is installed.
3. Uncomment the section of the task you want to test.
4. Run the program using:

   ```bash
   dotnet run
   ```
5. Observe the output in the console.

---

## 🧩 Example Output (Bank Account Example)

```
Deposited: 250, New Balance: 750
Account Number: 12345, Balance: 750
```

---

## 🧾 Summary

This project provides practical examples of how **Encapsulation** and **Properties** protect data integrity and control access in C#.

By completing these tasks, you will gain hands-on experience with:

* Data encapsulation and validation
* Property-based logic
* Computed properties and constructors
* Real-world OOP scenarios

---

## 💡 Author

**Muhammad Umer**

> A passionate learner and developer exploring C# fundamentals and OOP principles through real-world coding exercises.

