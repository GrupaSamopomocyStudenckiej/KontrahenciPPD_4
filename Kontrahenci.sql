/****** Object:  Database [Kontrahenci]    Script Date: 14.02.2021 13:54:28 ******/
CREATE DATABASE [Kontrahenci]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kontrahenci', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kontrahenci.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kontrahenci_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kontrahenci_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kontrahenci] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kontrahenci].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kontrahenci] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kontrahenci] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kontrahenci] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kontrahenci] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kontrahenci] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kontrahenci] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kontrahenci] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kontrahenci] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kontrahenci] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kontrahenci] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kontrahenci] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kontrahenci] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kontrahenci] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kontrahenci] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kontrahenci] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kontrahenci] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kontrahenci] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kontrahenci] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kontrahenci] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kontrahenci] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kontrahenci] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kontrahenci] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kontrahenci] SET RECOVERY FULL 
GO
ALTER DATABASE [Kontrahenci] SET  MULTI_USER 
GO
ALTER DATABASE [Kontrahenci] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kontrahenci] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kontrahenci] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kontrahenci] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kontrahenci] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kontrahenci] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kontrahenci', N'ON'
GO
ALTER DATABASE [Kontrahenci] SET QUERY_STORE = OFF
GO
USE [Kontrahenci]
GO
/****** Object:  Table [dbo].[Firmy]    Script Date: 14.02.2021 13:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmy](
	[IdFirmy] [int] IDENTITY(1,1) NOT NULL,
	[IdSiedzibyFirmy] [int] NOT NULL,
	[NazwaFirmy] [varchar](100) NOT NULL,
	[Nip] [varchar](9) NOT NULL,
	[Regon] [varchar](9) NOT NULL,
	[Miasto] [varchar](100) NOT NULL,
	[Ulica] [varchar](100) NOT NULL,
	[NrBudynku] [varchar](100) NOT NULL,
	[NrLokalu] [varchar](100) NOT NULL,
	[KodPocztowy] [varchar](6) NOT NULL,
	[Poczta] [varchar](100) NOT NULL,
	[NrTelefonu] [varchar](9) NOT NULL,
	[Kraj] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[StronaWWW] [varchar](100) NOT NULL,
	[NrKonta] [varchar](26) NOT NULL,
 CONSTRAINT [PK_Firmy] PRIMARY KEY CLUSTERED 
(
	[IdFirmy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pracownicy]    Script Date: 14.02.2021 13:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pracownicy](
	[IdPracownika] [int] IDENTITY(1,1) NOT NULL,
	[IdFirmy] [int] NOT NULL,
	[Imie] [varchar](100) NOT NULL,
	[Nazwisko] [varchar](100) NOT NULL,
	[NrTelefonu] [varchar](9) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Pracownicy] PRIMARY KEY CLUSTERED 
(
	[IdPracownika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Firmy] ON 
GO
INSERT [dbo].[Firmy] ([IdFirmy], [IdSiedzibyFirmy], [NazwaFirmy], [Nip], [Regon], [Miasto], [Ulica], [NrBudynku], [NrLokalu], [KodPocztowy], [Poczta], [NrTelefonu], [Kraj], [Email], [StronaWWW], [NrKonta]) VALUES (4, 0, N'APV321', N'745323452', N'213123123', N'Kraśnik', N'Norkowa', N'21', N'34', N'12-341', N'Kraśnik', N'638495675', N'Poland', N'das@wp.pl', N'www.dsa.com', N'52125698569856325698523652')
GO
SET IDENTITY_INSERT [dbo].[Firmy] OFF
GO
SET IDENTITY_INSERT [dbo].[Pracownicy] ON 
GO
INSERT [dbo].[Pracownicy] ([IdPracownika], [IdFirmy], [Imie], [Nazwisko], [NrTelefonu], [Email]) VALUES (1, 4, N'Szymon', N'Wiktor', N'123567234', N'sa@wp.pl')
GO
INSERT [dbo].[Pracownicy] ([IdPracownika], [IdFirmy], [Imie], [Nazwisko], [NrTelefonu], [Email]) VALUES (4, 4, N'Wiktor', N'Jakub', N'123123123', N'sadwas@wp.pl')
GO
INSERT [dbo].[Pracownicy] ([IdPracownika], [IdFirmy], [Imie], [Nazwisko], [NrTelefonu], [Email]) VALUES (5, 1, N'Kuba', N'Baran', N'52568545', N'w60024@student.wsiz.rzeszow.pl')
GO
SET IDENTITY_INSERT [dbo].[Pracownicy] OFF
GO
USE [master]
GO
ALTER DATABASE [Kontrahenci] SET  READ_WRITE 
GO
