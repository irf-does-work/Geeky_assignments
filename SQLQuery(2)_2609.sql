
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    ProductID INT,
    CustomerID INT,
    SaleDate DATE,
    Quantity INT,
    UnitPrice DECIMAL(10, 2)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50)
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(2)
);
*/

Select * from Sales;
Select * from Products;
Select * from Customers;
--Calculate the total sales amount for each product. Display the ProductID and total sales amount.
SELECT ProductID, (Quantity * UnitPrice) AS SaleTotal FROM Sales;

--Find the average quantity sold per sale for each product category.

SELECT p.Category, AVG(s.Quantity) from Sales s JOIN Products p ON s.ProductID = p.ProductID GROUP BY P.Category;

--List the top 5 customers by their total purchase amount. Include the CustomerID and total purchase amount.
SELECT TOP 5 s.CustomerID,/*CustomerName,*/ SUM(Quantity * UnitPrice)as TotalAmount FROM Sales s JOIN Customers c ON s.CustomerID=c.CustomerID GROUP BY s.CustomerID ORDER BY TotalAmount ;

--Determine the number of sales made each month in the year 2023. Display the month and the count of sales.
SELECT MONTH(SaleDate) AS MonthofSale ,COUNT(SaleID) FROM Sales WHERE YEAR(SaleDate)=2023 GROUP BY MONTH(SaleDate);
--SELECT DATENAME(MONTH,SaleDate) AS MonthofSale ,COUNT(SaleID) FROM Sales WHERE YEAR(SaleDate)=2023 GROUP BY MONTH(SaleDate) ;

--Calculate the total revenue for each state, but only for states with more than $10,000 in total sales.
SELECT c.State, SUM(s.Quantity * s.UnitPrice) as TotalRevenue  FROM Sales s JOIN Customers c ON s.CustomerID=c.CustomerID GROUP BY c.State HAVING SUM(s.Quantity * s.UnitPrice)>10000 ;



