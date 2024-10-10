----------------DATE AND TIME FUNCTIONS---------------


--37. Write a query to display the current date and time.
SELECT GETDATE();

--38. From an 'Orders' table, find all orders placed in the last 24 hours.
SELECT * FROM Orders WHERE OrdDate >= DATEADD(HOUR,-24,GETDATE());

--39. Display the current UTC date and time.
SELECT GETUTCDATE();

--40. Write a query to show the time difference between local time and UTC time.
SELECT DATEDIFF(MINUTE,GETDATE(), GETUTCDATE());

--41. Convert the current date and time to 'Pacific Standard Time'.
SELECT GETDATE() AT TIME ZONE 'Pacific Standard Time';

--42. From a 'Flights' table with a 'DepartureTime' column in UTC, convert all departure times to 'Eastern Standard Time'.
UPDATE Flights SET DepartureTime = DepartureTime AT TIME ZONE  'Eastern Standard Time';

--43. Add 3 months to the current date.
SELECT DATEADD(MONTH,3,GETDATE());

--44. From an 'Employees' table, write a query to calculate each employee's retirement date (65 years from their 'DateOfBirth').
SELECT EmpName, DATEADD(YEAR,65,DoB) as Retirement FROM Employees;

--45. Calculate the number of days between '2023-01-01' and '2023-12-31'.
SELECT DATEDIFF(DAY,2023-01-01,2023-12-31);

--46. From an 'Orders' table, find the average number of days between order date and ship date.
SELECT AVG(DATEDIFF(DAY,ShipDate,OrderDate));

--47. Extract the month number from the date '2023-09-15'.
SELECT MONTH('2023-09-15');

--48. From a 'Sales' table, write a query to group total sales by the quarter of the sale date.
SELECT DATEPART(QUARTER,SaleDate) AS Quarter, SUM(Quantity * UnitPrice) FROM Sales GROUP BY DATEPART(QUARTER,SaleDate);

--49. Extract the year from the current date.
SELECT YEAR(GETDATE());

--50. From an 'Employees' table, find all employees hired in the year 2022.
SELECT FirstName,HireDate FROM Employees WHERE YEAR(HireDate) = 2022;

--51. Check if '2023-02-30' is a valid date.
SELECT ISDATE('2023-02-30');

--52. Write a query to find all rows in a 'UserInputs' table where the 'EnteredDate' column contains invalid dates.
SELECT * FROM UserInputs WHERE ISDATE(EnteredDate) = 0;

--53. Find the last day of the current month.
SELECT EOMONTH(GETDATE());

--54. From a 'Subscriptions' table, write a query to extend all subscription end dates to the end of their respective months.
UPDATE Subscriptions SET EndDate = EOMONTH(EndDate);

--55. Display the current date and time.
SELECT GETDATE();

--56. Compare the results of two different methods to get the current timestamp - are they always the same?
SELECT GETDATE();
SELECT SYSDATETIME();
--SELECT CURRENT_TIMESTAMP;
--There is a difference in precision. GETDATE() returns a datetime value which is precise upto milliseconds and SYSDATETIME() returns a datetime2 value which is precise upto nanoseconds.

--57. Get the current date and time with higher precision than standard methods.
SELECT SYSDATETIME();

--58. Write a query to insert the current high-precision timestamp into a 'Logs' table.
INSERT INTO Logs VALUES (SYSDATETIME());

--59. Display the current UTC date and time with high precision.
SELECT SYSUTCDATETIME();

--60. Calculate the difference in microseconds between the current local time and UTC time.
SELECT DATEDIFF (MICROSECOND,SYSDATETIME(),SYSUTCDATETIME());

--61. Get the current date, time, and time zone offset.
SELECT SYSDATETIMEOFFSET();

--62. From a 'GlobalEvents' table, convert all event times to include time zone offset information.
UPDATE GlobalEvents SET EventTime = CONVERT(datetimeoffset,EventTime);

--63. Extract the month number from the date '2023-12-25'.
SELECT MONTH('2023-12-25');

--64. From a 'Sales' table, find the total sales for each month of the previous year.
SELECT MONTH(SaleDate) AS Month, SUM(Quantity * UnitPrice) AS TotalSale FROM Sales WHERE (DATEDIFF(YEAR,SaleDate,GETUTCDATE())=1) GROUP BY MONTH(SaleDate);

--65. Extract the day of the month from '2023-03-15'.
SELECT DAY('2023-03-15');

--66. Write a query to find all orders from an 'Orders' table that were placed on the 15th day of any month.
SELECT * FROM Orders WHERE DAY(OrderDate)=15;

--67. Get the name of the month for the date '2023-09-01'.
SELECT DATENAME(MONTH,'2023-09-01');


--68. From an 'Events' table, write a query to display the day of the week (in words) for each event date.
SELECT DATENAME(WEEKDAY,EventDate) From Events;

--69. Create a date for Christmas Day 2023.
SELECT DATEFROMPARTS(2023,12,25); 

--70. Write a query to convert separate year, month, and day columns from a 'Dates' table into a single DATE column.
ALTER TABLE EventDates ADD Dates date;
UPDATE EventDates SET Dates = DATEFROMPARTS(year,month,day);



