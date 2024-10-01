-- E-commerce Platform Schema

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Email VARCHAR(100),
    RegistrationDate DATE
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(200),
    Price DECIMAL(10, 2),
    CategoryID INT
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Questions

-- 1. List all products with their category names, including products without a category.
SELECT ProductName,c.CategoryID 
FROM Products p 
LEFT JOIN Categories c ON p.CategoryID = c.CategoryID; 

-- 2. Display all customers and their order history, including customers who haven't placed any orders.
SELECT c.CustomerID,CustomerName,o.OrderID,OD.ProductID,Quantity 
FROM Customers C 
LEFT JOIN Orders O ON c.CustomerID = o.CustomerID 
LEFT JOIN OrderDetails od ON o.OrderID = od.OrderID;

-- 3. Show all categories and the products in each category, including categories without any products.
SELECT * 
FROM Categories c 
LEFT JOIN Products p ON c.CategoryID = p.CategoryID;

-- 4. List all possible customer-product combinations, regardless of whether a purchase has occurred.
SELECT CustomerID,CustomerName,ProductID,ProductName FROM Customers CROSS JOIN Products;

-- 5. Display all orders with customer and product information, including orders where either the customer or product information is missing.
SELECT o.OrderID,o.OrderDate,o.TotalAmount,c.CustomerID,c.CustomerName,c.Email,p.ProductID,p.ProductName,od.Quantity 
FROM Orders o 
FULL OUTER JOIN OrderDetails od ON o.OrderID = od.OrderID 
LEFT JOIN Customers c ON c.CustomerID = o.CustomerID 
LEFT JOIN Products p ON p.ProductID = od.ProductID;
	
-- 6. Show all products that have never been ordered, along with their category information.
SELECT P.ProductID, ProductName, Price, c.CategoryID, CategoryName
FROM Products p 
LEFT JOIN OrderDetails od ON p.ProductID = od.OrderID 
LEFT JOIN Categories c ON c.CategoryID = p.CategoryID 
WHERE od.OrderID IS NULL;


-- 7. List all customers who have placed orders in the last week, along with the products they've purchased.
SELECT c.CustomerID,c.CustomerName,o.OrderDate
FROM Orders o JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE DATEPART(WEEK,o.OrderDate)=DATEPART(WEEK,GETDATE())-1 AND DATEPART(YEAR,o.OrderDate)=DATEPART(YEAR,GETDATE());

-- 8. Display all categories with products priced over $100, including categories without such products.
SELECT DISTINCT CategoryName
FROM Categories c JOIN Products p ON c.CategoryID = p.CategoryID 
WHERE P.Price>100;

-- 9. Show all orders placed before 2023 and any associated product information.
SELECT o.OrderID,OrderDate,od.ProductID,ProductName,Price
FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID WHERE YEAR(OrderDate) < 2023;	

-- 10. List all possible category-customer combinations, regardless of whether the customer has purchased a product from that category.
SELECT CustomerID,CustomerName,CategoryID,CategoryName FROM Customers CROSS JOIN Categories;
