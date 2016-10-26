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
```
USE [TSqlHowework]
GO

CREATE PROCEDURE usp_WithdrawMoney(@accountId int,@sum money) 
    AS
		UPDATE Accounts 
		SET Balance = Balance - @sum
		WHERE PersonId=@accountId 
		AND Balance > @sum
GO

EXEC usp_WithdrawMoney 1000
GO

CREATE PROCEDURE usp_DepositMoney(@accountId int,@sum money) 
	AS
		UPDATE Accounts 
		SET Balance += @sum
		WHERE PersonId=@accountId 
GO

EXEC usp_DepositMoney 100000
GO
```

#### 6. Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
```
USE [TSqlHowework]
GO

CREATE TABLE Logs(
    Id int PRIMARY KEY IDENTITY(0,1),
    AccountId int FOREIGN KEY REFERENCES Accounts(Id),
    OldSum money NOT NULL,
    NewSum money NOT NULL
)
GO
```
*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account changes.
```
USE [TSqlHowework]
GO

CREATE TRIGGER trg_Accounts_Insert 
ON Accounts
FOR UPDATE 
AS
DECLARE @beforeTransactionSum money;
SELECT @beforeTransactionSum =  Balance FROM deleted

INSERT INTO Logs(AccountId,OldSum,NewSum)	
SELECT Id , @beforeTransactionSum , Balance FROM inserted
PRINT('trg_Accounts_Insert fired!')
GO
```