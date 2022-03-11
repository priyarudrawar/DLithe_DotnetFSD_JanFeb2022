--stored procedure
--insert update delete
--cache -xyz pre comiled query

create database Dlith
use Dlith
create table DLIT_Trainees
create procedure PROC_DT
AS
BEGIN
     select * from Dlithe_Trainees where TID <4;
	 END 
	 exec Proc_Dt


	 --alter Store Procedure

	 alter procedure PROC_Dt
	 AS 
	 BEGIN
	 select * from Dlith_Trainees where TID<4 and TADDRESS='bengulurur';
	 END
	 exec proc_dt

	 --drop

	 drop procedure PROC_Dt

	 use secondtable
	 --sp procedure with input parameter
	 create procedure secondtable(@TADDRESS varchar(50))
	 as 
	 begin
	 select * from Project where TADDRESS=@TADDRESS
	 end

	 --display
	 exec secondtable @TADDRESS='palam'


	 --SP with output parameter
	 create procedure PROC_DT1(@TID int output)
	 as
	 begin
	 select @TID=max(TID) from Dlithe_Trainees
	 END

	 Declare 

	 exec PROC_DT1 @TID output
	 print 