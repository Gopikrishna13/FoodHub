-- FoodHub Database Creation Script for SQL Server LocalDB
-- Database: (localdb)\MSSQLLocalDB

USE master;
GO

-- Create the FoodHub database if it doesn't exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FoodHub')
BEGIN
    CREATE DATABASE FoodHub;
END
GO

USE FoodHub;
GO

-- Drop tables if they exist (in reverse order of dependencies)
IF OBJECT_ID('dbo.Delivery', 'U') IS NOT NULL DROP TABLE dbo.Delivery;
IF OBJECT_ID('dbo.BikeAssignment', 'U') IS NOT NULL DROP TABLE dbo.BikeAssignment;
IF OBJECT_ID('dbo.BikeColor', 'U') IS NOT NULL DROP TABLE dbo.BikeColor;
IF OBJECT_ID('dbo.MotorBike', 'U') IS NOT NULL DROP TABLE dbo.MotorBike;
IF OBJECT_ID('dbo.Dependent', 'U') IS NOT NULL DROP TABLE dbo.Dependent;
IF OBJECT_ID('dbo.Rider', 'U') IS NOT NULL DROP TABLE dbo.Rider;
IF OBJECT_ID('dbo.FoodItemIngredient', 'U') IS NOT NULL DROP TABLE dbo.FoodItemIngredient;
IF OBJECT_ID('dbo.Ingredient', 'U') IS NOT NULL DROP TABLE dbo.Ingredient;
IF OBJECT_ID('dbo.OrderItem', 'U') IS NOT NULL DROP TABLE dbo.OrderItem;
IF OBJECT_ID('dbo.FoodItem', 'U') IS NOT NULL DROP TABLE dbo.FoodItem;
IF OBJECT_ID('dbo.[Order]', 'U') IS NOT NULL DROP TABLE dbo.[Order];
IF OBJECT_ID('dbo.Customer', 'U') IS NOT NULL DROP TABLE dbo.Customer;
GO

-- 1. Customer Table
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    NIC NVARCHAR(12) NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL,
    ContactNumber NVARCHAR(15) NOT NULL,
    AddressLineNo NVARCHAR(10) NOT NULL,
    Lane NVARCHAR(100) NOT NULL,
    Street NVARCHAR(100) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Username NVARCHAR(100) NOT NULL
);
GO

-- 2. Order Table (Order is a reserved keyword, so we use brackets)
CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
    OrderTime TIME NOT NULL,
    OrderStatus NVARCHAR(50) NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    OrderAmount DECIMAL(18,2) NOT NULL,
    DispatchedTime DATETIME NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
GO

-- 3. FoodItem Table
CREATE TABLE FoodItem (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);
GO

-- 4. OrderItem Table (Junction table for Orders and Food Items)
CREATE TABLE OrderItem (
    OrderID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT NOT NULL,
    PRIMARY KEY (OrderID, ItemID),
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (ItemID) REFERENCES FoodItem(ItemID)
);
GO

-- 5. Ingredient Table
CREATE TABLE Ingredient (
    IngredientID INT IDENTITY(1,1) PRIMARY KEY,
    IngredientName NVARCHAR(100) NOT NULL
);
GO

-- 6. FoodItemIngredient Table (Junction table for FoodItem and Ingredient)
CREATE TABLE FoodItemIngredient (
    ItemID INT NOT NULL,
    IngredientID INT NOT NULL,
    PRIMARY KEY (ItemID, IngredientID),
    FOREIGN KEY (ItemID) REFERENCES FoodItem(ItemID),
    FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
);
GO

-- 7. Rider Table
CREATE TABLE Rider (
    RiderID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NOT NULL,
    NIC NVARCHAR(12) NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL,
    ContactNumber NVARCHAR(15) NOT NULL,
    LicenseNumber NVARCHAR(20) NOT NULL UNIQUE,
    Address NVARCHAR(255) NOT NULL,
    Age INT NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    UserName NVARCHAR(255)NOT NULL
);
GO

-- 8. Dependent Table
CREATE TABLE Dependent (
    DependentID INT IDENTITY(1,1) PRIMARY KEY,
    RiderID INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    Relationship NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    FOREIGN KEY (RiderID) REFERENCES Rider(RiderID)
);
GO

-- 9. MotorBike Table
CREATE TABLE MotorBike (
    BikeRegNo NVARCHAR(20) PRIMARY KEY,
    Brand NVARCHAR(50) NOT NULL,
    Model NVARCHAR(50) NOT NULL,
    EngineNumber NVARCHAR(50) NOT NULL UNIQUE,
    RegisteredDate DATE NOT NULL
);
GO

-- 10. BikeColor Table (since each bike can have multiple colors)
CREATE TABLE BikeColor (
    BikeRegNo NVARCHAR(20) NOT NULL,
    Color NVARCHAR(30) NOT NULL,
    PRIMARY KEY (BikeRegNo, Color),
    FOREIGN KEY (BikeRegNo) REFERENCES MotorBike(BikeRegNo)
);
GO

-- 11. BikeAssignment Table (records which bike a rider used)
CREATE TABLE BikeAssignment (
    AssignmentID INT IDENTITY(1,1) PRIMARY KEY,
    RiderID INT NOT NULL,
    BikeRegNo NVARCHAR(20) NOT NULL,
    AssignmentDate DATE NOT NULL,
    StartMeterReading INT NOT NULL,
    EndMeterReading INT NULL,
    FOREIGN KEY (RiderID) REFERENCES Rider(RiderID),
    FOREIGN KEY (BikeRegNo) REFERENCES MotorBike(BikeRegNo)
);
GO

-- 12. Delivery Table (to track which rider delivered which order)
CREATE TABLE Delivery (
    DeliveryID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    RiderID INT NOT NULL,
    BikeRegNo NVARCHAR(20) NULL, 
    DeliveryDateTime DATETIME NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (RiderID) REFERENCES Rider(RiderID),
    FOREIGN KEY (BikeRegNo) REFERENCES MotorBike(BikeRegNo)
);
GO

PRINT 'FoodHub database and tables created successfully!';
GO


