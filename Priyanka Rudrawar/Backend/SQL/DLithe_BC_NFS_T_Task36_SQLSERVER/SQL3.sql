 use dml;
 create table Trainees28
(
empid int not null,
empname varchar(50) not null,
designation varchar(50) not null,
score int not null,
constraint pk_empid2 primary key(empid)
);

--insert command in Trainees28
insert into Trainees28 values(1,'Nevetha','Developer',98);
insert into Trainees28 values(2,'Naveen','Developer',97);
insert into Trainees28 values(3,'Riju','Designer',97);
insert into Trainees28 values(4,'Aakass Elango','Designer',97);
insert into Trainees28 values(5,'Aakash','Developer',98);
insert into Trainees28 values(6,'Lalith','Designer',98);
insert into Trainees28 values(7,'Vishal','Designer',97);
insert into Trainees28 values(8,'JOHN','HR',98);
insert into Trainees28 values(9,'JAMES','Tester',98);
insert into Trainees28 values(10,'DEAN','HR',97);
insert into Trainees28 values(11,'SAM','HR',96);
insert into Trainees28 values(12,'JANCY','Tester',98);
insert into Trainees28 values(13,'NANCY','Developer',97);
insert into Trainees28 values(14,'DORA','Designer',96);
insert into Trainees28 values(15,'DAISY','Tester',97);
insert into Trainees28 values(16,'ROCKY','HR',97);	

 select * from trainees28;
 
create table Toppers
(
empid int,
empname varchar(25),
score int
);

INSERT INTO Toppers(empid,empname,score)
SELECT empid,empname,score FROM Trainees28
WHERE score>97;
 CREATE CLUSTERED INDEX IX_Employee_ID ON Toppers(empid ASC);

 select * from Toppers where empid=1;


 CREATE INDEX idx_score ON Trainees28 (score);

 select score from trainees28;



EXEC sp_helpindex 'Trainees28'
GO

SELECT
 name AS Index_Name,
 type_desc  As Index_Type,
 is_unique,
 OBJECT_NAME(object_id) As Table_Name
FROM
 sys.indexes
WHERE
 object_id = OBJECT_ID('Trainees28');
GO


SELECT OC.CUSTOMERID,customerName, customercity, customermail, salestotal,o.orderid
FROM onlinecustomers AS oc
   INNER JOIN
   orders AS o
   ON oc.customerid = o.customerid
   INNER JOIN
   sales AS s
   ON o.orderId = s.orderId;



CREATE NONCLUSTERED INDEX IX_Trainee28_DesTest ON Trainees28 (designation) WHERE designation='Tester';

select designation from trainees28 WHERE designation='Tester';