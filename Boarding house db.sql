use BoardingHouse

Select * from Employee_acc

select * from Tenant
where FirstName = 'John'
Collate latin1_general_cs_as

drop table Employee_acc

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

drop table Tenant

select * from Tenant

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
	Document_pic varbinary(max) null,
	archive smallint default 0,
	Employee_id int default 0

);
 
INSERT INTO Tenant (FirstName, LastName, Contact, Emergency_Name, Emergency_Contact, Relationship, School, Address, Document_pic, archive)
VALUES 
('John', 'Doe', 1234567890, 'Jane Doe', 9876543210, 'Spouse', 'ABC University', '123 Main St', 0x0101010101, 0),
('Alice', 'Smith', 9876543210, 'Bob Smith', 1234567890, 'Parent', 'XYZ College', '456 Oak St', 0x0202020202, 0),
('James', 'Johnson', 5555555555, 'Emily Johnson', 6666666666, 'Sibling', 'DEF School', '789 Pine St', 0x0303030303, 0),
-- Add more rows as needed
('Eva', 'Williams', 1111111111, 'Michael Williams', 2222222222, 'Child', 'GHI Academy', '987 Cedar St', 0x0404040404, 0),
('David', 'Martinez', 3333333333, 'Sophia Martinez', 4444444444, 'Cousin', 'JKL High School', '654 Birch St', 0x0505050505, 0),
-- Add more rows as needed
('Olivia', 'Brown', 7777777777, 'Daniel Brown', 8888888888, 'Friend', 'MNO School', '321 Elm St', 0x0606060606, 0),
-- Add more rows as needed
('Liam', 'Anderson', 9999999999, 'Ava Anderson', 8888888888, 'Friend', 'PQR Institute', '654 Pine St', 0x0707070707, 0),
-- Add more rows as needed
('Emma', 'Taylor', 7777777777, 'Noah Taylor', 6666666666, 'Sibling', 'STU College', '852 Oak St', 0x0808080808, 0),
('Logan', 'Clark', 4444444444, 'Sophia Clark', 3333333333, 'Cousin', 'VWX University', '147 Cedar St', 0x0909090909, 0),
-- Add more rows as needed
('Mia', 'Lewis', 2222222222, 'Ethan Lewis', 1111111111, 'Parent', 'YZA School', '369 Elm St', 0x1010101010, 0);


drop table Tenant

drop table Room

--Room Desc, cap, price status

Select Room_number, Description, (Availability + ':' + Capacity) as Availability,
Price, Status from Room; 

Select Room_number, Description, Availability + '/' + Capacity as Availability, Price, Status from Room;

use BoardingHouse

drop table Room

select * from Room

Create table Room(
	
	Room_id int primary key identity(1,1),
	Room_number int unique,
	Description varchar(50),
	Availability int,
	Capacity int,
	Price decimal(10,2),
	Status varchar(30) DEFAULT 'Available',
	Employee_id int default 0

);

INSERT INTO Room (Room_number, Description, Availability, Capacity, Price, Status)
VALUES 
(101, 'Standard Single', 1, 1, 75.00, 'Available'),
(102, 'Deluxe Double', 1, 2, 120.00, 'Available'),
(103, 'Executive Suite', 1, 4, 200.00, 'Available'),
(201, 'Standard Twin', 1, 2, 90.00, 'Available'),
(202, 'Family Room', 1, 4, 150.00, 'Available'),
(203, 'Luxury Suite', 1, 2, 250.00, 'Available'),
(301, 'Honeymoon Suite', 1, 2, 180.00, 'Available'),
(302, 'Penthouse', 1, 6, 400.00, 'Available'),
(303, 'Accessible Room', 1, 2, 100.00, 'Available'),
(401, 'VIP Suite', 1, 3, 300.00, 'Available');



Select * from Tenant

Create Table lease_tbl(
	
	lease_id int primary key identity(1,1),
	Tenant_id int,
	Employee_id int,
	room_id int,
	StartDate datetime DEFAULT GETDATE()

);

Create Table Payment(
	
	Payment_id int primary key identity(1,1),
	lease_id int,
	PaymentDate datetime default getdate(),
	Employee_id int,
	balance decimal(10,2) default 0,
	Amount_paid decimal(10,2) default 0,
	Type varchar(10)


);

Create table Maintenance(
	
	Maintenance_id int primary key identity(1,1),
	Tenant_id int,
	Employee_id int,
	Details varchar(45),
	Date_added datetime default getdate(),
	Archive smallint default 0
);



drop table Maintenance

select * from occupation_detail


Select * from Room

use BoardingHouse



select * from Employee_acc

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('John', 'Doe', NULL, 1234567890, 'johndoe', 'password123', 'Birth Place', 'Los Angeles', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Jane', 'Doe', NULL, 9876543210, 'janedoe', 'password456', 'Favorite Hero', 'Spider-Man', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Mike', 'Smith', NULL, 5555555555, 'mikesmith', 'password789', 'Favorite Team', 'Golden State Warriors', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Alice', 'Johnson', NULL, 2222222222, 'alicejohnson', 'password012', 'Birth Place', 'New York', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Bob', 'Williams', NULL, 3333333333, 'bobwilliams', 'password345', 'Favorite Hero', 'Iron Man', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Charlie', 'Taylor', NULL, 4444444444, 'charlietaylor', 'password678', 'Favorite Team', 'Los Angeles Lakers', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Diana', 'Moore', NULL, 6666666666, 'dianamoore', 'password901', 'Birth Place', 'Chicago', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Edward', 'Garcia', NULL, 7777777777, 'edwardgarcia', 'password234', 'Favorite Hero', 'Captain America', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Emma', 'Wilson', NULL, 8888888888, 'emmawilson', 'password567', 'Favorite Team', 'Boston Celtics', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Fred', 'Lewis', NULL, 1111111111, 'fredlewis', 'password890', 'Birth Place', 'Houston', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Georgia', 'Clark', NULL, 2222222222, 'georgiaclark', 'password123', 'Favorite Hero', 'Thor', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Henry', 'Davis', NULL, 3333333333, 'henrydavis', 'password456', 'Favorite Team', 'San Francisco Giants', 'User');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Isabella', 'Rodriguez', NULL, 4444444444, 'isabellarodriguez', 'password789', 'Birth Place', 'Miami', 'Admin');


select * from Employee_acc


