# CQRS-Pattern-Using-MediatR-In-ASP.NET-Core-WEB-API
This is a very basic CRUD Application using CQRS Design Pattern by MediatR

#Table Of Content
1. Read Data using MediatR & CQRS
   1.1  Create a ASP NET Core WEB API Project Named as EmployeeManagementAPI
   1.2  Create a Class Library Project in the same solution Named as EmployeeManagementLibrary
   1.3  Create Data folder for accessing data with Interface and implementation
   1.4  Create Model folder for database table. here i use only single table
   1.5  Install MediatR NuGet package to EmployeeManagementLibrary project
   1.6  Install MediatR.Extensions.Microsoft.DependencyInjection & Swashbuckle.AspNetCore on the API project and add referece with EmployeeManagementLibrary project
   1.7  Add queries and command and handler folder to EmployeeManagementLibrary project
   1.8  Add two query class in the queries folder that accept user request and propagate the response via handler
   1.9  Add two handler class in queries subfolder of handler folder
   1.10 Add an EmployeeController and add two GET method for reading data based on id and all of them
   
2. Write Data (Create) using MediatR & CQRS
   2.1  Add command class in the commands folder that accept user request and propagate the response via handler
   1.8  Add a handler class in commands subfolder of handler folder
   1.9  Add a POST method for saving data on employee table
   1.10 Install MediatR.Extensions.Microsoft.DependencyInjection & Swashbuckle.AspNetCore on the API project
