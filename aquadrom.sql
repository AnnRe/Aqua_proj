USE [master]
GO
/****** Object:  Database [aquadrom]    Script Date: 2015-01-25 11:57:58 ******/
CREATE DATABASE [aquadrom] ON  PRIMARY 
( NAME = N'aquadrom', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\aquadrom.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'aquadrom_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\aquadrom_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
USE [aquadrom]
GO
/****** Object:  Table [dbo].[Godziny_pracy]    Script Date: 2015-01-25 11:57:58 ******/
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
/****** Object:  Table [dbo].[Notatka]    Script Date: 2015-01-25 11:57:58 ******/
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
	[Akceptacja_KZ] [bit] NOT NULL,
	[Akceptacja_KSR] [bit] NOT NULL,
	[ID_R] [int] NULL,
	[ID_KZ] [int] NOT NULL,
	[ID_KSR] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_n] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Otwarcie_stanowiska]    Script Date: 2015-01-25 11:57:58 ******/
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
/****** Object:  Table [dbo].[Pracownik]    Script Date: 2015-01-25 11:57:58 ******/
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
	[Typ_konta] [nchar](1) NULL,
 CONSTRAINT [PK__Pracowni__B87EA53C0AD2A005] PRIMARY KEY CLUSTERED 
(
	[ID_p] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stanowisko]    Script Date: 2015-01-25 11:57:58 ******/
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
/****** Object:  Table [dbo].[Umowa]    Script Date: 2015-01-25 11:57:58 ******/
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

INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (2, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (3, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (6, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (8, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (10, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (11, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (13, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (15, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (16, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (17, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (18, CAST(0x0000A4320107AC00 AS DateTime), CAST(0x0000A432016A8C80 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (19, CAST(0x0000A4320107AC00 AS DateTime), CAST(0x0000A432016A8C80 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (20, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (21, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (23, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (25, CAST(0x0000A4330083D600 AS DateTime), CAST(0x0000A4330107AC00 AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (26, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A43200E6B680 AS DateTime), 27)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (27, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (29, CAST(0x0000A4330083D600 AS DateTime), CAST(0x0000A4330107AC00 AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (30, CAST(0x0000A4330083D600 AS DateTime), CAST(0x0000A4330107AC00 AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (31, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (32, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (33, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (34, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (35, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (36, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (37, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (38, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (39, CAST(0x0000A4320107AC00 AS DateTime), CAST(0x0000A432016A8C80 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (40, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (41, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (42, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (43, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (44, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (45, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (46, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (47, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (48, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (49, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (50, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (51, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (52, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (53, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (54, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (55, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (56, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (57, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (58, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (59, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (60, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (61, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (62, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (63, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (64, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (65, CAST(0x0000A4320107AC00 AS DateTime), CAST(0x0000A432016A8C80 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (66, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (67, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (68, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (69, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (70, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (71, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (72, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (73, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (74, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (75, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (76, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (77, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (78, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (79, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (80, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (81, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (82, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (83, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (84, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (85, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (86, CAST(0x0000A4320083D600 AS DateTime), CAST(0x0000A4320107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (87, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (88, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (89, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (90, CAST(0x0000A43300E6B680 AS DateTime), CAST(0x0000A433016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (91, CAST(0x0000A4320107AC00 AS DateTime), CAST(0x0000A432016A8C80 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (92, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (93, CAST(0x0000A43300C5C100 AS DateTime), CAST(0x0000A43301499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (94, CAST(0x0000A4330083D600 AS DateTime), CAST(0x0000A4330107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (95, CAST(0x0000A4340083D600 AS DateTime), CAST(0x0000A4340107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (96, CAST(0x0000A4350083D600 AS DateTime), CAST(0x0000A4350107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (97, CAST(0x0000A4360083D600 AS DateTime), CAST(0x0000A4360107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (98, CAST(0x0000A43A00E6B680 AS DateTime), CAST(0x0000A43A016A8C80 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (99, CAST(0x0000A43B00E6B680 AS DateTime), CAST(0x0000A43B016A8C80 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (100, CAST(0x0000A43C00E6B680 AS DateTime), CAST(0x0000A43C016A8C80 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (101, CAST(0x0000A43D0083D600 AS DateTime), CAST(0x0000A43D0107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (102, CAST(0x0000A43E0083D600 AS DateTime), CAST(0x0000A43E0107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (103, CAST(0x0000A4410083D600 AS DateTime), CAST(0x0000A4410107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (104, CAST(0x0000A4420083D600 AS DateTime), CAST(0x0000A4420107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (105, CAST(0x0000A4430083D600 AS DateTime), CAST(0x0000A4430107AC00 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (106, CAST(0x0000A44400A4CB80 AS DateTime), CAST(0x0000A4440128A180 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (107, CAST(0x0000A44700A4CB80 AS DateTime), CAST(0x0000A4470128A180 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (108, CAST(0x0000A4480083D600 AS DateTime), CAST(0x0000A44800E6B680 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (109, CAST(0x0000A4490083D600 AS DateTime), CAST(0x0000A44900E6B680 AS DateTime), 2)
GO
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (110, CAST(0x0000A44A0083D600 AS DateTime), CAST(0x0000A44A00E6B680 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (111, CAST(0x0000A44B0083D600 AS DateTime), CAST(0x0000A44B00E6B680 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (112, CAST(0x0000A44C00E6B680 AS DateTime), CAST(0x0000A44C016A8C80 AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (113, CAST(0x0000A43400E6B680 AS DateTime), CAST(0x0000A434016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (114, CAST(0x0000A43500E6B680 AS DateTime), CAST(0x0000A435016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (115, CAST(0x0000A43600E6B680 AS DateTime), CAST(0x0000A436016A8C80 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (116, CAST(0x0000A4370083D600 AS DateTime), CAST(0x0000A4370107AC00 AS DateTime), 4)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (117, CAST(0x0000A4330083D600 AS DateTime), CAST(0x0000A43300E6B680 AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (118, CAST(0x0000A4340107AC00 AS DateTime), CAST(0x0000A43401499700 AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (119, CAST(0x0000A4350083D600 AS DateTime), CAST(0x0000A43500E6B680 AS DateTime), 8)
SET IDENTITY_INSERT [dbo].[Godziny_pracy] OFF
SET IDENTITY_INSERT [dbo].[Notatka] ON 

INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (1, N'Jedna z osób kąpiących się zasłabła przed wejściem do basenu.', CAST(0x0000A41C00000000 AS DateTime), N'Zasłabnięcie', N'brak', 1, 1, 2, 48, 4)
SET IDENTITY_INSERT [dbo].[Notatka] OFF
SET IDENTITY_INSERT [dbo].[Otwarcie_stanowiska] ON 

INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (2, CAST(0x070040230E430000 AS Time), CAST(0x0700F0E066B80000 AS Time), N'R', 1)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (3, CAST(0x0700B0BD58750000 AS Time), CAST(0x0700F0E066B80000 AS Time), N'R', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (4, CAST(0x070040230E430000 AS Time), CAST(0x0700B0BD58750000 AS Time), N'Z', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (5, CAST(0x070040230E430000 AS Time), CAST(0x0700E03495640000 AS Time), N'Z', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (6, CAST(0x0700E03495640000 AS Time), CAST(0x0700F0E066B80000 AS Time), N'R', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (7, CAST(0x070040230E430000 AS Time), CAST(0x0700B0BD58750000 AS Time), N'R', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (8, CAST(0x070080461C860000 AS Time), CAST(0x07002058A3A70000 AS Time), N'R', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (9, CAST(0x07002058A3A70000 AS Time), CAST(0x0700F0E066B80000 AS Time), N'Z', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (10, CAST(0x070080461C860000 AS Time), CAST(0x0700F0E066B80000 AS Time), N'R', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (11, CAST(0x070040230E430000 AS Time), CAST(0x070080461C860000 AS Time), N'Z', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (12, CAST(0x070010ACD1530000 AS Time), CAST(0x07002058A3A70000 AS Time), N'WS', 1)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (13, CAST(0x070010ACD1530000 AS Time), CAST(0x07002058A3A70000 AS Time), N'WS', 2)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (14, CAST(0x07001882BA7D0000 AS Time), CAST(0x07002058A3A70000 AS Time), N'WS', 3)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (15, CAST(0x0700B0BD58750000 AS Time), CAST(0x070050CFDF960000 AS Time), N'WS', 4)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (16, CAST(0x070010ACD1530000 AS Time), CAST(0x0700E03495640000 AS Time), N'WS', 5)
INSERT [dbo].[Otwarcie_stanowiska] ([ID_o], [Od], [Do], [Typ_dnia], [ID_stanowiska]) VALUES (17, CAST(0x070050CFDF960000 AS Time), CAST(0x07002058A3A70000 AS Time), N'WS', 5)
SET IDENTITY_INSERT [dbo].[Otwarcie_stanowiska] OFF
SET IDENTITY_INSERT [dbo].[Pracownik] ON 

INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (1, N'Mateusz', N'Ogiermann', N'93031269578', N'ogipierogi@gmail.com', N'Ruda Śląska', N'Szczecińska', N'15', N'7', N'502145897   ', N'RW', CAST(0x913B0B00 AS Date), CAST(0x733B0B00 AS Date), N'MR', N'ogipierogi', N'm.ogiermann', 12, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (2, N'Jan', N'Kowalski', N'85041265478', N'j.kowalski@gmail.com', N'Katowice', N'3 Maja', N'10', N'4', N'603178954   ', N'KSR', CAST(0xA5390B00 AS Date), CAST(0xE5390B00 AS Date), N'SRW', N'jkowalski', N'j.kowalski', 2, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (4, N'Piotr', N'Nowak', N'80050645987', N'p.nowak@gmail.com', N'Ruda Śląska', N'Akademicka', N'5', N'3', N'604125269   ', N'KSR', CAST(0xB7390B00 AS Date), CAST(0xB2390B00 AS Date), N'MI', N'pnowak', N'p.nowak', 3, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (5, N'Andrzej', N'Zieliński', N'84110242985', N'a.ziel@gmail.com', N'Ruda Śląska', N'Szymanowskiego', N'56', N'10', N'798153469   ', N'KSR', CAST(0xA23A0B00 AS Date), CAST(0x483A0B00 AS Date), N'MR', N'azielinski', N'a.zielinski', 4, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (6, N'Paulina', N'Kaczmarek', N'90120845137', N'p.kaczmarek@wp.pl', N'Bytom', N'Ogrodowa', N'40', NULL, N'665125894   ', N'KSR', CAST(0x5F3A0B00 AS Date), CAST(0x6E3A0B00 AS Date), N'RW', N'pkaczmarek', N'p.kaczmarek', 9, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (7, N'Ernest', N'Maciejewski', N'81113012954', N'e.maciej@o2.pl', N'Zabrze', N'Parkowa', N'13', NULL, N'889632177   ', N'RW', CAST(0x703A0B00 AS Date), CAST(0x923A0B00 AS Date), N'IW', N'emaciejewski', N'e.maciejewski', 8, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (8, N'Agata', N'Musiał', N'86040347629', N'a.musial@onet.pl', N'Ruda Śląska', N'Sienkiewicza', N'15', N'4', N'605487300   ', N'RW', CAST(0xBC3A0B00 AS Date), CAST(0xBB3A0B00 AS Date), N'I', N'amusial', N'a.musial', 15, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (9, N'Michał', N'Ziętek', N'79030214598', N'zietek@michal.pl', N'Świętochłowice', N'Opolska', N'10', NULL, N'512487501   ', N'RW', CAST(0x4F3A0B00 AS Date), CAST(0x083A0B00 AS Date), N'MI', N'mzietek', N'm.zietek', 16, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (11, N'Barbara', N'Dudek', N'91020541869', N'bdudek91@gmail.com', N'Ruda Śląska', N'Katowicka', N'34', N'5', N'664178244   ', N'RW', CAST(0x5F3A0B00 AS Date), CAST(0x083A0B00 AS Date), N'SRW', N'bdudek', N'b.dudek', 19, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (12, N'Jarosław', N'Kasza', N'75041254329', N'kasza123456@o2.pl', N'Bytom', N'Karpacka', N'19', N'7', N'789526133   ', N'RW', CAST(0x6E3A0B00 AS Date), CAST(0x523A0B00 AS Date), N'RW', N'jkasza', N'j.kasza', 20, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (13, N'Ewelina', N'Janowska', N'79020545612', N'ejanowska@wp.pl', N'Ruda Śląska', N'Biskupia', N'20A', N'15', N'604148952   ', N'RW', CAST(0x4F390B00 AS Date), CAST(0x8B390B00 AS Date), N'MR', N'ejanowska', N'e.janowska', 21, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (14, N'Marek', N'Stasiak', N'87070845312', N'mstasiak@gmail.com', N'Chorzów', N'Graniczna', N'15', N'23', N'513489655   ', N'RW', CAST(0x8B390B00 AS Date), CAST(0x9B390B00 AS Date), N'IW', N'mstasiak', N'm.stasiak', 22, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (17, N'Katarzyna', N'Wencel', N'89080514569', N'kwencel@wp.pl', N'Katowice', N'Francuska', N'19', N'25', N'606598175   ', N'RW', CAST(0x9A390B00 AS Date), CAST(0x833A0B00 AS Date), N'I', N'kwencel', N'k.wencel', 23, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (18, N'Adrian', N'Iwanowski', N'76101056461', N'adi.iwan@wp.pl', N'Ruda Śląska', N'Hutnicza', N'20', NULL, N'514879546   ', N'RW', CAST(0x093A0B00 AS Date), CAST(0x93390B00 AS Date), N'MI', N'aiwanowski', N'a.iwanowski', 24, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (19, N'Anna', N'Boroń-Kowalska', N'74010245689', N'boron-kowalska@gmial.com', N'Zabrze', N'Jordana', N'10', N'15', N'548984235   ', N'RW', CAST(0xA83A0B00 AS Date), CAST(0xBE3A0B00 AS Date), N'SRW', N'aboronkowalska', N'a.boronkowalska', 25, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (23, N'Piotr', N'Szadkowski', N'88252445465', N'szadkowski.piotr@gmail.com', N'Ruda Śląska', N'Bulwarowa', N'45', N'7', N'651658564   ', N'RW', CAST(0x6E390B00 AS Date), CAST(0x8A3A0B00 AS Date), N'RW', N'pszadkowski', N'p.szadkowski', 10, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (24, N'Ewa', N'Nowok', N'92121465786', N'ewanowok@wp.pl', N'Gliwice', N'Pszczyńska', N'50', N'24', N'516516545   ', N'RW', CAST(0x45380B00 AS Date), CAST(0x133A0B00 AS Date), N'IW', N'enowok', N'ewa.nowok', 11, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (25, N'Agata', N'Szymańska', N'91052946548', N'agataszym@o2.pl', N'Ruda Śląska', N'Bulwarowa', N'50', N'19', N'564845465   ', N'RW', CAST(0x0B3A0B00 AS Date), CAST(0x683A0B00 AS Date), N'IW', N'aszymanska', N'a.szymanska', 13, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (26, N'Sylwia', N'Szczepanek', N'87121419849', N'szczepaneksylwia@gmail.com', N'Ruda Śląska', N'Prusa', N'10', NULL, N'816545664   ', N'RW', CAST(0xC33A0B00 AS Date), CAST(0x453A0B00 AS Date), N'I', N'sszczepanek', N's.szczepanek', 26, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (27, N'Sebastian', N'Zuber', N'89121448987', N'sebazuber@wp.pl', N'Ruda Śląska', N'Jagiellońska', N'14', N'35', N'816547988   ', N'RW', CAST(0x693A0B00 AS Date), CAST(0x2A3A0B00 AS Date), N'MI', N'szuber', N's.zuber', 27, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (28, N'Krzysztof', N'Czapla', N'90070945498', N'czaplak@gmail.com', N'Gliwice', N'Górnych Wałów', N'15', N'17', N'655153168   ', N'RW', CAST(0x9C3A0B00 AS Date), CAST(0x7B3A0B00 AS Date), N'SRW', N'kczapla', N'k.czapla', 28, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (29, N'Mariusz', N'Krawczyk', N'88063021466', N'mariokrawczyk@onet.pl', N'Ruda Śląska', N'Szermierzy', N'6', NULL, N'546545468   ', N'RW', CAST(0x573A0B00 AS Date), CAST(0xF3390B00 AS Date), N'RW', N'mkrawczyk', N'm.krawczyk', 29, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (30, N'Dorota', N'Salomon', N'79041951688', N'salomondoro@wp.pl', N'Ruda Śląska', N'Racjonalizatorów', N'15', N'3', N'489784654   ', N'RW', CAST(0x733A0B00 AS Date), CAST(0x9B390B00 AS Date), N'RW', N'dsalomon', N'd.salomon', 30, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (31, N'Małgorzata', N'Szewczyk', N'86021468987', N'gosiaszewczyk@gmail.com', N'Ruda Śląska', N'Rubinowa', N'16C', N'2', N'484985465   ', N'RW', CAST(0x0C3A0B00 AS Date), CAST(0x80390B00 AS Date), N'MR', N'mszewczyk', N'mszewczyk', 31, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (32, N'Eryk', N'Dankowski', N'90031746879', N'dankowskieryk@wp.pl', N'Ruda Śląska', N'Patriotów', N'10', N'16', N'565979745   ', N'RW', CAST(0x2C3A0B00 AS Date), CAST(0x5D3A0B00 AS Date), N'IW', N'edankowski', N'e.dankowski', 32, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (33, N'Andrzej', N'Siewior', N'90120645648', N'andisiewior@o2.pl', N'Ruda Śląska', N'Szewczyka', N'16', N'4', N'656589455   ', N'RW', CAST(0x563A0B00 AS Date), CAST(0x683A0B00 AS Date), N'I', N'asiewior', N'a.siewior', 33, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (34, N'Kamil', N'Woźny', N'91070954689', N'kwozny@wp.pl', N'Ruda Śląska', N'Kościelna', N'15', N'12', N'654868987   ', N'RW', CAST(0x763A0B00 AS Date), CAST(0x833A0B00 AS Date), N'MI', N'kwozny', N'k.wozny', 34, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (35, N'Ireneusz', N'Napiórkowski', N'87122856989', N'ireknapior@o2.pl', N'Ruda Śląska', N'Wspólna', N'19', NULL, N'656498878   ', N'RW', CAST(0x9B3A0B00 AS Date), CAST(0x7F3A0B00 AS Date), N'SRW', N'inapiorkowski', N'i.napiorkowski', 35, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (36, N'Patrycja', N'Siewior', N'85110665984', N'psiewior@o2.pl', N'Ruda Śląska', N'Sztandarowa', N'20', N'15', N'654984123   ', N'RW', CAST(0x6E3A0B00 AS Date), CAST(0x4E3A0B00 AS Date), N'RW', N'psiewior', N'p.siewior', 36, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (37, N'Stefania', N'Dzwonek', N'90111765214', N'stefadzwonek@gmail.com', N'Ruda Śląska', N'Szewczyka', N'21', N'30', N'889424651   ', N'RW', CAST(0x713A0B00 AS Date), CAST(0x903A0B00 AS Date), N'MR', N'sdzwonek', N's.dzwonek', 37, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (39, N'Natalia', N'Strycharz', N'91121365935', N'natastrycharz@gmail.com', N'Ruda Śląska', N'Reymonta', N'30', NULL, N'564231599   ', N'RW', CAST(0xE8390B00 AS Date), CAST(0x0B3A0B00 AS Date), N'IW', N'nstrycharz', N'n.strycharz', 38, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (40, N'Bartosz', N'Topolski', N'90030265498', N'bartopolski@wp.pl', N'Ruda Śląska', N'Kochanowskiego', N'9', N'12', N'561261348   ', N'RW', CAST(0xB2390B00 AS Date), CAST(0x503A0B00 AS Date), N'I', N'btopolski', N'b.topolski', 39, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (41, N'Maria', N'Bednarz', N'81052954896', N'marysiab@gmail.com', N'Ruda Śląska', N'Wiązowa', N'10', N'47', N'956484534   ', N'RW', CAST(0xEE390B00 AS Date), CAST(0x0E3A0B00 AS Date), N'MI', N'mbednarz', N'm.bednarz', 40, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (45, N'Szymon', N'Kosmala', N'83061451689', N'szymon.kosmala@wp.pl', N'Ruda Śląska', N'Jasna', N'13', NULL, N'890517564   ', N'RW', CAST(0x903A0B00 AS Date), CAST(0xB7390B00 AS Date), N'RW', N'skosmala', N's.kosmala', 41, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (46, N'Marta', N'Kaliszewska', N'90021545498', N'mkalisz@gmail.com', N'Świętochłowice', N'Szarych Szeregów', N'25', N'10', N'545468989   ', N'KZ', NULL, CAST(0xBC3A0B00 AS Date), NULL, N'mkaliszewska', N'm.kaliszewska', 42, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (47, N'Jan', N'Jeziorański', N'76093065985', N'jan.jezioraski@gmail.com', N'Ruda Śląska', N'Bojkowska', N'19', N'5', N'546189745   ', N'KZ', NULL, CAST(0xA73A0B00 AS Date), NULL, N'jjezioraski', N'j.jezioranski', 43, N'u')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta]) VALUES (48, N'Marcin', N'Chrzanowski', N'89021054899', N'm.chrzanowski@wp.pl', N'Bytom', N'Główna', N'52', N'7', N'546187986   ', N'KZ', NULL, CAST(0xCD390B00 AS Date), NULL, N'mchrzanowski', N'm.chrzanowski', 44, N'u')
SET IDENTITY_INSERT [dbo].[Pracownik] OFF
SET IDENTITY_INSERT [dbo].[Stanowisko] ON 

INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (1, N'S 1', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (2, N'S 2', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (3, N'S 3', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (4, N'S 4', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (5, N'S 5', N'S', 1)
SET IDENTITY_INSERT [dbo].[Stanowisko] OFF
SET IDENTITY_INSERT [dbo].[Umowa] ON 

INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (2, N'UOP', 160, CAST(0x01380B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (3, N'UOP', 160, CAST(0x98380B00 AS Date), CAST(0xF56B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (4, N'UOP', 160, CAST(0x31390B00 AS Date), CAST(0x8E6C0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (8, N'UOP', 120, CAST(0xB6380B00 AS Date), CAST(0x223A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (9, N'UZ', NULL, CAST(0x01380B00 AS Date), CAST(0xBC3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (10, N'UZ', NULL, CAST(0x20380B00 AS Date), CAST(0xC8390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (11, N'UZ', NULL, CAST(0x31390B00 AS Date), CAST(0xA9390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (12, N'UZ', NULL, CAST(0x4F390B00 AS Date), CAST(0xA9390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (13, N'UZ', NULL, CAST(0x12390B00 AS Date), CAST(0xDA3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (15, N'UOP', 80, CAST(0x31390B00 AS Date), CAST(0xE6390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (16, N'UOP', 160, CAST(0x2F390B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (19, N'UOP', 160, CAST(0x01380B00 AS Date), CAST(0x6E390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (20, N'UOP', 160, CAST(0x31390B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (21, N'UOP', 160, CAST(0x12390B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (22, N'UOP', 120, CAST(0x4F390B00 AS Date), CAST(0x053A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (23, N'UOP', 120, CAST(0xF2380B00 AS Date), CAST(0xEC3B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (24, N'UOP', 80, CAST(0x79380B00 AS Date), CAST(0x033A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (25, N'UOP', 80, CAST(0x98380B00 AS Date), CAST(0xD93A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (26, N'UZ', NULL, CAST(0x01380B00 AS Date), CAST(0x7F3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (27, N'UZ', NULL, CAST(0x4F390B00 AS Date), CAST(0xBC3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (28, N'UZ', NULL, CAST(0x31390B00 AS Date), CAST(0x9E3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (29, N'UZ', NULL, CAST(0x12390B00 AS Date), CAST(0x7F3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (30, N'UZ', NULL, CAST(0xF4380B00 AS Date), CAST(0x613A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (31, N'UZ', NULL, CAST(0xD5380B00 AS Date), CAST(0x423A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (32, N'UZ', NULL, CAST(0xB6380B00 AS Date), CAST(0x233A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (33, N'UZ', NULL, CAST(0x98380B00 AS Date), CAST(0x053A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (34, N'UZ', NULL, CAST(0x79380B00 AS Date), CAST(0xE6390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (35, N'UZ', NULL, CAST(0x5B380B00 AS Date), CAST(0xC8390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (36, N'UZ', NULL, CAST(0xD5380B00 AS Date), CAST(0x4F390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (37, N'UZ', NULL, CAST(0xF4380B00 AS Date), CAST(0x9E3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (38, N'UZ', NULL, CAST(0x12390B00 AS Date), CAST(0xBC3A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (39, N'UZ', NULL, CAST(0x31390B00 AS Date), CAST(0xA9390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (40, N'UZ', NULL, CAST(0x4F390B00 AS Date), CAST(0xC8390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (41, N'UZ', NULL, CAST(0x6E390B00 AS Date), CAST(0x053A0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (42, N'UOP', 160, CAST(0x8D390B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (43, N'UOP', 160, CAST(0xE6390B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (44, N'UOP', 160, CAST(0x8D390B00 AS Date), CAST(0xA9390B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (45, N'UOP', 160, CAST(0x053A0B00 AS Date), CAST(0x5E6B0B00 AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (48, N'UZ', NULL, CAST(0x86390B00 AS Date), CAST(0x6E390B00 AS Date))
SET IDENTITY_INSERT [dbo].[Umowa] OFF
ALTER TABLE [dbo].[Notatka] ADD  DEFAULT ((0)) FOR [Akceptacja_KZ]
GO
ALTER TABLE [dbo].[Notatka] ADD  DEFAULT ((0)) FOR [Akceptacja_KSR]
GO
ALTER TABLE [dbo].[Pracownik] ADD  CONSTRAINT [DF__Pracownik__Typ_k__4316F928]  DEFAULT ('U') FOR [Typ_konta]
GO
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
