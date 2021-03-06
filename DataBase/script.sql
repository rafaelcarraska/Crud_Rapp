USE [master]
GO
/****** Object:  Database [Handson]    Script Date: 11/03/2018 17:43:06 ******/
CREATE DATABASE [Handson] ON  PRIMARY 
( NAME = N'Handson', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Handson.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Handson_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Handson_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Handson].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Handson] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Handson] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Handson] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Handson] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Handson] SET ARITHABORT OFF 
GO
ALTER DATABASE [Handson] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Handson] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Handson] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Handson] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Handson] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Handson] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Handson] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Handson] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Handson] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Handson] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Handson] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Handson] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Handson] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Handson] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Handson] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Handson] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Handson] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Handson] SET RECOVERY FULL 
GO
ALTER DATABASE [Handson] SET  MULTI_USER 
GO
ALTER DATABASE [Handson] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Handson] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Handson', N'ON'
GO
USE [Handson]
GO
/****** Object:  Table [dbo].[Armas]    Script Date: 11/03/2018 17:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Armas](
	[ID] [int] NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locais]    Script Date: 11/03/2018 17:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locais](
	[ID] [int] NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suspeitos]    Script Date: 11/03/2018 17:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suspeitos](
	[ID] [int] NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (1, N'Cajado Devastador')
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (2, N'Phaser')
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (3, N'Peixeira')
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (4, N'Trezoitão')
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (5, N'Sabre de Luz')
INSERT [dbo].[Armas] ([ID], [Descricao]) VALUES (6, N'Bomba')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (1, N'Etérnia')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (2, N'Vulcano')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (3, N'Tatooine')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (4, N'Springfield')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (5, N'Gotham')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (6, N'Nova York')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (7, N'Sibéria')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (8, N'Machu Picchu')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (9, N'Show do Katinguele')
INSERT [dbo].[Locais] ([ID], [Descricao]) VALUES (10, N'São Paulo')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (1, N'Esqueleto')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (2, N'Khan')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (3, N'Darth vader')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (4, N'Sideshow Bob')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (5, N'Coringa')
INSERT [dbo].[Suspeitos] ([ID], [Descricao]) VALUES (6, N'Duende Verde')
USE [master]
GO
ALTER DATABASE [Handson] SET  READ_WRITE 
GO
