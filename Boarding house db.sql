use BoardingHouse

select * from Tenant

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
	Arhive smallint default 0

);


create table Tenant(

	Tenant_id int primary key identity(1,1),
	FirstName varchar(45),
	Lastname varchar(45),
	Contact bigint,
	Emergency_name varchar(45),
	Emergency_Contact bigint,
	Relationship varchar(30),
	School varchar(45),
	Address varchar(50),
	Document_pic varbinary(max),
	archive smallint default 0

);
 
 select * from Roo

Create table Room(
	
	Room_id int primary key identity(1,1),
	Room_number int unique,
	Description varchar(50),
	Tenant_id int,
	Availability int,
	Capacity int,
	Price decimal(10,2),
	Status varchar(30)

);

create table Maintenance(
	
	Maintenance_id int primary key identity(1,1),
	Tenant_id int,
	Employee_id int,
	Request varchar(45),
	Date_request datetime,
	Status varchar(40),
	Archive smallint

);












