create database assg2;
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2),
    HireDate DATE
);

--Create a table students and insert names in malayalam
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName NVARCHAR(50),
	Age INT,
    Department VARCHAR(50)
    
);

INSERT INTO Students VALUES(1,N'സാഗർ', 19,'CSE');
INSERT INTO Students VALUES 
    (2, N'ബിബിൻ', 20, 'CSE'),
    (3, N'അനുരാഗ്', 22, 'EEE'),
    (4, N'നോയൽ', 19, 'CE');

SELECT * FROM Students;

SELECT * FROM Employees;
--Retrieve all employees who work in Sales, Marketing, or IT departments.
SELECT FirstName, LastName, Department from Employees WHERE Department IN ('Sales','Marketing','IT');

--Find all employees with salaries ranging from $50,000 to $75,000 (inclusive).
SELECT FirstName, LastName, Salary FROM Employees WHERE Salary BETWEEN 50000 AND 75000;

--List all employees whose last name begins with the letter 'S'.
SELECT FirstName, LastName FROM Employees WHERE LastName LIKE 'S%';

--Display all employees with exactly five letters in their first name.
SELECT FirstName, LastName FROM Employees WHERE FirstName LIKE '_____';

--Find employees whose last name starts with either 'B', 'R', or 'S'.
SELECT FirstName, LastName FROM Employees WHERE LEFT(LastName,1) IN ('B','R','S') ;

--Retrieve all employees whose first name begins with any letter from 'A' through 'M'.
SELECT FirstName, LastName FROM Employees WHERE LEFT(FirstName,1) BETWEEN 'A' AND 'M';

--List employees whose last name doesn't start with a vowel (A, E, I, O, U).
SELECT FirstName, LastName FROM Employees WHERE LEFT(LastName,1)  NOT IN ('A','E','I','O','U');

--Identify employees earning more than $80,000 annually. 
SELECT FirstName, Salary FROM Employees WHERE Salary > 80000;

--Find employees who joined the company before 2020. 
SELECT FirstName, HireDate FROM Employees WHERE YEAR(HireDate)<2020;

-- List all employees not named 'John' (first name).
SELECT FirstName, LastName FROM Employees WHERE FirstName NOT LIKE 'John';

--Identify Marketing department employees earning $60,000 or less who were hired after June 30, 2019.
SELECT FirstName, Salary,HireDate  FROM Employees WHERE ((Salary <= 60000) AND (HireDate>'2019-06-30')); 

--Find employees whose first name contains the letters 'an' anywhere and ends with 'e'.
SELECT FirstName FROM Employees WHERE FirstName LIKE '%an%e';



