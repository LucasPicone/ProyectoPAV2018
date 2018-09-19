USE [Simulacro_Parcial_75982]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 09/18/2018 00:29:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfiles]') AND type in (N'U'))
DROP TABLE [dbo].[Perfiles]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/18/2018 00:29:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/18/2018 00:29:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[correo_electronico] [varchar](50) NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 09/18/2018 00:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfiles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[n_perfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (2, N'Tester')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (3, N'Desarrollador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (4, N'Responsable de Reportes')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
