USE StoreDB

ALTER TABLE [Link_ConcreteProduct_Order] drop constraint FK__Link_Conc__Produ__2C3393D0
ALTER TABLE [Link_ConcreteProduct_Order] DROP COLUMN [ProductId]

ALTER TABLE [Link_ConcreteProduct_Order]
ADD [ProductId] INT NOT NULL FOREIGN KEY REFERENCES [Product]([id])

DROP TABLE [ConcreteProduct]