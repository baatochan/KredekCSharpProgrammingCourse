USE [master]
GO
/****** Object:  Database [Zoo]    Script Date: 05.04.17 21:05:52 ******/
CREATE DATABASE [Zoo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Zoo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Zoo.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Zoo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Zoo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Zoo] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Zoo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Zoo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Zoo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Zoo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Zoo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Zoo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Zoo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Zoo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Zoo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Zoo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Zoo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Zoo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Zoo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Zoo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Zoo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Zoo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Zoo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Zoo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Zoo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Zoo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Zoo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Zoo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Zoo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Zoo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Zoo] SET  MULTI_USER 
GO
ALTER DATABASE [Zoo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Zoo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Zoo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Zoo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Zoo] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Zoo]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 05.04.17 21:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Species] [nvarchar](50) NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sloths]    Script Date: 05.04.17 21:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sloths](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[ZookeeperID] [int] NULL,
	[AnimalID] [int] NULL,
 CONSTRAINT [PK_Sloths] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zookeepers]    Script Date: 05.04.17 21:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zookeepers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Zookeeper] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Animals] ON 

INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (1, N'Leniwce', 56)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (2, N'Zyrafy', 32)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (3, N'Lwy', 12)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (4, N'Nietoperze', 179)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (5, N'Hipopotamy', 13)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (7, N'xx', 11)
INSERT [dbo].[Animals] ([ID], [Species], [Amount]) VALUES (8, N'rga', 113)
SET IDENTITY_INSERT [dbo].[Animals] OFF
SET IDENTITY_INSERT [dbo].[Sloths] ON 

INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (1, N'sloth1', 34, 1, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (2, N'sloth2', 2, 3, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (3, N'sloth3', 3, 2, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (4, N'sloth4', 12, 6, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (6, N'sloth5', 65, 4, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (7, N'sloth6', 23, 2, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (8, N'sloth7', 97, 4, 1)
INSERT [dbo].[Sloths] ([ID], [Name], [Age], [ZookeeperID], [AnimalID]) VALUES (9, N'sloth8', 43, 6, 1)
SET IDENTITY_INSERT [dbo].[Sloths] OFF
SET IDENTITY_INSERT [dbo].[Zookeepers] ON 

INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (1, N'Anna', N'Nowak')
INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (2, N'Paulina', N'Lis')
INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (3, N'Tomasz', N'Kot')
INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (4, N'Agata', N'Kowalska')
INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (5, N'Justyna', N'Kot')
INSERT [dbo].[Zookeepers] ([ID], [Name], [Surname]) VALUES (6, N'Zbigniew', N'Druh')
SET IDENTITY_INSERT [dbo].[Zookeepers] OFF
ALTER TABLE [dbo].[Sloths]  WITH CHECK ADD  CONSTRAINT [FK_Sloths_Animals] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animals] ([ID])
GO
ALTER TABLE [dbo].[Sloths] CHECK CONSTRAINT [FK_Sloths_Animals]
GO
ALTER TABLE [dbo].[Sloths]  WITH CHECK ADD  CONSTRAINT [FK_Sloths_Zookeepers] FOREIGN KEY([ZookeeperID])
REFERENCES [dbo].[Zookeepers] ([ID])
GO
ALTER TABLE [dbo].[Sloths] CHECK CONSTRAINT [FK_Sloths_Zookeepers]
GO
USE [master]
GO
ALTER DATABASE [Zoo] SET  READ_WRITE 
GO
