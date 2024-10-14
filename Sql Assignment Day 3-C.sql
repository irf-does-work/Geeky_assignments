-- Library Management Schema

CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    AuthorName VARCHAR(100),
    BirthYear INT
);

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title VARCHAR(200),
    AuthorID INT,
    PublicationYear INT,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

CREATE TABLE Patrons (
    PatronID INT PRIMARY KEY,
    PatronName VARCHAR(100),
    MembershipDate DATE
);

CREATE TABLE Loans (
    LoanID INT PRIMARY KEY,
    BookID INT,
    PatronID INT,
    LoanDate DATE,
    ReturnDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (PatronID) REFERENCES Patrons(PatronID)
);

-- Questions

-- 1. List all books along with their authors, including books without assigned authors.
SELECT BookID, Title, a.AuthorID, a.AuthorName
FROM Books b LEFT JOIN Authors a ON b.AuthorID = a.AuthorID;

-- 2. Display all patrons and their loan history, including patrons who have never borrowed a book.
SELECT p.PatronID, PatronName, LoanID, BookID, LoanDate,ReturnDate
FROM Patrons p LEFT JOIN Loans l ON p.PatronID = l.PatronID ;

-- 3. Show all authors and the books they've written, including authors who haven't written any books in our collection.
SELECT a.AuthorID, AuthorName, BookID, Title
FROM Authors a LEFT JOIN Books b ON a.AuthorID = b.AuthorID;

-- 4. List all possible book-patron combinations, regardless of whether a loan has occurred.
SELECT BookID, Title, PatronID, PatronName
FROM Books CROSS JOIN Patrons;

-- 5. Display all loans with book and patron information, including loans where either the book or patron information is missing.
SELECT  LoanID, b.BookID, Title, AuthorID, PublicationYear, p.PatronID, PatronName
FROM Loans l LEFT JOIN Books b ON l.BookID = b.BookID
LEFT JOIN Patrons p ON l.PatronID = p.PatronID;


-- 6. Show all books that have never been loaned, along with their author information.
SELECT b.BookID, Title, a.AuthorID, AuthorName, BirthYear
FROM Books b LEFT JOIN Loans l ON l.BookID = b.BookID 
JOIN Authors a ON a.AuthorID = b.AuthorID
WHERE l.LoanID IS NULL;

-- 7. List all patrons who have borrowed books in the last month, along with the books they've borrowed.
SELECT l.PatronID, PatronName, l.BookID, Title, l.LoanDate
FROM Loans l JOIN Patrons p ON l.PatronID = p.PatronID
JOIN Books b ON b.BookID = l.BookID WHERE MONTH(l.LoanDate)=MONTH(GETDATE())-1 AND YEAR(l.LoanDate)=YEAR(GETDATE());

-- 8. Display all authors born after 1970 and their books, including those without any books in our collection.
SELECT a.AuthorID, AuthorName, BirthYear, BookID, Title
FROM Authors a LEFT JOIN Books b ON a.AuthorID = b.AuthorID WHERE BirthYear > 1970;

-- 9. Show all books published before 2000 and any associated loan information.
SELECT B.BookID,Title,PublicationYear,LoanID, PatronID, LoanDate, ReturnDate
FROM Books b LEFT JOIN Loans l ON l.BookID = b.BookID WHERE PublicationYear < 2000;

-- 10. List all possible author-patron combinations, regardless of whether the patron has borrowed a book by that author.
SELECT AuthorID, AuthorName, PatronID, PatronName
FROM Authors A CROSS JOIN Patrons p;
