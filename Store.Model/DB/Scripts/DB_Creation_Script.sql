CREATE DATABASE StoreDB
ON
(
	NAME = 'StoreDB',
	FILENAME = 'E:\StoreDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogStoreDB',
	FILENAME = 'E:\StoreDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)               
COLLATE Cyrillic_General_CI_AS

use StoreDB;

create table ProductCategory
(
	Id int identity primary key,
	Name nvarchar(100) not null
)

create table DiliveryType
(
	Id int identity primary key,
	Name nvarchar(100) not null
)

create table PaymentType
(
	Id int identity primary key,
	Name nvarchar(100) not null
)

create table Product
(
	Id int identity primary key,
	Name nvarchar(100) not null,
	Price decimal not null
)

create table ProductDetails
(
	Id int identity primary key,
	ProductId int foreign key references Product(Id) not null,
	ProductCategoryId int foreign key references ProductCategory(Id) not null,
	Name nvarchar(100) not null,
	Value nvarchar(100) not null
)

create table ConcreteProduct 
(
	Id int identity primary key,
	FullName nvarchar(100) null,
	ProductId int foreign key references Product(Id) not null
)

create table [Order]
(
	Id int identity primary key,
	PaymentTypeId int foreign key references PaymentType(Id) not null,
	DiliveryTypeId int foreign key references DiliveryType(Id) not null,
)

create table Link_ConcreteProduct_Order
(
	Id int identity primary key,
	ProductId int foreign key references ConcreteProduct(Id) not null,
	OrderId int foreign key references [Order](Id) not null
)