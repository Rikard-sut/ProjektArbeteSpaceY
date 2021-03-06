USE [SpaceyDb]
GO
SET IDENTITY_INSERT [dbo].[Destinations] ON 

INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (1, N'IO', 200)
INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (2, N'The Moon', 50)
INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (3, N'Mars', 100)
INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (4, N'Pluto', 200)
INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (5, N'The Sun', 200)
INSERT [dbo].[Destinations] ([DestinationId], [Name], [ExpeditionRange]) VALUES (6, N'Asteroid BXX', 50)
SET IDENTITY_INSERT [dbo].[Destinations] OFF
SET IDENTITY_INSERT [dbo].[Rockets] ON 

INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (1, N'Falcon Heavy', 200, 200)
INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (2, N'Falcon 9', 100, 100)
INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (3, N'StarLink', 50, 200)
INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (4, N'StarLink Plus', 200, 50)
INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (5, N'MegaRocket', 200, 100)
INSERT [dbo].[Rockets] ([RocketId], [Name], [Range], [Seats]) VALUES (6, N'Falcon mini', 50, 50)
SET IDENTITY_INSERT [dbo].[Rockets] OFF
SET IDENTITY_INSERT [dbo].[Expeditions] ON 

INSERT [dbo].[Expeditions] ([ExpeditionId], [Departure], [RocketId], [DestinationId]) VALUES (1, CAST(N'2020-06-19T15:39:00.0000000' AS DateTime2), 1, 1)
INSERT [dbo].[Expeditions] ([ExpeditionId], [Departure], [RocketId], [DestinationId]) VALUES (2, CAST(N'2020-06-25T15:40:00.0000000' AS DateTime2), 4, 3)
INSERT [dbo].[Expeditions] ([ExpeditionId], [Departure], [RocketId], [DestinationId]) VALUES (3, CAST(N'2020-08-21T15:40:00.0000000' AS DateTime2), 4, 5)
INSERT [dbo].[Expeditions] ([ExpeditionId], [Departure], [RocketId], [DestinationId]) VALUES (4, CAST(N'2020-09-16T15:40:00.0000000' AS DateTime2), 5, 4)
INSERT [dbo].[Expeditions] ([ExpeditionId], [Departure], [RocketId], [DestinationId]) VALUES (5, CAST(N'2020-09-25T20:43:00.0000000' AS DateTime2), 6, 2)
SET IDENTITY_INSERT [dbo].[Expeditions] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (1, 1, 1, N'Rikard Skoglund')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (2, 1, 55, N'Carl Anders Lovesson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (3, 1, 46, N'Bengt Bengtsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (4, 1, 45, N'Linnea Karlsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (5, 1, 36, N'Bo Löf')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (6, 1, 35, N'Pia Sundhage')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (7, 1, 26, N'Evelina Björn')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (8, 1, 25, N'Eva Evelinsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (9, 1, 16, N'Karin Bengtsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (10, 1, 15, N'Niclas Timle')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (11, 1, 14, N'Jonathan Bäckhed')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (12, 1, 6, N'Claes Andersson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (13, 1, 5, N'Linus Örnborg')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (14, 1, 4, N'Carl Svahn')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (15, 1, 3, N'Sven Karlsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (16, 1, 2, N'Anders Svensson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (17, 1, 56, N'Love Pjärsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (18, 1, 66, N'Gustav Vasa')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (19, 2, 1, N'Jens Jönsson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (20, 2, 2, N'Peter Pan')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (21, 2, 3, N'Kung Bengt')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (22, 2, 4, N'Tomten Per')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (23, 4, 4, N'Jalle Jansson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (24, 4, 13, N'Jan Jallesson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (25, 4, 14, N'Lelle Persson')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (26, 4, 55, N'Gösta Lövin')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (27, 4, 87, N'Will Smith')
INSERT [dbo].[Customers] ([CustomerId], [ExpeditionId], [SeatNumber], [FullName]) VALUES (28, 4, 88, N'Per pettson')
SET IDENTITY_INSERT [dbo].[Customers] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200609121133_initial', N'3.1.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200616132727_firstRocketsDB', N'3.1.4')
