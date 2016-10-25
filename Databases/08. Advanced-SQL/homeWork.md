01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
SELECT FirstName, LastName, Salary
FROM Employees 
WHERE Salary=(SELECT MIN(Salary) FROM Employees)

02. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName, LastName, Salary
FROM Employees 
WHERE Salary<(SELECT MIN(Salary)*1.1 FROM Employees)

03. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
SELECT FirstName+ ' '+ LastName AS [Full Name], Salary, d.Name AS [Dep. Name]
FROM Employees e, Departments d
WHERE Salary=(SELECT MIN(Salary)FROM Employees s WHERE s.DepartmentID=d.DepartmentID)
ORDER BY Salary DESC

04. Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID=1

05. Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees e, Departments d
WHERE  e.DepartmentID=d.DepartmentID AND Name='Sales'

06. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(e.LastName) AS [Count of 'Sales' Department Employees]
FROM Employees e, Departments d
WHERE  e.DepartmentID=d.DepartmentID AND d.Name='Sales'

07. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(e.LastName) AS [Number of employees with manager]
FROM Employees e
WHERE  e.ManagerID IS NOT NULL

08. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(e.LastName) AS [Number of employees with manager]
FROM Employees e
WHERE  e.ManagerID IS NULL

09. Write a SQL query to find all departments and the average salary for each of them.
SELECT AVG(e.Salary) AS [AverageSalary], d.Name AS [Name of department]
FROM Employees e, Departments d
WHERE  e.DepartmentID=d.DepartmentID
GROUP BY  d.Name 

10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(e.LastName) AS [Number of employees], d.Name AS [Name of department], t.Name AS [Town]
FROM Employees e, Departments d, Towns t, Addresses a
WHERE  e.DepartmentID=d.DepartmentID
AND e.AddressID=a.AddressID
AND a.TownID=t.TownID
GROUP BY   t.Name, d.Name

11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT e.FirstName + ' ' + e.LastName AS [Names of manager with 5 employees]
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID OR m.ManagerID IS NULL
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(*)=5

12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Name of Employee],ISNULL(m.FirstName+' '+m.LastName,('no manager')) AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID=m.EmployeeID

13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT e.FirstName + ' ' + e.LastName AS [Name of Employee]
FROM Employees e
WHERE LEN(e.LastName)=5;

14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
SELECT CONVERT(VARCHAR(50),GETDATE(),104)+' '+CONVERT(VARCHAR(50),GETDATE(),114) AS[Date and time]

15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
CREATE TABLE Users(
Username VARCHAR(50) ,
Pass VARCHAR(50),
FirstName VARCHAR(50),
LastName VARCHAR(50),
LastLogin datetime
CONSTRAINT PK_Users PRIMARY KEY(Username),
CONSTRAINT Pass CHECK (LEN(Pass)>=5)
)
GO

16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
CREATE VIEW AllUsersFromToday AS
	SELECT *
	FROM Users u
	WHERE u.LastLogin = GETDATE()

17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
USE TelerikAcademy;
CREATE TABLE Groups(
Name NVARCHAR(50) NOT NULL UNIQUE , 
CONSTRAINT  PK_Groups PRIMARY KEY(Name)
)
GO

18. Write a SQL statement to add a column GroupID to the table Users.
ALTER TABLE Users
ADD GroupId INT FOREIGN KEY REFERENCES Groups(name)

19 Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups
VALUES 
(2),
(3)
GO
INSERT INTO Users
values 
('zaio2','11111','Zaio','Baio1',GetDate(),1),
('zaio3','11111','Zaio','Baio2',GetDate(),2),
('zaio4','11111','Zaio','Baio3',GetDate(),3)
GO

20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users SET
UserName='updated'
WHERE Username='zaio2'

21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE  Users
WHERE LastName='Baio3'
GO


22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
INSERT INTO  Users
(FirstName,LastName,Username,Pass,LastLogin)
SELECT e.FirstName,e.LastName,LOWER(LEFT(e.FirstName,1))+LOWER(LEFT(e.LastName,1))+LEFT(e.EmployeeID,4),e.EmployeeID+'12345',NULL
FROM Employees e

23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 
UPDATE  Users
SET Pass=NULL
WHERE DATEDIFF(day, LastLogin, '2016-3-10 00:00:00') > 0

24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE Users
WHERE Pass IS  NULL

25. Write a SQL query to display the average employee salary by department and job title.
SELECT AVG(e.Salary), e.JobTitle , d.Name  FROM Employees e, Departments d
WHERE d.DepartmentID=e.DepartmentID
GROUP BY e.JobTitle, d.Name

26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT MIN(e.Salary) as 'Min Salary', e.JobTitle , d.Name as 'Department name', 
e.FirstName + ' '+ e.LastName as 'Full Name'  FROM Employees e, Departments d
WHERE d.DepartmentID=e.DepartmentID
GROUP BY e.JobTitle, d.Name, e.FirstName + ' ' + e.LastName

27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP  1 COUNT(a.TownID) as [EmployeeCount] FROM Addresses a
JOIN Employees e
ON e.AddressID=a.AddressID
JOIN Towns t
ON t.TownID=a.TownID
GROUP BY t.TownID 
ORDER BY EmployeeCount DESC

28. Write a SQL query to display the number of managers from each town.
SELECT  COUNT(a.TownID) as [EmployeeCount], t.Name FROM Addresses a
JOIN Employees e
ON e.AddressID=a.AddressID
JOIN Towns t
ON t.TownID=a.TownID
WHERE e.ManagerID IS  NOT NULL
GROUP BY t.Name 
ORDER BY EmployeeCount DESC

29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--WorkHours--
DROP TABLE dbo.WorkHours
CREATE TABLE WorkHours(
Id INT PRIMARY KEY IDENTITY(1,1),
EmployeeId INT NOT NULL,
DateOfReport DATETIME,
Task NVARCHAR(50),
HoursOfWork INT,
Comments NVARCHAR(500),
CONSTRAINT FK_WorkHours_Employees FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeID)
)


--Add some records--
DECLARE @counter int
SET @counter=0

WHILE @counter<30
BEGIN
INSERT INTO WorkHours(EmployeeId,DateOfReport,Task,HoursOfWork,Comments)
VALUES (@counter,GETDATE(),'task'+CONVERT(VARCHAR(5), @counter),8,'comment'+CONVERT(VARCHAR(5), @counter))
SET @counter=@counter +1
END
DROP TABLE WorkHoursLog
GO

--WorkLogs--
CREATE TABLE WorkHoursLog(
Id int PRIMARY KEY IDENTITY(1,1),
WorkHoursId int,
EmployeeId INT FOREIGN KEY REFERENCES Employees(EmployeeId),
DateOfReport DATETIME,
Task NVARCHAR(50),
HoursOfWork INT,
Comments NVARCHAR(500),
[Action] varchar(10) NOT NULL
)

-- triggers --

--INSERT--
DROP TRIGGER trg_WorkHours_Insert
GO
CREATE TRIGGER trg_WorkHours_Insert ON WorkHours
FOR INSERT 
AS
INSERT INTO WorkHoursLog(WorkHoursId, EmployeeId, DateOfReport, Task, HoursOfWork, Comments, [Action])
    SELECT Id, EmployeeID, DateOfReport, Task, HoursOfWork, Comments, 'Insert'
    FROM inserted
PRINT 'FOR INSERT trigger fired.'
GO

--DELTETE--
DROP TRIGGER trg_WorkHours_Delete
GO
CREATE TRIGGER trg_WorkHours_Delete ON WorkHours
FOR DELETE 
AS
INSERT INTO WorkHoursLog(WorkHoursId,EmployeeId, DateOfReport, Task, HoursOfWork, Comments, [Action])
    SELECT Id, EmployeeId, DateOfReport, Task, HoursOfWork, Comments, 'Delete'
    FROM deleted
PRINT 'FOR DELETE trigger fired.'
GO

--UPDATE--
DROP TRIGGER trg_WorkHours_Update
GO
CREATE TRIGGER trg_WorkHours_Update ON WorkHours
FOR UPDATE 
AS
INSERT INTO WorkHoursLog(WorkHoursId,EmployeeId, DateOfReport, Task, HoursOfWork, Comments, [Action])
    SELECT Id, EmployeeId, DateOfReport, Task, HoursOfWork, Comments, 'UPDATE'
    FROM inserted
PRINT 'FOR UPDATE trigger fired.'
GO


--Trigers tests--

--DELETE--
DELETE FROM  WorkHours 
WHERE EmployeeId=25


--INSERT--
DECLARE @counter INT
SET @counter=31

INSERT INTO WorkHours(EmployeeId,DateOfReport,Task,HoursOfWork,Comments)
VALUES (@counter,GETDATE(),'task'+CONVERT(VARCHAR(5), @counter),8,'comment'+CONVERT(VARCHAR(5), @counter))

--UPDATE--
UPDATE WorkHours
SET HoursOfWork=9 
WHERE HoursOfWork=8


30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
BEGIN TRAN

ALTER TABLE Departments
	DROP CONSTRAINT FK_Departments_Employees
GO

DELETE e FROM  Employees e, Departments d
	WHERE e.DepartmentID=d.DepartmentID
	AND d.Name='Sales'

ROLLBACK TRAN

31. Start a database transaction and drop the table EmployeesProjects.
BEGIN TRAN

DROP TABLE EmployeesProjects

ROLLBACK TRAN

32. Find how to use temporary tables in SQL Server.
BEGIN TRAN

SELECT *  INTO  #Temp_EmployeesProjects
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * INTO EmployeesPRojects
FROM #Temp_EmployeesProjects

ROLLBACK TRAN