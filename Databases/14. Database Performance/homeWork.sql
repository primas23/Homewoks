--1.
USE master;  
GO  

CREATE DATABASE DatabasePerformance;  
GO
--
USE DatabasePerformance
GO

CREATE TABLE Log(
    Id int PRIMARY KEY IDENTITY(0,1),
    Message nvarchar(50) NOT NULL
)
GO 

DECLARE @i INT;
SET @i = 1;
INSERT INTO Log(n,'first') SELECT 1;
WHILE @i<10000000 BEGIN
  INSERT INTO Log(n)
    SELECT n + @i FROM dbo.Numbers;
  SET @i = @i * 2;
END;

--