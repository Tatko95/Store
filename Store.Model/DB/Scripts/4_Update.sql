USE StoreDB

ALTER TABLE [Product] ADD [Quantity] INT NOT NULL DEFAULT(0)

ALTER TABLE [Link_ConcreteProduct_Order] ADD [Quantity] INT NOT NULL DEFAULT(0)