--Create database BoardingHouse
use BoardingHouse

create Table Staff_acc(

	Staff_id int primary key identity(60,1),
	FirstName varchar(45),
	Lastname varchar(45),
	ProfilePic varbinary(max),
	Contact bigint,
	userName varchar(20) unique,
	password varchar(25),
	forgotQuestion varchar(45),
	forgotAnswer varchar(45),
	Role varchar(30),
	Date date default getdate(),
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
	Room_number varchar(20),
	Description varchar(50),
	allowed_gender varchar(10),
	Capacity int,
	Price decimal(10,2),
	Status varchar(30) DEFAULT 'Available',
	Staff_id int default 0,
	Archive smallint default 0

	FOREIGN key(Staff_id) REFERENCES Staff_acc(Staff_id)

);

Create Table lease_tbl(
	
	lease_id int primary key identity(40,1),
	Tenant_id int unique,
	Staff_id int,
	room_id int,
	assign_bed int,
	MonthlyPayment decimal,
	DepositAmount DECIMAL,
	StartLease date,
	EndLease date NULL,

	FOREIGN key (Tenant_id) REFERENCES Tenant(Tenant_id),
	FOREIGN key (Staff_id) REFERENCES Staff_acc(Staff_id),
	FOREIGN KEy (Room_id) REFERENCES Room(Room_id)
);

CREATE TABLE Payment (

    Payment_id INT PRIMARY KEY IDENTITY(1,1),
    Staff_id INT,
    Lease_id INT,
    PaymentDate DATETIME DEFAULT GETDATE(),
    Amount_paid DECIMAL(10,2) DEFAULT 0,
    Payment_type VARCHAR(10),
	SenderName varchar(45),
	Contact bigint,
	Reference bigint,
	archive smallint DEFAULT 0,
    CONSTRAINT fkStaff FOREIGN KEY (Staff_id) REFERENCES Staff_acc(Staff_id),
    CONSTRAINT FK_Lease FOREIGN KEY (Lease_id) REFERENCES Lease_tbl(Lease_id)

);

CREATE TABLE Addon (

    Addon_id INT PRIMARY KEY IDENTITY(75,1),
	lease_id int,
	Staff_id int,
    AddOnAmount DECIMAL(10,2),
    AddOnDetails VARCHAR(45),
	Date date DEFAULT getdate(),
	Archive TINYINT DEFAULT 0,
	FOREIGN key (lease_id) references lease_tbl(lease_id),
	FOREIGN key(Staff_id) REFERENCES Staff_acc(Staff_id)

);


Create table Maintenance(
	
	Maintenance_id int primary key identity(70,1),
	Staff_id int,
	Details varchar(45),
	Date_added datetime default getdate(),
	Archive smallint default 0,
	
	FOREIGN key(Staff_id) REFERENCES Staff_acc(Staff_id)
);

CREATE TABLE TenantRequest (

    Request_id INT PRIMARY KEY IDENTITY(80,1),
	Staff_id int,
    Tenant_id INT,
    Details VARCHAR(255),
    Date_added DATETIME DEFAULT GETDATE(),
	Archive int DEFAULT 0,

	FOREIGN key(Staff_id) REFERENCES Staff_acc(Staff_id),
	FOREIGN key(Tenant_id) REFERENCES Tenant(Tenant_id)

);

USE BoardingHouse;
