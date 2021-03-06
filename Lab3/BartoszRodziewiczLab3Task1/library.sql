USE [master]
GO
/****** Object:  Database [Library]    Script Date: 20.04.17 02:04:52 ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Library.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Library_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[ISBN] [numeric](13, 0) NOT NULL,
	[Publisher] [nvarchar](50) NULL,
	[YearOfPublishion] [int] NULL,
	[Info] [text] NULL,
	[CategoryID] [int] NULL,
	[BranchID] [int] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Branches]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[AddressLine1] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](6) NULL,
	[City] [nvarchar](50) NULL,
	[Phone] [int] NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[AddressLine1] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](6) NULL,
	[City] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Librarians]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librarians](
	[LibrarianID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[HireDate] [date] NULL,
 CONSTRAINT [PK_Librarians] PRIMARY KEY CLUSTERED 
(
	[LibrarianID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 20.04.17 02:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[DateOfReservation] [date] NULL,
	[DateOfPickup] [date] NULL,
	[DateOfReturn] [date] NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (1, N'Miasto kości', N'Cassandra Clare', CAST(9788374803762 AS Numeric(13, 0)), N'Mag', 2013, NULL, 2, 3)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (2, N'Pani Jeziora', N'Andrzej Sapkowski', CAST(9788375780697 AS Numeric(13, 0)), N'superNOWA', 2014, NULL, 2, 1)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (3, N'Metro 2033', N'Dmitry Glukhovsky', CAST(9788365315014 AS Numeric(13, 0)), N'Insignis', 2015, NULL, 3, 2)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (4, N'Intruz', N'Stephenie Meyer', CAST(9788324594672 AS Numeric(13, 0)), N'Wydawnictwo Dolnośląskie', 2013, N'Swiat zostal opanowany przez niewidzialnego wroga. Najezdzcy przejeli ludzkie ciala oraz umysly i wioda w nich normalne zycie. Jedna z ostatnich niezasiedlonych, wolnych istot ludzkich jest Melanie. Wpada jednak w rece wroga, a w jej ciele zostaje umieszczona dusza o imieniu Wagabunda. Intruz bada mysli poprzedniej wlascicielki ciala w poszukiwaniu sladów prowadzacych do reszty rebeliantów...', 3, 2)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (5, N'Uczta dla wron, część 1: Cienie śmierci', N'George R.R. Martin', CAST(9788377856635 AS Numeric(13, 0)), N'Zysk i S-ka', 2015, NULL, 2, 3)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (6, N'Nowy wspaniały świat', N'Aldous Huxley', CAST(9788374958691 AS Numeric(13, 0)), N'Muza', 2010, NULL, 3, 1)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (7, N'Ciemniejsza strona Greya', N'E L James', CAST(9788375085952 AS Numeric(13, 0)), N'Sonia Draga', 2012, NULL, 1, 1)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (8, N'Zanim się pojawiłeś', N'Jojo Moyes', CAST(9788380315884 AS Numeric(13, 0)), N'Świat Książki', 2016, NULL, 1, 2)
INSERT [dbo].[Books] ([BookID], [Name], [Author], [ISBN], [Publisher], [YearOfPublishion], [Info], [CategoryID], [BranchID]) VALUES (9, N'Zmierzch', N'Stephenie Meyer', CAST(9788324589159 AS Numeric(13, 0)), N'Wydawnictwo Dolnośląskie', 2007, NULL, 1, 3)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Branches] ON 

INSERT [dbo].[Branches] ([BranchID], [Name], [AddressLine1], [PostalCode], [City], [Phone]) VALUES (1, N'Filia nr 1', N'Rynek 5', N'44-004', N'Wrocław', 713655687)
INSERT [dbo].[Branches] ([BranchID], [Name], [AddressLine1], [PostalCode], [City], [Phone]) VALUES (2, N'Filia nr 2', N'Dokerska 8', N'44-024', N'Wrocław', 715423354)
INSERT [dbo].[Branches] ([BranchID], [Name], [AddressLine1], [PostalCode], [City], [Phone]) VALUES (3, N'Filia nr 3', N'Polna 43', N'44-154', N'Wrocław', 713254875)
SET IDENTITY_INSERT [dbo].[Branches] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (1, N'Romans')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (2, N'Fantasy')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (3, N'Sci-Fi')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [Name], [Surname], [AddressLine1], [PostalCode], [City], [Phone], [Email]) VALUES (1, N'Maria', N'Kowalska', N'Leśna 56', N'44-765', N'Wrocław', 548652145, N'maria@kowalska.pl')
INSERT [dbo].[Clients] ([ClientID], [Name], [Surname], [AddressLine1], [PostalCode], [City], [Phone], [Email]) VALUES (2, N'Jan', N'Nowak', N'Długa 345', N'44-065', N'Wrocław', 874563545, N'jnowak@wp.pl')
INSERT [dbo].[Clients] ([ClientID], [Name], [Surname], [AddressLine1], [PostalCode], [City], [Phone], [Email]) VALUES (3, N'Stefan', N'Mikolski', N'Górna 67', N'44-087', N'Wrocław', 214698574, N'smikol@onet.pl')
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Librarians] ON 

INSERT [dbo].[Librarians] ([LibrarianID], [Name], [Surname], [HireDate]) VALUES (1, N'Maciej', N'Podgórny', CAST(N'2017-01-05' AS Date))
SET IDENTITY_INSERT [dbo].[Librarians] OFF
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([ReservationID], [ClientID], [BookID], [DateOfReservation], [DateOfPickup], [DateOfReturn]) VALUES (1, 2, 6, CAST(N'2017-04-20' AS Date), CAST(N'2017-04-21' AS Date), CAST(N'2017-05-21' AS Date))
INSERT [dbo].[Reservations] ([ReservationID], [ClientID], [BookID], [DateOfReservation], [DateOfPickup], [DateOfReturn]) VALUES (2, 2, 5, CAST(N'2017-04-20' AS Date), CAST(N'2017-04-21' AS Date), CAST(N'2017-05-21' AS Date))
INSERT [dbo].[Reservations] ([ReservationID], [ClientID], [BookID], [DateOfReservation], [DateOfPickup], [DateOfReturn]) VALUES (3, 3, 5, CAST(N'2017-04-20' AS Date), CAST(N'2017-05-22' AS Date), CAST(N'2017-06-22' AS Date))
INSERT [dbo].[Reservations] ([ReservationID], [ClientID], [BookID], [DateOfReservation], [DateOfPickup], [DateOfReturn]) VALUES (4, 1, 4, CAST(N'2017-04-18' AS Date), CAST(N'2017-04-18' AS Date), CAST(N'2017-05-18' AS Date))
SET IDENTITY_INSERT [dbo].[Reservations] OFF
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Branches] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([BranchID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Branches]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Books]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Clients]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
