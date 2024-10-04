CREATE DATABASE BookMyShow;

CREATE TABLE Customer (
CustomerId INT PRIMARY KEY,
Name VARCHAR(50), 
PhNo INT, 
Email VARCHAR(100),
CurrentLocation VARCHAR(200), 
);

CREATE TABLE Movie (
MovieID INT PRIMARY KEY,
Title VARCHAR(100),
Genre VARCHAR(100),
Duration INT,
Rating DECIMAL(2,1)
);

CREATE TABLE Theatre (
TheatreID  INT PRIMARY KEY,
Name VARCHAR(50), 
Address VARCHAR(200)
);

CREATE TABLE Shows (
ShowID INT PRIMARY KEY
MovieID INT FOREIGN KEY REFERENCES Movie(MovieID),
TheatreID INT FOREIGN KEY REFERENCES Theatre(TheatreID),
TimeOfShow DATETIME
);

CREATE TABLE Booking (
BookingID INT PRIMARY KEY,
MovieID INT FOREIGN KEY REFERENCES Movie(MovieID),
CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerId),
Amount DECIMAL(2,1),
PaymentMethod VARCHAR(20)
);