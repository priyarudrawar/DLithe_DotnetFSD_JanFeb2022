--CREATE Trigger Database
create database mytriggers;

use mytriggers;


--crating employee table
CREATE TABLE Employee
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)
GO


-- Insert data into Employee table
INSERT INTO Employee VALUES (1,'Pranaya', 5000, 'Male', 3)
INSERT INTO Employee VALUES (2,'Priyanka', 5400, 'Female', 2)
INSERT INTO Employee VALUES (3,'Anurag', 6500, 'male', 1)
INSERT INTO Employee VALUES (4,'sambit', 4700, 'Male', 2)
INSERT INTO Employee VALUES (5,'Hina', 6600, 'Female', 3)

select * from Employee


--creating trigger to raise when try to insert new value
CREATE TRIGGER InsertError 
ON Employee
FOR INSERT
AS
BEGIN
PRINT 'You do not Have Permission Insert'
ROLLBACK TRANSACTION
END

INSERT INTO Employee VALUES (6,'Rina', 6900, 'Female', 2)
--Output
--You do not Have Permission Insert
--Msg 3609, Level 16, State 1, Line 32
--The transaction ended in the trigger. The batch has been aborted.

--klajskf
--Update will work, not triggers
UPDATE Employee SET Salary = 15000 WHERE Id = 5
select * from Employee