use msdb;
select * from Traines;
-- Start a new transaction    
BEGIN TRANSACTION  
-- SQL Statements  
 INSERT INTO Trainees28 VALUES(20, 'Rena', 'HR', 98)  ;
 UPDATE Trainees28 SET score = 100 WHERE empid=17; 
 -- Commit changes   
COMMIT TRANSACTION  --The INSERT and UPDATE statements cannot be rolled back after the transaction has been committed.

--Example of ROLLBACK Transaction

select * from Trainees28;
-- Start a new transaction    
BEGIN TRANSACTION  
-- SQL Statements  
 INSERT INTO Trainees28 VALUES(21, 'Parvathi', 'Tester', 98)  ;
 UPDATE Trainees28 SET score = 99 WHERE empid=18; 
--Undo Changes    
ROLLBACK TRANSACTION  

--Use of @@Error Global variable in transactions:
--This variable is used to check whether there is an error or not. 

BEGIN TRANSACTION  
INSERT INTO Trainees28 VALUES(21, 'Lucky B', 'HR', 98)  ;
-- Check for error  
IF(@@ERROR > 0)  
BEGIN  
    ROLLBACK TRANSACTION  
END  
ELSE  
BEGIN  
   COMMIT TRANSACTION  
END 

--Auto Rollback Transaction

BEGIN TRANSACTION 
  set nocount on; 
  INSERT INTO Trainees28 VALUES(18, 'Paru', 'Tester', 98)  ;  
  SELECT * FROM Trainees28
COMMIT TRANSACTION   

--Savepoint in Transactions
BEGIN TRANSACTION   
-- SQL Statements  
 INSERT INTO Trainees28 VALUES(22, 'Sithara', 'HR', 99)  ;
SAVE TRANSACTION InsertStatement  --savepoint is only applied to insert statement

UPDATE Trainees28 SET score = 100 WHERE empid=19;  --in the second output, the updation operation is rolled back because of the savepoint.
SELECT * FROM Trainees28 
 
ROLLBACK TRANSACTION InsertStatement  
COMMIT  
SELECT * FROM Trainees28  

--delete from trainees28 where empid=19

--Implicit Transaction in SQL Server
SET IMPLICIT_TRANSACTIONS ON   
UPDATE Trainees28 SET score = 100 WHERE empid=19;   
SELECT   
    IIF(@@OPTIONS & 2 = 2,   
    'Implicit Transaction Mode ON',   
    'Implicit Transaction Mode OFF'  
    ) AS 'Transaction Mode'   
SELECT @@TRANCOUNT AS OpenTrans   
COMMIT TRANSACTION  
SELECT @@TRANCOUNT AS OpenTrans  