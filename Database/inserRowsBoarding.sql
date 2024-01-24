use BoardingHouse

INSERT INTO Staff_acc 
  (FirstName, Lastname, ProfilePic, Contact, UserName, Password, ForgotQuestion, ForgotAnswer, Role)
VALUES 
  ('Daniel', 'Smith', NULL, 1234567890, 'johnSmith', 'password123', 'Birth Place', 'Los Angeles', 'Admin'),
  ('Jane', 'Doe', NULL, 9876543210, 'janedoe', 'password456', 'Favorite Hero', 'Spider-Man', 'User'),
  ('Mike', 'Smith', NULL, 5555555555, 'mikesmith', 'password789', 'Favorite Team', 'Golden State Warriors', 'User'),
  ('Alice', 'Johnson', NULL, 2222222222, 'alicejohnson', 'password012', 'Birth Place', 'New York', 'Admin'),
  ('Bob', 'Williams', NULL, 3333333333, 'bobwilliams', 'password345', 'Favorite Hero', 'Iron Man', 'User'),
  ('Charlie', 'Taylor', NULL, 4444444444, 'charlietaylor', 'password678', 'Favorite Team', 'Los Angeles Lakers', 'User'),
  ('Diana', 'Moore', NULL, 6666666666, 'dianamoore', 'password901', 'Birth Place', 'Chicago', 'Admin'),
  ('Edward', 'Garcia', NULL, 7777777777, 'edwardgarcia', 'password234', 'Favorite Hero', 'Captain America', 'Manager'),
  ('Emma', 'Wilson', NULL, 8888888888, 'emmawilson', 'password567', 'Favorite Team', 'Boston Celtics', 'Manager'),
  ('Fred', 'Lewis', NULL, 1111111111, 'fredlewis', 'password890', 'Birth Place', 'Houston', 'Admin'),
  ('Georgia', 'Clark', NULL, 2222222222, 'georgiaclark', 'password123', 'Favorite Hero', 'Thor', 'Admin'),
  ('Henry', 'Davis', NULL, 3333333333, 'henrydavis', 'password456', 'Favorite Team', 'San Francisco Giants', 'Cashier'),
  ('Isabella', 'Rodriguez', NULL, 4444444444, 'isabellarodriguez', 'password789', 'Birth Place', 'Miami', 'Admin');

INSERT INTO Room (Room_number, Description, allowed_gender, Capacity, Price, Status, Staff_id)
VALUES 
('1011', 'Standard Single', 'Male', 5, 3500.00, 'Available', 60),
('102', 'Deluxe Double', 'Female', 10, 2500.00, 'Available', 63),
('103', 'Executive Suite', 'Male', 10, 4500.00, 'Available', 72),
('201', 'Standard Twin', 'Female', 10, 1500.00, 'Available', 61),
('202', 'Family Room', 'Male', 10, 2500.00, 'Available', 61),
('203', 'Luxury Suite', 'Female', 20, 2500.00, 'Available', 64),
('301', 'Honeymoon Suite', 'Male', 20, 2500.00, 'Available', 65),
('302', 'Penthouse', 'Female', 10, 2500.00, 'Available', 61),
('303', 'Accessible Room', 'Male', 2500, 100.00, 'Available', 61),
('304', 'VIP Suite', 'Female', 15, 2500.00, 'Available', 61);

INSERT INTO bed_tbl (RoomID, BedNumber)
VALUES
    (30, 101),
    (31, 102),
    (32, 201),
    (32, 202),
    (33, 301),
    (33, 302),
    (34, 401),
    (34, 402),
    (35, 501),
    (35, 502),
    (36, 601),
    (36, 602),
    (37, 701),
    (37, 702),
    (38, 801);

INSERT INTO Tenant (FirstName, Lastname, Gender, Contact, Guardian, Emergency_Contact, Relationship, School, Address, Document_pic, archive)
VALUES
('Johny', 'Roadman', 'Male', 1234567890, 'Emergency1', 9876543210, 'Family', 'School1', 'Address1', NULL, 0),
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



INSERT INTO lease_tbl (Tenant_id, Staff_id, room_id, bed_id, StartLease, EndLease)
VALUES
    (21, 61, 30, 74, '2023-01-01', '2024-12-31'),
    (22, 62, 33, 75, '2023-02-01', '2024-11-30'),
    (23, 62, 30, 76, '2023-03-01', '2024-10-31'),
    (24, 62, 31, 77, '2023-04-01', '2024-09-30'),
    (25, 64, 33, 78, '2023-05-01', '2024-08-31'),
    (26, 64, 34, 79, '2023-06-01', '2024-07-31'),
    (27, 65, 39, 80, '2023-07-01', '2024-06-30'),
    (28, 60, 38, 81, '2023-08-01', '2024-05-31'),
    (29, 61, 34, 82, '2023-09-01', '2024-04-30'),
    (34, 67, 32, 83, '2023-10-01', '2024-03-31');



INSERT INTO TenantRequest (Staff_id, Tenant_id, Details)
VALUES (60, 21, 'Request details 1'),
       (61, 22, 'Request details 3'),
       (65, 20, 'Request details 4'),
       (62, 21, 'Request details 5'),
       (67, 24, 'Request details 6'),
       (61, 28, 'Request details 7'),
       (64, 28, 'Request details 8'),
       (67, 31, 'Request details 9'),
       (67, 31, 'Request details 10');


INSERT INTO Maintenance (Staff_id, Details)
VALUES (60, 'Maintenance details 1'),
       (65, 'Maintenance details 2'),
       (67, 'Maintenance details 3'),
       (67, 'Maintenance details 4'),
       (64, 'Maintenance details 5'),
       (63, 'Maintenance details 6'),
       (67, 'Maintenance details 7'),
       (68, 'Maintenance details 8'),
       (63, 'Maintenance details 9'),
       (64, 'Maintenance details 10');



INSERT INTO Addon (lease_id, Staff_id, AddOnAmount, AddOnDetails)
VALUES (40, 60, 50.00, 'Internet Service'),
       (40, 61, 25.00, 'Parking Space'),
       (41, 61, 100.00, 'Furnished Upgrade'),
       (43, 65, 75.00, 'Cleaning Service'),
       (44, 66, 30.00, 'Pet Fee'),
       (44, 65, 40.00, 'Gym Access'),
       (45, 68, 20.00, 'Storage Unit'),
       (46, 69, 55.00, 'Utilities Package'),
       (47, 70, 15.00, 'Key Replacement'),
       (48, 60, 90.00, 'Security Deposit');

--views
/*

create view receiptView as 
Select 
	p1.Payment_id,
	p1.Staff_id,
	p1.PaymentDate as DateTime,
	t1.FirstName + ' ' + t1.LastName as Tenant,
	l1.lease_id,
	p1.Amount_paid
from Payment as p1
left join lease_tbl as l1
on l1.lease_id = p1.Lease_id
left join Tenant as t1
on t1.Tenant_id = l1.Tenant_id 
where p1.archive = 0

*/
