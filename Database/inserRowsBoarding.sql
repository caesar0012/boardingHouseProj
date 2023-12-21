use BoardingHouse

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
VALUES ('Edward', 'Garcia', NULL, 7777777777, 'edwardgarcia', 'password234', 'Favorite Hero', 'Captain America', 'Manager');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Emma', 'Wilson', NULL, 8888888888, 'emmawilson', 'password567', 'Favorite Team', 'Boston Celtics', 'Manager');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Fred', 'Lewis', NULL, 1111111111, 'fredlewis', 'password890', 'Birth Place', 'Houston', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Georgia', 'Clark', NULL, 2222222222, 'georgiaclark', 'password123', 'Favorite Hero', 'Thor', 'Admin');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Henry', 'Davis', NULL, 3333333333, 'henrydavis', 'password456', 'Favorite Team', 'San Francisco Giants', 'Cashier');

INSERT INTO Employee_acc (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES ('Isabella', 'Rodriguez', NULL, 4444444444, 'isabellarodriguez', 'password789', 'Birth Place', 'Miami', 'Admin');

Select * from Room where allowed_gender = 'Male'

INSERT INTO Room (Room_number, Description, allowed_gender, Capacity, Price, Status, Employee_id)
VALUES 
(1011, 'Standard Single', 'Male', 5, 75.00, 'Available', 1),
(102, 'Deluxe Double', 'Female', 10, 120.00, 'Available', 1),
(103, 'Executive Suite', 'Male', 10, 200.00, 'Available', 1),
(201, 'Standard Twin', 'Female', 10, 90.00, 'Available', 1),
(202, 'Family Room', 'Male', 10, 150.00, 'Available', 1),
(203, 'Luxury Suite', 'Female', 20, 250.00, 'Available', 1),
(301, 'Honeymoon Suite', 'Male', 20, 180.00, 'Available', 1),
(302, 'Penthouse', 'Female', 10, 400.00, 'Available', 1),
(303, 'Accessible Room', 'Male', 20, 100.00, 'Available', 1),
(401, 'VIP Suite', 'Female', 15, 300.00, 'Available', 1);

select * from Room

drop table Tenant

INSERT INTO Tenant (FirstName, Lastname, Gender, Contact, Emergency_name, Emergency_Contact, Relationship, School, Address, Document_pic, archive)
VALUES
('John', 'Doe', 'Male', 1234567890, 'Emergency1', 9876543210, 'Family', 'School1', 'Address1', NULL, 0),
('Jane', 'Smith', 'Female', 2345678901, 'Emergency2', 8765432109, 'Friend', 'School2', 'Address2', NULL, 0),
('Alice', 'Johnson', 'Female', 3456789012, 'Emergency3', 7654321098, 'Sibling', 'School3', 'Address3', NULL, 0),
('Bob', 'Williams', 'Male', 4567890123, 'Emergency4', 6543210987, 'Relative', 'School4', 'Address4', NULL, 0),
('Charlie', 'Brown', 'Male', 5678901234, 'Emergency5', 5432109876, 'Friend', 'School5', 'Address5', NULL, 0),
('Diana', 'Miller', 'Female', 6789012345, 'Emergency6', 4321098765, 'Family', 'School6', 'Address6', NULL, 0),
('Ethan', 'Davis', 'Male', 7890123456, 'Emergency7', 3210987654, 'Friend', 'School7', 'Address7', NULL, 0),
('Fiona', 'Moore', 'Female', 8901234567, 'Emergency8', 2109876543, 'Relative', 'School8', 'Address8', NULL, 0),
('George', 'Lee', 'Male', 9012345678, 'Emergency9', 1098765432, 'Sibling', 'School9', 'Address9', NULL, 0),
('Molly', 'Nguyen2', 'Female', 9876543210, 'Emergency10', 9876543210, 'Family', 'School10', 'Address10', NULL, 0),
('Diyo', 'Miller', 'Female', 6789012345, 'Emergency6', 4321098765, 'Family', 'School6', 'Address6', NULL, 0),
('Ethaniel', 'Davis', 'Male', 7890123456, 'Emergency7', 3210987654, 'Friend', 'School7', 'Address7', NULL, 0),
('Bombastic', 'Moore', 'Female', 8901234567, 'Emergency8', 2109876543, 'Relative', 'School8', 'Address8', NULL, 0),
('Georgiana', 'Lee', 'Male', 9012345678, 'Emergency9', 1098765432, 'Sibling', 'School9', 'Address9', NULL, 0),
('Holistic', 'Nguyen', 'Female', 9876543210, 'Emergency10', 9876543210, 'Family', 'School10', 'Address10', NULL, 0);

Select * from Room
Select * from Employee_acc
INSERT INTO lease_tbl (Tenant_id, Employee_id, room_id, assign_bed, StartLease, EndLease)
VALUES
    (11, 1, 1, 1, '2023-01-01', '2024-12-31'),
    (2, 2, 6, 2, '2023-02-01', '2024-11-30'),
    (3, 2, 7, 3, '2023-03-01', '2024-10-31'),
    (4, 2, 8, 4, '2023-04-01', '2024-09-30'),
    (5, 4, 9, 5, '2023-05-01', '2024-08-31'),
    (6, 4, 10, 6, '2023-06-01', '2024-07-31'),
    (7, 5, 11, 7, '2023-07-01', '2024-06-30'),
    (8, 10, 12, 8, '2023-08-01', '2024-05-31'),
    (9, 1, 13, 9, '2023-09-01', '2024-04-30'),
    (10, 13, 14, 10, '2023-10-01', '2024-03-31');



--name, gender, room_number, bed assign, monthly, deposit, start, ane

Select l1.Room_id as lease_Room_id, r1.Room_number
from lease_tbl as l1
left join Room as r1
on l1.room_id = r1.Room_id

Select * from lease_tbl

Select * from Tenant

SELECT t1.Tenant_id,
       t1.FirstName + ' ' + t1.LastName as Name,
       t1.Gender,
       r1.room_number,
       l1.assign_bed, 
       l1.MonthlyPayment,
       l1.DepositAmount
FROM Tenant as t1
LEFT JOIN Room as r1 ON t1.Tenant_id = r1.Room_id
LEFT JOIN lease_tbl as l1 ON r1.Room_id = l1.room_id;

Select t1.FirstName + ' ' + t1.LastName as Name, t1.Gender, r1.Room_number, l1.assign_bed, l1.MonthlyPayment, l1.DepositAmount
from Tenant as t1
left join Room as r1
on t1.tenant_id = r1.Room_id
left join lease_tbl as l1
on t1.Tenant_id = l1.lease_id

SELECT t1.Tenant_id,
       t1.FirstName + ' ' + t1.LastName AS Name,
	   r1.room_number,
	   l1.assign_bed,
	   l1.MonthlyPayment,
	   l1.DepositAmount,
	   l1.StartLease,
	   l1.EndLease
FROM Tenant AS t1
LEFT JOIN Lease_tbl AS l1 
ON t1.Tenant_id = l1.Tenant_id
left join Room as r1
on t1.Tenant_id = r1.Room_id

Select * from lease_tbl

Select r1.Room_id, r1.Room_number, l1.Room_id as l1room_id
	from Room as r1
	left join lease_tbl as l1
	on l1.Lease_id = r1.Room_id




Select distinct l1.room_id, r1.Room_number
	from lease_tbl as l1
	left join Room as r1
	on r1.Room_id = l1.room_id
	where r1.Room_id = 1

Select room_id  from lease_tbl


Select * from lease_tbl

Select * from 

SELECT t1.Tenant_id,
                t1.FirstName + ' ' + t1.LastName AS Name,
                r1.room_number,
                l1.assign_bed,
                l1.MonthlyPayment,
                l1.DepositAmount,
                l1.StartLease,
                l1.EndLease
                FROM Tenant AS t1
                LEFT JOIN Lease_tbl AS l1
                ON t1.Tenant_id = l1.Tenant_id
                left join Room as r1
                on t1.Tenant_id = r1.Room_id

Select * from lease_tbl

Select * from Tenant

				