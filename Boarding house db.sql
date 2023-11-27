

Begin Transaction;

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



/*

Begin Transaction
	Rollback;

	*/
	select * from Customer_Personal_Info

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




create table Customer_occupancy(

	id int identity(1,1),
	Room smallint,
	Move_in date default getdate(),
	Archive smallint default 0,

	foreign key(id) references Customer_Personal_Info(id)

);

create table Create_room(

	Room_id int primary key identity(1,1),
	room_number int unique,
	Description varchar(45),
	Capacity int,
	Price decimal(10,2),
	Status varchar(20)

);

select cr.room_number, cp1.id, cp1.firstName from Create_room as cr
Join Customer_Personal_Info as cp1
on cr.room_number = cp1.id;



SELECT cr1.room_number, cr1.Description, cr1.Capacity, cr1.Price
,cpi.firstName + ' ' + cpi.middleName + ' ' + cpi.LastName AS Tenant,
cr1.Status
FROM Create_room as cr1
join Customer_Personal_Info as cpi
on cpi.id = cr1.Room_id;

SELECT cr1.room_number, cr1.Description, cr1.Capacity, cr1.Price\r\n,cpi.firstName + ' ' + cpi.middleName + ' ' + cpi.LastName AS Tenant,\r\ncr1.Status\r\nFROM Create_room as cr1\r\njoin Customer_Personal_Info as cpi\r\non cpi.id = cr1.Room_id

create table transaction_info(

   Transaction_id int primary key identity(1,1),
   Customer_id int identity(1,1),
   Staff_id int,
   Amount decimal,
   Via varchar(10)

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

    
 
 













