CREATE DATABASE [ManagementFlorarie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManagementFlorarie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DESKTOP05IM799\MSSQL\DATA\ManagementFlorarie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ManagementFlorarie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DESKTOP05IM799\MSSQL\DATA\ManagementFlorarie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManagementFlorarie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ManagementFlorarie] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET ARITHABORT OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ManagementFlorarie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ManagementFlorarie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET  ENABLE_BROKER 
GO

ALTER DATABASE [ManagementFlorarie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ManagementFlorarie] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET RECOVERY FULL 
GO

ALTER DATABASE [ManagementFlorarie] SET  MULTI_USER 
GO

ALTER DATABASE [ManagementFlorarie] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ManagementFlorarie] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ManagementFlorarie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ManagementFlorarie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ManagementFlorarie] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ManagementFlorarie] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [ManagementFlorarie] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ManagementFlorarie] SET  READ_WRITE 
GO

USE [ManagementFlorarie]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Angajat](
	[ID_Angajat] uniqueidentifier NOT NULL,
	[Nume] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NumarTelefon] [nvarchar](50) NOT NULL,
	[Adresa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ID_Angajat_Table] PRIMARY KEY CLUSTERED 
(
	[ID_Angajat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID_Angajat] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](255) unique NOT NULL,
	[Parola] [nvarchar](255) NOT NULL,
	[Rol] [int] NOT NULL,
 CONSTRAINT [PK_Username_Table] PRIMARY KEY CLUSTERED 
(
	[ID_Angajat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE[Login]
	WITH CHECK ADD CONSTRAINT [FK_AngajatID] FOREIGN KEY(ID_Angajat) REFERENCES Angajat (ID_Angajat) ON
UPDATE CASCADE ON
DELETE CASCADE
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Floare](
	[ID_Floare] [uniqueidentifier] NOT NULL,
	[Nume] [nvarchar](255) NOT NULL,
	[Tip] [nvarchar](50) NOT NULL,
	[Culoare] [nvarchar](50) NOT NULL,
	[Cantitate] [int] NOT NULL,
	[Pret] [int] NOT NULL,
 CONSTRAINT [PK_ID_Floare_Table] PRIMARY KEY CLUSTERED 
(
	[ID_Floare] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda](
	[ID_Comanda] [uniqueidentifier] NOT NULL,
	[ID_Floare] [uniqueidentifier] NOT NULL,
	[ID_Angajat] [uniqueidentifier] NOT NULL,
	[Nume] [nvarchar] (255) NOT NULL,
	[DataComanda] [datetime] NOT NULL,
	[DataRidicare] [datetime] NOT NULL,
	[Cantitate] [int] NOT NULL,
	[Observatii] [nvarchar](255) NOT NULL,
	[Status] [int] NOT NULL,
	[PretTotal] [int] NOT NULL
 CONSTRAINT [PK_ID_Table] PRIMARY KEY CLUSTERED 
(
	[ID_Comanda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Comanda]  WITH CHECK ADD  CONSTRAINT [FK_AngajatID_RezervareFloare] FOREIGN KEY([ID_Angajat])
REFERENCES [dbo].[Angajat] ([ID_Angajat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Comanda] CHECK CONSTRAINT [FK_AngajatID_RezervareFloare]
GO

ALTER TABLE [dbo].[Comanda]  WITH CHECK ADD  CONSTRAINT [FK_RezervareID] FOREIGN KEY([ID_Floare])
REFERENCES [dbo].[Floare] ([ID_Floare])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Comanda] CHECK CONSTRAINT [FK_RezervareID]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login_ReadByUsername](
	@Username nvarchar(255)
)
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT [ID_Angajat],
		   [Username],
		   [Parola],
		   [Rol]
	FROM dbo.[Login] 
	WHERE [Username]=@Username
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login_Insert](
	@ID_Angajat uniqueidentifier,
	@Username nvarchar(255),
	@Parola nvarchar(255),
	@Rol int
)
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ManagementFlorarie.dbo.[Login]
	(
	 [ID_Angajat],
	 [Username],
	 [Parola],
	 [Rol]
	 )
	 VALUES
	 (
	 @ID_Angajat,
	 @Username,
	 @Parola,
	 @Rol
	 )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Angajat_Insert](
	@ID_Angajat uniqueidentifier,
	@Nume nvarchar(255),
	@Email nvarchar(255),
	@NumarTelefon nvarchar(255),
	@Adresa nvarchar(255)
)
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.[Angajat]
	(
	 [ID_Angajat],
	 [Nume],
	 [Email],
	 [NumarTelefon],
	 [Adresa]
	 )
	 VALUES
	 (
	 @ID_Angajat,
	 @Nume,
	 @Email,
	 @NumarTelefon,
	 @Adresa
	 )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Angajat_Update](
	@ID_Angajat uniqueidentifier,
	@Nume nvarchar(255),
	@Email nvarchar(255),
	@NumarTelefon nvarchar(255),
	@Adresa nvarchar(255)
)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Angajat]
	SET
		[Nume]=@Nume,
		[Email]=@Email,
		[NumarTelefon]=@NumarTelefon,
		[Adresa]=@Adresa
	WHERE
		[ID_Angajat]=@ID_Angajat
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Angajat_Delete](
	@ID_Angajat uniqueidentifier
)
AS 
BEGIN
	DELETE 
	FROM dbo.[Angajat]
	WHERE [ID_Angajat]=@ID_Angajat
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login_Delete](
	@ID_Angajat uniqueidentifier
)
AS 
BEGIN
	SET NOCOUNT ON;

	DELETE 
	FROM dbo.[Login]
	WHERE [ID_Angajat] = @ID_Angajat
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login_UpdateParolaSiUsername](
	@ID_Angajat uniqueidentifier,
	@Username nvarchar(255),
	@Parola nvarchar(255)
)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Login]
	SET
		[Parola]=@Parola,
		[Username] = @Username
	WHERE
		[ID_Angajat] = @ID_Angajat
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Angajat_ReadAngajati]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT [ID_Angajat],
		   [Nume],
		   [Email],
		   [NumarTelefon],
		   [Adresa]
	FROM dbo.[Angajat] 
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Angajat_ReadAngajatDupaID]
	@ID_Angajat uniqueidentifier
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT angajat.[ID_Angajat],
		   angajat.[Nume],
		   angajat.[Email],
		   angajat.[NumarTelefon],
		   angajat.[Adresa],
		   l.[Username],
		   l.[Parola],
		   l.[Rol]
	FROM dbo.[Angajat] angajat
		INNER JOIN dbo.[Login] l ON l.[ID_Angajat] = angajat.[ID_Angajat]
	WHERE angajat.[ID_Angajat] = @ID_Angajat
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_Insert](
	@ID_Floare uniqueidentifier,
	@Nume nvarchar(255),
	@Tip nvarchar(255),
	@Culoare nvarchar(255),
	@Cantitate int,
	@Pret int
)
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.[Floare]
	(
	 [ID_Floare],
	 [Nume],
	 [Tip],
	 [Culoare],
	 [Cantitate],
	 [Pret]
	 )
	 VALUES
	 (
	@ID_Floare,
	@Nume,
	@Tip,
	@Culoare,
	@Cantitate,
	@Pret 
	 )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_Update](
	@ID_Floare uniqueidentifier,
	@Nume nvarchar(255),
	@Tip nvarchar(255),
	@Culoare nvarchar(255),
	@Cantitate int,
	@Pret int
)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Floare]
	SET
		[Nume]=@Nume,
		[Tip]=@Tip,
		[Culoare]=@Culoare,
		[Cantitate]=@Cantitate,
		[Pret]=@Pret
	WHERE
		[ID_Floare]=@ID_Floare
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_Delete](
	@ID_Floare uniqueidentifier
)
AS 
BEGIN
	DELETE 
	FROM dbo.[Floare]
	WHERE [ID_Floare]=@ID_Floare
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_ReadFlori]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT [ID_Floare],
		   [Nume],
		   [Tip],
		   [Culoare],
		   [Cantitate],
		   [Pret]
	FROM dbo.[Floare] 
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_ReadFloareDupaID]
	@ID_Floare uniqueidentifier
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT [ID_Floare],
		   [Nume],
		   [Tip],
		   [Culoare],
		   [Cantitate],
		   [Pret]
	FROM dbo.[Floare]
	WHERE [ID_Floare] = @ID_Floare
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_Cantitate]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT
		   [Cantitate]
	FROM dbo.[Floare] 
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_InsertCantitate](
	@ID_Floare uniqueidentifier,
	@Cantitate int
)
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.[Floare]
	(
	 [ID_Floare],
	 [Cantitate]
	 )
	 VALUES
	 (
	 @ID_Floare,
	 @Cantitate
	 )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Floare_UpdateCantitate](
	@ID_Floare uniqueidentifier,
	@Cantitate int
)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Floare]
	SET
		[Cantitate]=@Cantitate
	WHERE
		[ID_Floare] = @ID_Floare
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_ReadComenziDupaID]
	@ID_Floare uniqueidentifier,
	@ID_Angajat uniqueidentifier
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   ang.[ID_Angajat],
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   com.[Observatii]
	FROM dbo.[Comanda] com
		INNER JOIN
			dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
		INNER JOIN
			dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE (com.[ID_Angajat] = @ID_Angajat)
			AND
		  (com.[ID_Floare] = @ID_Floare)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_ReadComandaDupaID]
	@ID_Comanda uniqueidentifier
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE [ID_Comanda] = @ID_Comanda
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_ReadComenzi]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_Insert](
	@ID_Comanda uniqueidentifier,
	@ID_Floare uniqueidentifier,
	@ID_Angajat uniqueidentifier,
	@Nume nvarchar (255),
	@DataComanda datetime,
	@DataRidicare datetime,
	@Cantitate int,
	@Observatii nvarchar(255),
	@Status int,
	@PretTotal int
)
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.[Comanda]
	(
	 [ID_Comanda],
	 [ID_Floare],
	 [ID_Angajat],
	 [Nume],
	 [DataComanda],
	 [DataRidicare],
	 [Cantitate],
	 [Observatii],
	 [Status],
	 [PretTotal]
	 )
	 VALUES
	 (
	@ID_Comanda,
	@ID_Floare,
	@ID_Angajat,
	@Nume,
	@DataComanda,
	@DataRidicare,
	@Cantitate,
	@Observatii,
	@Status,
	@PretTotal
	 )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_Update](
	@ID_Comanda uniqueidentifier,
	@ID_Floare uniqueidentifier,
	@ID_Angajat uniqueidentifier,
	@Nume nvarchar(255),
	@DataComanda datetime,
	@DataRidicare datetime,
	@Cantitate int,
	@Observatii nvarchar(255),
	@Status int,
	@PretTotal int
)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Comanda]
	SET
		[ID_Comanda]=@ID_Comanda,
		[ID_Floare]= @ID_Floare,
		[ID_Angajat]= @ID_Angajat,
		[Nume] = @Nume,
		[DataComanda]=@DataComanda,
		[DataRidicare]=@DataRidicare,
		[Cantitate]=@Cantitate,
		[Observatii]=@Observatii,
		[Status]=@Status,
		[PretTotal]=@PretTotal
	WHERE
		[ID_Comanda]=@ID_Comanda
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_Delete](
	@ID_Comanda uniqueidentifier
)
AS 
BEGIN
	DELETE 
	FROM dbo.[Comanda]
	WHERE [ID_Comanda]=@ID_Comanda
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_Ieftina]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE flo.[PretTotal] <'500'
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_Scumpa]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE flo.[PretTotal] >='500'
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_CeaMaiIeftinaFloare]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE flo.[Pret] < '10'
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_CeaMaiVandutaFloare]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE (flo.[Nume] ='Trandafir' OR flo.[Nume] ='Orhidee' OR flo.[Nume] ='Zambila') AND com.[Cantitate] > '100'
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Comanda_CeaMaiScumpaFloare]
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT com.[ID_Comanda],
		   flo.[ID_Floare],
		   flo.[Nume] as NumeFloare,
		   ang.[ID_Angajat],
		   ang.[Nume] as NumeAngajat,
		   com.[Nume],
		   com.[DataComanda],
		   com.[DataRidicare],
		   com.[Cantitate],
		   flo.[Pret] as PretFloare,
		   com.[Observatii],
		   com.[Status],
		   com.[PretTotal]
	FROM dbo.[Comanda] com
	INNER JOIN	dbo.[Floare] flo ON flo.[ID_Floare] = com.[ID_Floare]
	INNER JOIN	dbo.[Angajat] ang ON ang.[ID_Angajat] = com.[ID_Angajat]
	WHERE flo.[Pret] > '20'
END
GO