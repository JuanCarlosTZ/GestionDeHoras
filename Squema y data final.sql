USE [master]
GO
/****** Object:  Database [GESTIONDEAULA]    Script Date: 4/9/2017 1:47:29 PM ******/
CREATE DATABASE [GESTIONDEAULA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GESTIONDEAULA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\GESTIONDEAULA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GESTIONDEAULA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\GESTIONDEAULA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GESTIONDEAULA] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GESTIONDEAULA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GESTIONDEAULA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET ARITHABORT OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GESTIONDEAULA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GESTIONDEAULA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GESTIONDEAULA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GESTIONDEAULA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET RECOVERY FULL 
GO
ALTER DATABASE [GESTIONDEAULA] SET  MULTI_USER 
GO
ALTER DATABASE [GESTIONDEAULA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GESTIONDEAULA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GESTIONDEAULA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GESTIONDEAULA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GESTIONDEAULA] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GESTIONDEAULA', N'ON'
GO
ALTER DATABASE [GESTIONDEAULA] SET QUERY_STORE = OFF
GO
USE [GESTIONDEAULA]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [GESTIONDEAULA]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAMPUS]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPUS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](75) NULL,
	[Descripcion] [varchar](250) NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EDIFICIO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EDIFICIO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NULL,
	[Descripcion] [varchar](250) NULL,
	[ID_Campus] [int] NOT NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AULA]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AULA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NULL,
	[Descripcion] [varchar](250) NULL,
	[Tipo] [varchar](15) NULL,
	[ID_Edificio] [int] NOT NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SOLICITUD]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOLICITUD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[ID_Aula] [int] NOT NULL,
	[Fecha_Reservacion] [datetime] NULL,
	[Cantidad_Hora] [int] NULL,
	[Fecha_Fin] [datetime] NULL,
	[Comentario] [varchar](250) NULL,
	[Estado] [varchar](15) NULL,
	[Ejecucion] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[ufnReporteSolicitud]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create function [dbo].[ufnReporteSolicitud]()
returns table
as 
return 
(

Select 
SOLICITUD.ID as Solicitud
,USUARIO.Nombre as Usuario
,USUARIO.Cedula as Cedula
,CAMPUS.Nombre as Campus 
,EDIFICIO.Nombre as Edificio 
,AULA.Nombre as Aula
,AULA.Tipo as Tipo_Aula
,SOLICITUD.Fecha_Reservacion
, dateadd(hour, cantidad_hora, Fecha_reservacion) as Fecha_Fin 
,SOLICITUD.Cantidad_Hora
,SOLICITUD.Estado
,SOLICITUD.Ejecucion


from SOLICITUD 
inner join AULA on SOLICITUD.ID_Aula = aula.ID
inner join EDIFICIO on AULA.ID_Edificio = EDIFICIO.ID
inner join CAMPUS on EDIFICIO.ID_Campus = CAMPUS.ID 
inner join USUARIO on SOLICITUD.ID_Usuario = USUARIO.ID

)




GO
/****** Object:  Table [dbo].[ASIGNAR_PERMISO_ROL]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNAR_PERMISO_ROL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Rol] [int] NOT NULL,
	[ID_Modulo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ASIGNAR_USUARIO_ROL]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNAR_USUARIO_ROL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Rol] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_AULA]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_AULA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Aula] [int] NOT NULL,
	[Capacidad_Reservacion] [int] NULL,
	[Cantidad_Reservacion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_SOLICITUD]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_SOLICITUD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Solicitud] [int] NOT NULL,
	[ID_Empleado] [int] NOT NULL,
	[Comentario] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EJECUCION]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EJECUCION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[No_Carnet] [varchar](100) NOT NULL,
	[Contrasena] [varchar](250) NOT NULL,
	[Tanda_Laboral] [varchar](15) NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ESTUDIANTE]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTUDIANTE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[No_Carnet] [varchar](100) NOT NULL,
	[Contrasena] [varchar](250) NOT NULL,
	[Tanda] [varchar](15) NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MODULO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODULO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROFESOR]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROFESOR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[No_Carnet] [varchar](100) NOT NULL,
	[Contrasena] [varchar](250) NOT NULL,
	[Tanda_Laboral] [varchar](15) NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ROL]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [varchar](250) NULL,
	[Estado] [varchar](15) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TANDA]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TANDA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NULL,
	[Descripcion] [varchar](250) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIPO_AULA]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_AULA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [varchar](250) NULL,
	[Fecha_Creado] [datetime] NULL,
	[Creado_Por] [int] NULL,
	[Fecha_Actualizado] [datetime] NULL,
	[Actualizado_Por] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIPO_USUARIO]    Script Date: 4/9/2017 1:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_USUARIO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ASIGNAR_PERMISO_ROL] ON 

INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (11, 3, 1)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (12, 3, 2)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (13, 3, 3)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (14, 3, 4)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (15, 3, 5)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (16, 3, 6)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (17, 3, 7)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (18, 3, 8)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (19, 3, 9)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (20, 3, 10)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (21, 3, 11)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (22, 3, 12)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (23, 3, 13)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (24, 3, 14)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (25, 3, 15)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (26, 3, 16)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (27, 3, 17)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (28, 3, 18)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (29, 3, 19)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (31, 1, 15)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (32, 1, 17)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (33, 1, 14)
INSERT [dbo].[ASIGNAR_PERMISO_ROL] ([ID], [ID_Rol], [ID_Modulo]) VALUES (34, 2, 17)
SET IDENTITY_INSERT [dbo].[ASIGNAR_PERMISO_ROL] OFF
SET IDENTITY_INSERT [dbo].[ASIGNAR_USUARIO_ROL] ON 

INSERT [dbo].[ASIGNAR_USUARIO_ROL] ([ID], [ID_Rol], [ID_Usuario]) VALUES (1, 3, 1)
INSERT [dbo].[ASIGNAR_USUARIO_ROL] ([ID], [ID_Rol], [ID_Usuario]) VALUES (3, 2, 1)
INSERT [dbo].[ASIGNAR_USUARIO_ROL] ([ID], [ID_Rol], [ID_Usuario]) VALUES (4, 1, 1)
SET IDENTITY_INSERT [dbo].[ASIGNAR_USUARIO_ROL] OFF
SET IDENTITY_INSERT [dbo].[AULA] ON 

INSERT [dbo].[AULA] ([ID], [Nombre], [Descripcion], [Tipo], [ID_Edificio], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'A', N'AULA ISO', N'LABORATORIO', 5, N'ACTIVO', CAST(N'2017-03-19T14:17:11.000' AS DateTime), 0, CAST(N'2017-03-19T14:17:11.000' AS DateTime), 0)
INSERT [dbo].[AULA] ([ID], [Nombre], [Descripcion], [Tipo], [ID_Edificio], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, N'B', N'', N'LABORATORIO', 5, N'ACTIVO', CAST(N'2017-03-19T14:17:39.000' AS DateTime), 0, CAST(N'2017-03-19T14:17:39.000' AS DateTime), 0)
INSERT [dbo].[AULA] ([ID], [Nombre], [Descripcion], [Tipo], [ID_Edificio], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (7, N'C', N'', N'GENERAL', 5, N'ACTIVO', CAST(N'2017-04-08T16:40:14.000' AS DateTime), 1, CAST(N'2017-04-08T17:01:16.000' AS DateTime), 1)
INSERT [dbo].[AULA] ([ID], [Nombre], [Descripcion], [Tipo], [ID_Edificio], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (8, N'Example', N'', N'GENERAL', 1006, N'ACTIVO', CAST(N'2017-04-09T11:02:42.000' AS DateTime), 1, CAST(N'2017-04-09T11:03:18.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[AULA] OFF
SET IDENTITY_INSERT [dbo].[CAMPUS] ON 

INSERT [dbo].[CAMPUS] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'CAFAM', N'Descripcion', N'ACTIVO', NULL, NULL, NULL, NULL)
INSERT [dbo].[CAMPUS] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, N'Nombre', N'Descripción', N'INACTIVO', NULL, NULL, CAST(N'2017-03-18T13:52:34.000' AS DateTime), 0)
INSERT [dbo].[CAMPUS] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (3, N'NICOLAS PICHARDO', N'Nicolas Pichardo', N'ACTIVO', NULL, NULL, CAST(N'2017-03-18T21:14:03.000' AS DateTime), 0)
INSERT [dbo].[CAMPUS] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (5, N'SOJE PERALTA', N'Esta es una descripción', N'INACTIVO', NULL, NULL, CAST(N'2017-04-08T15:35:03.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[CAMPUS] OFF
SET IDENTITY_INSERT [dbo].[DETALLE_AULA] ON 

INSERT [dbo].[DETALLE_AULA] ([ID], [ID_Aula], [Capacidad_Reservacion], [Cantidad_Reservacion]) VALUES (1, 7, 5, 0)
INSERT [dbo].[DETALLE_AULA] ([ID], [ID_Aula], [Capacidad_Reservacion], [Cantidad_Reservacion]) VALUES (2, 8, 4, 0)
SET IDENTITY_INSERT [dbo].[DETALLE_AULA] OFF
SET IDENTITY_INSERT [dbo].[EDIFICIO] ON 

INSERT [dbo].[EDIFICIO] ([ID], [Nombre], [Descripcion], [ID_Campus], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (4, N'EDIFICIO 1', N'LA verdadera Chercha', 3, N'INACTIVO', CAST(N'2017-03-18T18:13:20.000' AS DateTime), 0, CAST(N'2017-04-06T20:40:41.000' AS DateTime), 0)
INSERT [dbo].[EDIFICIO] ([ID], [Nombre], [Descripcion], [ID_Campus], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (5, N'EDIFICIO 2', N'', 2, N'ACTIVO', CAST(N'2017-03-19T13:55:17.000' AS DateTime), 0, CAST(N'2017-03-19T13:55:17.000' AS DateTime), 0)
INSERT [dbo].[EDIFICIO] ([ID], [Nombre], [Descripcion], [ID_Campus], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (6, N'EDIFICIO 3', N'', 2, N'ACTIVO', CAST(N'2017-04-06T20:39:58.000' AS DateTime), 0, CAST(N'2017-04-06T20:39:58.000' AS DateTime), 0)
INSERT [dbo].[EDIFICIO] ([ID], [Nombre], [Descripcion], [ID_Campus], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1006, N'EDIFICIO 4', N'', 2, N'ACTIVO', CAST(N'2017-04-08T15:38:40.000' AS DateTime), 0, CAST(N'2017-04-08T15:40:38.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[EDIFICIO] OFF
SET IDENTITY_INSERT [dbo].[EJECUCION] ON 

INSERT [dbo].[EJECUCION] ([ID], [Nombre]) VALUES (1, N'ABIERTO')
INSERT [dbo].[EJECUCION] ([ID], [Nombre]) VALUES (2, N'CERRADO')
INSERT [dbo].[EJECUCION] ([ID], [Nombre]) VALUES (3, N'CANCELADO')
SET IDENTITY_INSERT [dbo].[EJECUCION] OFF
SET IDENTITY_INSERT [dbo].[EMPLEADO] ON 

INSERT [dbo].[EMPLEADO] ([ID], [ID_Usuario], [No_Carnet], [Contrasena], [Tanda_Laboral], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, 1, N'20160111', N'20160111', N'MAÑANA', N'ACTIVO', CAST(N'2017-03-18T23:45:06.000' AS DateTime), 0, CAST(N'2017-03-19T02:32:31.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[EMPLEADO] OFF
SET IDENTITY_INSERT [dbo].[ESTADO] ON 

INSERT [dbo].[ESTADO] ([ID], [Nombre]) VALUES (1, N'ACTIVO')
INSERT [dbo].[ESTADO] ([ID], [Nombre]) VALUES (2, N'INACTIVO')
SET IDENTITY_INSERT [dbo].[ESTADO] OFF
SET IDENTITY_INSERT [dbo].[ESTUDIANTE] ON 

INSERT [dbo].[ESTUDIANTE] ([ID], [ID_Usuario], [No_Carnet], [Contrasena], [Tanda], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, 1, N'20160111', N'20160111', N'NOCHE', N'ACTIVO', CAST(N'2017-03-19T04:54:15.000' AS DateTime), 0, CAST(N'2017-03-19T04:54:32.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[ESTUDIANTE] OFF
SET IDENTITY_INSERT [dbo].[MODULO] ON 

INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (1, N'USUARIO')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (2, N'ESTUDIANTE')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (3, N'PROFESOR')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (4, N'EMPLEADO')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (5, N'CAMPUS')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (6, N'EDIFICIO')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (7, N'AULA')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (8, N'TIPO_AULA')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (9, N'DETALLE_AULA')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (10, N'TANDA')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (11, N'ROL')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (12, N'ASIGNAR_PERMISO_ROL')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (13, N'ASIGNAR_ROL_USUARIO')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (14, N'SOLICITUD')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (15, N'GESTION')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (16, N'CONFIGURACION')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (17, N'REPORTE')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (18, N'DETALLE_SOLICITUD')
INSERT [dbo].[MODULO] ([ID], [Nombre]) VALUES (19, N'SERVICIO')
SET IDENTITY_INSERT [dbo].[MODULO] OFF
SET IDENTITY_INSERT [dbo].[PROFESOR] ON 

INSERT [dbo].[PROFESOR] ([ID], [ID_Usuario], [No_Carnet], [Contrasena], [Tanda_Laboral], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (7, 1, N'20160111', N'2016011', N'MAÑANA', N'ACTIVO', CAST(N'2017-03-19T05:34:33.000' AS DateTime), 0, CAST(N'2017-03-27T03:26:06.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[PROFESOR] OFF
SET IDENTITY_INSERT [dbo].[ROL] ON 

INSERT [dbo].[ROL] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'ASISTENTE', N'Es quien puede atenser una solicitud', N'ACTIVO', NULL, NULL, NULL, NULL)
INSERT [dbo].[ROL] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, N'CLIENTE', N'Es quien usa los servicios', N'ACTIVO', NULL, NULL, NULL, NULL)
INSERT [dbo].[ROL] ([ID], [Nombre], [Descripcion], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (3, N'ADMINISTRADOR', N'Es quien configura el sistema', N'ACTIVO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ROL] OFF
SET IDENTITY_INSERT [dbo].[SOLICITUD] ON 

INSERT [dbo].[SOLICITUD] ([ID], [ID_Usuario], [ID_Aula], [Fecha_Reservacion], [Cantidad_Hora], [Fecha_Fin], [Comentario], [Estado], [Ejecucion]) VALUES (1, 1, 2, CAST(N'2017-03-27T00:00:00.000' AS DateTime), 0, NULL, N'hola', N'INACTIVO', N'CANCELADO')
INSERT [dbo].[SOLICITUD] ([ID], [ID_Usuario], [ID_Aula], [Fecha_Reservacion], [Cantidad_Hora], [Fecha_Fin], [Comentario], [Estado], [Ejecucion]) VALUES (2, 1, 2, CAST(N'2017-04-09T10:00:00.000' AS DateTime), 4, NULL, N'Solicitar aula', N'ACTIVO', N'ABIERTO')
INSERT [dbo].[SOLICITUD] ([ID], [ID_Usuario], [ID_Aula], [Fecha_Reservacion], [Cantidad_Hora], [Fecha_Fin], [Comentario], [Estado], [Ejecucion]) VALUES (3, 1, 2, CAST(N'2017-04-09T10:00:00.000' AS DateTime), 6, NULL, N'Buenos dias', N'ACTIVO', N'ABIERTO')
SET IDENTITY_INSERT [dbo].[SOLICITUD] OFF
SET IDENTITY_INSERT [dbo].[TANDA] ON 

INSERT [dbo].[TANDA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'MAÑANA', N'', NULL, NULL, NULL, NULL)
INSERT [dbo].[TANDA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, N'TARDE', N'', CAST(N'2017-03-19T01:58:10.000' AS DateTime), 0, CAST(N'2017-03-19T01:58:34.000' AS DateTime), 0)
INSERT [dbo].[TANDA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (3, N'NOCHE', N'', CAST(N'2017-03-19T01:58:25.000' AS DateTime), 0, CAST(N'2017-03-19T01:58:25.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[TANDA] OFF
SET IDENTITY_INSERT [dbo].[TIPO_AULA] ON 

INSERT [dbo].[TIPO_AULA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'AUDITORIO', N'', CAST(N'2017-03-19T12:21:36.000' AS DateTime), 0, CAST(N'2017-03-19T12:21:58.000' AS DateTime), 0)
INSERT [dbo].[TIPO_AULA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (2, N'GENERAL', N'', CAST(N'2017-03-19T12:22:26.000' AS DateTime), 0, CAST(N'2017-03-19T12:22:26.000' AS DateTime), 0)
INSERT [dbo].[TIPO_AULA] ([ID], [Nombre], [Descripcion], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (3, N'LABORATORIO', N'', CAST(N'2017-03-19T12:22:46.000' AS DateTime), 0, CAST(N'2017-03-19T12:22:46.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[TIPO_AULA] OFF
SET IDENTITY_INSERT [dbo].[TIPO_USUARIO] ON 

INSERT [dbo].[TIPO_USUARIO] ([ID], [Nombre]) VALUES (1, N'ESTUDIANTE')
INSERT [dbo].[TIPO_USUARIO] ([ID], [Nombre]) VALUES (2, N'EMPLEADO')
INSERT [dbo].[TIPO_USUARIO] ([ID], [Nombre]) VALUES (3, N'PROFESOR')
SET IDENTITY_INSERT [dbo].[TIPO_USUARIO] OFF
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([ID], [Nombre], [Cedula], [Estado], [Fecha_Creado], [Creado_Por], [Fecha_Actualizado], [Actualizado_Por]) VALUES (1, N'DAVID SANCHEZ', N'402-2619978-0', N'ACTIVO', CAST(N'2017-03-18T16:27:14.000' AS DateTime), 0, CAST(N'2017-03-18T16:46:28.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
ALTER TABLE [dbo].[ASIGNAR_PERMISO_ROL]  WITH CHECK ADD  CONSTRAINT [Asignar_Permiso_Rol_ID_Modulo_fk] FOREIGN KEY([ID_Modulo])
REFERENCES [dbo].[MODULO] ([ID])
GO
ALTER TABLE [dbo].[ASIGNAR_PERMISO_ROL] CHECK CONSTRAINT [Asignar_Permiso_Rol_ID_Modulo_fk]
GO
ALTER TABLE [dbo].[ASIGNAR_PERMISO_ROL]  WITH CHECK ADD  CONSTRAINT [Asignar_Permiso_Rol_ID_Rol_fk] FOREIGN KEY([ID_Rol])
REFERENCES [dbo].[ROL] ([ID])
GO
ALTER TABLE [dbo].[ASIGNAR_PERMISO_ROL] CHECK CONSTRAINT [Asignar_Permiso_Rol_ID_Rol_fk]
GO
ALTER TABLE [dbo].[ASIGNAR_USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [Asignar_Usuario_Rol_ID_Rol_fk] FOREIGN KEY([ID_Rol])
REFERENCES [dbo].[ROL] ([ID])
GO
ALTER TABLE [dbo].[ASIGNAR_USUARIO_ROL] CHECK CONSTRAINT [Asignar_Usuario_Rol_ID_Rol_fk]
GO
ALTER TABLE [dbo].[ASIGNAR_USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [Asignar_Usuario_Rol_ID_Usuario_fk] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIO] ([ID])
GO
ALTER TABLE [dbo].[ASIGNAR_USUARIO_ROL] CHECK CONSTRAINT [Asignar_Usuario_Rol_ID_Usuario_fk]
GO
ALTER TABLE [dbo].[AULA]  WITH CHECK ADD  CONSTRAINT [Aula_ID_Edificio_fk] FOREIGN KEY([ID_Edificio])
REFERENCES [dbo].[EDIFICIO] ([ID])
GO
ALTER TABLE [dbo].[AULA] CHECK CONSTRAINT [Aula_ID_Edificio_fk]
GO
ALTER TABLE [dbo].[DETALLE_AULA]  WITH CHECK ADD  CONSTRAINT [Detalle_Aula_ID_Aula_fk] FOREIGN KEY([ID_Aula])
REFERENCES [dbo].[AULA] ([ID])
GO
ALTER TABLE [dbo].[DETALLE_AULA] CHECK CONSTRAINT [Detalle_Aula_ID_Aula_fk]
GO
ALTER TABLE [dbo].[DETALLE_SOLICITUD]  WITH CHECK ADD  CONSTRAINT [Detalle_Solicitud_ID_Empleado_fk] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[EMPLEADO] ([ID])
GO
ALTER TABLE [dbo].[DETALLE_SOLICITUD] CHECK CONSTRAINT [Detalle_Solicitud_ID_Empleado_fk]
GO
ALTER TABLE [dbo].[DETALLE_SOLICITUD]  WITH CHECK ADD  CONSTRAINT [Detalle_Solicitud_ID_Solicitud_fk] FOREIGN KEY([ID_Solicitud])
REFERENCES [dbo].[SOLICITUD] ([ID])
GO
ALTER TABLE [dbo].[DETALLE_SOLICITUD] CHECK CONSTRAINT [Detalle_Solicitud_ID_Solicitud_fk]
GO
ALTER TABLE [dbo].[EDIFICIO]  WITH CHECK ADD  CONSTRAINT [Edificio_ID_Campus_fk] FOREIGN KEY([ID_Campus])
REFERENCES [dbo].[CAMPUS] ([ID])
GO
ALTER TABLE [dbo].[EDIFICIO] CHECK CONSTRAINT [Edificio_ID_Campus_fk]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [Empleado_ID_Usuario_fk] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIO] ([ID])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [Empleado_ID_Usuario_fk]
GO
ALTER TABLE [dbo].[ESTUDIANTE]  WITH CHECK ADD  CONSTRAINT [Estudiante_ID_Usuario_fk] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIO] ([ID])
GO
ALTER TABLE [dbo].[ESTUDIANTE] CHECK CONSTRAINT [Estudiante_ID_Usuario_fk]
GO
ALTER TABLE [dbo].[PROFESOR]  WITH CHECK ADD  CONSTRAINT [Profesor_ID_Usuario_fk] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIO] ([ID])
GO
ALTER TABLE [dbo].[PROFESOR] CHECK CONSTRAINT [Profesor_ID_Usuario_fk]
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD  CONSTRAINT [Solicitud_ID_Aula_fk] FOREIGN KEY([ID_Aula])
REFERENCES [dbo].[AULA] ([ID])
GO
ALTER TABLE [dbo].[SOLICITUD] CHECK CONSTRAINT [Solicitud_ID_Aula_fk]
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD  CONSTRAINT [Solicitud_ID_Usuario_fk] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIO] ([ID])
GO
ALTER TABLE [dbo].[SOLICITUD] CHECK CONSTRAINT [Solicitud_ID_Usuario_fk]
GO
USE [master]
GO
ALTER DATABASE [GESTIONDEAULA] SET  READ_WRITE 
GO
