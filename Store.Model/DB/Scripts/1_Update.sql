USE StoreDB

ALTER TABLE [Product]
ADD ProductCategoryId int,
constraint FK_prod_ProdCatId_prodCat_Id foreign key (ProductCategoryId) references [ProductCategory](Id)

ALTER TABLE [ProductDetails] drop constraint FK_prodDet_ProductCategoryId_prodCat_Id
ALTER TABLE [ProductDetails]
DROP COLUMN [ProductCategoryId]