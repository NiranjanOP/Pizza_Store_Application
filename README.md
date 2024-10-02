# Pizza Store Application

## Overview

The **Pizza Store Application** is a C# .NET project that allows users to order pizzas and manage pizza prices. It leverages SQL for data storage, making it a tasty combination of technology and deliciousness!

## Features

1. **Ordering Pizzas:**
   - Users can explore the menu, select their favorite pizzas, and place orders.
   - The application handles customizations such as toppings, crust types, and sizes.

2. **Price Management:**
   - Admins (or authorized users) can set and update pizza prices.
   - Prices are stored in an SQL database for easy retrieval.

3. **SQL Integration:**
   - The application connects to an SQL database to store pizza data.
   - SQL queries are used for retrieving and updating pizza information.

## Getting Started

1. **Prerequisites:**
   - Make sure you have the .NET SDK installed.
   - Set up an SQL database (e.g., using SQL Server).

2. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/pizza-store-app.git
   cd pizza-store-app

3. **Database Configuration:**
Update the connection string in appsettings.json to point to your SQL database.
Run database migrations to create the necessary tables:
```bash
dotnet ef database update
```

4. **Run the Application:**
```bash
dotnet run
```
## Contributing
Contributions are welcome! If you’d like to improve the application, follow these steps:
Fork the repository.
Create a new branch (git checkout -b feature/my-awesome-feature).
Make your changes and commit them.
Push to your forked repository.
Create a pull request.

## License
This project is licensed under the MIT License. Feel free to use, modify, and distribute it.
