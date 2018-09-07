USE [BDBochas]
GO
/****** Object:  Table [dbo].[Disciplinas]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disciplinas](
	[idDisciplina] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precioCuota] [int] NOT NULL,
 CONSTRAINT [PK_Disciplinas] PRIMARY KEY CLUSTERED 
(
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[edadDesde] [int] NOT NULL,
	[edadHasta] [int] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socios](
	[idSocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[direccion] [varchar](75) NULL,
	[dni] [int] NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Socios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recibo]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibo](
	[nroRecibo] [int] IDENTITY(1,1) NOT NULL,
	[fechaRecibo] [date] NOT NULL,
	[montoPagado] [int] NOT NULL,
 CONSTRAINT [PK_Recibo] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](20) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposBeca]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposBeca](
	[idTipoBeca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposBeca] PRIMARY KEY CLUSTERED 
(
	[idTipoBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[idTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPagoCuota]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPagoCuota](
	[idTipoPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](15) NOT NULL,
 CONSTRAINT [PK_TipoPagoCuota] PRIMARY KEY CLUSTERED 
(
	[idTipoPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TelefonosXSocios]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TelefonosXSocios](
	[idSocio] [int] NOT NULL,
	[nroTelefono] [int] NOT NULL,
	[responsableTelefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TelefonosXSocios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategoriasXDisciplinas]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriasXDisciplinas](
	[idCategoria] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[precioCuota] [int] NOT NULL,
	[precioInscripcion] [int] NOT NULL,
 CONSTRAINT [PK_CategoriasXDisciplinas] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC,
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[idTipoProducto] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precioUnitario] [int] NOT NULL,
	[idProductos] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[idProductos] ASC,
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DisciplinasXSocios]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DisciplinasXSocios](
	[idSocio] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[asistencia] [varchar](1) NOT NULL,
 CONSTRAINT [PK_DisciplinasXSocios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC,
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Becas]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Becas](
	[idBeca] [int] IDENTITY(1,1) NOT NULL,
	[idTipoBeca] [int] NOT NULL,
 CONSTRAINT [PK_Becas] PRIMARY KEY CLUSTERED 
(
	[idBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuotaSocial]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuotaSocial](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idTipoPago] [int] NOT NULL,
 CONSTRAINT [PK_CuotaSocial] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuotaDisciplina]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuotaDisciplina](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
 CONSTRAINT [PK_CuotaDisciplina] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC,
	[idCategoria] ASC,
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BecasXSocios]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BecasXSocios](
	[idBeca] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[fechaInicioBeca] [date] NOT NULL,
	[fechaFinBeca] [date] NULL,
 CONSTRAINT [PK_BecasXSocios] PRIMARY KEY CLUSTERED 
(
	[idBeca] ASC,
	[fechaInicioBeca] ASC,
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaProductos]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProductos](
	[nroRecibo] [int] NOT NULL,
	[idProductos] [int] NOT NULL,
	[idTipoProducto] [int] NOT NULL,
 CONSTRAINT [PK_VentaProductos] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idProductos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaProductosXSocioXDisciplina]    Script Date: 09/07/2018 17:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProductosXSocioXDisciplina](
	[idRecibo] [int] NOT NULL,
	[idProductos] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
 CONSTRAINT [PK_VentaProductosXSocioXDisciplina] PRIMARY KEY CLUSTERED 
(
	[idRecibo] ASC,
	[idDisciplina] ASC,
	[idProductos] ASC,
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Becas_TiposBeca]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[Becas]  WITH CHECK ADD  CONSTRAINT [FK_Becas_TiposBeca] FOREIGN KEY([idTipoBeca])
REFERENCES [dbo].[TiposBeca] ([idTipoBeca])
GO
ALTER TABLE [dbo].[Becas] CHECK CONSTRAINT [FK_Becas_TiposBeca]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Becas]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Becas] FOREIGN KEY([idBeca])
REFERENCES [dbo].[Becas] ([idBeca])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Becas]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Socios]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_CategoriasXDisciplinas_Categorias]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CategoriasXDisciplinas]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXDisciplinas_Categorias] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categorias] ([idCategoria])
GO
ALTER TABLE [dbo].[CategoriasXDisciplinas] CHECK CONSTRAINT [FK_CategoriasXDisciplinas_Categorias]
GO
/****** Object:  ForeignKey [FK_CategoriasXDisciplinas_Disciplinas]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CategoriasXDisciplinas]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas] FOREIGN KEY([idDisciplina])
REFERENCES [dbo].[Disciplinas] ([idDisciplina])
GO
ALTER TABLE [dbo].[CategoriasXDisciplinas] CHECK CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_CategoriasXDisciplinas]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_CategoriasXDisciplinas] FOREIGN KEY([idCategoria], [idDisciplina])
REFERENCES [dbo].[CategoriasXDisciplinas] ([idCategoria], [idDisciplina])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_CategoriasXDisciplinas]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_Recibo]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_Recibo]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_Socios]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_Socios]
GO
/****** Object:  ForeignKey [FK_CuotaSocial_TipoPagoCuota]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[CuotaSocial]  WITH CHECK ADD  CONSTRAINT [FK_CuotaSocial_TipoPagoCuota] FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TipoPagoCuota] ([idTipoPago])
GO
ALTER TABLE [dbo].[CuotaSocial] CHECK CONSTRAINT [FK_CuotaSocial_TipoPagoCuota]
GO
/****** Object:  ForeignKey [FK_DisciplinasXSocios_Disciplinas]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[DisciplinasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_DisciplinasXSocios_Disciplinas] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Disciplinas] ([idDisciplina])
GO
ALTER TABLE [dbo].[DisciplinasXSocios] CHECK CONSTRAINT [FK_DisciplinasXSocios_Disciplinas]
GO
/****** Object:  ForeignKey [FK_DisciplinasXSocios_Socios]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[DisciplinasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_DisciplinasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[DisciplinasXSocios] CHECK CONSTRAINT [FK_DisciplinasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_Productos_TipoProducto]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProducto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo].[TipoProducto] ([idTipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProducto]
GO
/****** Object:  ForeignKey [FK_TelefonosXSocios_Socios]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[TelefonosXSocios]  WITH CHECK ADD  CONSTRAINT [FK_TelefonosXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[TelefonosXSocios] CHECK CONSTRAINT [FK_TelefonosXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Productos]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Productos] FOREIGN KEY([idProductos], [idTipoProducto])
REFERENCES [dbo].[Productos] ([idProductos], [idTipoProducto])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Productos]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Recibo]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Recibo]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_Disciplinas]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Disciplinas] FOREIGN KEY([idDisciplina])
REFERENCES [dbo].[Disciplinas] ([idDisciplina])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Disciplinas]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_Socios]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_VentaProductos]    Script Date: 09/07/2018 17:59:56 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos] FOREIGN KEY([idRecibo], [idProductos])
REFERENCES [dbo].[VentaProductos] ([nroRecibo], [idProductos])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos]
GO
