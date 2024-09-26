--SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE';

--CREATE TABLE: Creates an Employees table with columns for EmployeeID, FirstName, LastName, Department, and Salary.
CREATE TABLE Employee(EmployeeID int primary key, FirstName varchar(20), LastName varchar(20),Department varchar(5),Salary int);

--INSERT: Adds three employee records to the table.
INSERT INTO Employee VALUES
(1,'Samuel','Sam','CSE',20000),
(2,'Karan','Kumar','ECE',25000),
(3,'John','Doe','HR',40000);

--SELECT: Shows different ways to query data:
--Select all columns and rows
SELECT * FROM employee;

--Select specific columns
SELECT FirstName,LastName FROM employee;
SELECT FirstName,Department FROM employee;
SELECT EmployeeID,LastName,Salary FROM employee;

--Select with a WHERE clause to filter results
SELECT FirstName,Department,Salary FROM employee WHERE(Salary > 22000);
SELECT FirstName FROM employee WHERE(Department='HR');

--What is the purpose of the IDENTITY keyword in the CREATE TABLE statement?
--The identitiy property is used to assign unique values to  each member of the column when a new row is created. 
--A seed and increment value are specified along with the identity keyword.
--The seed is the starting value (assigned to the first entry) and the value is incremented each time and assigned to the following rows when they are created.

--Write a SELECT statement to retrieve only the FirstName and Salary of all employees.
SELECT FirstName, Salary FROM employee;

--How would you modify the existing UPDATE statement to give all employees in the IT department a 10% raise
UPDATE Employee SET Salary = Salary + (Salary*0.1);

--Write a SELECT statement to find the highest salary in the Employees table.
SELECT MAX(Salary) AS MaxSal FROM employee;

--How would you add a new column named "HireDate" of type DATE to the Employees table?
ALTER TABLE employee ADD HireDate date;

--Write an INSERT statement to add a new employee named "Sarah Brown" in the "Marketing" department with a salary of 72000.00
ALTER TABLE employee ALTER COLUMN Department varchar(15);
INSERT INTO employee VALUES(4,'Sarah','Brown','Marketing',72000,NULL)

--How would you modify the table to ensure that the Salary column cannot contain negative values?
--Using a CHECK constraint
ALTER TABLE employee ADD CONSTRAINT Salary CHECK(Salary>=0);


--Write an ALTER TABLE statement to add an "Email" column to the Employees table with a UNIQUE constraint that allows NULL values
ALTER TABLE employee ADD Email varchar(30);
CREATE UNIQUE INDEX MultNull
ON Employee (Email)
WHERE Email IS NOT NULL;


