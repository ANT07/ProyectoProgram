USE [master]
GO
/****** Object:  Database [SistemaContable]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE DATABASE [SistemaContable]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaContable', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SistemaContable.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaContable_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SistemaContable_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaContable] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaContable].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaContable] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaContable] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaContable] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaContable] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaContable] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaContable] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaContable] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaContable] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaContable] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaContable] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaContable] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaContable] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaContable] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaContable] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaContable] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaContable] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaContable] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaContable] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaContable] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaContable] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaContable] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaContable] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaContable] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaContable] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaContable] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaContable] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaContable] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaContable] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SistemaContable] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SistemaContable]
GO
/****** Object:  UserDefinedFunction [dbo].[compruebausuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[compruebausuario](@usuario varchar(250))
returns int
as
begin 
	
return (select COUNT(*) from usuario where nombre=@usuario)
end

GO
/****** Object:  Table [dbo].[iu_menu]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[iu_menu](
	[ID_MENU] [int] IDENTITY(1,1) NOT NULL,
	[MENU] [varchar](45) NULL,
	[ICONO] [varchar](350) NULL,
	[MOVIL] [int] NULL CONSTRAINT [DF__iu_menu__movil__1273C1CD]  DEFAULT ('0'),
 CONSTRAINT [PK_IU_MENU] PRIMARY KEY CLUSTERED 
(
	[ID_MENU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[iu_opcion]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[iu_opcion](
	[ID_OPCION] [int] IDENTITY(1,1) NOT NULL,
	[OPCION] [varchar](65) NULL,
	[VISTA] [varchar](300) NULL,
	[ID_MENU] [int] NOT NULL,
	[CONTROLADOR] [varchar](300) NULL,
 CONSTRAINT [PK_IU_OPCION] PRIMARY KEY CLUSTERED 
(
	[ID_OPCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[iu_rol]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[iu_rol](
	[ID_ROL] [int] IDENTITY(1,1) NOT NULL,
	[ROL] [varchar](45) NULL,
 CONSTRAINT [PK_IU_ROL] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[iu_rol_menu]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[iu_rol_menu](
	[ID_ROL] [int] NOT NULL,
	[ID_OPCION] [int] NOT NULL,
	[ACCESO] [tinyint] NULL,
	[AGREGAR] [tinyint] NULL,
	[MODIFICAR] [tinyint] NULL,
	[ELIMINAR] [tinyint] NULL,
 CONSTRAINT [PK_IU_ROL_MENU] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC,
	[ID_OPCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblcuenta]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblcuenta](
	[CODIGOCUENTA] [varchar](150) NOT NULL,
	[IDNIVEL] [int] NOT NULL,
	[NOMBRECUENTA] [varchar](250) NOT NULL,
	[NUMEROCUENTA] [varchar](150) NOT NULL,
	[ID_USUARIO] [int] NOT NULL,
	[TBL_IDNIVEL] [int] NULL,
	[TBL_NUMEROCUENTA] [varchar](150) NULL,
	[IDTIPO] [bigint] NULL,
	[MAYOR] [int] NOT NULL,
 CONSTRAINT [PK_tblcuenta] PRIMARY KEY CLUSTERED 
(
	[IDNIVEL] ASC,
	[NUMEROCUENTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblcuentaNivel]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblcuentaNivel](
	[IDNIVEL] [int] NOT NULL,
	[NUMERONIVEL] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TBLCUENTANIVEL] PRIMARY KEY CLUSTERED 
(
	[IDNIVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbldetallepartida]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbldetallepartida](
	[IDPARTIDA] [varchar](100) NOT NULL,
	[IDNIVEL] [int] NOT NULL,
	[NUMEROCUENTA] [varchar](150) NOT NULL,
	[NUMERODETALLE] [smallint] NOT NULL,
	[PARCIAL] [float] NOT NULL,
	[DEBE] [float] NOT NULL,
	[HABER] [float] NOT NULL,
 CONSTRAINT [PK_TBLDETALLEPARTIDA] PRIMARY KEY CLUSTERED 
(
	[IDPARTIDA] ASC,
	[NUMERODETALLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblmaestropartida]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblmaestropartida](
	[IDPARTIDA] [varchar](100) NOT NULL,
	[ID_USUARIO] [int] NULL,
	[FECHACREACION] [datetime] NOT NULL,
	[CONCEPTOPARTIDA] [varchar](250) NOT NULL,
 CONSTRAINT [PK_TBLMAESTROPARTIDA] PRIMARY KEY CLUSTERED 
(
	[IDPARTIDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbltipocuenta]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbltipocuenta](
	[IDTIPO] [bigint] NOT NULL,
	[NOMBRETIPO] [varchar](250) NULL,
 CONSTRAINT [PK_TBLTIPOCUENTA] PRIMARY KEY CLUSTERED 
(
	[IDTIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[ID_USUARIO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](30) NULL,
	[CLAVE] [varchar](30) NULL,
	[ID_ROL] [int] NOT NULL,
	[NOMBRE_COMPLETO] [varchar](100) NULL,
	[ESTADO] [tinyint] NULL CONSTRAINT [DF__usuarios__estado__20C1E124]  DEFAULT ('0'),
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[usuarios]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[usuarios]
as
select id_usuario,nombre_completo,iu_rol.ROL,estado from usuario , iu_rol where usuario.ID_ROL = iu_rol.ID_ROL


GO
/****** Object:  View [dbo].[VistaMenus]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VistaMenus]
as 
select * from iu_menu
GO
/****** Object:  View [dbo].[VistaOpciones]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaOpciones]
AS
SELECT iu_opcion.ID_OPCION,iu_opcion.OPCION,iu_menu.MENU,iu_menu.ID_MENU,iu_rol.ROL,iu_rol.ID_ROL,iu_opcion.VISTA,iu_opcion.CONTROLADOR,
ACCESO = CASE iu_rol_menu.ACCESO WHEN 1 THEN 'SI' ELSE 'NO' END,EDITAR = CASE iu_rol_menu.MODIFICAR WHEN 1 THEN 'SI' ELSE 'NO'END ,
ELIMINAR = CASE iu_rol_menu.ELIMINAR WHEN 1 THEN 'SI' ELSE 'NO'END ,AGREGAR = CASE iu_rol_menu.AGREGAR WHEN 1 THEN 'SI' ELSE 'NO' END
FROM iu_opcion,iu_menu,iu_rol,iu_rol_menu
WHERE iu_menu.ID_MENU = iu_opcion.ID_MENU AND iu_opcion.ID_OPCION = iu_ROL_MENU.ID_OPCION AND iu_rol.ID_ROL = iu_rol_menu.ID_ROL

GO
/****** Object:  View [dbo].[VistaRoles]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VistaRoles]
as
select * from iu_rol
GO
/****** Object:  View [dbo].[VistaUsuarios]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VistaUsuarios]
as
select * from usuario
GO
/****** Object:  Index [FK_IU_OPCION_IU_MENU_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [FK_IU_OPCION_IU_MENU_FK] ON [dbo].[iu_opcion]
(
	[ID_MENU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FK_IU_ROL_MENU_IU_OPCION_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [FK_IU_ROL_MENU_IU_OPCION_FK] ON [dbo].[iu_rol_menu]
(
	[ID_OPCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FK_IU_ROL_MENU_IU_ROL_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [FK_IU_ROL_MENU_IU_ROL_FK] ON [dbo].[iu_rol_menu]
(
	[ID_ROL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [RELATIONSHIP_12_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [RELATIONSHIP_12_FK] ON [dbo].[tblcuenta]
(
	[IDTIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [RELATIONSHIP_5_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [RELATIONSHIP_5_FK] ON [dbo].[tblcuenta]
(
	[IDNIVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [RELATIONSHIP_8_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [RELATIONSHIP_8_FK] ON [dbo].[tblcuenta]
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RELATIONSHIP_10_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [RELATIONSHIP_10_FK] ON [dbo].[tbldetallepartida]
(
	[IDPARTIDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [RELATIONSHIP_7_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [RELATIONSHIP_7_FK] ON [dbo].[tblmaestropartida]
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FK_USUARIO_IU_ROL_FK]    Script Date: 10/21/2017 10:59:50 PM ******/
CREATE NONCLUSTERED INDEX [FK_USUARIO_IU_ROL_FK] ON [dbo].[usuario]
(
	[ID_ROL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[iu_opcion]  WITH CHECK ADD  CONSTRAINT [FK_iu_opcion_iu_menu] FOREIGN KEY([ID_MENU])
REFERENCES [dbo].[iu_menu] ([ID_MENU])
GO
ALTER TABLE [dbo].[iu_opcion] CHECK CONSTRAINT [FK_iu_opcion_iu_menu]
GO
ALTER TABLE [dbo].[iu_rol_menu]  WITH CHECK ADD  CONSTRAINT [FK_iu_rol_menu_iu_opcion] FOREIGN KEY([ID_OPCION])
REFERENCES [dbo].[iu_opcion] ([ID_OPCION])
GO
ALTER TABLE [dbo].[iu_rol_menu] CHECK CONSTRAINT [FK_iu_rol_menu_iu_opcion]
GO
ALTER TABLE [dbo].[iu_rol_menu]  WITH CHECK ADD  CONSTRAINT [FK_iu_rol_menu_iu_rol] FOREIGN KEY([ID_ROL])
REFERENCES [dbo].[iu_rol] ([ID_ROL])
GO
ALTER TABLE [dbo].[iu_rol_menu] CHECK CONSTRAINT [FK_iu_rol_menu_iu_rol]
GO
ALTER TABLE [dbo].[tblcuenta]  WITH CHECK ADD  CONSTRAINT [FK_TBLCUENT_1_TBLCUENT] FOREIGN KEY([IDNIVEL])
REFERENCES [dbo].[tblcuentaNivel] ([IDNIVEL])
GO
ALTER TABLE [dbo].[tblcuenta] CHECK CONSTRAINT [FK_TBLCUENT_1_TBLCUENT]
GO
ALTER TABLE [dbo].[tblcuenta]  WITH CHECK ADD  CONSTRAINT [FK_TBLCUENT_RELATIONS_TBLTIPOC] FOREIGN KEY([IDTIPO])
REFERENCES [dbo].[tbltipocuenta] ([IDTIPO])
GO
ALTER TABLE [dbo].[tblcuenta] CHECK CONSTRAINT [FK_TBLCUENT_RELATIONS_TBLTIPOC]
GO
ALTER TABLE [dbo].[tblcuenta]  WITH CHECK ADD  CONSTRAINT [FK_tblcuenta_tblcuenta] FOREIGN KEY([TBL_IDNIVEL], [TBL_NUMEROCUENTA])
REFERENCES [dbo].[tblcuenta] ([IDNIVEL], [NUMEROCUENTA])
GO
ALTER TABLE [dbo].[tblcuenta] CHECK CONSTRAINT [FK_tblcuenta_tblcuenta]
GO
ALTER TABLE [dbo].[tblcuenta]  WITH CHECK ADD  CONSTRAINT [FK_tblcuenta_usuario] FOREIGN KEY([ID_USUARIO])
REFERENCES [dbo].[usuario] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[tblcuenta] CHECK CONSTRAINT [FK_tblcuenta_usuario]
GO
ALTER TABLE [dbo].[tbldetallepartida]  WITH CHECK ADD  CONSTRAINT [FK_TBLDETAL_RELATIONS_TBLMAEST] FOREIGN KEY([IDPARTIDA])
REFERENCES [dbo].[tblmaestropartida] ([IDPARTIDA])
GO
ALTER TABLE [dbo].[tbldetallepartida] CHECK CONSTRAINT [FK_TBLDETAL_RELATIONS_TBLMAEST]
GO
ALTER TABLE [dbo].[tbldetallepartida]  WITH CHECK ADD  CONSTRAINT [FK_tbldetallepartida_tblcuenta] FOREIGN KEY([IDNIVEL], [NUMEROCUENTA])
REFERENCES [dbo].[tblcuenta] ([IDNIVEL], [NUMEROCUENTA])
GO
ALTER TABLE [dbo].[tbldetallepartida] CHECK CONSTRAINT [FK_tbldetallepartida_tblcuenta]
GO
ALTER TABLE [dbo].[tblmaestropartida]  WITH CHECK ADD  CONSTRAINT [FK_tblmaestropartida_usuario] FOREIGN KEY([ID_USUARIO])
REFERENCES [dbo].[usuario] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[tblmaestropartida] CHECK CONSTRAINT [FK_tblmaestropartida_usuario]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_iu_rol] FOREIGN KEY([ID_ROL])
REFERENCES [dbo].[iu_rol] ([ID_ROL])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_iu_rol]
GO
/****** Object:  StoredProcedure [dbo].[AgregarMenu]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarMenu]
@menu varchar(250),
@icono varchar(250)
as
insert into iu_menu values(@menu,@icono,0)
GO
/****** Object:  StoredProcedure [dbo].[AgregarOpcion]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarOpcion]
@opcion varchar(250),
@vista varchar(250),
@controlador varchar(250),
@id_menu int,
@id_rol int,
@acceso int,
@agregar int,
@modificar int,
@eliminar int
as
begin 
	insert into iu_opcion values(@opcion,@vista,@id_menu,@controlador)
	declare @idop int
	set @idop = (select iu_opcion.ID_OPCION  from iu_opcion where iu_opcion.ID_MENU = @id_menu and iu_opcion.OPCION = @opcion)
	insert into iu_rol_menu values(@id_rol,@idop,@acceso,@agregar,@modificar,@eliminar)

end
GO
/****** Object:  StoredProcedure [dbo].[AgregarRol]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarRol]
@rol varchar(250)
as begin 
	insert into iu_rol values(@rol)
end
GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarUsuario]
@usuario varchar(100),
@clave varchar(100),
@id_rol int,
@nombre_completo varchar(250),
@estado int
AS
begin 

insert into usuario values(@usuario,@clave,@id_rol,@nombre_completo,@estado)

end

GO
/****** Object:  StoredProcedure [dbo].[EditarMenu]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarMenu]
@idmenu int,
@menu varchar(250),
@icono varchar(250)
as
update iu_menu set MENU = @menu , ICONO = @icono where ID_MENU = @idmenu
GO
/****** Object:  StoredProcedure [dbo].[EditarOpcion]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarOpcion]
@idopcion int,
@opcion varchar(250),
@vista varchar(250),
@controlador varchar(250),
@id_menu int,
@id_rol int,
@acceso int,
@agregar int,
@modificar int,
@eliminar int
as
begin 
	update iu_opcion set OPCION = @opcion , VISTA = @vista, CONTROLADOR = @controlador, ID_MENU = @id_menu
	where ID_OPCION = @idopcion

	update iu_rol_menu set ACCESO = @acceso , AGREGAR =  @agregar , MODIFICAR = @modificar , ELIMINAR = @eliminar 
	where ID_OPCION = @idopcion and ID_ROL = @id_rol

end
GO
/****** Object:  StoredProcedure [dbo].[EditarRol]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarRol] 
@idrol int,
@rol varchar(250)
as
update iu_rol set ROL = @rol where ID_ROL = @idrol
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarUsuario]
@nombre varchar(250),
@clave varchar(50),
@idrol int,
@nombrecompleto varchar(250),
@estado int,
@iduser int
as
update usuario set NOMBRE = @nombre, CLAVE = @clave , ID_ROL = @idrol,NOMBRE_COMPLETO = @nombrecompleto , ESTADO = @estado
where ID_USUARIO = @iduser
GO
/****** Object:  StoredProcedure [dbo].[EliminarMenu]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarMenu]
@idemenu int
as
delete iu_menu where ID_MENU = @idemenu
GO
/****** Object:  StoredProcedure [dbo].[EliminarOpcion]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EliminarOpcion] 
@id_opcion int,
@id_rol int
as begin 
	delete iu_rol_menu where ID_OPCION = @id_opcion  and ID_ROL = @id_rol
	delete iu_opcion where ID_OPCION = @id_opcion
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarRol]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarRol]
@id_rol int
as 
begin 
delete iu_rol where ID_ROL = @id_rol

end
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarUsuario]
@id_usuario int
as
begin 
delete usuario where ID_USUARIO = @id_usuario

end
GO
/****** Object:  StoredProcedure [dbo].[GetOpcion]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOpcion]
@idopcion int,
@idrol int
as
SELECT iu_opcion.ID_OPCION,iu_opcion.OPCION,iu_menu.MENU,iu_menu.ID_MENU,iu_rol.ROL,iu_rol.ID_ROL,iu_opcion.VISTA,iu_opcion.CONTROLADOR,
ACCESO = CASE iu_rol_menu.ACCESO WHEN 1 THEN 'SI' ELSE 'NO' END,EDITAR = CASE iu_rol_menu.MODIFICAR WHEN 1 THEN 'SI' ELSE 'NO'END ,
ELIMINAR = CASE iu_rol_menu.ELIMINAR WHEN 1 THEN 'SI' ELSE 'NO'END ,AGREGAR = CASE iu_rol_menu.AGREGAR WHEN 1 THEN 'SI' ELSE 'NO' END
FROM iu_opcion,iu_menu,iu_rol,iu_rol_menu
WHERE iu_menu.ID_MENU = iu_opcion.ID_MENU AND iu_opcion.ID_OPCION = iu_ROL_MENU.ID_OPCION AND iu_rol.ID_ROL = iu_rol_menu.ID_ROL
and iu_rol_menu.ID_ROL = @idrol and iu_rol_menu.ID_OPCION = @idopcion

GO
/****** Object:  StoredProcedure [dbo].[ingresoUsuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ingresoUsuario]
@USUARIO VARCHAR(250),
@CLAVE VARCHAR(250)
AS
	SELECT * FROM usuario WHERE NOMBRE = @USUARIO AND CLAVE = @CLAVE AND ESTADO = 1

GO
/****** Object:  StoredProcedure [dbo].[menus]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[menus]
as
select menu from iu_menu
GO
/****** Object:  StoredProcedure [dbo].[opciones]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[opciones]
@menu varchar(250),
@usuario varchar(250)
as
begin 
	select iu_opcion.OPCION,iu_opcion.VISTA,iu_opcion.CONTROLADOR,iu_rol_menu.ACCESO,iu_rol_menu.AGREGAR,iu_rol_menu.ELIMINAR,iu_rol_menu.MODIFICAR from iu_rol_menu,iu_rol,iu_opcion,iu_menu,usuario where usuario.nombre=@usuario
AND iu_menu.MENU = @menu
and iu_opcion.ID_OPCION = iu_rol_menu.ID_OPCION 
and iu_rol.ID_ROL = usuario.ID_ROL 
and iu_rol.id_rol = iu_rol_menu.ID_ROL
AND iu_menu.ID_MENU = iu_opcion.ID_MENU

end
GO
/****** Object:  StoredProcedure [dbo].[registrousuario]    Script Date: 10/21/2017 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrousuario]
@usuario varchar(250),
@nombreCompleto varchar(250),
@clave varchar(250),
@rol int
as
begin
insert into usuario(nombre, nombre_completo, clave , id_rol) values(@usuario,@nombreCompleto,@clave,@rol)
end

GO
USE [master]
GO
ALTER DATABASE [SistemaContable] SET  READ_WRITE 
GO
