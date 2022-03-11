use Dlit;


-- Create view on single table Trainees28
create VIEW Trainee
AS
Select *
From trainees28 where score>97;

select * from Trainees28Toppers;

--In the simple view we can insert, update, delete data. 
--We can only insert data in a simple view if we have a primary key and all not null fields in the view.

insert into Trainees28Toppers values(17,'Lucky','HR',98);

update Trainees28Toppers set designation='Tester' where empid=17;

delete from Trainees28Toppers where empid=17;

--Complex View
--When we create a view on more than one table, it is called a complex view.

create view onlineshoppingview
as
SELECT OC.CUSTOMERID,customerName, customercity, customermail, salestotal,o.orderid
FROM onlinecustomers AS oc
   INNER JOIN
   orders AS o
   ON oc.customerid = o.customerid
   INNER JOIN
   sales AS s
   ON o.orderId = s.orderId;

select * from onlineshoppingview;

--We can only update data in a complex view. We can't insert data in a complex view.

update onlineshoppingview set salestotal=salestotal-50;