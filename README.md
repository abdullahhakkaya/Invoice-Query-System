# Invoice Query System

A simple C# console application demonstrating LINQ queries on a list of invoices.  
This application allows users to interactively sort and filter invoice data based on various criteria.

---

## Features

- Sort invoices by **Part Description** (alphabetically)
- Sort invoices by **Price** (descending)
- Show **stock quantities** sorted by quantity (descending)
- Display **total amounts** (Quantity × Price) sorted by total (descending)
- Filter and display products with total amounts **between $200 and $500**
- Exit the application

---

## Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/en-us/download) or [.NET Core SDK](https://dotnet.microsoft.com/en-us/download) installed

### Running the Application

1. Clone or download the project source code.
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.
4. Follow the on-screen menu to perform different queries on the sample invoice data.

---

## Usage

When you run the program, you will see a menu with options:

INVOICE QUERY SYSTEM

1. Sort by part description
2. Sort by price
3. Show stock quantities
4. Show total amounts
5. Show products with total between $200 and $500
6. Exit

Your choice (1-6):

Enter the corresponding number to execute the query. After each result, press any key to return to the menu.

---

## Sample Data

The application uses the following sample invoices:

| Part Number | Description       | Quantity | Price    |
|-------------|-------------------|----------|----------|
| 83          | Electric sander   | 7        | $57.98   |
| 24          | Electric saw      | 18       | $99.99   |
| 71          | Sledgehammer      | 11       | $21.50   |
| 77          | Hammer            | 76       | $11.99   |
| 39          | Lawn mower       | 3        | $79.50   |
| 68          | Screwdriver       | 106      | $6.99    |
| 56          | Jigsaw            | 21       | $11.50   |
| 32          | Wrench            | 34       | $7.50    |

---

## Code Structure

- `Program` class: Contains the `Main` method, displays menu, and processes user input.
- `Invoice` class: Represents an invoice item with properties for part number, description, quantity, and price.
- LINQ queries are used to filter, sort, and project invoice data.

---

## Error Handling

The application uses a try-catch block to handle unexpected runtime exceptions gracefully, displaying error messages and preventing crashes.

---

## License

This project is open-source and free to use.

---

*Created as a LINQ demonstration console application.*
