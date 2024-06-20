use [291_FinalProject];

drop table Customer;
drop table Employee;
drop table Branch;
drop table RentalTransaction;
drop table Car;
drop table CarType;

CREATE TABLE Customer(
CustomerID nchar(10) primary key,
[FirstName] nchar(20) NULL,
[LastName] nchar(20) NULL,
[Age] int NULL,
[Street] nchar(50) NULL,
[City] nchar(20) NULL,
[Province] nchar(20) NULL,
[PostalCode] nchar(10) NULL,
[EmailAddress] nchar(30) NULL,
[PhoneNumber] nchar(15) NULL);

CREATE TABLE Employee(
EmployeeID nchar(10) primary key,
[FirstName] nchar(20) NULL,
[LastName] nchar(20) NULL,
[Street] nchar(50) NULL,
[City] nchar(20) NULL,
[Province] nchar(20) NULL,
[PostalCode] nchar(10) NULL,
[EmailAddress] nchar(30) NULL,
[PhoneNumber] nchar(15) NULL);

CREATE TABLE CarType(
ModelID nchar(10) primary key,
[ModelDesc] nchar(20) NULL,
[Capacity] int NULL,
[DailyRate] float NULL,
[WeeklyRate] float NULL,
[MonthlyRate] float NULL);

CREATE TABLE Branch(
BranchID nchar(10) primary key,
[BranchName] nchar(20) NULL,
[Street] nchar(50) NULL,
[City] nchar(20) NULL,
[Province] nchar(20) NULL,
[PostalCode] nchar(10) NULL);

CREATE TABLE Car(
CarID nchar(10) primary key,
[Colour] nchar(20) NULL,
[Manufacturer] nchar(20) NULL,
ModelID nchar(10) FOREIGN KEY REFERENCES CarType(ModelID) NULL,
BranchID nchar(10) FOREIGN KEY REFERENCES Branch(BranchID) NULL);


CREATE TABLE RentalTransaction(
RegistrationID nchar(10) primary key,
[DateFrom] datetime,
[DateTo] datetime,
[Fees] float,
[TotalCost] float,
[FromBranchID] nchar(10) FOREIGN KEY REFERENCES Branch(BranchID),
[ToBranchID] nchar(10) FOREIGN KEY REFERENCES Branch(BranchID),
[EmployeeID] nchar(10) FOREIGN KEY REFERENCES Employee(EmployeeID),
[CustomerID] nchar(10) FOREIGN KEY REFERENCES Customer(CustomerID),
CarID nchar(10) FOREIGN KEY REFERENCES Car(CarID));


