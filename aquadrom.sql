USE [master]
GO
/****** Object:  Database [aquadrom]    Script Date: 2015-01-27 12:07:55 ******/
CREATE DATABASE [aquadrom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aquadrom', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\aquadrom.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'aquadrom_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\aquadrom_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [aquadrom] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aquadrom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aquadrom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aquadrom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aquadrom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aquadrom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aquadrom] SET ARITHABORT OFF 
GO
ALTER DATABASE [aquadrom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [aquadrom] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [aquadrom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aquadrom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aquadrom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aquadrom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aquadrom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aquadrom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aquadrom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aquadrom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aquadrom] SET  DISABLE_BROKER 
GO
ALTER DATABASE [aquadrom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aquadrom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aquadrom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aquadrom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aquadrom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aquadrom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [aquadrom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aquadrom] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [aquadrom] SET  MULTI_USER 
GO
ALTER DATABASE [aquadrom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aquadrom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aquadrom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aquadrom] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [aquadrom]
GO
/****** Object:  Table [dbo].[Godziny_pracy]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Godziny_pracy](
	[ID_g] [int] IDENTITY(1,1) NOT NULL,
	[Od] [datetime] NOT NULL,
	[Do] [datetime] NOT NULL,
	[ID_pracownika] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_g] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Notatka]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notatka](
	[ID_n] [int] IDENTITY(1,1) NOT NULL,
	[Opis] [nvarchar](200) NOT NULL,
	[Czas] [datetime] NOT NULL,
	[Rodzaj_zdarzenia] [nvarchar](20) NOT NULL,
	[Uwagi] [nvarchar](50) NULL,
	[Akceptacja_KZ] [bit] NOT NULL DEFAULT ((0)),
	[Akceptacja_KSR] [bit] NOT NULL DEFAULT ((0)),
	[ID_R] [int] NULL,
	[ID_KZ] [int] NOT NULL,
	[ID_KSR] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_n] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Otwarcie_stanowiska]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otwarcie_stanowiska](
	[ID_o] [int] IDENTITY(1,1) NOT NULL,
	[Od] [time](7) NOT NULL,
	[Do] [time](7) NOT NULL,
	[Typ_dnia] [nvarchar](2) NOT NULL,
	[ID_stanowiska] [int] NOT NULL,
 CONSTRAINT [PK_Otwarcie_stan] PRIMARY KEY CLUSTERED 
(
	[ID_o] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pracownik]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pracownik](
	[ID_p] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Pesel] [varchar](11) NOT NULL,
	[Mail] [nvarchar](35) NOT NULL,
	[Miasto] [nvarchar](20) NOT NULL,
	[Ulica] [nvarchar](20) NOT NULL,
	[Numer_domu] [nvarchar](4) NOT NULL,
	[Numer_mieszkania] [nvarchar](4) NULL,
	[Numer_telefonu] [nchar](12) NOT NULL,
	[Stanowisko] [nvarchar](3) NOT NULL,
	[Data_waznosci_KPP] [date] NULL,
	[Data_badan] [date] NOT NULL,
	[Stopien] [nvarchar](3) NULL,
	[Login] [nvarchar](40) NOT NULL,
	[Haslo] [nvarchar](256) NOT NULL,
	[ID_umowy] [int] NOT NULL,
	[Typ_konta] [nchar](1) NULL CONSTRAINT [DF__Pracownik__Typ_k__4316F928]  DEFAULT ('U'),
	[Ostrzezenie_umowa] [varchar](1) NOT NULL DEFAULT ('f'),
	[Ostrzezenie_KPP] [varchar](1) NOT NULL DEFAULT ('f'),
	[Ostrzezenie_badania] [varchar](1) NOT NULL DEFAULT ('f'),
 CONSTRAINT [PK__Pracowni__B87EA53C0AD2A005] PRIMARY KEY CLUSTERED 
(
	[ID_p] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stanowisko]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stanowisko](
	[ID_s] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](10) NOT NULL,
	[Strefa] [nvarchar](10) NOT NULL,
	[Liczba_pracownikow] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_s] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Umowa]    Script Date: 2015-01-27 12:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Umowa](
	[ID_u] [int] IDENTITY(1,1) NOT NULL,
	[Typ] [nvarchar](3) NOT NULL,
	[Wymiar_godzin] [int] NULL,
	[Poczatek_umowy] [date] NOT NULL,
	[Koniec_umowy] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_u] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Godziny_pracy] ON 

INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (121, CAST(N'2015-01-01 08:30:00.000' AS DateTime), CAST(N'2015-01-01 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (122, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (123, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (124, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (125, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (126, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (127, CAST(N'2015-01-01 08:30:00.000' AS DateTime), CAST(N'2015-01-01 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (128, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (129, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (130, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (131, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (132, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (133, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (134, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (135, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (136, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (137, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (138, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (139, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (140, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (141, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (142, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (143, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (144, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (145, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (146, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (147, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (148, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (149, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (150, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (151, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (152, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (153, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (154, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (155, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (156, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 14)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (157, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 17)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (158, CAST(N'2015-01-01 15:00:00.000' AS DateTime), CAST(N'2015-01-01 17:00:00.000' AS DateTime), 18)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (159, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 13:00:00.000' AS DateTime), 19)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (160, CAST(N'2015-01-01 15:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 23)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (161, CAST(N'2015-01-01 16:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 24)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (162, CAST(N'2015-01-01 17:00:00.000' AS DateTime), CAST(N'2015-01-01 20:00:00.000' AS DateTime), 25)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (163, CAST(N'2015-01-01 19:30:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 26)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (164, CAST(N'2015-01-01 19:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 27)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (165, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (166, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (167, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (168, CAST(N'2015-01-01 08:30:00.000' AS DateTime), CAST(N'2015-01-01 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (169, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (170, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (171, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (172, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (173, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (174, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (175, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (176, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (177, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (178, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (179, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (180, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (181, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (182, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (183, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (184, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (185, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (186, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (187, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (188, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (189, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (190, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (191, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (192, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (193, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (194, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (195, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (196, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (197, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (198, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (199, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (200, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (201, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (202, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (203, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (204, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (205, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (206, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (207, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (208, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (209, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (210, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (211, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (212, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (213, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (214, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (215, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (216, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (217, CAST(N'2015-01-01 08:30:00.000' AS DateTime), CAST(N'2015-01-01 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (218, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (219, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
GO
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (220, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (221, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (222, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (223, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (224, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (225, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (226, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (227, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (228, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (229, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (230, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (231, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (232, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (233, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (234, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (235, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (236, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (237, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (238, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (239, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (240, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (241, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (242, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (243, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (244, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (245, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (246, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (247, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (248, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (249, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (250, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (251, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (252, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (253, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (254, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (255, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (256, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (257, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (258, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (259, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (260, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (261, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (262, CAST(N'2015-01-01 08:30:00.000' AS DateTime), CAST(N'2015-01-01 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (263, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (264, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (265, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (266, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (267, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (268, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (269, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (270, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (271, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (272, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (273, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (274, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (275, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (276, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (277, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (278, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (279, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (280, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (281, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (282, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (283, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (284, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (285, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (286, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (287, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (288, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (289, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (290, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (291, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (292, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (293, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (294, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (295, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (296, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (297, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (298, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (299, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (300, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (301, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (302, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (303, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (304, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (305, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (306, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (307, CAST(N'2015-01-02 08:30:00.000' AS DateTime), CAST(N'2015-01-02 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (308, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (309, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (310, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (311, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (312, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (313, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (314, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (315, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (316, CAST(N'2015-01-11 08:00:00.000' AS DateTime), CAST(N'2015-01-11 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (317, CAST(N'2015-01-02 10:00:00.000' AS DateTime), CAST(N'2015-01-02 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (318, CAST(N'2015-01-03 10:00:00.000' AS DateTime), CAST(N'2015-01-03 12:30:00.000' AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (319, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (320, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (321, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (322, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (323, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (324, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (325, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (326, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (327, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (328, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (329, CAST(N'2015-01-02 10:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (330, CAST(N'2015-01-03 10:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (331, CAST(N'2015-01-02 10:00:00.000' AS DateTime), CAST(N'2015-01-02 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (332, CAST(N'2015-01-03 10:00:00.000' AS DateTime), CAST(N'2015-01-03 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (333, CAST(N'2015-01-02 09:00:00.000' AS DateTime), CAST(N'2015-01-02 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (334, CAST(N'2015-01-03 09:00:00.000' AS DateTime), CAST(N'2015-01-03 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (335, CAST(N'2015-01-02 14:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (336, CAST(N'2015-01-03 14:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (337, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 14:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (338, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (339, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (340, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (341, CAST(N'2015-01-05 13:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (342, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (343, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (344, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (345, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (346, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (347, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (348, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (349, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (350, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (351, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (352, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (353, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (354, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (355, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (356, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (357, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 59)
SET IDENTITY_INSERT [dbo].[Godziny_pracy] OFF
SET IDENTITY_INSERT [dbo].[Notatka] ON 

INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (2, N'', CAST(N'2015-01-25 00:00:00.000' AS DateTime), N'dassdad', NULL, 1, 1, 1, 1, 1)
INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (3, N'dsf', CAST(N'2015-01-25 00:00:00.000' AS DateTime), N'sadf', NULL, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Notatka] OFF
SET IDENTITY_INSERT [dbo].[Otwarcie_stanowiska] ON 

INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (2, CAST(N'08:00:00' AS Time), CAST(N'22:00:00' AS Time), N'R', 1)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (3, CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), N'R', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'14:00:00' AS Time), N'Z', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), N'Z', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (6, CAST(N'12:00:00' AS Time), CAST(N'22:00:00' AS Time), N'R', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (7, CAST(N'08:00:00' AS Time), CAST(N'14:00:00' AS Time), N'R', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (8, CAST(N'16:00:00' AS Time), CAST(N'20:00:00' AS Time), N'R', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (9, CAST(N'20:00:00' AS Time), CAST(N'22:00:00' AS Time), N'Z', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (10, CAST(N'16:00:00' AS Time), CAST(N'22:00:00' AS Time), N'R', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (11, CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), N'Z', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (12, CAST(N'10:00:00' AS Time), CAST(N'20:00:00' AS Time), N'WS', 1)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (13, CAST(N'10:00:00' AS Time), CAST(N'20:00:00' AS Time), N'WS', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (14, CAST(N'15:00:00' AS Time), CAST(N'20:00:00' AS Time), N'WS', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (15, CAST(N'14:00:00' AS Time), CAST(N'18:00:00' AS Time), N'WS', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (16, CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), N'WS', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (17, CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), N'WS', 5)
SET IDENTITY_INSERT [dbo].[Otwarcie_stanowiska] OFF
SET IDENTITY_INSERT [dbo].[Pracownik] ON 

INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (1, N'Mateusz', N'Ogiermann', N'93031269578', N'ogipierogi@gmail.com', N'Ruda Śląska', N'Szczecińska', N'15', N'7', N'502145897   ', N'RW', CAST(N'2016-07-01' AS Date), CAST(N'2016-06-01' AS Date), N'MR', N'ogipierogi', N'm.ogiermann', 12, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (2, N'Jan', N'Kowalski', N'85041265478', N'j.kowalski@gmail.com', N'Katowice', N'3 Maja', N'10', N'4', N'603178954   ', N'KSR', CAST(N'2015-02-25' AS Date), CAST(N'2015-04-30' AS Date), N'SRW', N'jkowalski', N'j.kowalski', 2, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (4, N'Piotr', N'Nowak', N'80050645987', N'p.nowak@gmail.com', N'Ruda Śląska', N'Akademicka', N'5', N'3', N'604125269   ', N'KSR', CAST(N'2015-03-15' AS Date), CAST(N'2015-03-10' AS Date), N'MI', N'pnowak', N'p.nowak', 3, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (5, N'Andrzej', N'Zieliński', N'84110242985', N'a.ziel@gmail.com', N'Ruda Śląska', N'Szymanowskiego', N'56', N'10', N'798153469   ', N'KSR', CAST(N'2015-11-05' AS Date), CAST(N'2015-08-07' AS Date), N'MR', N'azielinski', N'a.zielinski', 4, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (6, N'Paulina', N'Kaczmarek', N'90120845137', N'p.kaczmarek@wp.pl', N'Bytom', N'Ogrodowa', N'40', NULL, N'665125894   ', N'KSR', CAST(N'2015-08-30' AS Date), CAST(N'2015-09-14' AS Date), N'RW', N'pkaczmarek', N'p.kaczmarek', 9, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (7, N'Ernest', N'Maciejewski', N'81113012954', N'e.maciej@o2.pl', N'Zabrze', N'Parkowa', N'13', NULL, N'889632177   ', N'RW', CAST(N'2015-09-16' AS Date), CAST(N'2015-10-20' AS Date), N'IW', N'emaciejewski', N'e.maciejewski', 8, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (8, N'Agata', N'Musiał', N'86040347629', N'a.musial@onet.pl', N'Ruda Śląska', N'Sienkiewicza', N'15', N'4', N'605487300   ', N'RW', CAST(N'2015-12-01' AS Date), CAST(N'2015-11-30' AS Date), N'I', N'amusial', N'a.musial', 15, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (9, N'Michał', N'Ziętek', N'79030214598', N'zietek@michal.pl', N'Świętochłowice', N'Opolska', N'10', NULL, N'512487501   ', N'KZ', NULL, CAST(N'2015-06-04' AS Date), NULL, N'mzietek', N'm.zietek', 16, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (11, N'Barbara', N'Dudek', N'91020541869', N'bdudek91@gmail.com', N'Ruda Śląska', N'Katowicka', N'34', N'5', N'664178244   ', N'RW', CAST(N'2015-08-30' AS Date), CAST(N'2015-06-04' AS Date), N'SRW', N'bdudek', N'b.dudek', 19, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (12, N'Jarosław', N'Kasza', N'75041254329', N'kasza123456@o2.pl', N'Bytom', N'Karpacka', N'19', N'7', N'789526133   ', N'RW', CAST(N'2015-09-14' AS Date), CAST(N'2015-08-17' AS Date), N'RW', N'jkasza', N'j.kasza', 20, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (13, N'Ewelina', N'Janowska', N'79020545612', N'ejanowska@wp.pl', N'Ruda Śląska', N'Biskupia', N'20A', N'15', N'604148952   ', N'RW', CAST(N'2014-12-01' AS Date), CAST(N'2015-01-30' AS Date), N'MR', N'ejanowska', N'e.janowska', 21, N'u', N'f', N't', N't')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (14, N'Marek', N'Stasiak', N'87070845312', N'mstasiak@gmail.com', N'Chorzów', N'Graniczna', N'15', N'23', N'513489655   ', N'RW', CAST(N'2015-01-30' AS Date), CAST(N'2015-02-15' AS Date), N'IW', N'mstasiak', N'm.stasiak', 22, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (17, N'Katarzyna', N'Wencel', N'89080514569', N'kwencel@wp.pl', N'Katowice', N'Francuska', N'19', N'25', N'606598175   ', N'RW', CAST(N'2015-02-14' AS Date), CAST(N'2015-10-05' AS Date), N'I', N'kwencel', N'k.wencel', 23, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (18, N'Adrian', N'Iwanowski', N'76101056461', N'adi.iwan@wp.pl', N'Ruda Śląska', N'Hutnicza', N'20', NULL, N'514879546   ', N'RW', CAST(N'2015-06-05' AS Date), CAST(N'2015-02-07' AS Date), N'MI', N'aiwanowski', N'a.iwanowski', 24, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (19, N'Anna', N'Boroń-Kowalska', N'74010245689', N'boron-kowalska@gmial.com', N'Zabrze', N'Jordana', N'10', N'15', N'548984235   ', N'RW', CAST(N'2015-11-11' AS Date), CAST(N'2015-12-03' AS Date), N'SRW', N'aboronkowalska', N'a.boronkowalska', 25, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (23, N'Piotr', N'Szadkowski', N'88252445465', N'szadkowski.piotr@gmail.com', N'Ruda Śląska', N'Bulwarowa', N'45', N'7', N'651658564   ', N'RW', CAST(N'2015-01-01' AS Date), CAST(N'2015-10-12' AS Date), N'RW', N'pszadkowski', N'p.szadkowski', 10, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (24, N'Ewa', N'Nowok', N'92121465786', N'ewanowok@wp.pl', N'Gliwice', N'Pszczyńska', N'50', N'24', N'516516545   ', N'RW', CAST(N'2014-03-10' AS Date), CAST(N'2015-06-15' AS Date), N'IW', N'enowok', N'ewa.nowok', 11, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (25, N'Agata', N'Szymańska', N'91052946548', N'agataszym@o2.pl', N'Ruda Śląska', N'Bulwarowa', N'50', N'19', N'564845465   ', N'RW', CAST(N'2015-06-07' AS Date), CAST(N'2015-09-08' AS Date), N'IW', N'aszymanska', N'a.szymanska', 13, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (26, N'Sylwia', N'Szczepanek', N'87121419849', N'szczepaneksylwia@gmail.com', N'Ruda Śląska', N'Prusa', N'10', NULL, N'816545664   ', N'RW', CAST(N'2015-12-08' AS Date), CAST(N'2015-08-04' AS Date), N'I', N'sszczepanek', N's.szczepanek', 26, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (27, N'Sebastian', N'Zuber', N'89121448987', N'sebazuber@wp.pl', N'Ruda Śląska', N'Jagiellońska', N'14', N'35', N'816547988   ', N'RW', CAST(N'2015-09-09' AS Date), CAST(N'2015-07-08' AS Date), N'MI', N'szuber', N's.zuber', 27, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (28, N'Krzysztof', N'Czapla', N'90070945498', N'czaplak@gmail.com', N'Gliwice', N'Górnych Wałów', N'15', N'17', N'655153168   ', N'RW', CAST(N'2015-10-30' AS Date), CAST(N'2015-09-27' AS Date), N'SRW', N'kczapla', N'k.czapla', 28, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (29, N'Mariusz', N'Krawczyk', N'88063021466', N'mariokrawczyk@onet.pl', N'Ruda Śląska', N'Szermierzy', N'6', NULL, N'546545468   ', N'RW', CAST(N'2015-08-22' AS Date), CAST(N'2015-05-14' AS Date), N'RW', N'mkrawczyk', N'm.krawczyk', 29, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (30, N'Dorota', N'Salomon', N'79041951688', N'salomondoro@wp.pl', N'Ruda Śląska', N'Racjonalizatorów', N'15', N'3', N'489784654   ', N'RW', CAST(N'2015-09-19' AS Date), CAST(N'2015-02-15' AS Date), N'RW', N'dsalomon', N'd.salomon', 30, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (31, N'Małgorzata', N'Szewczyk', N'86021468987', N'gosiaszewczyk@gmail.com', N'Ruda Śląska', N'Rubinowa', N'16C', N'2', N'484985465   ', N'RW', CAST(N'2015-06-08' AS Date), CAST(N'2015-01-19' AS Date), N'MR', N'mszewczyk', N'mszewczyk', 31, N'u', N'f', N'f', N't')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (32, N'Eryk', N'Dankowski', N'90031746879', N'dankowskieryk@wp.pl', N'Ruda Śląska', N'Patriotów', N'10', N'16', N'565979745   ', N'RW', CAST(N'2015-07-10' AS Date), CAST(N'2015-08-28' AS Date), N'IW', N'edankowski', N'e.dankowski', 32, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (33, N'Andrzej', N'Siewior', N'90120645648', N'andisiewior@o2.pl', N'Ruda Śląska', N'Szewczyka', N'16', N'4', N'656589455   ', N'RW', CAST(N'2015-08-21' AS Date), CAST(N'2015-09-08' AS Date), N'I', N'asiewior', N'a.siewior', 33, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (34, N'Kamil', N'Woźny', N'91070954689', N'kwozny@wp.pl', N'Ruda Śląska', N'Kościelna', N'15', N'12', N'654868987   ', N'RW', CAST(N'2015-09-22' AS Date), CAST(N'2015-10-05' AS Date), N'MI', N'kwozny', N'k.wozny', 34, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (35, N'Ireneusz', N'Napiórkowski', N'87122856989', N'ireknapior@o2.pl', N'Ruda Śląska', N'Wspólna', N'19', NULL, N'656498878   ', N'RW', CAST(N'2015-10-29' AS Date), CAST(N'2015-10-01' AS Date), N'SRW', N'inapiorkowski', N'i.napiorkowski', 35, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (36, N'Patrycja', N'Siewior', N'85110665984', N'psiewior@o2.pl', N'Ruda Śląska', N'Sztandarowa', N'20', N'15', N'654984123   ', N'RW', CAST(N'2015-09-14' AS Date), CAST(N'2015-08-13' AS Date), N'RW', N'psiewior', N'p.siewior', 36, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (37, N'Stefania', N'Dzwonek', N'90111765214', N'stefadzwonek@gmail.com', N'Ruda Śląska', N'Szewczyka', N'21', N'30', N'889424651   ', N'RW', CAST(N'2015-09-17' AS Date), CAST(N'2015-10-18' AS Date), N'MR', N'sdzwonek', N's.dzwonek', 37, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (39, N'Natalia', N'Strycharz', N'91121365935', N'natastrycharz@gmail.com', N'Ruda Śląska', N'Reymonta', N'30', NULL, N'564231599   ', N'RW', CAST(N'2015-05-03' AS Date), CAST(N'2015-06-07' AS Date), N'IW', N'nstrycharz', N'n.strycharz', 38, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (40, N'Bartosz', N'Topolski', N'90030265498', N'bartopolski@wp.pl', N'Ruda Śląska', N'Kochanowskiego', N'9', N'12', N'561261348   ', N'RW', CAST(N'2015-03-10' AS Date), CAST(N'2015-08-15' AS Date), N'I', N'btopolski', N'b.topolski', 39, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (41, N'Maria', N'Bednarz', N'81052954896', N'marysiab@gmail.com', N'Ruda Śląska', N'Wiązowa', N'10', N'47', N'956484534   ', N'RW', CAST(N'2015-05-09' AS Date), CAST(N'2015-06-10' AS Date), N'MI', N'mbednarz', N'm.bednarz', 40, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (45, N'Szymon', N'Kosmala', N'83061451689', N'szymon.kosmala@wp.pl', N'Ruda Śląska', N'Jasna', N'13', NULL, N'890517564   ', N'RW', CAST(N'2015-10-18' AS Date), CAST(N'2015-03-15' AS Date), N'RW', N'skosmala', N's.kosmala', 41, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (46, N'Marta', N'Kaliszewska', N'90021545498', N'mkalisz@gmail.com', N'Świętochłowice', N'Szarych Szeregów', N'25', N'10', N'545468989   ', N'KZ', NULL, CAST(N'2015-12-01' AS Date), NULL, N'mkaliszewska', N'm.kaliszewska', 42, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (47, N'Jan', N'Jeziorański', N'76093065985', N'jan.jezioraski@gmail.com', N'Ruda Śląska', N'Bojkowska', N'19', N'5', N'546189745   ', N'KZ', NULL, CAST(N'2015-11-10' AS Date), NULL, N'jjezioraski', N'j.jezioranski', 43, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (48, N'Marcin', N'Chrzanowski', N'89021054899', N'm.chrzanowski@wp.pl', N'Bytom', N'Główna', N'52', N'7', N'546187986   ', N'KZ', NULL, CAST(N'2015-04-06' AS Date), NULL, N'mchrzanowski', N'm.chrzanowski', 44, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (55, N'Dita', N'Majewska', N'91030443202', N'd.majewska@o2.pl', N'Ruda Śląska', N'Przasnyska', N'141', NULL, N'412589741   ', N'RW', CAST(N'2015-12-01' AS Date), CAST(N'2015-08-15' AS Date), N'RW', N'dmajewska', N'd.majewska', 45, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (56, N'Bogumił', N'Olszewski', N'77082812610', N'b.olszewski@o2.pl', N'Gliwice', N'Strażacka', N'18', N'10', N'514879478   ', N'RW', CAST(N'2015-03-05' AS Date), CAST(N'2015-04-06' AS Date), N'RW', N'bolszewski', N'b.olszewski', 49, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (57, N'Iwona', N'Wieczorek', N'88042714432', N'i.wieczorek@gmail.com', N'Katowice', N'Powstańsów', N'75', N'20', N'673518366   ', N'RW', CAST(N'2015-10-20' AS Date), CAST(N'2015-06-14' AS Date), N'MR', N'iwieczorek', N'i.wieczorek', 48, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (58, N'Elżbieta', N'Dąbrowska', N'84051435280', N'e.dabrawska@o2.pl', N'Świętochłowice', N'Bohaterów Warszawy', N'30', N'19', N'727008505   ', N'KZ', NULL, CAST(N'2015-10-12' AS Date), NULL, N'e.dabrawska', N'e.dabrawska', 50, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (59, N'Amadeusz', N'Adamski', N'82072478670', N'a.adamski@wp.pl', N'Bytom', N'Podjazdowa', N'118', NULL, N'693372247   ', N'KSR', CAST(N'2015-12-02' AS Date), CAST(N'2015-06-14' AS Date), N'SRW', N'aadamski', N'a.adamski', 51, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (61, N'Patryk', N'Wysocki', N'87080942197', N'p.wysocki@onet.pl', N'Będzin', N'Słupecka', N'15', N'6', N'602556453   ', N'RW', CAST(N'2015-04-12' AS Date), CAST(N'2015-05-14' AS Date), N'I', N'pwysocki', N'p.wysocki', 52, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (62, N'Zofia', N'Grabowska', N'90020216229', N'z.grabowska@onet.pl', N'Katowice', N'Powstańców', N'102', NULL, N'788946568   ', N'RW', CAST(N'2015-06-30' AS Date), CAST(N'2015-08-19' AS Date), N'MI', N'zgrabowska', N'z.grabowska', 53, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (63, N'Radosław', N'Maciejewski', N'90080815034', N'r.maciejewski@gmail.com', N'Ruda Śląska', N'Sanocka', N'43', N'10', N'887215364   ', N'RW', CAST(N'2015-10-01' AS Date), CAST(N'2015-09-02' AS Date), N'RW', N'rmaciejewski', N'r.maciejewski', 54, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (64, N'Adam', N'Romański', N'91082610283', N'adamadam@o2.pl', N'Łódź', N'Wyszyńskiego', N'5', N'0', N'+48500500500', N'RW', CAST(N'2015-02-28' AS Date), CAST(N'2015-03-20' AS Date), N'RW', N'adam.romański', N'TsAkHob5cA', 56, N'U', N'f', N'f', N'f')
SET IDENTITY_INSERT [dbo].[Pracownik] OFF
SET IDENTITY_INSERT [dbo].[Stanowisko] ON 

INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (1, N'S 1', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (2, N'S 2', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (3, N'S 3', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (4, N'S 4', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (5, N'S 5', N'S', 1)
SET IDENTITY_INSERT [dbo].[Stanowisko] OFF
SET IDENTITY_INSERT [dbo].[Umowa] ON 

INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (2, N'UOP', 160, CAST(N'2014-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (3, N'UOP', 160, CAST(N'2014-06-01' AS Date), CAST(N'2050-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (4, N'UOP', 160, CAST(N'2014-11-01' AS Date), CAST(N'2050-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (8, N'UOP', 120, CAST(N'2014-07-01' AS Date), CAST(N'2015-06-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (9, N'UZ', NULL, CAST(N'2014-01-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (10, N'UZ', NULL, CAST(N'2014-02-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (11, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (12, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (13, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-12-31' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (15, N'UOP', 80, CAST(N'2014-11-01' AS Date), CAST(N'2015-05-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (16, N'UOP', 160, CAST(N'2014-10-30' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (19, N'UOP', 160, CAST(N'2014-01-01' AS Date), CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (20, N'UOP', 160, CAST(N'2014-11-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (21, N'UOP', 160, CAST(N'2014-10-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (22, N'UOP', 120, CAST(N'2014-12-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (23, N'UOP', 120, CAST(N'2014-08-30' AS Date), CAST(N'2016-09-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (24, N'UOP', 80, CAST(N'2014-05-01' AS Date), CAST(N'2015-05-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (25, N'UOP', 80, CAST(N'2014-06-01' AS Date), CAST(N'2015-12-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (26, N'UZ', NULL, CAST(N'2014-01-01' AS Date), CAST(N'2015-10-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (27, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (28, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (29, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-10-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (30, N'UZ', NULL, CAST(N'2014-09-01' AS Date), CAST(N'2015-09-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (31, N'UZ', NULL, CAST(N'2014-08-01' AS Date), CAST(N'2015-08-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (32, N'UZ', NULL, CAST(N'2014-07-01' AS Date), CAST(N'2015-07-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (33, N'UZ', NULL, CAST(N'2014-06-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (34, N'UZ', NULL, CAST(N'2014-05-01' AS Date), CAST(N'2015-05-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (35, N'UZ', NULL, CAST(N'2014-04-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (36, N'UZ', NULL, CAST(N'2014-08-01' AS Date), CAST(N'2014-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (37, N'UZ', NULL, CAST(N'2014-09-01' AS Date), CAST(N'2015-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (38, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (39, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (40, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (41, N'UZ', NULL, CAST(N'2015-01-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (42, N'UOP', 160, CAST(N'2015-02-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (43, N'UOP', 160, CAST(N'2015-05-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (44, N'UOP', 160, CAST(N'2015-02-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (45, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (48, N'UZ', NULL, CAST(N'2015-01-25' AS Date), CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (49, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (50, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (51, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (52, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2018-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (53, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (54, N'UZ', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (55, N'UOP', 160, CAST(N'2015-01-25' AS Date), CAST(N'2016-12-24' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (56, N'UOP', 156, CAST(N'2015-01-26' AS Date), CAST(N'2015-03-27' AS Date))
SET IDENTITY_INSERT [dbo].[Umowa] OFF
ALTER TABLE [dbo].[Godziny_pracy]  WITH CHECK ADD  CONSTRAINT [FKGodziny-Pracownik] FOREIGN KEY([ID_pracownika])
REFERENCES [dbo].[Pracownik] ([ID_p])
GO
ALTER TABLE [dbo].[Godziny_pracy] CHECK CONSTRAINT [FKGodziny-Pracownik]
GO
ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [FKNotatkaKSR-Pracownik] FOREIGN KEY([ID_KSR])
REFERENCES [dbo].[Pracownik] ([ID_p])
GO
ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [FKNotatkaKSR-Pracownik]
GO
ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [FKNotatkaKZ-Pracownik] FOREIGN KEY([ID_KZ])
REFERENCES [dbo].[Pracownik] ([ID_p])
GO
ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [FKNotatkaKZ-Pracownik]
GO
ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [FKNotatka-pracownik] FOREIGN KEY([ID_R])
REFERENCES [dbo].[Pracownik] ([ID_p])
GO
ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [FKNotatka-pracownik]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [FKPracownik-Umowa] FOREIGN KEY([ID_umowy])
REFERENCES [dbo].[Umowa] ([ID_u])
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [FKPracownik-Umowa]
GO
ALTER TABLE [dbo].[Otwarcie_stanowiska]  WITH CHECK ADD  CONSTRAINT [CK_Otwarcie_stan] CHECK  (([Typ_dnia]='Z' OR [Typ_dnia]='WS' OR [Typ_dnia]='R'))
GO
ALTER TABLE [dbo].[Otwarcie_stanowiska] CHECK CONSTRAINT [CK_Otwarcie_stan]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_umowa]='f' OR [Ostrzezenie_umowa]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_KPP]='f' OR [Ostrzezenie_KPP]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_badania]='f' OR [Ostrzezenie_badania]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_umowa]='f' OR [Ostrzezenie_umowa]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_KPP]='f' OR [Ostrzezenie_KPP]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_badania]='f' OR [Ostrzezenie_badania]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_umowa]='f' OR [Ostrzezenie_umowa]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_KPP]='f' OR [Ostrzezenie_KPP]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Ostrzezenie_badania]='f' OR [Ostrzezenie_badania]='t'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__1CF15040] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__1CF15040]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__2D27B809] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__2D27B809]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__4AB81AF0] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__4AB81AF0]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__5DCAEF64] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__5DCAEF64]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__5EBF139D] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__5EBF139D]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stano__5FB337D6] CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stano__5FB337D6]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__1DE57479] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__1DE57479]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__2E1BDC42] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__2E1BDC42]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__4BAC3F29] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__4BAC3F29]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__60A75C0F] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__60A75C0F]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__619B8048] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__619B8048]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Stopi__628FA481] CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Stopi__628FA481]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Typ_k__4CA06362] CHECK  (([Typ_konta]='U' OR [Typ_konta]='A'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Typ_k__4CA06362]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [CK__Pracownik__Typ_k__6383C8BA] CHECK  (([Typ_konta]='U' OR [Typ_konta]='A'))
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [CK__Pracownik__Typ_k__6383C8BA]
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
USE [master]
GO
ALTER DATABASE [aquadrom] SET  READ_WRITE 
GO
