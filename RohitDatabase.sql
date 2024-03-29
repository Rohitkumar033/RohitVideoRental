USE [master]
GO
/****** Object:  Database [RohitDatabase]    Script Date: 11/09/2019 11:19:01 AM ******/
CREATE DATABASE [RohitDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RohitDatabase_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RohitDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RohitDatabase_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RohitDatabase.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RohitDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RohitDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RohitDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RohitDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RohitDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RohitDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RohitDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [RohitDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RohitDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RohitDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RohitDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RohitDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RohitDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RohitDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RohitDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RohitDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RohitDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RohitDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RohitDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RohitDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RohitDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RohitDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RohitDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RohitDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RohitDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RohitDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [RohitDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RohitDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RohitDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RohitDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RohitDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RohitDatabase] SET QUERY_STORE = OFF
GO
USE [RohitDatabase]
GO
/****** Object:  Table [dbo].[BookingVideo]    Script Date: 11/09/2019 11:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingVideo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NULL,
	[VideoID] [int] NULL,
	[VideoIssued] [varchar](50) NULL,
	[VideoReturn] [varchar](50) NULL,
 CONSTRAINT [PK_BookingVideo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 11/09/2019 11:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[F_Name] [varchar](50) NULL,
	[L_Name] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoCD]    Script Date: 11/09/2019 11:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoCD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[VideoTitle] [varchar](50) NULL,
	[VideoRatting] [varchar](50) NULL,
	[VideoYear] [int] NULL,
	[VideoCost] [int] NULL,
	[VideoCopies] [int] NULL,
	[VideoPlot] [varchar](50) NULL,
	[VideoGenre] [nchar](10) NULL,
 CONSTRAINT [PK_VideoCaste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookingVideo] ON 

INSERT [dbo].[BookingVideo] ([id], [MemberID], [VideoID], [VideoIssued], [VideoReturn]) VALUES (2, 3, 1, N'9/09/2019', N'Booked')
INSERT [dbo].[BookingVideo] ([id], [MemberID], [VideoID], [VideoIssued], [VideoReturn]) VALUES (3, 5, 6, N'13/08/2019', N'Booked')
SET IDENTITY_INSERT [dbo].[BookingVideo] OFF
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (2, N'Harman', N'singh', N'224005766', N'6 wimey ave')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (3, N'Ramesh', N'kumar', N'225005769', N'77 rose ave')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (5, N'Binni', N'singh', N'222532541', N'12 wintere road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (6, N'Rohit', N'kumar', N'225415354', N'2 rangitoto road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (7, N'Rishi', N'sharma', N'225546954', N'10 picton road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (8, N'Ankit', N'mehta', N'224479634', N'80 coronation street')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (9, N'Nitin', N'verma', N'226987354', N'great south road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (10, N'Puneet', N'bhandari', N'225684126', N'2 birdwood ave')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (11, N'Ranveer', N'dhillon', N'554986325', N'12 wenworth ave')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (12, N'Raman', N'kumar', N'225005769', N'3 oakland road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (13, N'Ishwar', N'narang', N'227614202', N'44 hiil road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (14, N'Jashan', N'virk', N'225478962', N'57 coronation road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (15, N'Guri', N'dhaliwal', N'22544893', N'5 hamilton road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (16, N'shikha', N'sharma', N'25548965', N'7/8 kolmar road')
INSERT [dbo].[Member] ([ID], [F_Name], [L_Name], [Mobile], [Address]) VALUES (17, N'sahil ', N'khatri', N'44857694', N'45 first ave')
SET IDENTITY_INSERT [dbo].[Member] OFF
SET IDENTITY_INSERT [dbo].[VideoCD] ON 

INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (1, N'Singam', N'12', 2019, 5, 2, N'w', N'Action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (2, N'3 idots', N'4', 2011, 7, 1, N'3', N'comedy    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (3, N'Don', N'6', 2009, 20, 1, N'4', N'Action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (4, N'bhaggi', N'10', 2013, 200, 3, N'R', N'action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (5, N'shloy', N'22', 1975, 100, 0, N's', N'Action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (6, N'Dilwale', N'66', 2011, 220, 2, N'H', N'Romance   ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (7, N'Saaho', N'30', 2019, 50, 1, N'H', N'Romance   ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (8, N'Kesari', N'40', 2019, 300, 0, N'FH', N'Advanture ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (9, N'War', N'80', 2017, 550, 2, N'H', N'Action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (10, N'Badla', N'60', 2018, 80, 1, N'H', N'Action    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (11, N'Student of the year', N'40', 2014, 200, 2, N'H', N'Fantesy   ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (12, N'Housefull 2', N'40', 2016, 500, 2, N'FH', N'Comedy    ')
INSERT [dbo].[VideoCD] ([id], [VideoTitle], [VideoRatting], [VideoYear], [VideoCost], [VideoCopies], [VideoPlot], [VideoGenre]) VALUES (13, N'Race', N'30', 2016, 90, 1, N'H', N'Action    ')
SET IDENTITY_INSERT [dbo].[VideoCD] OFF
USE [master]
GO
ALTER DATABASE [RohitDatabase] SET  READ_WRITE 
GO
