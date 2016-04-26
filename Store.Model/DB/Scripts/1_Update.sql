USE [E:\STUDY\KPI\STORE\STORE.MODEL\DB\STOREDB.MDF];

ALTER TABLE [Product]
ADD ProductCategoryId int foreign key references [ProductCategory](Id)

ALTER TABLE [ProductDetails] drop constraint FK__ProductDe__Produ__1920BF5C
ALTER TABLE [ProductDetails]
DROP COLUMN [ProductCategoryId]