Environment Setup:
1.	The solution should be compatible with Visual Studio 2022 Community Edition.
2.	MS SQL Server Express and MySQL Community should be used.
3.	You can download the Northwind DB script from this GitHub link (https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql).
4.	You’ll need to convert all necessary database objects from MS SQL Server to MySQL. Identify the required objects based on the application specifications provided below.
5.	Your application can be either a web or desktop app, developed with the .Net stack.
 
Application Requirements:
1.	The application should display data from the ‘Customers’ table and the ‘Invoices’ view. Feel free to decide how best to present linked data (Invoices for a customer).
2.	Implement CRUD operations for the ‘Customers’ records.
3.	Include data validation for user inputs.
4.	Application configuration should allow to configure connection to MS SQL Server or MySQL.
5.	Consider common architectural patterns and include unit tests. Implementation of unit tests is not required.

The solution:
1. Create Northwind DB on SQL Server 2022 and restore the script that was downloaded from the link above.
2. Then change the name of the OrderDetails table as it contains a space between two words and this is not a good name for a table.
3. Next, based on the application requirements, the required tables and views are selected and a script is created.
4. The script was then modified in MySQL so that it is compatible with MySQL DB and can be executed.
5. Then some required SP and views were created in SQL Server.
6. A user login and a user for the DB were created for the connection to this DB, which should be used in the connection string file.
7. A new view “CombinedInvoicesAndCustomers” is created to display the data from the “Customers” table and the “Invoices” view.
8. All associated scripts can be found in the Scripts.rar file.
9. Then a new Window Form project is created with ".NET8".
10. Next, the required EF Core packages are installed in the project.
11. MVP (Model-View-Presenter), a software architecture pattern used in the project.
12. The AppConfig and ConfigurationManager classes are used to configure the connection to MS SQL Server.
13. The information about the connection string is also saved in the config.json file.
14. DBContex is used to retrieve data from the database for the “Customers” table or the “CombinedInvoicesAndCustomers” view and also to insert, update and, delete data in relation to the “Customers” table.
15. The design patterns Singleton and Dependency Injection are used in the APP.
16. To validate the user input, the DataAnnotations of the Customer class are added to the model. In addition, the ModelDataValidation class was created to consider all DataAnnotations from the Customer model class.
17. Finally the xUnit Test is added to the project.
