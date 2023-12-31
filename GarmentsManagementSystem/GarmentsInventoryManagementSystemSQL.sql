USE [master]
GO
/****** Object:  Database [GarmentsManagementSystem]    Script Date: 8/17/2023 4:39:34 PM ******/
CREATE DATABASE [GarmentsManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GarmentsManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GarmentsManagementSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GarmentsManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GarmentsManagementSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GarmentsManagementSystem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GarmentsManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GarmentsManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GarmentsManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GarmentsManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GarmentsManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GarmentsManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GarmentsManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [GarmentsManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GarmentsManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GarmentsManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GarmentsManagementSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GarmentsManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GarmentsManagementSystem]
GO
/****** Object:  Table [dbo].[Admin_info]    Script Date: 8/17/2023 4:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin_info](
	[A_Id] [varchar](15) NOT NULL,
	[A_Name] [varchar](30) NOT NULL,
	[A_Gender] [varchar](10) NOT NULL,
	[A_Address] [varchar](50) NOT NULL,
	[A_Role] [varchar](15) NOT NULL,
	[A_Joining_Date] [date] NOT NULL,
	[A_Salary] [float] NOT NULL,
	[A_Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ManagerInfo] PRIMARY KEY CLUSTERED 
(
	[A_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinishedProductInfo]    Script Date: 8/17/2023 4:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FinishedProductInfo](
	[FinishedProductId] [varchar](15) NOT NULL,
	[FinishedCatagory] [varchar](20) NULL,
	[FinishedProductName] [varchar](30) NULL,
	[FinishedQuantity] [int] NULL,
	[FinishedCost] [float] NULL,
	[FinishDate] [date] NULL,
 CONSTRAINT [PK_FinishedProductInfo] PRIMARY KEY CLUSTERED 
(
	[FinishedProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manager_info]    Script Date: 8/17/2023 4:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manager_info](
	[M_id] [varchar](15) NOT NULL,
	[M_Name] [nvarchar](30) NOT NULL,
	[M_Gender] [varchar](10) NOT NULL,
	[M_Address] [varchar](50) NOT NULL,
	[M_Role] [varchar](15) NOT NULL,
	[M_Joining_Date] [date] NOT NULL,
	[M_Salary] [float] NOT NULL,
	[M_Password] [varchar](50) NOT NULL,
	[A_Id] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Manager_info] PRIMARY KEY CLUSTERED 
(
	[M_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RawMeterialInfo]    Script Date: 8/17/2023 4:39:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RawMeterialInfo](
	[RawId] [varchar](15) NOT NULL,
	[RawCategory] [varchar](30) NOT NULL,
	[RawProductName] [varchar](30) NOT NULL,
	[RawQuantity] [int] NOT NULL,
	[RawCost] [float] NOT NULL,
	[RawDate] [date] NOT NULL,
 CONSTRAINT [PK_RawMeterialInfo] PRIMARY KEY CLUSTERED 
(
	[RawId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Admin_info] ([A_Id], [A_Name], [A_Gender], [A_Address], [A_Role], [A_Joining_Date], [A_Salary], [A_Password]) VALUES (N'E-001', N'Rahman', N'Male', N'Dhaka,Bangladesh', N'Admin', CAST(N'2020-09-11' AS Date), 50000, N'123')
INSERT [dbo].[Admin_info] ([A_Id], [A_Name], [A_Gender], [A_Address], [A_Role], [A_Joining_Date], [A_Salary], [A_Password]) VALUES (N'E-002', N'Raiyan', N'Male', N'Dhaka', N'Admin', CAST(N'2020-02-04' AS Date), 120000, N'456')
INSERT [dbo].[FinishedProductInfo] ([FinishedProductId], [FinishedCatagory], [FinishedProductName], [FinishedQuantity], [FinishedCost], [FinishDate]) VALUES (N'F-1', N'Workwears', N'Chef uniforms', 40, 2000, CAST(N'2020-02-02' AS Date))
INSERT [dbo].[FinishedProductInfo] ([FinishedProductId], [FinishedCatagory], [FinishedProductName], [FinishedQuantity], [FinishedCost], [FinishDate]) VALUES (N'F-2', N'Bottoms weares', N'Pants', 30, 3000, CAST(N'2023-08-17' AS Date))
INSERT [dbo].[FinishedProductInfo] ([FinishedProductId], [FinishedCatagory], [FinishedProductName], [FinishedQuantity], [FinishedCost], [FinishDate]) VALUES (N'F-3', N'T-Shirts', N'Polo shirts', 20, 4000, CAST(N'2023-08-17' AS Date))
INSERT [dbo].[FinishedProductInfo] ([FinishedProductId], [FinishedCatagory], [FinishedProductName], [FinishedQuantity], [FinishedCost], [FinishDate]) VALUES (N'F-4', N'Bottoms weares', N'None', 201, 2000, CAST(N'2023-08-17' AS Date))
INSERT [dbo].[Manager_info] ([M_id], [M_Name], [M_Gender], [M_Address], [M_Role], [M_Joining_Date], [M_Salary], [M_Password], [A_Id]) VALUES (N'M-2', N'Rahim Abdullah', N'Male', N'Dhaka', N'Manager', CAST(N'2023-11-08' AS Date), 500000, N'11111111', N'E-001')
INSERT [dbo].[Manager_info] ([M_id], [M_Name], [M_Gender], [M_Address], [M_Role], [M_Joining_Date], [M_Salary], [M_Password], [A_Id]) VALUES (N'M-3', N'Niloy', N'Male', N'Dhaka', N'Manager', CAST(N'2023-08-11' AS Date), 40000, N'111', N'E-001')
INSERT [dbo].[Manager_info] ([M_id], [M_Name], [M_Gender], [M_Address], [M_Role], [M_Joining_Date], [M_Salary], [M_Password], [A_Id]) VALUES (N'M-4', N'Raiyan Sultan', N'Male', N'Dhaka', N'Manager', CAST(N'2020-02-12' AS Date), 500000, N'44444444', N'E-001')
INSERT [dbo].[Manager_info] ([M_id], [M_Name], [M_Gender], [M_Address], [M_Role], [M_Joining_Date], [M_Salary], [M_Password], [A_Id]) VALUES (N'M-5', N'Raiyan', N'', N'Dhaka,Bangladesh', N'Manager', CAST(N'2019-02-02' AS Date), 50000, N'12345678', N'E-001')
INSERT [dbo].[RawMeterialInfo] ([RawId], [RawCategory], [RawProductName], [RawQuantity], [RawCost], [RawDate]) VALUES (N'R-1', N'Fabrics', N'Wool', 40, 40000, CAST(N'2020-12-02' AS Date))
INSERT [dbo].[RawMeterialInfo] ([RawId], [RawCategory], [RawProductName], [RawQuantity], [RawCost], [RawDate]) VALUES (N'R-2', N'Buttons', N'Jeans buttons', 20, 4000, CAST(N'2020-01-02' AS Date))
INSERT [dbo].[RawMeterialInfo] ([RawId], [RawCategory], [RawProductName], [RawQuantity], [RawCost], [RawDate]) VALUES (N'R-3', N'Miscellaneous', N'Garment bags', 60, 4000, CAST(N'2023-02-02' AS Date))
INSERT [dbo].[RawMeterialInfo] ([RawId], [RawCategory], [RawProductName], [RawQuantity], [RawCost], [RawDate]) VALUES (N'R-4', N'Threads', N'Yarn for knitted', 200, 2000, CAST(N'2023-01-16' AS Date))
ALTER TABLE [dbo].[Manager_info]  WITH CHECK ADD  CONSTRAINT [FK_Manager_info_Admin_info1] FOREIGN KEY([A_Id])
REFERENCES [dbo].[Admin_info] ([A_Id])
GO
ALTER TABLE [dbo].[Manager_info] CHECK CONSTRAINT [FK_Manager_info_Admin_info1]
GO
USE [master]
GO
ALTER DATABASE [GarmentsManagementSystem] SET  READ_WRITE 
GO
