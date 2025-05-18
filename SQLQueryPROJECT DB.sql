-- Create and use the OnlinePharmacy database
CREATE DATABASE OnlinePharmacy;
USE OnlinePharmacy;

-- Create Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    FullName VARCHAR(100),
    Email VARCHAR(100),
    Password VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(150)
);

-- Insert data into Users table
INSERT INTO Users VALUES
(1, 'Ahmed Ali', 'ahmed@gmail.com', 'pass123', '0100000001', 'Cairo'),
(2, 'Sara Mostafa', 'sara@yahoo.com', 'sara456', '0100000002', 'Giza'),
(3, 'Mohamed Tarek', 'mtarek@gmail.com', 'mt@pass', '0100000003', 'Alexandria'),
(4, 'Nour Hossam', 'nour@mail.com', 'nour@2024', '0100000004', 'Asyut'),
(5, 'Ali Fathy', 'ali_f@hotmail.com', 'ali_321', '0100000005', 'Zagazig'),
(6, 'Mona Adel', 'mona@gmail.com', 'mona_777', '0100000006', 'Tanta'),
(7, 'Tarek Samir', 'tsamir@yahoo.com', 'tareks', '0100000007', 'Luxor'),
(8, 'Rana Amr', 'rana@mail.com', 'rana123', '0100000008', 'Minya'),
(9, 'Khaled Nabil', 'khaled@gmail.com', 'khaledx', '0100000009', 'Mansoura'),
(10, 'Laila Yasser', 'laila@gmail.com', 'laila22', '0100000010', 'Ismailia'),
(11, 'Youssef Salah', 'ysalah@yahoo.com', 'ys999', '0100000011', 'Suez'),
(12, 'Huda Magdy', 'huda@mail.com', 'huda@med', '0100000012', 'Fayoum'),
(13, 'Mahmoud Khaled', 'mahmoud@gmail.com', 'mk@pass', '0100000013', 'Sohag'),
(14, 'Salma Rami', 'salma@mail.com', 'salmaok', '0100000014', 'Banha'),
(15, 'Walid Hany', 'walid@outlook.com', 'passwalid', '0100000015', 'Beni Suef');

-- Create Categories table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100),
    Description VARCHAR(200),
    AgeRestriction INT,
    Status VARCHAR(20)
);

-- Insert data into Categories table
INSERT INTO Categories VALUES
(1, 'Painkillers', 'Medicines to reduce pain', 12, 'Active'),
(2, 'Antibiotics', 'Used to treat bacterial infections', 0, 'Active'),
(3, 'Allergy', 'Antihistamines and related meds', 6, 'Active'),
(4, 'Vitamins', 'Supplements for health', 0, 'Active'),
(5, 'Diabetes', 'Insulin and oral hypoglycemics', 18, 'Active'),
(6, 'Blood Pressure', 'Hypertension medications', 18, 'Active'),
(7, 'Cold & Flu', 'Relief for cold symptoms', 0, 'Active'),
(8, 'Digestive Health', 'For stomach and digestion', 0, 'Active'),
(9, 'Skin Care', 'Topical treatments and creams', 0, 'Active'),
(10, 'Baby Care', 'Meds and care for infants', 0, 'Active'),
(11, 'Heart Health', 'Cardiac-related medicines', 18, 'Active'),
(12, 'Eye Drops', 'Ophthalmic treatments', 0, 'Active'),
(13, 'Muscle Relaxants', 'For muscle pain/spasm', 12, 'Active'),
(14, 'Mental Health', 'Antidepressants, etc.', 18, 'Restricted'),
(15, 'First Aid', 'Creams, antiseptics', 0, 'Active');

-- Create Medicines table
CREATE TABLE Medicines (
    MedicineID INT PRIMARY KEY,
    MedicineName VARCHAR(100),
    Price DECIMAL(8,2),
    Stock INT,
    CategoryID INT,
    Manufacturer VARCHAR(100),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Insert data into Medicines table
INSERT INTO Medicines VALUES
(1, 'Panadol Extra', 25.50, 200, 1, 'GSK'),
(2, 'Augmentin 1g', 95.00, 150, 2, 'GSK'),
(3, 'Zyrtec', 30.00, 100, 3, 'UCB'),
(4, 'Vitamin C 1000mg', 18.00, 300, 4, 'NOW'),
(5, 'Insulatard', 80.00, 80, 5, 'Novo Nordisk'),
(6, 'Concor 5mg', 65.00, 90, 6, 'Merck'),
(7, 'Flustat', 16.50, 200, 7, 'Eva Pharma'),
(8, 'Buscopan', 22.00, 120, 8, 'Boehringer'),
(9, 'Fucidin Cream', 40.00, 50, 9, 'Leo Pharma'),
(10, 'Sudocrem', 35.00, 70, 10, 'Teva'),
(11, 'Aspirin Protect', 33.00, 110, 11, 'Bayer'),
(12, 'Tears Naturale', 27.00, 100, 12, 'Alcon'),
(13, 'Myolgin', 18.50, 90, 13, 'Amoun'),
(14, 'Cipralex 10mg', 95.00, 40, 14, 'Lundbeck'),
(15, 'Betadine', 25.00, 130, 15, 'Mundipharma');

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    UserID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10,2),
    Status VARCHAR(20),
    PaymentMethod VARCHAR(20),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Insert data into Orders table
INSERT INTO Orders VALUES
(1, 1, '2024-04-01', 120.50, 'Delivered', 'Credit Card'),
(2, 2, '2024-04-02', 95.00, 'Pending', 'Cash'),
(3, 3, '2024-04-03', 180.00, 'Shipped', 'Credit Card'),
(4, 4, '2024-04-04', 55.50, 'Delivered', 'Cash'),
(5, 5, '2024-04-05', 65.00, 'Cancelled', 'Wallet'),
(6, 6, '2024-04-06', 90.00, 'Delivered', 'Credit Card'),
(7, 7, '2024-04-07', 45.00, 'Shipped', 'Cash'),
(8, 8, '2024-04-08', 125.00, 'Delivered', 'Wallet'),
(9, 9, '2024-04-09', 70.00, 'Pending', 'Credit Card'),
(10, 10, '2024-04-10', 110.00, 'Delivered', 'Cash'),
(11, 11, '2024-04-11', 85.00, 'Delivered', 'Wallet'),
(12, 12, '2024-04-12', 140.00, 'Shipped', 'Credit Card'),
(13, 13, '2024-04-13', 99.00, 'Pending', 'Cash'),
(14, 14, '2024-04-14', 60.00, 'Cancelled', 'Wallet'),
(15, 15, '2024-04-15', 75.00, 'Delivered', 'Credit Card');

-- Create OrderDetails table
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    MedicineID INT,
    Quantity INT,
    Subtotal DECIMAL(8,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (MedicineID) REFERENCES Medicines(MedicineID)
);

-- Insert data into OrderDetails table
INSERT INTO OrderDetails VALUES
(1, 1, 1, 2, 51.00),
(2, 1, 4, 1, 18.00),
(3, 2judd, 2, 1, 95.00),
(4, 3, 5, 2, 160.00),
(5, 3, 4, 1, 18.00),
(6, 4, 7, 3, 49.50),
(7, 5, 6, 1, 65.00),
(8, 6, 3, 3, 90.00),
(9, 7, 8, 2, 44.00),
(10, 8, 9, 2, 80.00),
(11, 9, 10, 2, 70.00),
(12, 10, 11, 2, 66.00),
(13, 11, 12, 1, 27.00),
(14, 12, 13, 2, 37.00),
(15, 13, 14, 1, 95.00);

-- Create Reviews table
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY,
    UserID INT,
    MedicineID INT,
    Rating INT,
    Comment VARCHAR(200),
    ReviewDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (MedicineID) REFERENCES Medicines(MedicineID)
);

-- Insert data into Reviews table
INSERT INTO Reviews VALUES
(1, 1, 1, 5, 'Very effective for headache', '2024-04-01'),
(2, 2, 2, 4, 'Works well, a bit expensive', '2024-04-02'),
(3, 3, 4, 5, 'Good immune booster', '2024-04-03'),
(4, 4, 7, 3, 'Mild relief', '2024-04-04'),
(5, 5, 6, 4, 'Helpful in lowering BP', '2024-04-05'),
(6, 6, 3, 5, 'Perfect for allergy', '2024-04-06'),
(7, 7, 5, 5, 'Essential for my diabetes', '2024-04-07'),
(8, 8, 9, 4, 'Clears skin well', '2024-04-08'),
(9, 9, 10, 5, 'Best cream for baby', '2024-04-09'),
(10, 10, 11, 3, 'Standard aspirin', '2024-04-10'),
(11, 11, 12, 4, 'Good eye relief', '2024-04-11'),
(12, 12, 13, 5, 'Very relaxing', '2024-04-12'),
(13, 13, 14, 3, 'Need prescription', '2024-04-13'),
(14, 14, 15, 4, 'Useful for wounds', '2024-04-14'),
(15, 15, 1, 5, 'Quick pain relief', '2024-04-15');

-- Select all medicines
SELECT * FROM Medicines;

ALTER TABLE Medicines
ADD MedicineID INT IDENTITY(1,1);

-- Select medicine name and price
SELECT MedicineName, Price FROM Medicines;

-- Select medicines with price greater than 50
SELECT MedicineName, Price
FROM Medicines
WHERE Price > 50;

-- Select distinct user addresses
SELECT DISTINCT Address FROM Users;

-- Select medicines ordered by price ascending
SELECT MedicineName, Price
FROM Medicines
ORDER BY Price ASC;

-- Select users ordered by full name descending
SELECT FullName, Email
FROM Users
ORDER BY FullName DESC;

-- Select medicines with 'in' in their name
SELECT MedicineName
FROM Medicines
WHERE MedicineName LIKE '%in%';

-- Select medicines with price between 30 and 70
SELECT MedicineName, Price
FROM Medicines
WHERE Price BETWEEN 30 AND 70;

-- Select minimum and maximum medicine prices
SELECT MIN(Price) AS MinPrice, MAX(Price) AS MaxPrice
FROM Medicines;

-- Select orders with specific payment methods
SELECT * FROM Orders
WHERE PaymentMethod IN ('Wallet', 'Cash');

-- Add Gender column to Users table
ALTER TABLE Users
ADD Gender VARCHAR(10);

-- Select all users after adding Gender column
SELECT * FROM Users;

-- Join users, orders, order details, and medicines
SELECT U.FullName, M.MedicineName
FROM Users U
JOIN Orders O ON U.UserID = O.UserID
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
JOIN Medicines M ON OD.MedicineID = M.MedicineID;

-- Count orders per user
SELECT U.FullName, COUNT(O.OrderID) AS NumberOfOrders
FROM Users U
JOIN Orders O ON U.UserID = O.UserID
GROUP BY U.FullName;

-- Sum total spent per user
SELECT U.FullName, SUM(O.TotalAmount) AS TotalSpent
FROM Users U
JOIN Orders O ON U.UserID = O.UserID
GROUP BY U.FullName;

-- Calculate average rating per medicine
SELECT M.MedicineName, AVG(R.Rating) AS AverageRating
FROM Reviews R
JOIN Medicines M ON R.MedicineID = M.MedicineID
GROUP BY M.MedicineName;

-- Left join orders with order details
SELECT Orders.OrderID, OrderDetails.MedicineID, OrderDetails.Quantity
FROM Orders
LEFT JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID;

-- Right join orders with order details
SELECT Orders.OrderID, OrderDetails.MedicineID, OrderDetails.Quantity
FROM Orders
RIGHT JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID;

-- Select users who ordered Zyrtec
SELECT U.FullName
FROM Users U
JOIN Orders O ON U.UserID = O.UserID
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
JOIN Medicines M ON OD.MedicineID = M.MedicineID
WHERE M.MedicineName = 'Zyrtec'
GROUP BY U.FullName
HAVING COUNT(DISTINCT O.OrderID) > 0;

-- Update prices for specific medicines
UPDATE Medicines
SET Price =
    CASE
        WHEN MedicineName = 'Panadol Extra' THEN 28.00
        WHEN MedicineName = 'Augmentin 1g' THEN 100.00
        ELSE Price
    END
WHERE MedicineName IN ('Panadol Extra', 'Augmentin 1g');

-- Update order status to Delivered
UPDATE Orders
SET Status = 'Delivered'
WHERE OrderID = 2;

-- Delete specific review
DELETE FROM Reviews
WHERE ReviewID = 15;

-- Delete medicines with zero stock
DELETE FROM Medicines
WHERE Stock = 0;

-- Drop Reviews table
DROP TABLE Reviews;

-- Delete all data from OrderDetails
DELETE FROM OrderDetails;

-- Categorize reviews based on rating
SELECT
    MedicineID,
    Rating,
    CASE
        WHEN Rating = 5 THEN 'Excellent'
        WHEN Rating = 4 THEN 'Good'
        WHEN Rating = 3 THEN 'Average'
        ELSE 'Low'
    END AS ReviewLevel
FROM Reviews;

-- Select users ordered by full name ascending
SELECT * FROM Users
ORDER BY FullName ASC;

-- Select users with multiple orders
SELECT U.UserID, U.FullName, COUNT(O.OrderID) AS TotalOrders
FROM Users U
JOIN Orders O ON U.UserID = O.UserID
GROUP BY U.UserID, U.FullName
HAVING COUNT(O.OrderID) > 1;