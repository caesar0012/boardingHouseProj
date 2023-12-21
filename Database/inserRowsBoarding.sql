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

INSERT INTO Room (Room_number, Description, allowed_gender, Capacity, Price, Status, Employee_id)
VALUES 
(1011, 'Standard Single', 'Male', 5, 75.00, 'Available', 60),
(102, 'Deluxe Double', 'Female', 10, 120.00, 'Available', 63),
(103, 'Executive Suite', 'Male', 10, 200.00, 'Available', 72),
(201, 'Standard Twin', 'Female', 10, 90.00, 'Available', 61),
(202, 'Family Room', 'Male', 10, 150.00, 'Available', 61),
(203, 'Luxury Suite', 'Female', 20, 250.00, 'Available', 64),
(301, 'Honeymoon Suite', 'Male', 20, 180.00, 'Available', 65),
(302, 'Penthouse', 'Female', 10, 400.00, 'Available', 61),
(303, 'Accessible Room', 'Male', 20, 100.00, 'Available', 61),
(401, 'VIP Suite', 'Female', 15, 300.00, 'Available', 61);

Select * from Employee_acc

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

INSERT INTO lease_tbl (Tenant_id, Employee_id, room_id, assign_bed, StartLease, EndLease)
VALUES
    (21, 61, 32, 1, '2023-01-01', '2024-12-31'),
    (22, 62, 36, 2, '2023-02-01', '2024-11-30'),
    (23, 62, 37, 3, '2023-03-01', '2024-10-31'),
    (24, 62, 38, 4, '2023-04-01', '2024-09-30'),
    (25, 64, 39, 5, '2023-05-01', '2024-08-31'),
    (26, 64, 38, 6, '2023-06-01', '2024-07-31'),
    (27, 65, 38, 7, '2023-07-01', '2024-06-30'),
    (28, 60, 38, 8, '2023-08-01', '2024-05-31'),
    (29, 61, 32, 9, '2023-09-01', '2024-04-30'),
    (34, 67, 32, 10, '2023-10-01', '2024-03-31');

use BoardingHouse

Select * from lease_tbl

UPDATE lease_tbl 
SET room_id = 38
WHERE Tenant_id = 21;

Select t1.Tenant_id,
	t1.FirstName + ' ' + t1.LastName as Name,
	t1.Gender,
	l1.room_id,
	l1.assign_bed
from tenant as t1
left join lease_tbl as l1
on t1.Tenant_id = l1.Tenant_id
left join Room as r1
on l1.room_id = r1.Room_id

Select * from Employee_acc

Select * from lease_tbl
Select * from Tenant


use BoardingHouse