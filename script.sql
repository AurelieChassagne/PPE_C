USE [master]
GO
/****** Object:  Database [gsb]    Script Date: 06/02/2017 14:42:48 ******/
CREATE DATABASE [gsb] ON  PRIMARY 
( NAME = N'gsb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\gsb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gsb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\gsb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gsb] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gsb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gsb] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [gsb] SET ANSI_NULLS OFF
GO
ALTER DATABASE [gsb] SET ANSI_PADDING OFF
GO
ALTER DATABASE [gsb] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [gsb] SET ARITHABORT OFF
GO
ALTER DATABASE [gsb] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [gsb] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [gsb] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [gsb] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [gsb] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [gsb] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [gsb] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [gsb] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [gsb] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [gsb] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [gsb] SET  DISABLE_BROKER
GO
ALTER DATABASE [gsb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [gsb] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [gsb] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [gsb] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [gsb] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [gsb] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [gsb] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [gsb] SET  READ_WRITE
GO
ALTER DATABASE [gsb] SET RECOVERY FULL
GO
ALTER DATABASE [gsb] SET  MULTI_USER
GO
ALTER DATABASE [gsb] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [gsb] SET DB_CHAINING OFF
GO
USE [gsb]
GO
/****** Object:  User [Delage]    Script Date: 06/02/2017 14:42:48 ******/
CREATE USER [Delage] FOR LOGIN [gsbdevdelage] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Chassagne]    Script Date: 06/02/2017 14:42:48 ******/
CREATE USER [Chassagne] FOR LOGIN [gsbdevchassagne] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Bonin]    Script Date: 06/02/2017 14:42:48 ******/
CREATE USER [Bonin] FOR LOGIN [gsbdevbonin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 06/02/2017 14:42:48 ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Specialite]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialite](
	[id] [int] NOT NULL,
	[nom] [text] NULL,
 CONSTRAINT [PK_Specialite] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secteur]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secteur](
	[id] [int] NOT NULL,
	[nom] [text] NULL,
 CONSTRAINT [PK_Secteur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gestionnaire]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gestionnaire](
	[login] [varchar](20) NOT NULL,
	[mdp] [varchar](20) NULL,
 CONSTRAINT [PK_Gestionnaire] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Famille]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Famille](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](max) NULL,
 CONSTRAINT [PK_Famille] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Visiteur]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Visiteur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nchar](25) NULL,
	[nom] [text] NULL,
	[prenom] [text] NULL,
	[login] [varchar](20) NULL,
	[motdepasse] [varchar](20) NULL,
	[adresse] [varchar](50) NULL,
	[cp] [varchar](5) NULL,
	[ville] [text] NULL,
	[dateEmbauche] [date] NULL,
	[idSecteur] [int] NULL,
 CONSTRAINT [PK_Visiteur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produit]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produit](
	[ref] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](max) NULL,
	[dosage] [varchar](max) NULL,
	[prix] [float] NULL,
	[contreIndication] [varchar](max) NULL,
	[effetTherapeutique] [varchar](max) NULL,
	[idFamille] [int] NULL,
 CONSTRAINT [PK_Produit] PRIMARY KEY CLUSTERED 
(
	[ref] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Praticiens]    Script Date: 06/02/2017 14:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Praticiens](
	[Code] [int] NOT NULL,
	[RaisonSociale] [nchar](50) NULL,
	[Adresse] [varchar](50) NULL,
	[Telephone] [nchar](10) NULL,
	[ContactNom] [nchar](10) NULL,
	[ContactAdresseMail] [nchar](10) NULL,
	[idSpecialite] [int] NULL,
	[CoefficientNotoriete] [int] NULL,
	[CoefficientConfiance] [int] NULL,
 CONSTRAINT [PK_Practiciens] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [fk_Secteur]    Script Date: 06/02/2017 14:42:49 ******/
ALTER TABLE [dbo].[Visiteur]  WITH CHECK ADD  CONSTRAINT [fk_Secteur] FOREIGN KEY([idSecteur])
REFERENCES [dbo].[Secteur] ([id])
GO
ALTER TABLE [dbo].[Visiteur] CHECK CONSTRAINT [fk_Secteur]
GO
/****** Object:  ForeignKey [fk_Famille]    Script Date: 06/02/2017 14:42:49 ******/
ALTER TABLE [dbo].[Produit]  WITH CHECK ADD  CONSTRAINT [fk_Famille] FOREIGN KEY([idFamille])
REFERENCES [dbo].[Famille] ([id])
GO
ALTER TABLE [dbo].[Produit] CHECK CONSTRAINT [fk_Famille]
GO
/****** Object:  ForeignKey [fk_Specialite]    Script Date: 06/02/2017 14:42:49 ******/
ALTER TABLE [dbo].[Praticiens]  WITH CHECK ADD  CONSTRAINT [fk_Specialite] FOREIGN KEY([idSpecialite])
REFERENCES [dbo].[Specialite] ([id])
GO
ALTER TABLE [dbo].[Praticiens] CHECK CONSTRAINT [fk_Specialite]
GO
