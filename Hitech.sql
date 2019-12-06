USE [master]
GO
/****** Object:  Database [HitechDB]    Script Date: 2019-12-06 2:37:01 PM ******/
CREATE DATABASE [HitechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HitechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HitechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HitechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HitechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HitechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HitechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HitechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HitechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HitechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HitechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HitechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HitechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HitechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HitechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HitechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HitechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HitechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HitechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HitechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HitechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HitechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HitechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HitechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HitechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HitechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HitechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HitechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HitechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HitechDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HitechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HitechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HitechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HitechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HitechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HitechDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HitechDB] SET QUERY_STORE = OFF
GO
USE [HitechDB]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 2019-12-06 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBooks](
	[AuthorID] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
 CONSTRAINT [PK_AuthorBooks] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] NOT NULL,
	[FirstName] [nchar](30) NULL,
	[LastName] [nchar](30) NULL,
	[Email] [nchar](20) NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [int] NOT NULL,
	[Title] [nchar](30) NULL,
	[UnitPrice] [int] NULL,
	[YearPublished] [int] NULL,
	[QOH] [int] NULL,
	[PublisherID] [int] NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] NOT NULL,
	[CategoryType] [varchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Name] [nchar](20) NULL,
	[CustomerId] [int] NOT NULL,
	[City] [nchar](20) NULL,
	[PostalCode] [nchar](20) NULL,
	[PhoneNumber] [nchar](20) NULL,
	[FaxNumber] [nchar](20) NULL,
	[CreditLimit] [int] NULL,
	[Street] [nchar](20) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nchar](30) NULL,
	[LastName] [nchar](30) NULL,
	[JobTitle] [nchar](30) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserId] [int] NOT NULL,
	[Password] [nchar](10) NULL,
	[LoginId] [int] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLine]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLine](
	[OrderID] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
 CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[PlacedDate] [date] NULL,
	[ArrivingDate] [date] NULL,
	[CustomerId] [int] NULL,
	[EmployeeId] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] NOT NULL,
	[ISBN] [int] NULL,
	[Name] [nchar](30) NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2019-12-06 2:37:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] NOT NULL,
	[FirstName] [nchar](30) NULL,
	[LastName] [nchar](30) NULL,
	[JobTitle] [nchar](30) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [PublisherID], [CategoryId]) VALUES (1, N'harry                         ', 123, 221, 121, NULL, NULL)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [PublisherID], [CategoryId]) VALUES (100, N'harry                         ', 12, 7, 212, NULL, NULL)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [PublisherID], [CategoryId]) VALUES (200, N'The Wreck of titan            ', 26, 1957, 24, NULL, NULL)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [PublisherID], [CategoryId]) VALUES (1041, N'harry                         ', 12, 7, 212, NULL, NULL)
INSERT [dbo].[Customers] ([Name], [CustomerId], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Street]) VALUES (N'gavan               ', 1000, N'DSJFHDS             ', N'E2W3W3              ', N'222-222-2222        ', N'1212                ', 1000, N'GDSDSF              ')
INSERT [dbo].[Customers] ([Name], [CustomerId], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Street]) VALUES (N'kp                  ', 3002, N'kjsdhfd             ', N'H2H3J3              ', N'111-111-1111        ', N'9876                ', 1000, N'DORLET              ')
INSERT [dbo].[Customers] ([Name], [CustomerId], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Street]) VALUES (N'william             ', 3003, N'New York            ', N'H6H2B6              ', N'123-221-2222        ', N'2346                ', 2000, N'Dorlet              ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1000, N'Henri                         ', N'Brown                         ', N'MIS Manager                   ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1001, N'Thomas                        ', N'Moore                         ', N'Sales Manager                 ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1002, N'David                         ', N'Gray                          ', N'Vehla                         ')
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2000, N'admin     ', 1)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2001, N'sales     ', 2)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2003, N'peter     ', 3)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2004, N'mary      ', 4)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2005, N'jenni     ', 5)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (0, CAST(N'2018-03-12' AS Date), CAST(N'2018-04-12' AS Date), 3003, NULL)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (3000, CAST(N'2012-04-12' AS Date), CAST(N'2013-05-11' AS Date), 3003, NULL)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (3001, CAST(N'2019-11-03' AS Date), CAST(N'2013-11-23' AS Date), 3003, 1000)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (3002, CAST(N'2013-03-31' AS Date), CAST(N'2014-04-12' AS Date), 3002, NULL)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (3232, CAST(N'2222-12-22' AS Date), NULL, 3002, 1002)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (4000, CAST(N'2033-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Publishers] ([PublisherID], [ISBN], [Name]) VALUES (1000, 100, N'Premier Press                 ')
INSERT [dbo].[Publishers] ([PublisherID], [ISBN], [Name]) VALUES (2000, 200, N'Wrox                          ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2000, N'Henri                         ', N'Brown                         ', N'MIS Manager                   ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2001, N'Thomas                        ', N'Moore                         ', N'Sales Manager                 ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2003, N'Peter                         ', N'Wang                          ', N'Inventory Controller          ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2004, N'Mary                          ', N'Brown                         ', N'Order Clerks                  ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2005, N'Jennifer                      ', N'Bouchard                      ', N'Order Clerks                  ')
ALTER TABLE [dbo].[AuthorBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBooks_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[AuthorBooks] CHECK CONSTRAINT [FK_AuthorBooks_Authors]
GO
ALTER TABLE [dbo].[AuthorBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBooks_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[AuthorBooks] CHECK CONSTRAINT [FK_AuthorBooks_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_User]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Books]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employee]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders1] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders2] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders2]
GO
ALTER TABLE [dbo].[Publishers]  WITH CHECK ADD  CONSTRAINT [FK_Publishers_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Publishers] CHECK CONSTRAINT [FK_Publishers_Books]
GO
USE [master]
GO
ALTER DATABASE [HitechDB] SET  READ_WRITE 
GO
