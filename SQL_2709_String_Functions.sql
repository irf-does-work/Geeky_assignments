----------------------------------STRING FUNCTIONS------------------------------------------------

--1. Extract the middle 3 characters from the string 'ABCDEFG'.
SELECT SUBSTRING('ABCDEFG',3,3);

--2. From a table 'Employees' with a column 'FullName', write a query to extract the first name (assuming it's always the first word before a space).
SELECT LEFT (FullName,CHARINDEX(' ',FullName)-1) AS FirstName FROM Employees;
--SELECT STRING_SPLIT (FullName , ' ') AS FirstName FROM Employees;;
--3. Extract the first 5 characters from the string 'SQL Server 2022'.
SELECT LEFT ('SQL Server 2022',5);

--4. From a 'Products' table with a 'ProductCode' column, write a query to get the first 3 characters of each product code
SELECT LEFT (ProductCode,5) from Products;

--5. Extract the last 4 characters from the string 'ABCDEFGHIJKL'.
SELECT RIGHT ('ABCDEFGHIJKL',4);

--6. From an 'Orders' table with an 'OrderID' column (format: ORD-YYYY-NNNN), write a query to extract just the numeric portion at the end.
SELECT RIGHT (OrderID,4) FROM Orders;

--7. Write a query to find the length of the string 'SQL Server Functions'.
SELECT LEN('SQL Server Functions');

--8. From a 'Customers' table, find customers whose names are longer than 20 characters.
SELECT CustName FROM Customers WHERE LEN(CustName)>20;

--9. Compare the results of character count and byte count for the string 'SQL Server' with a trailing space.
SELECT DATALENGTH('SQL Server ') AS ByteCount;  --Byte count
SELECT LEN('SQL Server ') AS CharCount;  --Character count

--10. Write a query to find the byte count of an empty string and explain the result.
SELECT DATALENGTH('') AS ByteCount; 
	--The  bytecount of an empty string is 0. This is because it has no characters and hence requires 0 bytes to be stored

--11. Find the position of 'Server' in the string 'Microsoft SQL Server'.
SELECT CHARINDEX('Server','Microsoft SQL Server');

--12. From an 'Emails' table, write a query to extract the domain name from email addresses.
SELECT RIGHT(emailid, CHARINDEX('@',REVERSE(emailid))-1) FROM Email;

--13. Find the position of the first number in the string 'ABC123DEF456'.
SELECT PATINDEX('%[0-9]%','ABC123DEF456');

--14. Write a query to find all product names from a 'Products' table that contain a number.
SELECT ProductName FROM Products WHERE PATINDEX('%[0-9]%',ProductName) != 0;

--15. Join the strings 'SQL', 'Server', and '2022' with spaces between them.
SELECT CONCAT_WS(' ', 'SQL','Server','2022');

--16. From 'Employees' table with 'FirstName' and 'LastName' columns, create a 'FullName' column.
SELECT CONCAT_WS(' ',FirstName,LastName) AS FullName FROM Employees;

--17. Join the array ('SQL', 'Server', '2022') with a hyphen as the separator.
SELECT CONCAT_WS('-','SQL', 'Server', '2022');

--18. From an 'Addresses' table, combine 'Street', 'City', 'State', and 'ZIP' columns into a single address string.
SELECT CONCAT_WS(', ',Street,City,State,ZIP) AS FullAddress from Addresses;

--19. Change all occurrences of 'a' to 'e' in the string 'database management'.
SELECT REPLACE ('database management','a','e');

--20. From a 'Products' table, write a query to replace all spaces in product names with underscores.
UPDATE Products SET ProductName = REPLACE (ProductName,' ','_');

--21. Create a string of 10 asterisks (*).
SELECT REPLICATE('*', 10);

--22. Write a query to pad all product codes in a 'Products' table to a length of 10 characters with leading zeros.
UPDATE Products SET ProductID = RIGHT((REPLICATE('0',10)+ProductID),10);  

--23. Insert the string 'New ' at the beginning of 'York City'.
SELECT CONCAT('New', ' York City');

--24. From an 'Emails' table, mask the username part of email addresses, showing only the first and last characters.
SELECT LEFT(emailid,1) + REPLICATE('*',CHARINDEX('@',emailid)-2) +RIGHT(emailid,len(emailid)-Charindex('@',emailid)+2) FROM Email;

--25. Convert the string 'sql server' to uppercase.
SELECT UPPER('sql server');

--26. Write a query to convert all customer names in a 'Customers' table to uppercase.
UPDATE Customers SET CustName = UPPER(CustName);

--27. Convert the string 'SQL SERVER' to lowercase.
SELECT LOWER ('SQL SERVER');

--28. From a 'Products' table, write a query to convert all product descriptions to lowercase.
UPDATE Products SET ProdDescription = LOWER(ProdDescription);

--29. Remove trailing spaces from the string 'SQL Server    '.
SELECT RTRIM('SQL Server    ');

--30. Write a query to remove trailing spaces from all email addresses in an 'Employees' table.
UPDATE Employees SET email = RTRIM(email);

--31. Remove leading spaces from the string '   SQL Server'.
SELECT LTRIM('   SQL Server');

--32. From a 'Comments' table, write a query to remove leading spaces from all comment texts.
UPDATE Comments SET comment = LTRIM(comment);

--33. Display the current date in the format 'dd-MM-yyyy'.
SELECT FORMAT(GETDATE(), 'dd-mm-yyyy') ;

--34. From an 'Orders' table with an 'OrderTotal' column, display the total as a currency with 2 decimal places.
SELECT FORMAT(OrderTotal, 'C', 'en-IN') AS FormattedOrderTotal
FROM Orders;


--35. Separate the string 'apple,banana,cherry' into individual fruits.
 SELECT value as Fruits FROM string_split('apple,banana,cherry',',');

 --From a 'Skills' table with a 'SkillList' column containing comma-separated skills, write a query to create a row for each individual skill.
SELECT value AS EachSkill FROM Skills CROSS APPLY STRING_SPLIT(SkillList, ',');
