USE [OrderDb]
GO
SET IDENTITY_INSERT [dbo].[customers] ON 
GO
INSERT [dbo].[customers] ([Id], [Name]) VALUES (1, N'MIC')
GO
INSERT [dbo].[customers] ([Id], [Name]) VALUES (2, N'JOHN')
GO
INSERT [dbo].[customers] ([Id], [Name]) VALUES (3, N'LORENZO')
GO
INSERT [dbo].[customers] ([Id], [Name]) VALUES (4, N'BASSANIO')
GO
SET IDENTITY_INSERT [dbo].[customers] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (1, N'59433912-207b-40ed-82d5-85435d06e862', 1)
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (2, N'de4614c1-5870-460b-9bbe-0a82570cfe30', 2)
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (3, N'1fe38c5f-3185-407d-bc88-d790adbdb621', 3)
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (4, N'5370bcad-4846-4c4c-ac54-d34c0bb6f289', 4)
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (5, N'04876573-5e3c-4821-bfc5-fdcfdd165793', 1)
GO
INSERT [dbo].[orders] ([Id], [OrderNumber], [CustomerId]) VALUES (6, N'053c8393-a3ad-47de-8a39-51f0275d8bff', 3)
GO
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 
GO
INSERT [dbo].[products] ([Id], [name], [price]) VALUES (1, N'CORN', CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[products] ([Id], [name], [price]) VALUES (2, N'SOYA', CAST(25.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[products] ([Id], [name], [price]) VALUES (3, N'WHEAT', CAST(36.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[orderDetails] ON 
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (13, 5, 1, 3)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (14, 5, 2, 2)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (15, 4, 1, 2)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (56, 3, 3, 4)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (57, 3, 2, 2)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (80, 6, 1, 2)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (81, 6, 2, 12)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (82, 6, 3, 3)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (83, 2, 2, 4)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (84, 2, 1, 12)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (85, 2, 3, 11)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (104, 1, 2, 5)
GO
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (105, 1, 3, 12)
GO
SET IDENTITY_INSERT [dbo].[orderDetails] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230328170205_InitialMigration', N'7.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230328173046_Column_Type_Change', N'7.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230330054446_column removed', N'7.0.4')
GO
