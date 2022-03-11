create database secondtable
use secondtable
create table Departments
(
Dno int Primary key,
Dname varchar(25)
)

--insert into table(department)
insert into Departments values(1,'hr')

select * from Departments

--check containts 
create table Project
( 
prjno int primary key,
prjname varchar(25) check (prjname like 'p1%'),
prjclient varchar(25) default 'XYZ'
)

select * from Project 

insert into Project values (1,'P1022', 'cvhk')

--UNIQUE
create table Traines
( 
ID int primary key,
TName varchar(30) unique,
TSalaray int default 35000,
Taddress varchar(50) NOT NULL,
Tdepartment varchar(50) check (TSalaray>=20000 )
)

--insert
insert into Traine values(01,'deepak','nagpur','cs')