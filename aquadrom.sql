USE [master]
GO
/****** Object:  Database [aquadrom]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Godziny_pracy]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Notatka]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Otwarcie_stanowiska]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Pracownik]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Stanowisko]    Script Date: 2015-01-27 21:01:28 ******/
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
/****** Object:  Table [dbo].[Umowa]    Script Date: 2015-01-27 21:01:28 ******/
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
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (130, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (133, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (136, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (139, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (144, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (147, CAST(N'2015-01-01 10:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (150, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (153, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (156, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 21:00:00.000' AS DateTime), 14)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (157, CAST(N'2015-01-01 14:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 17)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (158, CAST(N'2015-01-01 15:00:00.000' AS DateTime), CAST(N'2015-01-01 17:00:00.000' AS DateTime), 18)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (159, CAST(N'2015-01-01 09:00:00.000' AS DateTime), CAST(N'2015-01-01 13:00:00.000' AS DateTime), 19)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (160, CAST(N'2015-01-01 15:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 23)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (161, CAST(N'2015-01-01 16:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 24)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (162, CAST(N'2015-01-01 17:00:00.000' AS DateTime), CAST(N'2015-01-01 20:00:00.000' AS DateTime), 25)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (163, CAST(N'2015-01-01 19:30:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 26)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (164, CAST(N'2015-01-01 19:00:00.000' AS DateTime), CAST(N'2015-01-01 22:00:00.000' AS DateTime), 27)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (189, CAST(N'2015-01-01 08:00:00.000' AS DateTime), CAST(N'2015-01-01 12:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (194, CAST(N'2015-01-04 14:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (201, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (206, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (650, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (651, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (652, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 16:00:00.000' AS DateTime), 1)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (653, CAST(N'2015-01-02 08:30:00.000' AS DateTime), CAST(N'2015-01-02 10:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (654, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (655, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (656, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (657, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (658, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (659, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (660, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (661, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (662, CAST(N'2015-01-11 08:00:00.000' AS DateTime), CAST(N'2015-01-11 22:00:00.000' AS DateTime), 2)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (665, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (666, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 5)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (667, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (668, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 6)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (669, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (670, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 7)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (671, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (672, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (673, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (674, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 16:00:00.000' AS DateTime), 8)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (675, CAST(N'2015-01-02 10:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (676, CAST(N'2015-01-03 10:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 9)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (677, CAST(N'2015-01-02 10:00:00.000' AS DateTime), CAST(N'2015-01-02 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (678, CAST(N'2015-01-03 10:00:00.000' AS DateTime), CAST(N'2015-01-03 21:00:00.000' AS DateTime), 11)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (679, CAST(N'2015-01-02 09:00:00.000' AS DateTime), CAST(N'2015-01-02 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (680, CAST(N'2015-01-03 09:00:00.000' AS DateTime), CAST(N'2015-01-03 15:00:00.000' AS DateTime), 12)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (681, CAST(N'2015-01-02 14:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (682, CAST(N'2015-01-03 14:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 13)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (683, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 22:00:00.000' AS DateTime), 14)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (684, CAST(N'2015-01-02 08:00:00.000' AS DateTime), CAST(N'2015-01-02 14:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (685, CAST(N'2015-01-03 08:00:00.000' AS DateTime), CAST(N'2015-01-03 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (686, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (687, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 46)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (688, CAST(N'2015-01-05 13:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (689, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (690, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (691, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (692, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (693, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 57)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (694, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (695, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (696, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (697, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 58)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (698, CAST(N'2015-01-04 08:00:00.000' AS DateTime), CAST(N'2015-01-04 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (699, CAST(N'2015-01-05 08:00:00.000' AS DateTime), CAST(N'2015-01-05 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (700, CAST(N'2015-01-06 08:00:00.000' AS DateTime), CAST(N'2015-01-06 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (701, CAST(N'2015-01-07 08:00:00.000' AS DateTime), CAST(N'2015-01-07 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (702, CAST(N'2015-01-08 08:00:00.000' AS DateTime), CAST(N'2015-01-08 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (703, CAST(N'2015-01-09 08:00:00.000' AS DateTime), CAST(N'2015-01-09 22:00:00.000' AS DateTime), 59)
INSERT [dbo].[Godziny_pracy] ([ID_g], [Od], [Do], [ID_pracownika]) VALUES (704, CAST(N'2015-01-10 08:00:00.000' AS DateTime), CAST(N'2015-01-10 22:00:00.000' AS DateTime), 59)
SET IDENTITY_INSERT [dbo].[Godziny_pracy] OFF
SET IDENTITY_INSERT [dbo].[Notatka] ON 

INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (2, N'', CAST(N'2015-01-25 00:00:00.000' AS DateTime), N'dassdad', NULL, 1, 1, 1, 1, 1)
INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (3, N'dsf', CAST(N'2015-01-25 00:00:00.000' AS DateTime), N'sadf', NULL, 1, 1, 1, 1, 1)
INSERT [dbo].[Notatka] ([ID_n], [Opis], [Czas], [Rodzaj_zdarzenia], [Uwagi], [Akceptacja_KZ], [Akceptacja_KSR], [ID_R], [ID_KZ], [ID_KSR]) VALUES (4, N'COs tam ', CAST(N'2015-01-25 00:00:00.000' AS DateTime), N'Wypadek', NULL, 1, 1, 2, 1, 1)
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

INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (1, N'Mateusz', N'Ogiermann', N'93031269578', N'ogipierogi@gmail.com', N'Ruda Śląska', N'Szczecińska', N'15', N'7', N'502145897   ', N'RW', CAST(N'2016-07-01' AS Date), CAST(N'2016-06-01' AS Date), N'MR', N'ogipierogi', N'cd1b4bc7558c8ffc7c93b52a19145751a2f522946572675a6d2b889c0158f878', 12, N'a', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (2, N'Jan', N'Kowalski', N'85041265478', N'j.kowalski@gmail.com', N'Katowice', N'3 Maja', N'10', N'4', N'603178954   ', N'KSR', CAST(N'2015-02-25' AS Date), CAST(N'2015-04-30' AS Date), N'SRW', N'jkowalski', N'04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', 2, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (4, N'Piotr', N'Nowak', N'80050645987', N'p.nowak@gmail.com', N'Ruda Śląska', N'Akademicka', N'5', N'3', N'604125269   ', N'KSR', CAST(N'2015-03-15' AS Date), CAST(N'2015-03-10' AS Date), N'MI', N'pnowak', N'6f5d27fe867c521f33db642c88af4c00f7fa1f745943d9e93de17ef91fce5aa8', 3, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (5, N'Andrzej', N'Zieliński', N'84110242985', N'a.ziel@gmail.com', N'Ruda Śląska', N'Szymanowskiego', N'56', N'10', N'798153469   ', N'KSR', CAST(N'2015-11-05' AS Date), CAST(N'2015-08-07' AS Date), N'MR', N'azielinski', N'495ac2e4aab0e5a55fda2f13c25b0c3877dbaa96c53f1cd25fcfc967029de251', 4, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (6, N'Paulina', N'Kaczmarek', N'90120845137', N'p.kaczmarek@wp.pl', N'Bytom', N'Ogrodowa', N'40', NULL, N'665125894   ', N'KSR', CAST(N'2015-08-30' AS Date), CAST(N'2015-09-14' AS Date), N'RW', N'pkaczmarek', N'49b448f55fb50a315ed5de59b9e0cbe6679e51f8a6352546c10b9310c2c28add', 9, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (7, N'Ernest', N'Maciejewski', N'81113012954', N'e.maciej@o2.pl', N'Zabrze', N'Parkowa', N'13', NULL, N'889632177   ', N'RW', CAST(N'2015-09-16' AS Date), CAST(N'2015-10-20' AS Date), N'IW', N'emaciejewski', N'2f021d31b397ea24ad692d3ee27a1b42cce6006ea3b719361eea52c6c335d8a6', 8, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (8, N'Agata', N'Musiał', N'86040347629', N'a.musial@onet.pl', N'Ruda Śląska', N'Sienkiewicza', N'15', N'4', N'605487300   ', N'RW', CAST(N'2015-12-01' AS Date), CAST(N'2015-11-30' AS Date), N'I', N'amusial', N'93d454d485bc73e9b0edb779a9674d23d9a62c6d03e1bf67eae9fe9449e3845d', 15, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (9, N'Michał', N'Ziętek', N'79030214598', N'zietek@michal.pl', N'Świętochłowice', N'Opolska', N'10', NULL, N'512487501   ', N'KZ', NULL, CAST(N'2015-06-04' AS Date), NULL, N'mzietek', N'13b6921c0edb2d9865b8281aa2ec5174abc4c24caae39b5d3224ce156d19ba58', 16, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (11, N'Barbara', N'Dudek', N'91020541869', N'bdudek91@gmail.com', N'Ruda Śląska', N'Katowicka', N'34', N'5', N'664178244   ', N'RW', CAST(N'2015-08-30' AS Date), CAST(N'2015-06-04' AS Date), N'SRW', N'bdudek', N'c5912b4fa9ffcfce47e12c6ba6e2449ff88d4a0c2a89bbfa6d7e03354f014fa7', 19, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (12, N'Jarosław', N'Kasza', N'75041254329', N'kasza123456@o2.pl', N'Bytom', N'Karpacka', N'19', N'7', N'789526133   ', N'RW', CAST(N'2015-09-14' AS Date), CAST(N'2015-08-17' AS Date), N'RW', N'jkasza', N'9f5dc486b698c40ecfdcbbc9c3489bc07e4bbf13691848ca8731e358a1dade68', 20, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (13, N'Ewelina', N'Janowska', N'79020545612', N'ejanowska@wp.pl', N'Ruda Śląska', N'Biskupia', N'20A', N'15', N'604148952   ', N'RW', CAST(N'2014-12-01' AS Date), CAST(N'2015-01-30' AS Date), N'MR', N'ejanowska', N'b28d1c3d3f444ee1dff43cf65f273e038cb0657f6a0effef73f8a1931e8f1dc8', 21, N'u', N'f', N't', N't')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (14, N'Marek', N'Stasiak', N'87070845312', N'mstasiak@gmail.com', N'Chorzów', N'Graniczna', N'15', N'23', N'513489655   ', N'RW', CAST(N'2015-01-30' AS Date), CAST(N'2015-02-15' AS Date), N'IW', N'mstasiak', N'fdd0398b61ae9c008e298927438e937042ecb97811a299490f1ce9f24f23006a', 22, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (17, N'Katarzyna', N'Wencel', N'89080514569', N'kwencel@wp.pl', N'Katowice', N'Francuska', N'19', N'25', N'606598175   ', N'RW', CAST(N'2015-02-14' AS Date), CAST(N'2015-10-05' AS Date), N'I', N'kwencel', N'8a05d84bdd1d926ac879f252c114d8def2b9f6f801683708578d17f0cfd7c56e', 23, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (18, N'Adrian', N'Iwanowski', N'76101056461', N'adi.iwan@wp.pl', N'Ruda Śląska', N'Hutnicza', N'20', NULL, N'514879546   ', N'RW', CAST(N'2015-06-05' AS Date), CAST(N'2015-02-07' AS Date), N'MI', N'aiwanowski', N'bc0fc2266f58d86eae993a679ce0c98dc7ce0ed64ffa0f703977871b804b67d5', 24, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (19, N'Anna', N'Boroń-Kowalska', N'74010245689', N'boron-kowalska@gmial.com', N'Zabrze', N'Jordana', N'10', N'15', N'548984235   ', N'RW', CAST(N'2015-11-11' AS Date), CAST(N'2015-12-03' AS Date), N'SRW', N'aboronkowalska', N'cf02d84a4e9753c02ce7309c7ee92ea1270e8ced83c0f2f179cb4cf4c9d1b934', 25, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (23, N'Piotr', N'Szadkowski', N'88252445465', N'szadkowski.piotr@gmail.com', N'Ruda Śląska', N'Bulwarowa', N'45', N'7', N'651658564   ', N'RW', CAST(N'2015-01-01' AS Date), CAST(N'2015-10-12' AS Date), N'RW', N'pszadkowski', N'cf3a70beb24f3ffe33f70054f25c822dfb04072cc7a6f16ba29ef8925650b538', 10, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (24, N'Ewa', N'Nowok', N'92121465786', N'ewanowok@wp.pl', N'Gliwice', N'Pszczyńska', N'50', N'24', N'516516545   ', N'RW', CAST(N'2014-03-10' AS Date), CAST(N'2015-06-15' AS Date), N'IW', N'enowok', N'67c41fe1af73141db7ba79fb0f0225d264c7e5f1e7b60c518e92c577865c83f0', 11, N'u', N'f', N't', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (25, N'Agata', N'Szymańska', N'91052946548', N'agataszym@o2.pl', N'Ruda Śląska', N'Bulwarowa', N'50', N'19', N'564845465   ', N'RW', CAST(N'2015-06-07' AS Date), CAST(N'2015-09-08' AS Date), N'IW', N'aszymanska', N'303719df128fdd85dbb0e2eec7f821a1e4bc887df5c70e3142c123f278cfda8a', 13, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (26, N'Sylwia', N'Szczepanek', N'87121419849', N'szczepaneksylwia@gmail.com', N'Ruda Śląska', N'Prusa', N'10', NULL, N'816545664   ', N'RW', CAST(N'2015-12-08' AS Date), CAST(N'2015-08-04' AS Date), N'I', N'sszczepanek', N'9a9bc884e26ff82780fe47a4d43aaa90b11751f5c0f64589004431b7236b6911', 26, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (27, N'Sebastian', N'Zuber', N'89121448987', N'sebazuber@wp.pl', N'Ruda Śląska', N'Jagiellońska', N'14', N'35', N'816547988   ', N'RW', CAST(N'2015-09-09' AS Date), CAST(N'2015-07-08' AS Date), N'MI', N'szuber', N'9f120d748ac1fd9c419da6549ac35aa4214c2165bad8d6a60c78635f52ceab63', 27, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (28, N'Krzysztof', N'Czapla', N'90070945498', N'czaplak@gmail.com', N'Gliwice', N'Górnych Wałów', N'15', N'17', N'655153168   ', N'RW', CAST(N'2015-10-30' AS Date), CAST(N'2015-09-27' AS Date), N'SRW', N'kczapla', N'c3b761181ce9d69f142876c0811156c6ae057faada54375d1ab16af61200b7ff', 28, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (29, N'Mariusz', N'Krawczyk', N'88063021466', N'mariokrawczyk@onet.pl', N'Ruda Śląska', N'Szermierzy', N'6', NULL, N'546545468   ', N'RW', CAST(N'2015-08-22' AS Date), CAST(N'2015-05-14' AS Date), N'RW', N'mkrawczyk', N'003818d82081db2a925a1c6781a32e50cea116803b730b24d8aba0ff9ca33d92', 29, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (30, N'Dorota', N'Salomon', N'79041951688', N'salomondoro@wp.pl', N'Ruda Śląska', N'Racjonalizatorów', N'15', N'3', N'489784654   ', N'RW', CAST(N'2015-09-19' AS Date), CAST(N'2015-02-15' AS Date), N'RW', N'dsalomon', N'70c9697fe4e9d0c7e8dd1803c0e6f2d94f4ec7509b01583e3b68a7fe91e39721', 30, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (31, N'Małgorzata', N'Szewczyk', N'86021468987', N'gosiaszewczyk@gmail.com', N'Ruda Śląska', N'Rubinowa', N'16C', N'2', N'484985465   ', N'RW', CAST(N'2015-06-08' AS Date), CAST(N'2015-01-19' AS Date), N'MR', N'mszewczyk', N'3b38e058ae1358efe650e72b5f3f45f93e61faf8432703e7e4143d06810baba4', 31, N'u', N'f', N'f', N't')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (32, N'Eryk', N'Dankowski', N'90031746879', N'dankowskieryk@wp.pl', N'Ruda Śląska', N'Patriotów', N'10', N'16', N'565979745   ', N'RW', CAST(N'2015-07-10' AS Date), CAST(N'2015-08-28' AS Date), N'IW', N'edankowski', N'56c7b692e55c23d2d3d1b227873dc8ac093a2e50d305bd52e8978549ba8149c9', 32, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (33, N'Andrzej', N'Siewior', N'90120645648', N'andisiewior@o2.pl', N'Ruda Śląska', N'Szewczyka', N'16', N'4', N'656589455   ', N'RW', CAST(N'2015-08-21' AS Date), CAST(N'2015-09-08' AS Date), N'I', N'asiewior', N'f7c3c944c3cc82eef70a0dc7b5746a23a449ff8b57b6bd0c170cdf41562a0ae7', 33, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (34, N'Kamil', N'Woźny', N'91070954689', N'kwozny@wp.pl', N'Ruda Śląska', N'Kościelna', N'15', N'12', N'654868987   ', N'RW', CAST(N'2015-09-22' AS Date), CAST(N'2015-10-05' AS Date), N'MI', N'kwozny', N'55678387b77db9fc06fb76733b56ac6df19c5f79439a6313313afda22eca8886', 34, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (35, N'Ireneusz', N'Napiórkowski', N'87122856989', N'ireknapior@o2.pl', N'Ruda Śląska', N'Wspólna', N'19', NULL, N'656498878   ', N'RW', CAST(N'2015-10-29' AS Date), CAST(N'2015-10-01' AS Date), N'SRW', N'inapiorkowski', N'a41ad52a5d948c59ffebe5b50813f7437f531c380755c7135f64cf54c9b1647a', 35, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (36, N'Patrycja', N'Siewior', N'85110665984', N'psiewior@o2.pl', N'Ruda Śląska', N'Sztandarowa', N'20', N'15', N'654984123   ', N'RW', CAST(N'2015-09-14' AS Date), CAST(N'2015-08-13' AS Date), N'RW', N'psiewior', N'30542a3ddf3121faeb2fc3f5c36c95da2ccb003b00eac57e1d56941f482ba927', 36, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (37, N'Stefania', N'Dzwonek', N'90111765214', N'stefadzwonek@gmail.com', N'Ruda Śląska', N'Szewczyka', N'21', N'30', N'889424651   ', N'RW', CAST(N'2015-09-17' AS Date), CAST(N'2015-10-18' AS Date), N'MR', N'sdzwonek', N'c635014643c6fd7f80764f55866c8841d7874d5c7a456cde2723294765b442cc', 37, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (39, N'Natalia', N'Strycharz', N'91121365935', N'natastrycharz@gmail.com', N'Ruda Śląska', N'Reymonta', N'30', NULL, N'564231599   ', N'RW', CAST(N'2015-05-03' AS Date), CAST(N'2015-06-07' AS Date), N'IW', N'nstrycharz', N'5733e895b4cf69a0fac0bf1caac292f8e7b539ef24bed6bcb1a6a0305e7d0707', 38, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (40, N'Bartosz', N'Topolski', N'90030265498', N'bartopolski@wp.pl', N'Ruda Śląska', N'Kochanowskiego', N'9', N'12', N'561261348   ', N'RW', CAST(N'2015-03-10' AS Date), CAST(N'2015-08-15' AS Date), N'I', N'btopolski', N'31d0cca84007d3d6bbe4677cfe2c2dcd3f7c8be406b71ce1f5e509ac3699a2d4', 39, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (41, N'Maria', N'Bednarz', N'81052954896', N'marysiab@gmail.com', N'Ruda Śląska', N'Wiązowa', N'10', N'47', N'956484534   ', N'RW', CAST(N'2015-05-09' AS Date), CAST(N'2015-06-10' AS Date), N'MI', N'mbednarz', N'31f9c62b082da23c47ea8f45121b764799816782166de786355070717e6e769c', 40, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (45, N'Szymon', N'Kosmala', N'83061451689', N'szymon.kosmala@wp.pl', N'Ruda Śląska', N'Jasna', N'13', NULL, N'890517564   ', N'RW', CAST(N'2015-10-18' AS Date), CAST(N'2015-03-15' AS Date), N'RW', N'skosmala', N'c2a665c9a0f9df23fc01bce26d28acc684e3cbad9d7615f4dc49cd4ff8677ed1', 41, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (46, N'Marta', N'Kaliszewska', N'90021545498', N'mkalisz@gmail.com', N'Świętochłowice', N'Szarych Szeregów', N'25', N'10', N'545468989   ', N'KZ', NULL, CAST(N'2015-12-01' AS Date), NULL, N'mkaliszewska', N'b2305e21e4537d5308f213bd5587f86d683993f2d1135609aae5175da494f217', 42, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (47, N'Jan', N'Jeziorański', N'76093065985', N'jan.jezioraski@gmail.com', N'Ruda Śląska', N'Bojkowska', N'19', N'5', N'546189745   ', N'KZ', NULL, CAST(N'2015-11-10' AS Date), NULL, N'jjezioraski', N'c2304f35ce60d8ef0e70613f0378dab176a0582f7989fb892123259ba1ecd005', 43, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (48, N'Marcin', N'Chrzanowski', N'89021054899', N'm.chrzanowski@wp.pl', N'Bytom', N'Główna', N'52', N'7', N'546187986   ', N'KZ', NULL, CAST(N'2015-04-06' AS Date), NULL, N'mchrzanowski', N'8a83ced2160103bf2be196b0e7da931c24079fb5db1b9296070eccbd0d601ac1', 44, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (55, N'Dita', N'Majewska', N'91030443202', N'd.majewska@o2.pl', N'Ruda Śląska', N'Przasnyska', N'141', NULL, N'412589741   ', N'RW', CAST(N'2015-12-01' AS Date), CAST(N'2015-08-15' AS Date), N'RW', N'dmajewska', N'31517586d643a17607accc8c3e38b53109bda9596a49609317fa322d76561909', 45, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (56, N'Bogumił', N'Olszewski', N'77082812610', N'b.olszewski@o2.pl', N'Gliwice', N'Strażacka', N'18', N'10', N'514879478   ', N'RW', CAST(N'2015-03-05' AS Date), CAST(N'2015-04-06' AS Date), N'RW', N'bolszewski', N'b099c7f497a2eacfe3006700af883db97447ef44cf3e6ef7166e2c39907086bc', 49, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (57, N'Iwona', N'Wieczorek', N'88042714432', N'i.wieczorek@gmail.com', N'Katowice', N'Powstańsów', N'75', N'20', N'673518366   ', N'RW', CAST(N'2015-10-20' AS Date), CAST(N'2015-06-14' AS Date), N'MR', N'iwieczorek', N'4acc34c1f5e2728912f3264fe7b73f3b46946dd046fb3c17d8b9210fdd10c99c', 48, N'u', N't', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (58, N'Elżbieta', N'Dąbrowska', N'84051435280', N'e.dabrawska@o2.pl', N'Świętochłowice', N'Bohaterów Warszawy', N'30', N'19', N'727008505   ', N'KZ', NULL, CAST(N'2015-10-12' AS Date), NULL, N'e.dabrawska', N'db34ad081ed9008360c468833c8a07bdfa116fd26d8cd2add40f05ae47da6fc7', 50, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (59, N'Amadeusz', N'Adamski', N'82072478670', N'a.adamski@wp.pl', N'Bytom', N'Podjazdowa', N'118', NULL, N'693372247   ', N'KSR', CAST(N'2015-12-02' AS Date), CAST(N'2015-06-14' AS Date), N'SRW', N'aadamski', N'3c629aa663db06cf2f886aba475e02b0fcf7c006def6ec312cf71a8a2ed9a85e', 51, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (61, N'Patryk', N'Wysocki', N'87080942197', N'p.wysocki@onet.pl', N'Będzin', N'Słupecka', N'15', N'6', N'602556453   ', N'RW', CAST(N'2015-04-12' AS Date), CAST(N'2015-05-14' AS Date), N'I', N'pwysocki', N'9a66459cc9ad894b0153639c3b871a8b197f53b03b97dc583bb46e99fae97243', 52, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (62, N'Zofia', N'Grabowska', N'90020216229', N'z.grabowska@onet.pl', N'Katowice', N'Powstańców', N'102', NULL, N'788946568   ', N'RW', CAST(N'2015-06-30' AS Date), CAST(N'2015-08-19' AS Date), N'MI', N'zgrabowska', N'efb100ec9c567ea9ba4ed9e41bb704df645879149a95bc31dbd28c589d263ce9', 53, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (63, N'Radosław', N'Maciejewski', N'90080815034', N'r.maciejewski@gmail.com', N'Ruda Śląska', N'Sanocka', N'43', N'10', N'887215364   ', N'RW', CAST(N'2015-10-01' AS Date), CAST(N'2015-09-02' AS Date), N'RW', N'rmaciejewski', N'd58ebd42cc469bf9aef801a3b427269d9331d173bacf0e388cf99ac03abab223', 54, N'u', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (64, N'Adam', N'Romański', N'91082610283', N'adamadam@o2.pl', N'Łódź', N'Wyszyńskiego', N'5', N'0', N'+48500500500', N'RW', CAST(N'2015-02-28' AS Date), CAST(N'2015-03-20' AS Date), N'RW', N'adam.romański', N'e43e94b5cb15212bd19dea3030a2ee70ac859a87995b3d525ded868bc15d8ab3', 56, N'U', N'f', N'f', N'f')
INSERT [dbo].[Pracownik] ([ID_p], [Imie], [Nazwisko], [Pesel], [Mail], [Miasto], [Ulica], [Numer_domu], [Numer_mieszkania], [Numer_telefonu], [Stanowisko], [Data_waznosci_KPP], [Data_badan], [Stopien], [Login], [Haslo], [ID_umowy], [Typ_konta], [Ostrzezenie_umowa], [Ostrzezenie_KPP], [Ostrzezenie_badania]) VALUES (113, N'Adam', N'Nowak', N'91082610283', N'ogus18@gmail.com', N'Gliwice', N'Kochanowskiego', N'32', N'6', N'+48500500500', N'RW', CAST(N'2015-02-02' AS Date), CAST(N'2015-04-03' AS Date), N'SRW', N'adam.nowak', N'6f8104291a30abb466497e6b747cc013ae21dda716ca8c1a80a0e4274f0874f5', 106, N'U', N'f', N't', N'f')
SET IDENTITY_INSERT [dbo].[Pracownik] OFF
SET IDENTITY_INSERT [dbo].[Stanowisko] ON 

INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (1, N'S 1', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (2, N'S 2', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (3, N'S 3', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (4, N'S 4', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (5, N'S 5', N'S', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (6, N'S 1', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (7, N'S 2', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (8, N'S 3', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (9, N'S 4', N'R', 1)
INSERT [dbo].[Stanowisko] ([ID_s], [Nazwa], [Strefa], [Liczba_pracownikow]) VALUES (10, N'S 5', N'S', 1)
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
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (57, N'UOP', 160, CAST(N'2014-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (58, N'UOP', 160, CAST(N'2014-06-01' AS Date), CAST(N'2050-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (59, N'UOP', 160, CAST(N'2014-11-01' AS Date), CAST(N'2050-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (60, N'UOP', 120, CAST(N'2014-07-01' AS Date), CAST(N'2015-06-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (61, N'UZ', NULL, CAST(N'2014-01-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (62, N'UZ', NULL, CAST(N'2014-02-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (63, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (64, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (65, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-12-31' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (66, N'UOP', 80, CAST(N'2014-11-01' AS Date), CAST(N'2015-05-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (67, N'UOP', 160, CAST(N'2014-10-30' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (68, N'UOP', 160, CAST(N'2014-01-01' AS Date), CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (69, N'UOP', 160, CAST(N'2014-11-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (70, N'UOP', 160, CAST(N'2014-10-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (71, N'UOP', 120, CAST(N'2014-12-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (72, N'UOP', 120, CAST(N'2014-08-30' AS Date), CAST(N'2016-09-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (73, N'UOP', 80, CAST(N'2014-05-01' AS Date), CAST(N'2015-05-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (74, N'UOP', 80, CAST(N'2014-06-01' AS Date), CAST(N'2015-12-30' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (75, N'UZ', NULL, CAST(N'2014-01-01' AS Date), CAST(N'2015-10-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (76, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (77, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (78, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-10-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (79, N'UZ', NULL, CAST(N'2014-09-01' AS Date), CAST(N'2015-09-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (80, N'UZ', NULL, CAST(N'2014-08-01' AS Date), CAST(N'2015-08-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (81, N'UZ', NULL, CAST(N'2014-07-01' AS Date), CAST(N'2015-07-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (82, N'UZ', NULL, CAST(N'2014-06-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (83, N'UZ', NULL, CAST(N'2014-05-01' AS Date), CAST(N'2015-05-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (84, N'UZ', NULL, CAST(N'2014-04-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (85, N'UZ', NULL, CAST(N'2014-08-01' AS Date), CAST(N'2014-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (86, N'UZ', NULL, CAST(N'2014-09-01' AS Date), CAST(N'2015-11-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (87, N'UZ', NULL, CAST(N'2014-10-01' AS Date), CAST(N'2015-12-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (88, N'UZ', NULL, CAST(N'2014-11-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (89, N'UZ', NULL, CAST(N'2014-12-01' AS Date), CAST(N'2015-04-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (90, N'UZ', NULL, CAST(N'2015-01-01' AS Date), CAST(N'2015-06-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (91, N'UOP', 160, CAST(N'2015-02-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (92, N'UOP', 160, CAST(N'2015-05-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (93, N'UOP', 160, CAST(N'2015-02-01' AS Date), CAST(N'2015-03-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (94, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (95, N'UZ', NULL, CAST(N'2015-01-25' AS Date), CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (96, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (97, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (98, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (99, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2018-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (100, N'UOP', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (101, N'UZ', 160, CAST(N'2015-01-01' AS Date), CAST(N'2050-01-01' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (102, N'UOP', 160, CAST(N'2015-01-25' AS Date), CAST(N'2016-12-24' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (103, N'UOP', 156, CAST(N'2015-01-26' AS Date), CAST(N'2015-03-27' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (104, N'UZ', NULL, CAST(N'2015-01-27' AS Date), CAST(N'2015-01-31' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (105, N'UZ', NULL, CAST(N'2015-01-27' AS Date), CAST(N'2015-01-31' AS Date))
INSERT [dbo].[Umowa] ([ID_u], [Typ], [Wymiar_godzin], [Poczatek_umowy], [Koniec_umowy]) VALUES (106, N'UOP', 160, CAST(N'2015-01-27' AS Date), CAST(N'2015-02-27' AS Date))
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
