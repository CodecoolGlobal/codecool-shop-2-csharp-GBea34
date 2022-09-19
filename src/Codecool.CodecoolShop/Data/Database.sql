USE [master]
GO
/****** Object:  Database [shopDB]    Script Date: 2022. 09. 19. 13:44:42 ******/
CREATE DATABASE [shopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shopDB', FILENAME = N'C:\Users\olive\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\shopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shopDB_log', FILENAME = N'C:\Users\olive\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\shopDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [shopDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shopDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [shopDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [shopDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [shopDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [shopDB] SET ARITHABORT ON 
GO
ALTER DATABASE [shopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [shopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shopDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [shopDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [shopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shopDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [shopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [shopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shopDB] SET RECOVERY FULL 
GO
ALTER DATABASE [shopDB] SET  MULTI_USER 
GO
ALTER DATABASE [shopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [shopDB] SET QUERY_STORE = OFF
GO
USE [shopDB]
GO
/****** Object:  ColumnMasterKey [CMK_Auto1]    Script Date: 2022. 09. 19. 13:44:42 ******/
CREATE COLUMN MASTER KEY [CMK_Auto1]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/my/13FDE58CBE2D439E39706EACDDDC6CEC2C991137'
)
GO
/****** Object:  ColumnEncryptionKey [CEK_Auto1]    Script Date: 2022. 09. 19. 13:44:42 ******/
CREATE COLUMN ENCRYPTION KEY [CEK_Auto1]
WITH VALUES
(
	COLUMN_MASTER_KEY = [CMK_Auto1],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E000001630075007200720065006E00740075007300650072002F006D0079002F003100330066006400650035003800630062006500320064003400330039006500330039003700300036006500610063006400640064006300360063006500630032006300390039003100310033003700B42A0962B532F3B1DBAA3692AC3BE18A645BDE9F347E9188E3BEA754C25E38DA40CBC721279B757CE6AED181053AE701880201AE4ED900A753F87320748B5AEBB5531DD174073FB589B21922AEA0D11F68B8A47862153C1980F6CA2A0BE9F7B078AEE0DE437C9218556C8071C3583290A4DA43C9C5F8576DF613B37D4D0A7BEBB515D8B1CA15C21790D1CDD662DC8A9F1E5E8A61054155100DB56175D314123A32626B826A39F0D615E4B30671183598042731A6C4919FDDD54CEA3FAA6C33DC6A9F6E511B976C9D0C6A00FF31AB7C42509C29A4724E1C648DFDC8C1FA25EEC42882203F7ED66B42769D38E9D620DC941C3CE2B6137578BB920AED4FE2D6DBFE0EA1492C1E4F0AA31199E3DA5BAC2E638FF92C6F9E8872BE45B46E14A25BB01FD75C15A9155454877511E51A2C0979EA445B078291D9607BA8C22EC858430B414687B1908D061DEE8097075E96346354F3251DAB9470E9BCEBEF1D29D0FB7FF597DB01EBCB92614F562B6530ACF8A08303E5CD90ECD4DE250AC594056BE14891F77B345384E60817DB3A12E87B0F988B6A9D35874380BFB9691E52BEF83727CDB8B76CE34750AF1041E555A68ABE5967309F43BCCD5B94C15D687E9B7331B8249C9B85F09A335EFCDF4593F67B70390C87FD79AB266765F0D3B7CF8FCD9B09D1598A0EAE92F0C835108D8CBD54BDBE1217622FA50366F960492A0E5C282BAFF2
)
GO
/****** Object:  Table [dbo].[chart]    Script Date: 2022. 09. 19. 13:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chart](
	[id] [int] NOT NULL,
 CONSTRAINT [PK_chart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2022. 09. 19. 13:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Curency] [nchar](10) NOT NULL,
	[DefaultPrice] [decimal](18, 0) NOT NULL,
	[SupplierId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopUsers]    Script Date: 2022. 09. 19. 13:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ('USD') FOR [Curency]
GO
USE [master]
GO
ALTER DATABASE [shopDB] SET  READ_WRITE 
GO
