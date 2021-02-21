USE [ReCar]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK__Brands__DAD4F3BEB065B9AB] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[BrandID] [int] NOT NULL,
	[ColorID] [int] NOT NULL,
	[ModelYear] [int] NOT NULL,
	[DailyPrice] [decimal](18, 0) NOT NULL,
	[CarName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Cars__68A0340EB4C5D45F] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorID] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK__Colors__8DA7676DE5AE84BD] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[RentDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21.02.2021 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (1, N'BMW')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (2, N'Tesla')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (3, N'Bugatti')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (4, N'Audi')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (5, N'Cadillac')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (6, N'Renault')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (7, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (8, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (9, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (10, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (11, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (12, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (13, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (14, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (15, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (16, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (17, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (18, N'Alfa Romeo')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (19, N'Alfa Romeo')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (1, 1, 1, 2020, CAST(1500 AS Decimal(18, 0)), N'BMW')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (2, 3, 3, 2018, CAST(1000 AS Decimal(18, 0)), N'Bugatti')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (3, 5, 5, 2015, CAST(500 AS Decimal(18, 0)), N'Cadillac')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (4, 6, 4, 2020, CAST(1500 AS Decimal(18, 0)), N'Renault')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (5, 2, 4, 2018, CAST(1000 AS Decimal(18, 0)), N'Tesla')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (6, 1, 1, 2020, CAST(1600 AS Decimal(18, 0)), N'BMW')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (7, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (8, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (9, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (10, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (11, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (12, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (13, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (14, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (15, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (16, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (17, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (18, 1, 1, 2015, CAST(1200 AS Decimal(18, 0)), N'Aston Martin')
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice], [CarName]) VALUES (19, 2, 1, 2020, CAST(1500 AS Decimal(18, 0)), N'BMW')
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (1, N'Beyaz')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (2, N'Siyah')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (3, N'Gri')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (4, N'Kırmızı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (5, N'Mavi')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (6, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (7, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (8, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (9, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (10, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (11, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (12, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (13, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (14, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (15, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (16, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (17, N'Sarı')
GO
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (18, N'Sarı')
GO
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (1, 2, N'ErdinçHolding')
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (2, 1, N'GEOS')
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (3, 2, N'Doğuş Holding')
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (4, 2, N'Doğuş Holding')
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (5, 2, N'Doğuş Holding')
GO
INSERT [dbo].[Customers] ([CustomerID], [UserID], [CompanyName]) VALUES (6, 2, N'Doğuş Holding')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Rentals] ON 
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (1, 1, 1, CAST(N'2021-01-12T00:00:00.000' AS DateTime), CAST(N'2021-02-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (2, 3, 2, CAST(N'2021-01-25T00:00:00.000' AS DateTime), CAST(N'2021-02-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (3, 1, 1, CAST(N'2021-02-21T12:38:44.867' AS DateTime), CAST(N'2021-02-21T12:38:44.870' AS DateTime))
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (4, 1, 1, CAST(N'2021-02-21T12:39:05.560' AS DateTime), CAST(N'2021-02-21T12:39:05.563' AS DateTime))
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (5, 1, 1, CAST(N'2021-02-21T12:39:23.077' AS DateTime), CAST(N'2021-02-21T12:39:23.080' AS DateTime))
GO
INSERT [dbo].[Rentals] ([RentalId], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (7, 1, 2, CAST(N'2021-02-21T12:39:56.163' AS DateTime), CAST(N'2021-02-21T12:39:56.163' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Rentals] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (1, N'Şeyma', N'Yıldırım', N'seyma@gmail.com', N'12345')
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (2, N'Erdem', N'Üner', N'erdem@gmail.co', N'12345')
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (3, N'Sena', N'Kahveci', N'sena@gmail.com', N'12345')
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (4, N'Sena', N'Kahveci', N'sena@gmail.com', N'12345')
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (5, N'Sena', N'Kahveci', N'sena@gmail.com', N'12345')
GO
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Email], [Password]) VALUES (6, N'Sena', N'Kahveci', N'sena@gmail.com', N'12345')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Brands] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([BrandID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Brands]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Colors] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Colors]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Users1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Users1]
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarID])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Cars]
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Customers]
GO
