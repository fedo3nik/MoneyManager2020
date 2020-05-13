use master

create database MoneyManager;
use MoneyManager

create table Users
(
	ID int primary key identity(10, 1),
	email varchar(60),
	password varchar(15)
);
alter table Users add cash money default 0;

create table Outlay_Types
(
	ID int primary key,
	descript varchar(80)
);

create table Income_Types
(
	ID int primary key,
	descript varchar(80)
);

create table Outlays
(
	ID int primary key,
	UserID int foreign key references Users(ID),
	cash money,
	outlayDate date,
	OutlayTypeID int foreign key references Outlay_Types(ID)
);
create table Incomes
(
	ID int primary key,
	UserID int foreign key references Users(ID),
	cash money,
	incomeDate date,
	IncomeTypeID int foreign key references Income_Types(ID)
);
create table OutlayPlan
(
	ID int primary key,
	UserID int foreign key references Users(ID),
	cash money,
	OutlayTypeID int foreign key references Outlay_Types(ID),
	planDate date
);

