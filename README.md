## Employee 

This is an employee management system that allows CRUD operations (Create, Read, Update, Delete) using C# and .NET. The project adheres to SOLID principles and has layered architecture for responsibility separation, such as API, Application, and Communication layers.

## Features
| **Functionality**        | **Description**                                                                 |
|--------------------------|---------------------------------------------------------------------------------|
| **Add Employee**          | Create a new employee entry.                                                    |
| **List Employees**        | Retrieve all registered employees.                                              |
| **Update Employee**       | Edit existing employee details.                                                 |
| **Delete Employee**       | Remove an employee from the database.                                           |


## Requirements
- .NET 6 or higher

## Structure

- Employee.API: Handles endpoints for employee management.
- Employee.Application: Contains business logic.
- Employee.Communication: Manages data transfer between layers and the client.
