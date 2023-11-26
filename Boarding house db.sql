

create table Employee_Info(

	Employee_id int primary key identity(1,1),
	firstName varchar(45),
	lastName varchar(45),
	ProfilePic varbinary(max),
	Contact Bigint

);

create table Employee_acc(

	Employee_id int identity(1,1),
	userName varchar(45),
	password varchar(45),
	forgotQuestion varchar(45),
	forgotAnswer varchar(45),
	Role varchar(30),
	Timein datetime default getdate(),
	Timeout datetime,
	Archive smallint default 0,

	foreign key(Employee_id) references Employee_info(Employee_id),


);

create table Customer_Personal_Info(
	
	id int primary key identity(1,1),
	firstName varchar(20),
	middleName varchar(25),
	lastName varchar(25),
	Contact bigint,
	Emergency_Contact bigint,
	Relationship varchar(20),
	School varchar(45),
	Address varchar(60),
	Document varbinary(max)


);

--drop table Customer_occupancy
--  Select * from Customer_occupancy


create table Customer_occupancy(

	id int identity(1,1),
	Room smallint,
	Move_in date default getdate(),
	Archive smallint default 0,

	foreign key(id) references Customer_Personal_Info(id)

);







create table transaction_info(

   Transaction_id int primary key,
   Customer_id int,
   Staff_id int,
   Amount decimal,
   Via varchar(10),
   type int,

);

create table Maintenance(

	Maintenace_id int,
	Customer_id int,
	Employee_id int,
	Request varchar(65),
	Date_added datetime,
	Archive smallint,

);

create table Admin(

	id int,
	user_name smallint,
	password date,
	Role varchar(20),

);

    
 
 













