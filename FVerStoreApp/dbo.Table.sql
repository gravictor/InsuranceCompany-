﻿CREATE TABLE [dbo].[AspNetOrders]
(
	[Id] NVARCHAR(80) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(20) NOT NULL,
	[Email] NVARCHAR(30) NOT NULL,
	[Year] INT NOT NULL,
	[Insurancess] NVARCHAR(40) NOT NULL,
	[Price] INT NOT NULL,
	[MonthCount] INT NOT NULL

)
