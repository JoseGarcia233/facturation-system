USE [master]
GO
/****** Object:  Database [sistema_facturacion1]    Script Date: 24/8/2021 8:18:03 p. m. ******/
CREATE DATABASE [sistema_facturacion1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sistema_facturacion1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\sistema_facturacion1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sistema_facturacion1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\sistema_facturacion1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sistema_facturacion1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sistema_facturacion1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sistema_facturacion1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET ARITHABORT OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sistema_facturacion1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sistema_facturacion1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sistema_facturacion1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sistema_facturacion1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET RECOVERY FULL 
GO
ALTER DATABASE [sistema_facturacion1] SET  MULTI_USER 
GO
ALTER DATABASE [sistema_facturacion1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sistema_facturacion1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sistema_facturacion1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sistema_facturacion1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sistema_facturacion1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sistema_facturacion1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sistema_facturacion1', N'ON'
GO
ALTER DATABASE [sistema_facturacion1] SET QUERY_STORE = OFF
GO
USE [sistema_facturacion1]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 24/8/2021 8:18:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[Id] [int] IDENTITY(2,6) NOT NULL,
	[Cedula] [int] NULL,
	[Nombre] [varchar](100) NULL,
	[Telefono] [bigint] NULL,
	[Categoria] [varchar](100) NULL,
	[Email] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 24/8/2021 8:18:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[Id] [int] NOT NULL,
	[Nombre_producto] [int] NULL,
	[Categoria_Cliente] [int] NULL,
	[Monto_total] [int] NULL,
	[Catidad] [int] NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 24/8/2021 8:18:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_proveedor] [int] NULL,
	[Nombre_poducto] [int] NULL,
	[Cantidad_A] [int] NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 24/8/2021 8:18:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[ID] [int] IDENTITY(2,6) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 24/8/2021 8:18:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[Id] [int] IDENTITY(2,6) NOT NULL,
	[Cedula] [int] NULL,
	[Nombre] [varchar](100) NULL,
	[Telefono] [bigint] NULL,
	[Email] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 
GO
INSERT [dbo].[clientes] ([Id], [Cedula], [Nombre], [Telefono], [Categoria], [Email]) VALUES (8, 1224234434, N'Manuel ', 1234556678, N'Premium', N'mnl@yahoo.com')
GO
INSERT [dbo].[clientes] ([Id], [Cedula], [Nombre], [Telefono], [Categoria], [Email]) VALUES (6008, 65587767, N'Juan ', 676787878, N'Premium', N'ju1345@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[inventario] ON 
GO
INSERT [dbo].[inventario] ([Id], [Nombre_proveedor], [Nombre_poducto], [Cantidad_A], [Fecha]) VALUES (5, 14, 8, 22, CAST(N'2021-08-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[inventario] ([Id], [Nombre_proveedor], [Nombre_poducto], [Cantidad_A], [Fecha]) VALUES (8, 20, 20, 10, CAST(N'2021-08-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[inventario] ([Id], [Nombre_proveedor], [Nombre_poducto], [Cantidad_A], [Fecha]) VALUES (12, 26, 14, 12, CAST(N'2021-08-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[inventario] ([Id], [Nombre_proveedor], [Nombre_poducto], [Cantidad_A], [Fecha]) VALUES (13, 2, 6008, 10, CAST(N'2021-08-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[inventario] ([Id], [Nombre_proveedor], [Nombre_poducto], [Cantidad_A], [Fecha]) VALUES (15, 20, 14, 2, CAST(N'2021-08-26T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[inventario] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio]) VALUES (8, N'iphone x max', N'35000')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio]) VALUES (14, N'Mouse maxuell', N'4000')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio]) VALUES (20, N'usb 1gb', N'500')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio]) VALUES (6008, N'Teclado Logitech', N'6000')
GO
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedores] ON 
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (2, 1243, N'marcos sm', 8299077801, N'LGmarc@gmail.com')
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (8, 10679, N'carmona moto', 3793673, N'carmoto@gmail.com')
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (14, 12345678, N'moto service', 8093449067, N'motoservice@gmail.com')
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (20, 95678, N'carmona cars', 8090900, N'cmona@gmail.com')
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (26, 8707085, N'razor', 6796976, N'razor@yahoo.com')
GO
INSERT [dbo].[proveedores] ([Id], [Cedula], [Nombre], [Telefono], [Email]) VALUES (32, 4878434, N'jose', 3432545, N'ju1345@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[proveedores] OFF
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([Categoria_Cliente])
REFERENCES [dbo].[clientes] ([Id])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([Catidad])
REFERENCES [dbo].[inventario] ([Id])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([Nombre_producto])
REFERENCES [dbo].[productos] ([ID])
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD FOREIGN KEY([Nombre_proveedor])
REFERENCES [dbo].[proveedores] ([Id])
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD FOREIGN KEY([Nombre_poducto])
REFERENCES [dbo].[productos] ([ID])
GO
USE [master]
GO
ALTER DATABASE [sistema_facturacion1] SET  READ_WRITE 
GO
