
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

--SELECT p.Category, AVG(s.Quantity) from Sales s JOIN Products p ON s.ProductID = p.ProductID GROUP BY P.Category;
SELECT p.Category, AVG(s.Quantity) AS AvgSale from Sales s RIGHT JOIN Products p ON s.ProductID = p.ProductID GROUP BY P.Category;

--List the top 5 customers by their total purchase amount. Include the CustomerID and total purchase amount.
SELECT TOP 5 s.CustomerID,/*CustomerName,*/ SUM(Quantity * UnitPrice)as TotalAmount FROM Sales s JOIN Customers c ON s.CustomerID=c.CustomerID GROUP BY s.CustomerID ORDER BY TotalAmount ;

--Determine the number of sales made each month in the year 2023. Display the month and the count of sales.
SELECT MONTH(SaleDate) AS MonthofSale ,COUNT(SaleID) FROM Sales WHERE YEAR(SaleDate)=2023 GROUP BY MONTH(SaleDate);
--SELECT DATENAME(MONTH,SaleDate) AS MonthofSale ,COUNT(SaleID) FROM Sales WHERE YEAR(SaleDate)=2023 GROUP BY MONTH(SaleDate) ;

--Calculate the total revenue for each state, but only for states with more than $10,000 in total sales.
SELECT c.State, SUM(s.Quantity * s.UnitPrice) as TotalRevenue  FROM Sales s JOIN Customers c ON s.CustomerID=c.CustomerID GROUP BY c.State HAVING SUM(s.Quantity * s.UnitPrice)>10000 ;


--Find products that have been sold more than 100 times in total. Display the ProductID, ProductName, and the total quantity sold.
--SELECT ProductId,  SUM(Quantity) AS TotalQty FROM Sales GROUP BY ProductID HAVING SUM(Quantity)>100 ; 
--SELECT s.ProductID,  SUM(Quantity) AS TotalQty FROM Sales s JOIN Products p ON s.ProductID=p.ProductID GROUP BY s.ProductID HAVING SUM(Quantity)>100 ; 
SELECT s.ProductID, p.ProductName ,SUM(Quantity) AS TotalQty FROM Sales s JOIN Products p ON s.ProductID=p.ProductID GROUP BY s.ProductID,p.ProductName HAVING SUM(Quantity)>100 ; 

--For each customer, find the date of their first purchase and the date of their most recent purchase.
Select c.CustomerName, MIN(s.SaleDate) AS FirstBuy,MAX(s.SaleDate) AS RecentBuy FROM Customers c JOIN Sales s ON s.CustomerID = c.CustomerID GROUP BY c.CustomerName;

--Find the customers who have made purchases on at least 5 different dates. Display the CustomerID and the count of distinct purchase dates.
Select c.CustomerName  FROM Customers c JOIN Sales s ON s.CustomerID = c.CustomerID  GROUP BY c.CustomerName HAVING COUNT(DISTINCT s.SaleID)>5;

