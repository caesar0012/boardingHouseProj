use BoardingHouse

create Table Employee_acc(

	Employee_id int primary key identity(60,1),
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

	Tenant_id int primary key identity(20,1),
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


Create table Room(
	
	Room_id int primary key identity(30,1),
	Room_number int unique,
	Description varchar(50),
	allowed_gender varchar(10),
	Capacity int,
	Price decimal(10,2),
	Status varchar(30) DEFAULT 'Available',
	Employee_id int default 0,

	FOREIGN key(Employee_id) REFERENCES Employee_acc(Employee_id)

);



Create Table lease_tbl(
	
	lease_id int primary key identity(40,1),
	Tenant_id int unique,
	Employee_id int,
	room_id int,
	assign_bed int,
	MonthlyPayment decimal,
	DepositAmount DECIMAL,
	StartLease date,
	EndLease date NULL,

	FOREIGN key (Tenant_id) REFERENCES Tenant(Tenant_id),
	FOREIGN key (Employee_id) REFERENCES Employee_acc(Employee_id),
	FOREIGN KEy (Room_id) REFERENCES Room(Room_id)
);

Create Table Payment(
	
	Payment_id int primary key identity(50,1),
	Employee_id int,
	lease_id int,
	PaymentDate datetime default getdate(),
	Amount_paid decimal(10,2) default 0,
	Payment_type VARCHAR(10),
	AddOnAmount decimal,
	AddOnDetails varchar(45),
	OutstandingBalance decimal(10,2) default 0,

	FOREIGN KEY(Employee_id) REFERENCES Employee_acc(Employee_id),
	FOREIGN Key(lease_id) REFERENCES lease_tbl(lease_id)

);


Create table Maintenance(
	
	Maintenance_id int primary key identity(70,1),
	Employee_id int,
	Details varchar(45),
	Date_added datetime default getdate(),
	Archive smallint default 0,
	
	FOREIGN key(Employee_id) REFERENCES Employee_acc(Employee_id)
);

CREATE TABLE TenantRequest (

    Request_id INT PRIMARY KEY IDENTITY(80,1),
	Employee_id int,
    Tenant_id INT,
    Details VARCHAR(255),
    Date_added DATETIME DEFAULT GETDATE(),
	Archive int DEFAULT 0,

	FOREIGN key(Employee_id) REFERENCES Employee_acc(Employee_id),
	FOREIGN key(Tenant_id) REFERENCES Tenant(Tenant_id)

);


