---
layout: post
title: ##Platform_Name## Grid connected to SQL via Entity Framework | Syncfusion
description: Bind SQL Server data to ##Platform_Name## Grid using Entity Framework Core with complete CRUD, filtering, sorting, paging, and advanced data operations.
platform: ej2-asp-core-mvc
control: Grid
documentation: ug
domainurl: ##DomainURL##
---

# Connecting SQL Server to ASP.NET Core Grid Using Entity Framework

The [Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid](https://www.syncfusion.com/aspnet-core-ui-controls/grid) supports binding data from a SQL Server database using Entity Framework Core (EF Core). This modern approach provides a more maintainable and type-safe alternative to raw SQL queries.

**What is Entity Framework Core?**

Entity Framework Core (EF Core) is a software tool that simplifies database operations in .NET applications. It serves as a bridge between C# code and databases like SQL Server.

**Key Benefits of Entity Framework Core**

- **Automatic SQL Generation**: Entity Framework Core generates optimized SQL queries automatically, eliminating the need to write raw SQL code.
- **Type Safety**: Work with strongly-typed objects instead of raw SQL strings, reducing errors.
- **Built-in Security**: Automatic parameterization prevents SQL injection attacks.
- **Version Control for Databases**: Manage database schema changes version-by-version through migrations.
- **Familiar Syntax**: Use LINQ (Language Integrated Query) syntax, which is more intuitive than raw SQL strings.

**What is Entity Framework Core SQL Server Provider?**

The **Microsoft.EntityFrameworkCore.SqlServer** package is the official Entity Framework Core provider for SQL Server. It acts as a bridge between Entity Framework Core and SQL Server, allowing applications to read, write, update, and delete data in a SQL Server database.

## Prerequisites

Ensure the following software and packages are installed before proceeding:

| Software/Package | Version | Purpose |
|-----------------|---------|---------|
| Visual Studio 2022 | 17.0 or later | Development IDE with ASP.NET Core workload |
| .NET SDK | net8.0 or compatible | Runtime and build tools |
| SQL Server | 2019 or later | Database server |
| Syncfusion.EJ2.AspNet.Core | {{ site.releaseversion }} | Grid and UI components |
| Microsoft.EntityFrameworkCore | 9.0.0 or later | Core framework for database operations |
| Microsoft.EntityFrameworkCore.Tools | 9.0.0 or later | Tools for managing database migrations |
| Microsoft.EntityFrameworkCore.SqlServer | 9.0.0 or later | SQL Server provider for Entity Framework Core |

## Setting Up the SQL Server Environment for Entity Framework Core

### Step 1: Create the database and Table in SQL Server

First, the **SQL Server database** structure must be created to store ticket records.

**Instructions:**
1. Open SQL Server Management Studio (SSMS) or any SQL Server client.
2. Create a new database named `NetworkSupportDB`.
3. Define a `Tickets` table with the specified schema.
4. Insert sample data for testing.

Run the following SQL script:

```sql
-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'NetworkSupportDB')
BEGIN
    CREATE DATABASE NetworkSupportDB;
END
GO

USE NetworkSupportDB;
GO

-- Create Tickets Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tickets')
BEGIN
    CREATE TABLE dbo.Tickets (
        TicketId INT PRIMARY KEY IDENTITY(1,1),
        PublicTicketId VARCHAR(50) NOT NULL UNIQUE,
        Title VARCHAR(200) NULL,
        Description TEXT NULL,
        Category VARCHAR(100) NULL,
        Department VARCHAR(100) NULL,
        Assignee VARCHAR(100) NULL,
        CreatedBy VARCHAR(100) NULL,
        Status VARCHAR(50) NOT NULL DEFAULT 'Open',
        Priority VARCHAR(50) NOT NULL DEFAULT 'Medium',
        ResponseDue DATETIME2 NULL,
        DueDate DATETIME2 NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE(),
        UpdatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
    );
END
GO

-- Insert Sample Data (Optional)
INSERT INTO dbo.Tickets (PublicTicketId, Title, Description, Category, Department, Assignee, CreatedBy, Status, Priority, ResponseDue, DueDate, CreatedAt, UpdatedAt)
VALUES
('NET-1001', 'Network Connectivity Issue', 'Users unable to connect to the VPN', 'Network Issue', 'Network Ops', 'John Doe', 'Alice Smith', 'Open', 'High', '2026-01-14 10:00:00', '2026-01-15 17:00:00', '2026-01-13 10:15:30', '2026-01-13 10:15:30'),
('NET-1002', 'Server Performance Degradation', 'Email server responding slowly', 'Performance', 'Infrastructure', 'Emily White', 'Bob Johnson', 'InProgress', 'Critical', '2026-01-13 15:00:00', '2026-01-14 17:00:00', '2026-01-13 11:20:10', '2026-01-13 11:20:10');
GO
```

After executing this script, the ticket records are stored in the `Tickets` table within the `NetworkSupportDB` database. The database is now ready for integration with the ASP.NET Core application.

---

### Step 2: Install Required NuGet Packages

Before installing the necessary NuGet packages, a new ASP.NET Core Web Application must be created using the default template.
This template automatically generates essential starter files—such as **Program.cs, appsettings.json, and the wwwroot folder**.

For this guide, a ASP.NET Core application named **Grid_MSSQL** has been created. Once the project is set up, the next step involves installing the required NuGet packages. NuGet packages are software libraries that add functionality to the application. These packages enable Entity Framework Core and SQL Server integration.

**Method 1: Using Package Manager Console**

1. Open Visual Studio 2022.
2. Navigate to **Tools → NuGet Package Manager → Package Manager Console**.
3. Run the following commands:

```powershell
Install-Package Microsoft.EntityFrameworkCore -Version 9.0.0; 
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 9.0.0; 
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 9.0.0; 
Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}
```

**Method 2: Using NuGet Package Manager UI**

1. Open **Visual Studio 2022 → Tools → NuGet Package Manager → Manage NuGet Packages for Solution**.
2. Search for and install each package individually:
   - **Microsoft.EntityFrameworkCore** (version 9.0.0 or later)
   - **Microsoft.EntityFrameworkCore.Tools** (version 9.0.0 or later)
   - **Microsoft.EntityFrameworkCore.SqlServer** (version 9.0.0 or later)
   - **Syncfusion.EJ2.AspNet.Core** (version {{ site.releaseversion }})

All required packages are now installed.

### Step 3: Create the Data Model

A data model is a C# class that represents the structure of a database table. This model defines the properties that correspond to the columns in the `Tickets` table.

**Instructions:**

1. Create a new folder named `Data` in the ASP.NET Core application project.
2. Inside the `Data` folder, create a new file named **Tickets.cs**.
3. Define the **Tickets** class with the following code:

```csharp
using System.ComponentModel.DataAnnotations;

namespace Grid_MSSQL.Data
{
    /// <summary>
    /// Represents a ticket record mapped to the 'Tickets' table in the database.
    /// This model defines the structure of ticket-related data used throughout the application.
    /// </summary>
    public class Tickets
    {
        /// <summary>
        /// Gets or sets the unique identifier for the ticket record.
        /// </summary>
        [Key]
        public int TicketId { get; set; }

        /// <summary>
        /// Gets or sets the public-facing ticket identifier (e.g., NET-1001).
        /// </summary>
        public string? PublicTicketId { get; set; }

        /// <summary>
        /// Gets or sets the ticket title or subject.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets a detailed description of the ticket.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the category of the issue (e.g., Network, Hardware, Software).
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the department responsible for handling the ticket.
        /// </summary>
        public string? Department { get; set; }

        /// <summary>
        /// Gets or sets the name of the agent assigned to the ticket.
        /// </summary>
        public string? Assignee { get; set; }

        /// <summary>
        /// Gets or sets the name of the person who created the ticket.
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the current status of the ticket (e.g., Open, In Progress, Resolved, Closed).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the priority level of the ticket (e.g., Critical, High, Medium, Low).
        /// </summary>
        public string? Priority { get; set; }

        /// <summary>
        /// Gets or sets the deadline for responding to the ticket.
        /// </summary>
        public DateTime? ResponseDue { get; set; }

        /// <summary>
        /// Gets or sets the deadline for resolving the ticket.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the ticket was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the ticket was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
```

**Explanation:**
- The `[Key]` attribute marks the `TicketId` property as the primary key (a unique identifier for each record).
- Each property represents a column in the database table.
- The `?` symbol indicates that a property is nullable (can be empty).
- The model includes comprehensive XML documentation for each property.

The data model has been successfully created.

### Step 4: Configure the DbContext

A `DbContext` is a special class that manages the connection between the application and the SQL Server database. It handles all database operations such as saving, updating, deleting, and retrieving data.

**Instructions:**

1. Inside the `Data` folder, create a new file named **TicketsDbContext.cs**.
2. Define the `TicketsDbContext` class with the following code:

```csharp
using Microsoft.EntityFrameworkCore;

namespace Grid_MSSQL.Data
{
    /// <summary>
    /// DbContext for Tickets entity
    /// Manages database connections and entity configurations for the Network Support Ticket System
    /// </summary>
    public class TicketsDbContext : DbContext
    {
        public TicketsDbContext(DbContextOptions<TicketsDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet for Ticket entities
        /// </summary>
        public DbSet<Tickets> Tickets => Set<Tickets>();

        /// <summary>
        /// Configures the entity mappings and constraints
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Tickets entity
            modelBuilder.Entity<Tickets>(entity =>
            {
                // Primary Key
                entity.HasKey(e => e.TicketId);

                // Auto-increment for Primary Key
                entity.Property(e => e.TicketId)
                    .ValueGeneratedOnAdd();

                // Column configurations
                entity.Property(e => e.PublicTicketId)
                    .HasMaxLength(50)
                    .IsRequired(true);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsRequired(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(int.MaxValue)  // For MAX type
                    .IsRequired(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsRequired(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsRequired(false);

                entity.Property(e => e.Assignee)
                    .HasMaxLength(100)
                    .IsRequired(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsRequired(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .HasDefaultValue("Open");

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .HasDefaultValue("Medium");

                // DateTime columns
                entity.Property(e => e.ResponseDue)
                    .HasColumnType("datetime2")
                    .IsRequired(false);

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime2")
                    .IsRequired(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime2")
                    .IsRequired(false)
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime2")
                    .IsRequired(false)
                    .HasDefaultValueSql("GETDATE()");

                // Add indexes for frequently queried columns
                entity.HasIndex(e => e.PublicTicketId)
                    .HasDatabaseName("IX_PublicTicketId");

                entity.HasIndex(e => e.Status)
                    .HasDatabaseName("IX_Status");

                entity.HasIndex(e => e.CreatedAt)
                    .HasDatabaseName("IX_CreatedAt");

                // Table name and schema
                entity.ToTable("Tickets", schema: "dbo");
            });
        }
    }
}
```

**Explanation:**
- The `DbContext` class inherits from Entity Framework's `DbContext` base class.
- The `Tickets` property represents the `Tickets` table in the database.
- The `OnModelCreating` method configures how the database columns should behave (maximum length, required/optional, default values, data types, indexes, etc.).
- SQL Server-specific configurations include `datetime2` for timestamp columns and `GETDATE()` for default values.
- Database indexes are configured for improved query performance on frequently accessed columns.

The **TicketsDbContext** class is required because:

- It **connects** the application to the database.
- It **manages** all database operations.
- It **maps** C# models to actual database tables.
- It **configures** how data should look inside the database.
- It **enables** SQL Server-specific features like indexes and default value functions.

Without this class, Entity Framework Core will not know where to save data or how to create the Tickets table. The DbContext has been successfully configured.

### Step 5: Configure the Connection String

A connection string contains the information needed to connect the application to the SQL Server database, including the server address, database name, and authentication credentials.

**Instructions:**

1. Open the `appsettings.json` file in the project root.
2. Add or update the `ConnectionStrings` section with the SQL Server connection details:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=SYNCLAPN-43362;Initial Catalog=NetworkSupportDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

**Connection String Components:**

| Component | Description |
|-----------|-------------|
| Data Source | The address of the SQL Server instance (server name, IP address, or localhost) |
| Initial Catalog | The database name (in this case, `NetworkSupportDB`) |
| Integrated Security | Set to `True` for Windows Authentication; use `False` with Username/Password for SQL Authentication |
| Connect Timeout | Connection timeout in seconds (default is 15) |
| Encrypt | Enables encryption for the connection (set to `True` for production environments) |
| Trust Server Certificate | Whether to trust the server certificate (set to `False` for security) |
| Application Intent | Set to `ReadWrite` for normal operations or `ReadOnly` for read-only scenarios |
| Multi Subnet Failover | Used in failover clustering scenarios (typically `False`) |

The database connection string has been configured successfully.

### Step 6: Create the Repository Class

A repository class is an intermediary layer that handles all database operations. This class uses Entity Framework Core to communicate with the database.

**Instructions:**

1. Inside the `Data` folder, create a new file named **TicketRepository.cs**.
2. Define the **TicketRepository** class with the following code:

```csharp
using Microsoft.EntityFrameworkCore;

namespace Grid_MSSQL.Data
{
    /// <summary>
    /// Repository pattern implementation for Tickets entity using Entity Framework Core
    /// Handles all CRUD operations and business logic for network support tickets
    /// </summary>
    public class TicketRepository
    {
        private readonly TicketsDbContext _context;

        public TicketRepository(TicketsDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all tickets from the database ordered by ID descending
        /// </summary>
        /// <returns>List of all tickets</returns>
        public async Task<List<Tickets>> GetTicketsDataAsync()
        {
            try
            {
                return await _context.Tickets
                    .OrderByDescending(t => t.TicketId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving tickets: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Adds a new ticket to the database
        /// </summary>
        /// <param name="value">The ticket model to add</param>
        public async Task AddTicketAsync(Tickets value)
        {
            // Handle logic to add a new ticket to the database
        }

        /// <summary>
        /// Updates an existing ticket
        /// </summary>
        /// <param name="value">The ticket model with updated values</param>
        public async Task UpdateTicketAsync(Tickets value)
        {
            // Handle logic to update an existing ticket to the database
        }

        /// <summary>
        /// Deletes a ticket from the database
        /// </summary>
        /// <param name="key">The ticket ID to delete</param>
        public async Task RemoveTicketAsync(int? key)
        {
            // Handle logic to delete an existing ticket to the database
        }
    }
}
```

The repository class has been created.

### Step 7: Register Services in Program.cs

The `Program.cs` file is where application services are registered and configured. This file must be updated to enable Entity Framework Core and the repository pattern.

**Instructions:**

1. Open the `Program.cs` file at the project root.
2. Add the following code after the line `var builder = WebApplication.CreateBuilder(args);`:

```csharp
using Grid_MSSQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// ========== ENTITY FRAMEWORK CORE CONFIGURATION ==========
// Get connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found in configuration.");
}

// Register DbContext with SQL Server provider
builder.Services.AddDbContext<TicketsDbContext>(options =>
{
    options.UseSqlServer(connectionString);

    // Enable detailed error messages in development
    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
    }
});

// Register Repository for dependency injection
builder.Services.AddScoped<TicketRepository>();
// ========================================================

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
```

**Explanation:**

- **`AddDbContext<TicketsDbContext>`**: Registers the DbContext with SQL Server as the database provider using `UseSqlServer()`.
- **`EnableSensitiveDataLogging()`**: Enabled in development to log detailed information about database operations (useful for debugging).
- **`AddScoped<TicketRepository>`**: Registers the repository as a scoped service, creating a new instance for each HTTP request.

The service registration has been completed successfully.

---

## Integrating Syncfusion ASP.NET Core Grid

### Step 1: Install and Configure ASP.NET Core Grid control

Syncfusion is a library that provides pre-built UI components like Grid, which is used to display data in a table format.

**Instructions:**

1. The Syncfusion.EJ2.AspNet.Core package was installed in **Step 2** of the previous heading.
2. Import the required TagHelper in the `~/Pages/_ViewImports.cshtml` file:

```csharp
@addTagHelper *, Syncfusion.EJ2
```

3. Add the Syncfusion stylesheet and scripts in the `Pages/Shared/_Layout.cshtml` file. Find the `<head>` section and add:

```html
    <!-- Syncfusion ASP.NET Core control stylesheet -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
    <!-- Syncfusion ASP.NET Core control scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
```

4. Register the Syncfusion Script Manager `<ejs-scripts>` at the end of the `<body>` tag in in the `Pages/Shared/_Layout.cshtml` file: 

```html
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
```

5. Configure the server to serve static files and handle API requests in `Program.cs` by adding the following code:

```cs
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
```

Syncfusion components are now configured and ready to use. For additional guidance, refer to the Grid component's [getting‑started](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core) documentation.

### Step 2: Update the ASP.NET Core Grid control

The tag helper in `~/Pages/Index.cshtml` page will display the ticket data in a Syncfusion ASP.NET Core Grid with search, filter, sort, and pagination capabilities.

**Instructions:**

1. Open the file named `Index.cshtml` in the `Pages` folder.
2. Add the following code to create a basic Grid:

```html
@page 
@using Grid_MSSQL.Data
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

@inject TicketRepository TicketService

<PageTitle>Network Support Ticket System</PageTitle>

<section class="bg-gray-50 dark:bg-gray-950">
    <div class="mx-auto w-full py-12 sm:px-6 px-4">
        <h1 class="mb-4 text-3xl font-bold">Network Support Ticket System</h1>
        <p class="mb-3 text-gray-600">Manage and view all support tickets from the database.</p>
        
        <!-- Syncfusion Asp.Net Core Grid control -->
        <ejs-grid id="Grid" allowPaging="true" allowSorting="true" allowFiltering="true">
            <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
            <e-grid-columns>
                <!-- Columns configuration -->
            </e-grid-columns>
        </ejs-grid>
    </div>
</section>

<script>
    // CustomAdaptor class will be added in the next step
<script>
```

**Component Explanation:**

- **`@inject TicketRepository`**: Injects the repository to access database methods.
- **`<ejs-grid>`**: The DataGrid component that displays data in rows and columns.
- **`<e-grid-columns>`**: Defines individual columns in the DataGrid.
- **`<e-grid-pagesettings>`**: Configures pagination with 10 records per page.

The tag helper has been updated successfully with Grid.

---

### Step 3: Implement the CustomAdaptor

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid can bind data from a **SQL Server** database using `DataManager` and set the `Adaptor` property to [CustomAdaptor](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/custom-adaptor) for scenarios that require full control over data operations.

The `CustomAdaptor` is a bridge between the Grid and the database. It handles all data operations including reading, searching, filtering, sorting, paging, and CRUD operations. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid sends operation details to the API through a `DataManagerRequest` object. These details can be applied to the data source using methods from the `DataOperations` class.

**Instructions:**

1. Create a new folder named `Controller` in the ASP.NET Core application project.
2. Inside the `Controller` folder, create a new file named `GridController.cs`.
3. Add the following `CustomAdaptor` class code:

```csharp

using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Apply filter operation if filter criteria exists.
                if (dataManagerRequest.Where?.Count > 0)
                {
                    queryable = operations.PerformFiltering(queryable, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                // Apply sort operation if sort criteria exists.
                if (dataManagerRequest.Sorted?.Count > 0)
                {
                    queryable = operations.PerformSorting(queryable, dataManagerRequest.Sorted);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}

```

The `CustomAdaptor` class has been successfully implemented with all data operations.

**Common methods in data operations**

* `PerformSearching` - Applies search criteria to the collection.
* `PerformFiltering` - Filters data based on conditions.
* `PerformSorting` - Sorts data by one or more fields.
* `PerformSkip` - Skips a defined number of records for paging.
* `PerformTake` - Retrieves a specified number of records for paging.
* `PerformAggregation` – Calculates aggregate values such as Sum, Average, Min, and Max.

---

### Step 4: Add Toolbar with CRUD and search options

The toolbar provides buttons for adding, editing, deleting records, and searching the data.

**Instructions:**

1. Open the `~/Pages/Index.cshtml` file.
2. Update the `<ejs-grid>` component to include the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property with CRUD and search options:

```html
<ejs-grid id="Grid" allowPaging="true" allowSorting="true" allowFiltering="true" toolbar="@(new List<string> { "Add", "Edit", "Delete", "Update", "Cancel", "Search" })">
    
    <!-- Grid columns configuration -->
</ejs-grid>
```

**Toolbar Items Explanation:**

| Item | Function |
|------|----------|
| `Add` | Opens a form to add a new ticket record. |
| `Edit` | Enables editing of the selected record. |
| `Delete` | Deletes the selected record from the database. |
| `Update` | Saves changes made to the selected record. |
| `Cancel` | Cancels the current edit or add operation. |
| `Search` | Displays a search box to find records. |

The toolbar has been successfully added.

---

### Step 5: Implement Paging Feature

Paging divides large datasets into smaller pages to improve performance and usability.

**Instructions:**

1. The paging feature is already partially enabled in the `<SfGrid>` component with [allowPaging="true"](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging).
2. The page size is configured with [pageSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_PageSettings).
3. No additional code changes are required from the previous steps.

```html
<ejs-grid id="Grid" allowPaging="true">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>    
    <!-- Grid columns configuration -->
</ejs-grid>
```

4. Update the `GridDataPost` method in `GridController.cs` to handle paging:

```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
```

Fetches ticket data by calling the **GetTicketsDataAsync** method, which is implemented in the **TicketRepository.cs** file.

```csharp
/// <summary>
/// Retrieves all tickets from the database ordered by ID descending
/// </summary>
/// <returns>List of all tickets</returns>
public async Task<List<Tickets>> GetTicketsDataAsync()
{
    try
    {
        return await _context.Tickets
            .OrderByDescending(t => t.TicketId)
            .ToListAsync();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error retrieving tickets: {ex.Message}");
        throw;
    }
}
```

**How Paging Works:**

- The DataGrid displays 10 records per page (as set in `pageSettings`).
- Navigation buttons allow the user to move between pages.
- When a page is requested, the `GridDataPost` method receives skip and take values.
- The `DataOperations.PerformSkip()` and `DataOperations.PerformTake()` methods handle pagination.
- Only the requested page of records is transmitted from the server.

Paging feature is now active with 10 records per page.

---

### Step 6: Implement Searching feature

Searching allows the user to find records by entering keywords in the search box.

**Instructions:**

1. Ensure the toolbar includes the "Search" item.

```html
<ejs-grid id="Grid" allowPaging="true" toolbar="@(new List<string> { "Search" })">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
    <!-- Grid columns configuration -->
</ejs-grid>
```

2. Update the `GridDataPost` method in `GridController.cs` to handle searching:

```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}

```

**How Searching Works:**

- When the user enters text in the search box and presses Enter, the Grid sends a search request to the CustomAdaptor.
- The `GridDataPost` method receives the search criteria in `dataManagerRequest.Search`.
- The `DataOperations.PerformSearching()` method filters the data based on the search term across all columns.
- Results are returned and displayed in the Grid.

Searching feature is now active.

---

### Step 7: Implement Filtering feature

Filtering allows the user to restrict data based on column values using a menu interface.

**Instructions:**

1. Open the `~/Pages/Index.cshtml` file.
2. Add the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property and [filterSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings) to the grid control:

```html
<ejs-grid id="Grid" allowPaging="true" allowFiltering="true" toolbar="@(new List<string> { "Search" })">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
    <e-grid-filterSettings type="Menu"></e-grid-filterSettings>    
    <!-- Grid columns configuration -->
</ejs-grid>
```

3. Update the `GridDataPost` method in `GridController.cs` to handle filtering:

```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Apply filter operation if filter criteria exists.
                if (dataManagerRequest.Where?.Count > 0)
                {
                    queryable = operations.PerformFiltering(queryable, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
```

**How Filtering Works:**

- Click on the dropdown arrow in any column header to open the filter menu.
- Select filtering criteria (equals, contains, greater than, less than, etc.).
- Click the "Filter" button to apply the filter.
- The `ReadAsync` method receives the filter criteria in `dataManagerRequest.Where`.
- The `DataOperations.PerformFiltering()` method applies the filter conditions to the data.
- Results are filtered accordingly and displayed in the DataGrid.

Filtering feature is now active.

---

### Step 8: Implement Sorting feature

Sorting enables the user to arrange records in ascending or descending order based on column values.

**Instructions:**

1. Open the `~/Pages/Index.cshtml` file.
2. Add the [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property to the grid control:

```html
<ejs-grid id="Grid" allowPaging="true" allowSorting="true" allowFiltering="true" toolbar="@(new List<string> { "Search" })">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
    <e-grid-filterSettings type="Menu"></e-grid-filterSettings>    
    <!-- Grid columns configuration -->
</ejs-grid>
```

3. Update the `GridDataPost` method in `GridController.cs` to handle sorting:

```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Apply filter operation if filter criteria exists.
                if (dataManagerRequest.Where?.Count > 0)
                {
                    queryable = operations.PerformFiltering(queryable, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                // Apply sort operation if sort criteria exists.
                if (dataManagerRequest.Sorted?.Count > 0)
                {
                    queryable = operations.PerformSorting(queryable, dataManagerRequest.Sorted);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
```

**How Sorting Works:**

- Click on the column header to sort in ascending order.
- Click again to sort in descending order.
- The `ReadAsync` method receives the sort criteria in `dataManagerRequest.Sorted`.
- The `DataOperations.PerformSorting()` method sorts the data based on the specified column and direction.
- Records are sorted accordingly and displayed in the DataGrid.

Sorting feature is now active.

---

### Step 9: Implement Grouping feature

Grouping organizes records into hierarchical groups based on column values.

**Instructions:**

1. Open the `~/Pages/Index.cshtml` file.
2. Add the [AllowGrouping](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to the grid control:

```html
<ejs-grid id="Grid" allowPaging="true" allowGrouping="true" allowSorting="true" allowFiltering="true" toolbar="@(new List<string> { "Search" })">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
    <e-grid-filterSettings type="Menu"></e-grid-filterSettings>    
    <!-- Grid columns configuration -->
</ejs-grid>
```

3. Update the `GridDataPost` method in `GridController.cs` to handle grouping:

```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;
using System.Collections;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                IEnumerable<Tickets> dataSource = tickets.AsEnumerable();

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply group operation if group criteria exists.
                IEnumerable groupedData = dataSource;
                if (dataManagerRequest.Group != null && dataManagerRequest.Group.Count > 0)
                {
                    foreach (var group in dataManagerRequest.Group)
                    {
                        groupedData = operations.PerformGrouping<Tickets>(dataSource, dataManagerRequest);
                    }
                }

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Apply filter operation if filter criteria exists.
                if (dataManagerRequest.Where?.Count > 0)
                {
                    queryable = operations.PerformFiltering(queryable, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                // Apply sort operation if sort criteria exists.
                if (dataManagerRequest.Sorted?.Count > 0)
                {
                    queryable = operations.PerformSorting(queryable, dataManagerRequest.Sorted);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
```

**How Grouping Works:**

- Columns can be grouped by dragging the column header into the group drop area.
- Each group can be expanded or collapsed by clicking on the group header.
- The `GridDataPost` method receives the grouping instructions through `dataManagerRequest.Group`.
- The grouping operation is processed using `PerformGrouping` method, which organizes the records into hierarchical groups based on the selected column.
- Grouping is performed after search, filter, and sort operations, ensuring the grouped data reflects all applied conditions.
- The processed grouped result is then returned to the **Grid** and displayed in a structured, hierarchical format.

Grouping feature is now active.

---

### Step 10: Perform CRUD operations

CustomAdaptor methods enable users to create, read, update, and delete records directly from the DataGrid. Each operation calls corresponding data layer methods in **TicketRepository.cs** to execute SQL Server commands.

Add the Grid **EditSettings** and **Toolbar** configuration to enable create, read, update, and delete (CRUD) operations.

```html
<ejs-grid id="Grid" allowPaging="true" allowGrouping="true" allowSorting="true" allowFiltering="true" toolbar="@(new List<string> { "Add", "Edit", "Delete", "Cancel", "Update", "Search" })">
    <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
    <e-grid-filterSettings type="Menu"></e-grid-filterSettings>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true"></e-grid-editSettings>            
    <!-- Grid columns  -->
</ejs-grid>
```

**Insert**

Record insertion allows new tickets to be added directly through the DataGrid component. The adaptor processes the insertion request, performs any required business‑logic validation, and saves the newly created record to the SQL Server database.

In **GridController.cs**, implement the `Insert` method:

```csharp
// POST: Insert new ticket
[HttpPost("Insert")]
public async Task<IActionResult> Insert([FromBody] CRUDModel<Tickets> crudModel)
{
    try
    {
        if (crudModel.Value == null)
        {
            return BadRequest(new { error = "Invalid data" });
        }

        await _ticketService.AddTicketAsync(crudModel.Value);

        return Ok(crudModel.Value);
    }
    catch (Exception ex)
    {
        System.Diagnostics.Debug.WriteLine($"Error in Insert: {ex.Message}");
        return StatusCode(500, new { error = ex.Message });
    }
}
```

In **Data/TicketRepository.cs**, the insert method is implemented as:

```csharp
public async Task AddTicketAsync(Tickets value)
{
    try
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value), "Ticket cannot be null");
        
        string generatedPublicTicketId = await GeneratePublicTicketIdAsync();
        value.PublicTicketId = generatedPublicTicketId;
        
        if (value.CreatedAt == null)
            value.CreatedAt = DateTime.Now;

        if (value.UpdatedAt == null)
            value.UpdatedAt = DateTime.Now;

        _context.Tickets.Add(value);

        await _context.SaveChangesAsync();
    }
    catch (DbUpdateException ex)
    {
        Console.WriteLine($"Database error while adding ticket: {ex.Message}");
        throw;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error adding ticket: {ex.Message}");
        throw;
    }
}
```

**What happens behind the scenes:**

1. The form data is collected and validated in the CustomAdaptor's `Insert()` method.
2. The `TicketRepository.AddTicketAsync()` method is called.
3. The new record is added to the `_context.Tickets` collection.
4. `SaveChangesAsync()` persists the record to the SQL Server database.
5. The DataGrid automatically refreshes to display the new record.

Now the new ticket is persisted to the database and reflected in the grid.

**Update**

Record modification allows ticket details to be updated directly within the DataGrid. The adaptor processes the edited row, validates the updated values, and applies the changes to the **SQL Server database** while ensuring data integrity is preserved.

In **GridController.cs**, implement the `Update` method:

```csharp
// POST: Update existing ticket.
[HttpPost("Update")]
public async Task<IActionResult> Update([FromBody] CRUDModel<Tickets> crudModel)
{
    try
    {
        if (crudModel.Value == null)
        {
            return BadRequest(new { error = "Invalid data" });
        }

        await _ticketService.UpdateTicketAsync(crudModel.Value);

        return Ok(crudModel.Value);
    }
    catch (Exception ex)
    {
        System.Diagnostics.Debug.WriteLine($"Error in Update: {ex.Message}");
        return StatusCode(500, new { error = ex.Message });
    }
}
```

In **Data/TicketRepository.cs**, the update method is implemented as:

```csharp
public async Task UpdateTicketAsync(Tickets value)
{
    try
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value), "Ticket cannot be null");

        if (value.TicketId <= 0)
            throw new ArgumentException("Ticket ID must be valid", nameof(value.TicketId));

        var existingTicket = await _context.Tickets.FindAsync(value.TicketId);
        if (existingTicket == null)
            throw new KeyNotFoundException($"Ticket with ID {value.TicketId} not found");

        existingTicket.PublicTicketId = value.PublicTicketId;
        existingTicket.Title = value.Title;
        existingTicket.Description = value.Description;
        existingTicket.Category = value.Category;
        existingTicket.Department = value.Department;
        existingTicket.Assignee = value.Assignee;
        existingTicket.CreatedBy = value.CreatedBy;
        existingTicket.Status = value.Status;
        existingTicket.Priority = value.Priority;
        existingTicket.ResponseDue = value.ResponseDue;
        existingTicket.DueDate = value.DueDate;
        existingTicket.CreatedAt = value.CreatedAt;
        existingTicket.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException ex)
    {
        Console.WriteLine($"Concurrency error while updating ticket: {ex.Message}");
        throw;
    }
    catch (DbUpdateException ex)
    {
        Console.WriteLine($"Database error while updating ticket: {ex.Message}");
        throw;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error updating ticket: {ex.Message}");
        throw;
    }
}
```

**What happens behind the scenes:**

1. The modified data is collected from the form.
2. The CustomAdaptor's `Update()` method is called.
3. The `TicketRepository.UpdateTicketAsync()` method is called.
4. The existing record is retrieved from the database by ID.
5. All properties are updated with the new values.
6. `SaveChangesAsync()` persists the changes to the SQL Server database.
7. The DataGrid refreshes to display the updated record.

Now modifications are synchronized to the database and reflected in the grid UI.

**Delete**

Record deletion allows tickets to be removed directly from the DataGrid. The adaptor captures the delete request, executes the corresponding **SQL Server DELETE** operation, and updates both the database and the grid to reflect the removal.

In **GridController.cs**, implement the `Remove` method:

```csharp
// POST: Delete ticket (alternative approach)
[HttpPost("Remove")]
public async Task<IActionResult> Remove([FromBody] CRUDModel<Tickets> crudModel)
{

    try
    {
        // Check if we have the Value (full object).
        if (crudModel.Value != null)
        {
            await _ticketService.RemoveTicketAsync(crudModel.Value.TicketId);
            return Ok(crudModel.Value);
        }

        // Check if we have the Key.
        if (crudModel.Key != null)
        {
            // Try to parse as integer.
            if (int.TryParse(crudModel.Key.ToString(), out int ticketId))
            {
                await _ticketService.RemoveTicketAsync(ticketId);
                return Ok(new { success = true, deletedId = ticketId });
            }

            // Try to find by PublicTicketId.
            var tickets = await _ticketService.GetTicketsDataAsync();
            var ticket = tickets.FirstOrDefault(t => t.PublicTicketId == crudModel.Key.ToString());

            if (ticket != null)
            {
                await _ticketService.RemoveTicketAsync(ticket.TicketId);
                return Ok(ticket);
            }
        }

        return BadRequest(new { error = "No valid key or value provided for deletion" });
    }
    catch (Exception ex)
    {
        System.Diagnostics.Debug.WriteLine($"Error in Remove: {ex.Message}");
        return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
    }
}
```

In **Data/TicketRepository.cs**, the delete method is implemented as:

```csharp
public async Task RemoveTicketAsync(int? key)
{
    try
    {
        if (key == null || key <= 0)
            throw new ArgumentException("Ticket ID cannot be null or invalid", nameof(key));

        var ticket = await _context.Tickets.FindAsync(key);
        if (ticket == null)
            throw new KeyNotFoundException($"Ticket with ID {key} not found");

        _context.Tickets.Remove(ticket);
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateException ex)
    {
        Console.WriteLine($"Database error while deleting ticket: {ex.Message}");
        throw;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error deleting ticket: {ex.Message}");
        throw;
    }
}
```

**What happens behind the scenes:**

1. The user selects a record and clicks "Delete".
2. A confirmation dialog appears (built into the Grid).
3. If confirmed, the CustomAdaptor's `Remove()` method is called.
4. The `TicketRepository.RemoveTicketAsync()` method is called.
5. The record is located in the database by its ID.
6. The record is removed from the `_context.Tickets` collection.
7. `SaveChangesAsync()` executes the DELETE statement in SQL Server.
8. The DataGrid refreshes to remove the deleted record from the UI.

Now tickets are removed from the database and the grid UI reflects the changes immediately.

**Batch update**

Batch operations combine multiple insert, update, and delete actions into a single request, minimizing network overhead and ensuring transactional consistency by applying all changes atomically to the SQL Server database.

In **GridController.cs**, implement the `Batch` method:

```csharp
// Batch operations.
[HttpPost("Batch")]
public async Task<IActionResult> Batch([FromBody] CRUDModel<Tickets> crudModel)
{
    try
    {
        // Insert
        if (crudModel.Added != null && crudModel.Added.Count > 0)
        {
            foreach (var ticket in crudModel.Added)
            {
                await _ticketService.AddTicketAsync(ticket);
            }
        }

        // Update
        if (crudModel.Changed != null && crudModel.Changed.Count > 0)
        {
            foreach (var ticket in crudModel.Changed)
            {
                await _ticketService.UpdateTicketAsync(ticket);
            }
        }

        // Delete
        if (crudModel.Deleted != null && crudModel.Deleted.Count > 0)
        {
            foreach (var ticket in crudModel.Deleted)
            {
                await _ticketService.RemoveTicketAsync(ticket.TicketId);
            }
        }

        return Ok(new { success = true });
    }
    catch (Exception ex)
    {
        System.Diagnostics.Debug.WriteLine($"Error in Batch: {ex.Message}");
        return StatusCode(500, new { error = ex.Message });
    }
}
```

> This method is triggered when the DataGrid is operating in [Batch](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/batch-editing) Edit mode.

**What happens behind the scenes:**

- The DataGrid collects all added, edited, and deleted records in Batch Edit mode.
- The combined batch request is passed to the CustomAdaptor's `Batch()` method.
- Each modified record is processed using `TicketRepository.UpdateTicketAsync()`.
- Each newly added record is saved using `TicketRepository.AddTicketAsync()`.
- Each deleted record is removed using `TicketRepository.RemoveTicketAsync()`.
- All repository operations persist changes to the SQL Server database.
- The DataGrid refreshes to display the updated, added, and removed records in a single response.

Now the adaptor supports bulk modifications with atomic database synchronization. All CRUD operations are now fully implemented, enabling comprehensive data management capabilities within the ASP.NET Core Grid.

---

### Step 11: Complete Home.razor Code

Here is the complete and final `Home.razor` component with all features integrated. This component uses the exact implementation from the Grid_MSSQL project:

```html
@page
@model IndexModel
@using Grid_MSSQL.Data
@inject TicketRepository TicketService
@{
    ViewData["Title"] = "Network Support Ticket System";
}
<PageTitle>Network Support Ticket System</PageTitle>
<section class="bg-gray-50 dark:bg-gray-950">
    <div class="mx-auto w-full py-12 sm:px-6 px-4">
        <h1 class="mb-4 text-3xl font-bold">Network Support Ticket System</h1>
        <p class="mb-3 text-gray-600">Manage and view all support tickets from the database.</p>
        <!-- Syncfusion EJ2 Grid -->
        <ejs-grid id="Grid" allowPaging="true" allowGrouping="true" allowSorting="true" allowFiltering="true" toolbar="@(new List<string> { "Add", "Edit", "Delete", "Cancel", "Update", "Search" })">
            <e-grid-pagesettings pageSize="10"></e-grid-pagesettings>
            <e-grid-filterSettings type="Menu"></e-grid-filterSettings>
            <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode='Batch'></e-grid-editSettings>
            <e-grid-columns>
                <e-grid-column field="PublicTicketId" headerText="Ticket ID" width="140" textAlign="Left" isPrimaryKey="true" />
                <e-grid-column field="Title" headerText="Title" width="220" />
                <e-grid-column field="Description" headerText="Description" width="320" />
                <e-grid-column field="Category" headerText="Category" width="140" />
                <e-grid-column field="Department" headerText="Department" width="140" />
                <e-grid-column field="Assignee" headerText="Assignee" width="140" />
                <e-grid-column field="CreatedBy" headerText="Created By" width="140" />
                <e-grid-column field="Status" headerText="Status" width="120"></e-grid-column>
                <e-grid-column field="Priority" headerText="Priority" width="120" />
                <e-grid-column field="CreatedAt" headerText="Created" format="yMd" type="date" width="140" />
                <e-grid-column field="UpdatedAt" headerText="Updated" format="yMd" type="date" width="140" />
            </e-grid-columns>
        </ejs-grid>
    </div>
</section>

<!-- Custom Adaptor and grid initialization -->
<script>
    class CustomAdaptor extends ej.data.UrlAdaptor {
        processQuery(dm, query) {
            console.log("Query being sent to server:", query.params); 
            return super.processQuery(dm, query);
        }

        processResponse(data, ds, query, xhr, request, changes) {
            console.log("Raw server response:", data); 
            return super.processResponse(data, ds, query, xhr, request, changes);
        }
    }

    document.addEventListener("DOMContentLoaded", function () {
        let grid = document.getElementById("Grid").ej2_instances[0];
        if (grid) {
            let dataManager = new ej.data.DataManager({
                url: "https://localhost:xxxx/Grid/GridData", // Replace xxxx with your actual port number.
                insertUrl: "https://localhost:xxxx/Grid/Insert",
                updateUrl: "https://localhost:xxxx/Grid/Update",
                removeUrl: "https://localhost:xxxx/Grid/Remove",
                batchUrl: "https://localhost:xxxx/Grid/Batch",
                adaptor: new CustomAdaptor(),
            });
            grid.dataSource = dataManager;
        }
    });
</script>

```


> * Set [isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) to **true** for a column that contains unique values.
> * Set [isIdentity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) to **true** for auto-generated columns to disable editing during add or update operations.
> * The [editType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) property can be used to specify the desired editor for each column. [🔗](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit-types)
> * [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) property of the `Column` specifies the data type of a grid column.
> * The [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) property that allows rendering custom elements in a column instead of the default field value. [🔗](https://ej2.syncfusion.com/aspnetcore/documentation/grid/columns/column-template)


```csharp
using Microsoft.AspNetCore.Mvc;
using Grid_MSSQL.Data;
using Syncfusion.EJ2.Base;
using System.Collections;

namespace Grid_MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : ControllerBase
    {
        private readonly TicketRepository _ticketService;

        public GridController(TicketRepository ticketService)
        {
            _ticketService = ticketService;
        }

        // Keep GET for testing.
        [HttpGet("GridData")]
        public async Task<IActionResult> GridDataGet([FromQuery] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Add POST for actual grid operations.
        [HttpPost("GridData")]
        public async Task<IActionResult> GridDataPost([FromBody] DataManagerRequest dataManagerRequest)
        {
            return await ProcessGridRequest(dataManagerRequest);
        }

        // Shared processing logic.
        private async Task<IActionResult> ProcessGridRequest(DataManagerRequest dataManagerRequest)
        {
            try
            {
                var tickets = await _ticketService.GetTicketsDataAsync();

                if (tickets == null || tickets.Count == 0)
                {
                    return Ok(new { result = new List<Tickets>(), count = 0 });
                }

                IEnumerable<Tickets> dataSource = tickets.AsEnumerable();

                var queryable = tickets.AsQueryable();
                var operations = new DataOperations();

                // Apply group operation if group criteria exists.
                IEnumerable groupedData = dataSource;
                if (dataManagerRequest.Group != null && dataManagerRequest.Group.Count > 0)
                {
                    foreach (var group in dataManagerRequest.Group)
                    {
                        groupedData = operations.PerformGrouping<Tickets>(dataSource, dataManagerRequest);
                    }
                }

                // Apply search operation if search criteria exists.
                if (dataManagerRequest.Search?.Count > 0)
                {
                    queryable = operations.PerformSearching(queryable, dataManagerRequest.Search);
                }

                // Apply filter operation if filter criteria exists.
                if (dataManagerRequest.Where?.Count > 0)
                {
                    queryable = operations.PerformFiltering(queryable, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                // Apply sort operation if sort criteria exists.
                if (dataManagerRequest.Sorted?.Count > 0)
                {
                    queryable = operations.PerformSorting(queryable, dataManagerRequest.Sorted);
                }

                // Calculate total record count before paging for accurate pagination.
                int totalCount = queryable.Count();

                // Apply paging skip operation.
                if (dataManagerRequest.Skip > 0)
                {
                    queryable = operations.PerformSkip(queryable, dataManagerRequest.Skip);
                }

                // Apply paging take operation to retrieve only the requested page size
                if (dataManagerRequest.Take > 0)
                {
                    queryable = operations.PerformTake(queryable, dataManagerRequest.Take);
                }

                // Return the result with total count for pagination metadata
                var response = dataManagerRequest.RequiresCounts
                    ? new { result = queryable.ToList(), count = totalCount }
                    : (object)queryable.ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GridData: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // POST: Insert new ticket
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] CRUDModel<Tickets> crudModel)
        {
            try
            {
                if (crudModel.Value == null)
                {
                    return BadRequest(new { error = "Invalid data" });
                }

                await _ticketService.AddTicketAsync(crudModel.Value);

                return Ok(crudModel.Value);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Insert: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // POST: Update existing ticket
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] CRUDModel<Tickets> crudModel)
        {
            try
            {
                if (crudModel.Value == null)
                {
                    return BadRequest(new { error = "Invalid data" });
                }

                await _ticketService.UpdateTicketAsync(crudModel.Value);

                return Ok(crudModel.Value);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Update: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // POST: Delete ticket (alternative approach)
        [HttpPost("Remove")]
        public async Task<IActionResult> Remove([FromBody] CRUDModel<Tickets> crudModel)
        {

            try
            {
                // Check if we have the Value (full object).
                if (crudModel.Value != null)
                {
                    await _ticketService.RemoveTicketAsync(crudModel.Value.TicketId);
                    return Ok(crudModel.Value);
                }

                // Check if we have the Key.
                if (crudModel.Key != null)
                {
                    // Try to parse as integer.
                    if (int.TryParse(crudModel.Key.ToString(), out int ticketId))
                    {
                        await _ticketService.RemoveTicketAsync(ticketId);
                        return Ok(new { success = true, deletedId = ticketId });
                    }

                    // Try to find by PublicTicketId.
                    var tickets = await _ticketService.GetTicketsDataAsync();
                    var ticket = tickets.FirstOrDefault(t => t.PublicTicketId == crudModel.Key.ToString());

                    if (ticket != null)
                    {
                        await _ticketService.RemoveTicketAsync(ticket.TicketId);
                        return Ok(ticket);
                    }
                }

                return BadRequest(new { error = "No valid key or value provided for deletion" });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Remove: {ex.Message}");
                return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

        // Batch operations.
        [HttpPost("Batch")]
        public async Task<IActionResult> Batch([FromBody] CRUDModel<Tickets> crudModel)
        {
            try
            {
                // Insert
                if (crudModel.Added != null && crudModel.Added.Count > 0)
                {
                    foreach (var ticket in crudModel.Added)
                    {
                        await _ticketService.AddTicketAsync(ticket);
                    }
                }

                // Update
                if (crudModel.Changed != null && crudModel.Changed.Count > 0)
                {
                    foreach (var ticket in crudModel.Changed)
                    {
                        await _ticketService.UpdateTicketAsync(ticket);
                    }
                }

                // Delete
                if (crudModel.Deleted != null && crudModel.Deleted.Count > 0)
                {
                    foreach (var ticket in crudModel.Deleted)
                    {
                        await _ticketService.RemoveTicketAsync(ticket.TicketId);
                    }
                }

                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Batch: {ex.Message}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
```

> * Set [isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) to **true** for a column that contains unique values.
> * Set [IsIdentity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) to **true** for auto-generated columns to disable editing during add or update operations.

---

## Running the Application

**Step 1: Build the Application**

1. Open the terminal or Package Manager Console.
2. Navigate to the project directory.
3. Run the following command:

```powershell
dotnet build
```

**Step 2: Run the Application**

Execute the following command:

```powershell
dotnet run
```

**Step 3: Access the Application**

1. Open a web browser.
2. Navigate to `https://localhost:xxxx` (or the port shown in the terminal).
3. The Network Support Ticket System is now running and ready to use.

### Available Features

- **View Data**: All tickets from the SQL Server database are displayed in the DataGrid.
- **Search**: Use the search box to find tickets by any field.
- **Filter**: Click on column headers to apply filters.
- **Sort**: Click on column headers to sort data in ascending or descending order.
- **Pagination**: Navigate through records using page numbers.
- **Add**: Click the "Add" button to create a new ticket.
- **Edit**: Click the "Edit" button to modify existing tickets.
- **Delete**: Click the "Delete" button to remove tickets.

---

## Complete Sample Repository

A complete, working sample implementation is available in the GitHub repository.

---
## Summary

This guide demonstrates how to:

1. Create a SQL Server database with ticket records. [🔗](#step-1-create-the-database-and-table-in-sql-server)
2. Install necessary NuGet packages for Entity Framework Core and Syncfusion. [🔗](#step-2-install-required-nuget-packages)
3. Create data models and DbContext for database communication. [🔗](#step-3-create-the-data-model)
4. Configure connection strings and register services. [🔗](#step-5-configure-the-connection-string)
5. Implement the repository pattern for data access. [🔗](#step-6-create-the-repository-class)
6. Create a ASP.NET Core application with a Grid that supports searching, filtering, sorting, paging, and CRUD operations. [🔗](#step-1-install-and-configure-aspnet-core-grid-control)
7. Handle bulk operations and batch updates. [🔗](#step-10-perform-crud-operations)

The application now provides a complete solution for managing network support tickets with a modern, user-friendly interface integrated with SQL Server.
