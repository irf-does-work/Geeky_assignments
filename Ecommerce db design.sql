CREATE DATABASE Amazon

CREATE TABLE Customer (
CustomerId INT PRIMARY KEY,
Name VARCHAR(50), 
PhNo INT, 
Email VARCHAR(100),
Address VARCHAR(200)
);


CREATE TABLE Brands (
BrandId INT PRIMARY KEY,
BrandName VARCHAR(30)
);

CREATE TABLE Seller(
SellerId INT PRIMARY KEY,
SellerName VARCHAR(30),
Contact INT
);


CREATE TABLE Products(
ProductId INT PRIMARY KEY,
ProductName VARCHAR(30),
Price DECIMAL(10,2),
BrandId INT FOREIGN KEY REFERENCES Brands(BrandId),
SellerId INT FOREIGN KEY REFERENCES Seller(SellerId),
ReviewId INT FOREIGN KEY REFERENCES Reviews(ReviewId)
);

CREATE TABLE Reviews(
ReviewId INT PRIMARY KEY,
Title VARCHAR(30),
Description VARCHAR(500),
Rating DECIMAL(2,1),
CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerId),
);


CREATE TABLE Orders(
OrderId INT PRIMARY KEY,
CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerId),
ProductId INT FOREIGN KEY REFERENCES Products(ProductId),
Quantity INT,
OrderDate DATE,
);

