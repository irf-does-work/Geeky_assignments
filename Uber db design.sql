CREATE DATABASE UBER;

CREATE TABLE Driver (
DriverId INT PRIMARY KEY, 
Name VARCHAR(50), 
PhNo INT, 
VehicleRegistration VARCHAR(15), 
Rating DECIMAL(2,1)
);

CREATE TABLE Passenger (
PassengerId INT PRIMARY KEY,
Name VARCHAR(50), 
PhNo INT, 
HomeAddress VARCHAR(200), 
Rating DECIMAL(2,1)
);
	
CREATE TABLE Rides (
RideId INT PRIMARY KEY, 
StartTime DATETIME, 
Pickup VARCHAR(200),
Dropoff VARCHAR(200), 
Fare DECIMAL(10,2),
DriverID INT FOREIGN KEY REFERENCES Driver(DriverID),
PassengerId INT FOREIGN KEY REFERENCES Passenger(PassengerId)
);


CREATE TABLE Payments (
PaymentId INT PRIMARY KEY, 
Amount DECIMAL(10,2),
PaymentMethod VARCHAR(20),
);

	