# Online Blood Bank Management System

## Overview
The **Online Blood Bank Management System** is a web-based application that streamlines blood bank operations such as donor registration, blood availability checks, and posting blood requirements. It allows users in need of blood to find donors and facilitates blood donations. This system is built using the **ASP.NET Core** framework and utilizes **SQL Server** as the database for storing and managing blood-related data.

## Features
- **User Registration/Login**: Users and donors can register, log in, and manage their profiles.
- **Donor Registration**: Donors can sign up and post details about their blood donations.
- **Blood Requirement Posting**: Users can post their requirements for specific blood types.
- **Blood Availability Check**: Users can search for blood availability in the blood bank.
- **Donor Finder**: The system provides matching donors based on the required blood group.
- **Blood Storage Management**: Blood donation and storage details are automatically stored and updated in the database.
- **Emergency Notification**: Users can be notified when their required blood type is available.

## Technologies Used
- **Frontend**: HTML5, CSS3, Bootstrap, JavaScript
- **Backend**: ASP.NET Core MVC (Model-View-Controller)
- **Database**: SQL Server with Entity Framework Core (EF Core)
- **IDE**: Visual Studio 2022 (or latest version)
- **ORM**: Entity Framework Core

## Requirements
- .NET SDK (version 6.0 or later) [Download here](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (or later) [Download here](https://visualstudio.microsoft.com/)
- SQL Server and SQL Server Management Studio (SSMS) [Download here](https://www.microsoft.com/en-us/sql-server)

## Installation

### Step 1: Clone the Repository
Clone the repository from GitHub (or your chosen version control platform):
```bash
git clone https://github.com/Nisinii/blood-bank-management-system.git
```

### Step 2: Install Dependencies
Once you've cloned the repository, open the solution in Visual Studio and follow these steps:

1. **Open the Package Manager Console** in Visual Studio.
   - Go to **Tools > NuGet Package Manager > Package Manager Console**.

2. Run the following commands to install the necessary dependencies for **Entity Framework Core** and **SQL Server**:
   ```bash
   Install-Package Microsoft.EntityFrameworkCore.SqlServer
   Install-Package Microsoft.EntityFrameworkCore.Tools
   ```

### Step 3: Configure the Database
1. In the `appsettings.json` file, update the connection string to point to your local SQL Server:
   ```json
   "ConnectionStrings": {
       "BloodBankDatabase": "Server=YOUR_SERVER;Database=BloodBankDB;Trusted_Connection=True;"
   }
   ```
  Replace YOUR_SERVER with your SQL Server instance.

2. In the Package Manager Console, run the following commands to create the database and apply migrations:
```bash
Add-Migration InitialCreate
Update-Database
```

### Step 4: Run the Application
1. Press F5 or click Run in Visual Studio to start the application.
2. The application will launch in your default browser at https://localhost:5001 (or a similar port).
   
