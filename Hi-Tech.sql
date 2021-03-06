USE [master]
GO
/****** Object:  Database [HitechDB]    Script Date: 12/7/2019 4:53:01 PM ******/
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
EXEC sys.sp_db_vardecimal_storage_format N'HitechDB', N'ON'
GO
ALTER DATABASE [HitechDB] SET QUERY_STORE = OFF
GO
USE [HitechDB]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Authors]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Books]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Categories]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Customers]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[OrderLine]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[Publishers]    Script Date: 12/7/2019 4:53:01 PM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 12/7/2019 4:53:01 PM ******/
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
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [PublisherID], [CategoryId]) VALUES (123456789, N'I dont give a f**k            ', 55, 1990, 2, NULL, NULL)
INSERT [dbo].[Customers] ([Name], [CustomerId], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Street]) VALUES (N'Nitin               ', 1010, N'Ernakulam           ', N'h3h2p4              ', N'111-111-1111        ', N'1234                ', 2345, N'saint               ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1111, N'Nitin                         ', N'Joy                           ', N'Programmer                    ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (2222, N'Roneet                        ', N'Kumar                         ', N'Programmer                    ')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (3333, N'Roneet                        ', N'Kumar                         ', N'Programmer                    ')
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (1111, N'1234      ', 1)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (2222, N'1234      ', 2)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (3333, N'1234      ', 3)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (4444, N'1234      ', 4)
INSERT [dbo].[Login] ([UserId], [Password], [LoginId]) VALUES (5555, N'1234      ', 5)
INSERT [dbo].[Orders] ([OrderID], [PlacedDate], [ArrivingDate], [CustomerId], [EmployeeId]) VALUES (1, CAST(N'2011-11-11' AS Date), CAST(N'2011-11-11' AS Date), 1010, 2222)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (1111, N'Henry                         ', N'Brown                         ', N'MIS Manager                   ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2222, N'Thomas                        ', N'Moore                         ', N'Sales Manager                 ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (3333, N'Peter                         ', N'Wang                          ', N'Inventory Controller          ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (4444, N'Mary                          ', N'Brown                         ', N'Order Clerk                   ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (5555, N'Jennifer                      ', N'Bouchard                      ', N'Order Clerk                   ')
ALTER TABLE [dbo].[AuthorBooks]  WITH NOCHECK ADD  CONSTRAINT [FK_AuthorBooks_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[AuthorBooks] CHECK CONSTRAINT [FK_AuthorBooks_Authors]
GO
ALTER TABLE [dbo].[AuthorBooks]  WITH NOCHECK ADD  CONSTRAINT [FK_AuthorBooks_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[AuthorBooks] CHECK CONSTRAINT [FK_AuthorBooks_Books]
GO
ALTER TABLE [dbo].[Books]  WITH NOCHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH NOCHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Categories]  WITH NOCHECK ADD  CONSTRAINT [FK_Categories_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories]
GO
ALTER TABLE [dbo].[Login]  WITH NOCHECK ADD  CONSTRAINT [FK_Login_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_User]
GO
ALTER TABLE [dbo].[OrderLine]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderLine_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Books]
GO
ALTER TABLE [dbo].[OrderLine]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderLine_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH NOCHECK ADD  CONSTRAINT [FK_Orders_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employee]
GO
ALTER TABLE [dbo].[Orders]  WITH NOCHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH NOCHECK ADD  CONSTRAINT [FK_Orders_Orders1] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders1]
GO
ALTER TABLE [dbo].[Orders]  WITH NOCHECK ADD  CONSTRAINT [FK_Orders_Orders2] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders2]
GO
ALTER TABLE [dbo].[Publishers]  WITH NOCHECK ADD  CONSTRAINT [FK_Publishers_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Publishers] CHECK CONSTRAINT [FK_Publishers_Books]
GO
USE [master]
GO
ALTER DATABASE [HitechDB] SET  READ_WRITE 
GO
