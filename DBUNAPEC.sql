

USE [DBUNAPEC]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aulas](
	[Id_Aula] [varchar](10) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[tipo_aula] [int] NOT NULL,
	[id_edificio] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Cupos_Reservados] [int] NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Aulas] PRIMARY KEY CLUSTERED 
(
	[Id_Aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Campus]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campus](
	[Id_Campus] [int] NOT NULL IDENTITY(1,1),
	[Descripcion] [varchar](100) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Campus] PRIMARY KEY CLUSTERED 
(
	[Id_Campus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Edificios]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificios] (
	[Id_Edificio] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[ID_Campus] [int] NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Edificios] PRIMARY KEY CLUSTERED 
(
	[Id_Edificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id_empleado] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[tanda] [varchar](50) NOT NULL,
	[f_ingreso] [varchar](50) NOT NULL,
	[Estado] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservaciones]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservaciones](
	[no_reservacion] [int] NOT NULL IDENTITY(1,1),
	[Empleado] [int] NOT NULL,
	[usuario] [int] NOT NULL,
	[f_reservacion] [date] NOT NULL,
	[c_horas] [varchar](50) NOT NULL,
	[Comentario] [varchar](100) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Reservaciones] PRIMARY KEY CLUSTERED 
(
	[no_reservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Aulas]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Aulas](
	[Id_TipoAula] [int] NOT NULL IDENTITY(1,1),
	[Descripcion] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Tipo_Aulas] PRIMARY KEY CLUSTERED 
(
	[Id_TipoAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/02/2017 08:07:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[No_carnet] [int] NOT NULL,
	[Cedula] [varchar](50) NOT NULL,
	[tipo_usuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[No_carnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Aulas]  WITH CHECK ADD  CONSTRAINT [FK_Aulas_Edificios] FOREIGN KEY([id_edificio])
REFERENCES [dbo].[Edificios] ([Id_Edificio])
GO
ALTER TABLE [dbo].[Aulas] CHECK CONSTRAINT [FK_Aulas_Edificios]
GO
ALTER TABLE [dbo].[Aulas]  WITH CHECK ADD  CONSTRAINT [FK_Aulas_Tipo_Aulas] FOREIGN KEY([tipo_aula])
REFERENCES [dbo].[Tipo_Aulas] ([Id_TipoAula])
GO
ALTER TABLE [dbo].[Aulas] CHECK CONSTRAINT [FK_Aulas_Tipo_Aulas]
GO
ALTER TABLE [dbo].[Edificios]  WITH CHECK ADD  CONSTRAINT [FK_Edificios_Campus] FOREIGN KEY([ID_Campus])
REFERENCES [dbo].[Campus] ([Id_Campus])
GO
ALTER TABLE [dbo].[Edificios] CHECK CONSTRAINT [FK_Edificios_Campus]
GO
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Empleado] FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleado] ([Id_empleado])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Empleado]
GO
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuario] ([No_carnet])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Usuario]
GO
