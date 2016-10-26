## 06. Transact SQL
### _Homework_

#### 1.	Create a database with two tables: `People(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
```
USE master;  
GO  

CREATE DATABASE TSqlHowework;  
GO
```

```
USE TSqlHowework
GO

CREATE TABLE People(
    Id int PRIMARY KEY IDENTITY(0,1),
    FirstName nvarchar(50) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    SSN nvarchar(20)
)
GO 
```

```
USE TSqlHowework
GO

CREATE TABLE Accounts(
    Id int PRIMARY KEY IDENTITY(0,1),
    PersonId int FOREIGN KEY REFERENCES People(Id),
    Balance money NOT NULL
)
GO
```
	*	Insert few records for testing.
```
USE [TSqlHowework]
GO

INSERT INTO [dbo].[People]
           ([FirstName]
           ,[LastName]
           ,[SSN])
	VALUES('Vasli','Levski','721-07-4424') 
	 
INSERT INTO [dbo].[People]
			([FirstName]
			,[LastName]
			,[SSN])
	VALUES('Htisto','Botev','721-07-4425') 
	 
INSERT INTO [dbo].[People]
			([FirstName]
			,[LastName]
			,[SSN])
	VALUES('Simeon','Veliki','721-07-4426')

INSERT INTO [dbo].[People]
			([FirstName]
			,[LastName]
			,[SSN])
	VALUES('Han','Asparuh','681-07-4427')
GO
```
```
USE [TSqlHowework]
GO

INSERT INTO [dbo].[Accounts]
           ([PersonId]
           ,[Balance])
     VALUES(0, 1000000)
GO

INSERT INTO [dbo].[Accounts]
           ([PersonId]
           ,[Balance])
     VALUES(1, 2000000)
GO

INSERT INTO [dbo].[Accounts]
           ([PersonId]
           ,[Balance])
     VALUES(2, 3000000)
GO

INSERT INTO [dbo].[Accounts]
           ([PersonId]
           ,[Balance])
     VALUES(3, 4000000)
GO
```

	*	Write a stored procedure that selects the full names of all People.

```
USE [TSqlHowework]
GO

CREATE PROCEDURE uspFullNameOfAllPeople	
AS
BEGIN
	SELECT FirstName + ' ' + LastName FROM People
END
GO

EXEC uspFullNameOfAllPeople
GO
```

#### 2.	Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
```
USE [TSqlHowework]
GO

CREATE PROCEDURE upsGetAllPeopleWithMoreThan	
	@money money
AS
BEGIN
	SELECT p.FirstName FROM People p, Accounts a
	WHERE p.Id=a.PersonId
	AND a.Balance > @money
END
GO

EXEC upsGetAllPeopleWithMoreThan 1000000
GO
EXEC upsGetAllPeopleWithMoreThan 3000000
GO
```

#### 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
	*	It should calculate and return the new sum.
```
USE [TSqlHowework]
GO

CREATE FUNCTION ufn_CalculateMoney(@sum money,@interestRate real,@months int)
  RETURNS money
AS
BEGIN
  RETURN @sum*(1+@months*((@interestRate/100)/12))
END
GO
```
	*	Write a `SELECT` to test whether the function works as expected.
```
USE [TSqlHowework]
GO

SELECT Balance, dbo.ufn_CalculateMoney(Balance,3.5,12) AS [InterestRate] FROM Accounts
GO
```

#### 4.	Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
	*	It should take the `AccountId` and the interest rate as parameters.
```
USE [TSqlHowework]
GO

CREATE PROCEDURE upsCalculate	
	@accountId int,
	@interesRate real
AS
BEGIN
    SELECT Balance, dbo.ufn_CalculateMoney(Balance,@interesRate,1) AS [InterestRate]
    FROM Accounts as a 
    WHERE a.Id = @accountId
END
GO
```
```
EXEC [dbo].[upsCalculate] @accountId = 1, @interesRate = 3.5
```

#### 5. Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.