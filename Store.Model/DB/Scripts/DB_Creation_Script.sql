CREATE DATABASE StoreDB
ON
(
	NAME = 'StoreDB',
	FILENAME = 'E:\GitHub\StoreDB\StoreDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogStoreDB',
	FILENAME = 'E:\GitHub\StoreDB\StoreDB.ldf',
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
	ProductId int not null,
	ProductCategoryId int not null,
	Name nvarchar(100) not null,
	Value nvarchar(100) not null,
	constraint FK_prodDet_ProductId_prod_Id foreign key (ProductId) references Product(Id),
	constraint FK_prodDet_ProductCategoryId_prodCat_Id foreign key (ProductCategoryId) references ProductCategory(Id)
)

create table ConcreteProduct 
(
	Id int identity primary key,
	FullName nvarchar(100) null,
	ProductId int not null,
	constraint FK_concrProd_ProductId_prod_Id foreign key (ProductId) references Product(Id)
)

create table [Order]
(
	Id int identity primary key,
	PaymentTypeId int not null,
	DiliveryTypeId int not null,
	constraint FK_ord_PayTypeId_payType_Id foreign key (PaymentTypeId) references PaymentType(Id),
	constraint FK_ord_DilTypeId_dilType_Id foreign key (DiliveryTypeId) references DiliveryType(Id)
)

create table Link_ConcreteProduct_Order
(
	Id int identity primary key,
	ProductId int not null,
	OrderId int not null,
	constraint FK_link_ProdId_concrProd_Id foreign key (ProductId) references ConcreteProduct(Id),
	constraint FK_link_OrderId_order_Id foreign key (OrderId) references [Order](Id)
)
