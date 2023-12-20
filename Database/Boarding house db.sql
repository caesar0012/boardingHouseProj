use BoardingHouse


Select Employee_id, FirstName from Employee_acc
Union all
Select Tenant.Tenant_id, FirstName from Tenant
order by Employee_id asc



create Table Employee_acc(

	Employee_id int primary key identity(1,1),
	FirstName varchar(45),
	Lastname varchar(45),
	ProfilePic varbinary(max),
	Contact bigint,
	userName varchar(20) unique,
	password varchar(25),
	forgotQuestion varchar(45),
	forgotAnswer varchar(45),
	Role varchar(30),
	Timein datetime default getdate(),
	Timeout datetime,
	Archive smallint default 0

);


create table Tenant(

	Tenant_id int primary key identity(1,1),
	FirstName varchar(45),
	Lastname varchar(45),
	Gender varchar(10),
	Contact bigint,
	Emergency_name varchar(45),
	Emergency_Contact bigint,
	Relationship varchar(30),
	School varchar(45),
	Address varchar(50),
	Document_pic varbinary(max) null,
	archive smallint default 0,

);

drop table Room

Select * from Room

Create table Room(
	
	Room_id int primary key identity(1,1),
	Room_number int unique,
	Description varchar(50),
	allowed_gender varchar(10),
	Capacity int,
	Price decimal(10,2),
	Status varchar(30) DEFAULT 'Available',
	Employee_id int default 0

);

alter table  Room add FOREIGN key(Employee_id) references Employee_acc(Employee_id)

Create Table lease_tbl(
	
	lease_id int primary key identity(1,1),
	Tenant_id int unique,
	Employee_id int,
	room_id int,
	assign_bed int,
	StartLease date,
	EndLease date NULL

);

drop table lease_tbl

Select * from lease_tbl

use BoardingHouse

alter table lease_tbl
	add FOREIGN key(Employee_id) references Employee_acc(Employee_id)

alter table lease_tbl
	add FOREIGN key(Tenant_id) references Tenant(Tenant_id)

alter table lease_tbl
	add FOREIGN key(room_id) references Room(Room_id)

select * from lease_tbl

truncate table lease_tbl

-- Select t1.Tenant_id ,(t1.FirstName + ' ' + t1.LastName) as Name, Gender,  lease1.room_id from Tenant as t1
-- 	inner join lease_tbl as lease1
-- 	on  t1.Tenant_id = lease1.lease_id where ;
 
-- Insert 10 rows into the Tenant table




Create Table Payment(
	
	Payment_id int primary key identity(1,1),
	lease_id int,
	PaymentDate datetime default getdate(),
	Employee_id int,
	balance decimal(10,2) default 0,
	Amount_paid decimal(10,2) default 0

);

Create table Maintenance(
	
	Maintenance_id int primary key identity(1,1),
	Employee_id int,
	Details varchar(45),
	Date_added datetime default getdate(),
	Archive smallint default 0

);

drop table TenantRequest

CREATE TABLE TenantRequest (

    Request_id INT PRIMARY KEY IDENTITY(1,1),
	Employee_id int,
    Tenant_id INT,
    Details VARCHAR(255),
    Date_added DATETIME DEFAULT GETDATE(),
	Archive int DEFAULT 0

);

Select * from TenantRequest

Select * from Tenant

Select t1.Tenant_id, t1.FirstName + ' ' + t1.LastName as Name
from Tenant as t1
where t1.FirstName + ' ' + t1.Lastname = 'John Doe'