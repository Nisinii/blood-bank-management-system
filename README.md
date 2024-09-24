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

2. Run the following commands to install the necessary dependencies for **MySQL-related packages**:
   ```bash
   dotnet add package Pomelo.EntityFrameworkCore.MySql
   dotnet add package MySql.Data
   ```

### Step 3: Configure the Database
1. In the `appsettings.json` file, update the connection string to point to your local SQL Server:
   ```json
   "ConnectionStrings": {
       "BloodBankDatabase": "Server=YOUR_SERVER;Database=BloodBankDB;Trusted_Connection=True;"
   }
   ```
  Replace YOUR_SERVER with your SQL Server instance.

2. In VS Code terminal, run the following commands to create the database and apply migrations:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Step 4: Install packages related to **ASP.NET Core Scaffolding Tool**
Run the following commands in terminal where your root package is"
   ```bash
   dotnet tool install -g dotnet-aspnet-codegenerator
   dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
   dotnet restore
   ```

### Step 5: Create Controllers for CRUD Operations
Run the following commands in terminal where your root package is"
   ```bash
   dotnet aspnet-codegenerator controller -name DonorsController -m Donor -dc BloodBankContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
   dotnet aspnet-codegenerator controller -name BloodDonationsController -m BloodDonation -dc BloodBankContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
   dotnet aspnet-codegenerator controller -name BloodRequirementsController -m BloodRequirement -dc BloodBankContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
   ```

### Step 6: Run the Application
1. Press F5 or click Run in Visual Studio to start the application.
2. The application will launch in your default browser at https://localhost:5001 (or a similar port).

## Usage
- User Registration: New users and donors can register through the Sign Up page.
- Login: Existing users and donors can log in with their credentials.
- Donor Registration: Donors can provide their blood group and contact details.
- Blood Posting: Users can post blood donation or requirement details on the platform.
- Blood Search: Users can search for available blood types or donors based on their requirements.

## Database Structure
The system uses the following key tables:
- Donors: Stores information about blood donors (name, blood group, contact, last donation date).
- BloodDonations: Stores information about blood donations (blood group, date of donation, storage location).
- BloodRequirements: Stores blood requirement requests posted by users (required blood group, patient name, contact, required date).
