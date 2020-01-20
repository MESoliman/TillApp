CREATE TABLE [dbo].[Orders] (
    [OrderId]   INT             IDENTITY (1, 1) NOT NULL,
    [OrderName] NVARCHAR (MAX)  NULL,
    [Amount]    DECIMAL (18, 2) NOT NULL,
    [IsPaid]    BIT             NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

