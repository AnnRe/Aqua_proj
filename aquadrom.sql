USE [master]
GO
/****** Object:  Database [aquadrom]    Script Date: 2014-11-04 16:19:34 ******/
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
/****** Object:  Table [dbo].[Godziny_pracy]    Script Date: 2014-11-04 16:19:34 ******/
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
/****** Object:  Table [dbo].[Notatka]    Script Date: 2014-11-04 16:19:35 ******/
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
/****** Object:  Table [dbo].[Otwarcie_stanowiska]    Script Date: 2014-11-04 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otwarcie_stanowiska](
	[ID_o] [int] IDENTITY(1,1) NOT NULL,
	[Od] [datetime] NOT NULL,
	[Do] [datetime] NOT NULL,
	[Typ_dnia] [nvarchar](2) NOT NULL,
	[ID_stanowiska] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_o] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pracownik]    Script Date: 2014-11-04 16:19:35 ******/
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
	[Login] [nvarchar](30) NOT NULL,
	[Haslo] [nvarchar](256) NOT NULL,
	[ID_umowy] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_p] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stanowisko]    Script Date: 2014-11-04 16:19:35 ******/
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
/****** Object:  Table [dbo].[Umowa]    Script Date: 2014-11-04 13:43:33 ******/
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
ALTER TABLE [dbo].[Notatka] ADD  DEFAULT ((0)) FOR [Akceptacja_KZ]
GO
ALTER TABLE [dbo].[Notatka] ADD  DEFAULT ((0)) FOR [Akceptacja_KSR]
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
ALTER TABLE [dbo].[Otwarcie_stanowiska]  WITH CHECK ADD  CONSTRAINT [FKOtwarcie-stanowisko] FOREIGN KEY([ID_stanowiska])
REFERENCES [dbo].[Stanowisko] ([ID_s])
GO
ALTER TABLE [dbo].[Otwarcie_stanowiska] CHECK CONSTRAINT [FKOtwarcie-stanowisko]
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD  CONSTRAINT [FKPracownik-Umowa] FOREIGN KEY([ID_umowy])
REFERENCES [dbo].[Umowa] ([ID_u])
GO
ALTER TABLE [dbo].[Pracownik] CHECK CONSTRAINT [FKPracownik-Umowa]
GO
ALTER TABLE [dbo].[Otwarcie_stanowiska]  WITH CHECK ADD CHECK  (([Typ_dnia]='Z' OR [Typ_dnia]='WS' OR [Typ_dnia]='R'))
GO
ALTER TABLE [dbo].[Otwarcie_stanowiska]  WITH CHECK ADD CHECK  (([Typ_dnia]='Z' OR [Typ_dnia]='WS' OR [Typ_dnia]='R'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Stanowisko]='KZ' OR [Stanowisko]='KSR' OR [Stanowisko]='RW'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Pracownik]  WITH CHECK ADD CHECK  (([Stopien]='IW' OR [Stopien]='I' OR [Stopien]='MI' OR [Stopien]='SRW' OR [Stopien]='RW' OR [Stopien]='MR'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Stanowisko]  WITH CHECK ADD CHECK  (([Strefa]='S' OR [Strefa]='R'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
ALTER TABLE [dbo].[Umowa]  WITH CHECK ADD CHECK  (([Typ]='UOP' OR [Typ]='UZ'))
GO
USE [master]
GO
ALTER DATABASE [aquadrom] SET  READ_WRITE 
GO
