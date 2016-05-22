USE StoreDB

ALTER TABLE [Link_ConcreteProduct_Order] drop constraint FK_link_ProdId_concrProd_Id
ALTER TABLE [Link_ConcreteProduct_Order] DROP COLUMN [ProductId]

ALTER TABLE [Link_ConcreteProduct_Order]
ADD [ProductId] INT NOT NULL,
constraint FK_link_ProdId_prod_Id FOREIGN KEY (ProductId) REFERENCES [Product]([id])

DROP TABLE [ConcreteProduct]