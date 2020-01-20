CREATE TABLE [dbo].[Items] (
    [ItemId]    INT             IDENTITY (1, 1) NOT NULL,
    [OrderID]   INT             NOT NULL,
    [ProductID] INT             NOT NULL,
    [Quantity]  INT             NOT NULL,
    [Cost]      DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([ItemId] ASC),
    CONSTRAINT [FK_Items_Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Items_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Items_OrderID]
    ON [dbo].[Items]([OrderID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Items_ProductID]
    ON [dbo].[Items]([ProductID] ASC);

