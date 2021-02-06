USE [ReCar]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 6.02.2021 20:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 6.02.2021 20:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[BrandID] [int] NULL,
	[ColorID] [int] NULL,
	[ModelYear] [nvarchar](25) NULL,
	[DailyPrice] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 6.02.2021 20:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorID] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
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
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (1, 1, 1, N'2020', CAST(1500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (2, 3, 3, N'2018', CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (3, 5, 5, N'2015', CAST(500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (4, 6, 4, N'2020', CAST(1500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (5, 2, 4, N'2018', CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cars] ([CarID], [BrandID], [ColorID], [ModelYear], [DailyPrice]) VALUES (6, 1, 1, N'2020', CAST(1600 AS Decimal(18, 0)))
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
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([BrandID])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
GO
