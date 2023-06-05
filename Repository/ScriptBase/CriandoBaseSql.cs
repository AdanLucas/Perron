
using Repository.ScriptBase;

public static class CriandoBaseSql
{
    private static string nomePadrao = "";

	public static CriandoProcedure Procedures = new CriandoProcedure(); 

    public static string ScriptBase()
    {
            return $@"
						USE [master]
						GO
						/****** Object:  Database [{nomePadrao}]    Script Date: 04/06/2023 00:48:17 ******/
						CREATE DATABASE [{nomePadrao}]
						
						ALTER DATABASE [{nomePadrao}] SET COMPATIBILITY_LEVEL = 140
						GO
						IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
						begin
						EXEC [{nomePadrao}].[dbo].[sp_fulltext_database] @action = 'enable'
						end
						GO
						ALTER DATABASE [{nomePadrao}] SET ANSI_NULL_DEFAULT OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET ANSI_NULLS OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET ANSI_PADDING OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET ANSI_WARNINGS OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET ARITHABORT OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET AUTO_CLOSE OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET AUTO_SHRINK OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET AUTO_UPDATE_STATISTICS ON 
						GO
						ALTER DATABASE [{nomePadrao}] SET CURSOR_CLOSE_ON_COMMIT OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET CURSOR_DEFAULT  GLOBAL 
						GO
						ALTER DATABASE [{nomePadrao}] SET CONCAT_NULL_YIELDS_NULL OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET NUMERIC_ROUNDABORT OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET QUOTED_IDENTIFIER OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET RECURSIVE_TRIGGERS OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET  DISABLE_BROKER 
						GO
						ALTER DATABASE [{nomePadrao}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET DATE_CORRELATION_OPTIMIZATION OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET TRUSTWORTHY OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET ALLOW_SNAPSHOT_ISOLATION OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET PARAMETERIZATION SIMPLE 
						GO
						ALTER DATABASE [{nomePadrao}] SET READ_COMMITTED_SNAPSHOT OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET HONOR_BROKER_PRIORITY OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET RECOVERY FULL 
						GO
						ALTER DATABASE [{nomePadrao}] SET  MULTI_USER 
						GO
						ALTER DATABASE [{nomePadrao}] SET PAGE_VERIFY CHECKSUM  
						GO
						ALTER DATABASE [{nomePadrao}] SET DB_CHAINING OFF 
						GO
						ALTER DATABASE [{nomePadrao}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
						GO
						ALTER DATABASE [{nomePadrao}] SET TARGET_RECOVERY_TIME = 60 SECONDS 
						GO
						ALTER DATABASE [{nomePadrao}] SET DELAYED_DURABILITY = DISABLED 
						GO
						ALTER DATABASE [{nomePadrao}] SET QUERY_STORE = OFF
						GO
						USE [{nomePadrao}]
						GO
						ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
						GO
						ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
						GO
						ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
						GO
						ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
						GO
						ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
						GO
						ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
						GO
						ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
						GO
						ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
						GO
						ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
						GO
						USE [{nomePadrao}]
						GO
						/****** Object:  Table [dbo].[Classe]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Classe](
							[Id] [int] IDENTITY(1,1) NOT NULL,
							[Descricao] [varchar](50) NULL,
							[Ativo] [bit] NULL,
						 CONSTRAINT [PK_Classe] PRIMARY KEY CLUSTERED 
						(
							[Id] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]
						GO
						/****** Object:  Table [dbo].[Engrediente]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Engrediente](
							[Id] [int] IDENTITY(1,1) NOT NULL,
							[Descricao] [varchar](50) NULL,
							[Ativo] [bit] NULL,
						 CONSTRAINT [PK_Engrediente] PRIMARY KEY CLUSTERED 
						(
							[Id] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]
						GO
						/****** Object:  Table [dbo].[Sabor]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Sabor](
							[Id] [int] IDENTITY(1,1) NOT NULL,
							[Descricao] [varchar](50) NULL,
							[IdClasse] [int] NULL,
							[Ativo] [bit] NULL,
						 CONSTRAINT [PK_Sabor] PRIMARY KEY CLUSTERED 
						(
							[Id] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]
						GO
						/****** Object:  Table [dbo].[Sabor_has_Engrediente]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Sabor_has_Engrediente](
							[Id] [int] IDENTITY(1,1) NOT NULL,
							[Sabor] [int] NULL,
							[Engrediente] [int] NULL,
							[Ativo] [bit] NULL,
						 CONSTRAINT [PK_Sabor_has_Engrediente] PRIMARY KEY CLUSTERED 
						(
							[Id] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]
						GO
						/****** Object:  Table [dbo].[Sabor_has_EngredienteTamanho]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Sabor_has_EngredienteTamanho](
							[IdSaborEngrediente] [int] NULL,
							[Tamanho] [int] NULL,
							[Quantidade] [decimal](6, 2) NULL,
							[UnidadeMedida] [int] NULL,
							[Ativo] [bit] NULL
						) ON [PRIMARY]
						GO
						/****** Object:  Table [dbo].[Tamanho]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE TABLE [dbo].[Tamanho](
							[Id] [int] IDENTITY(1,1) NOT NULL,
							[Descricao] [varchar](50) NULL,
							[QntPedacos] [int] NULL,
							[Ativo] [bit] NULL,
						 CONSTRAINT [PK_Tamanho] PRIMARY KEY CLUSTERED 
						(
							[Id] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]
						GO
						ALTER TABLE [dbo].[Sabor]  WITH CHECK ADD  CONSTRAINT [FK_Sabor_Classe] FOREIGN KEY([IdClasse])
						REFERENCES [dbo].[Classe] ([Id])
						GO
						ALTER TABLE [dbo].[Sabor] CHECK CONSTRAINT [FK_Sabor_Classe]
						GO
						ALTER TABLE [dbo].[Sabor_has_Engrediente]  WITH CHECK ADD  CONSTRAINT [FK_Sabor_has_Engrediente_Engrediente] FOREIGN KEY([Engrediente])
						REFERENCES [dbo].[Engrediente] ([Id])
						GO
						ALTER TABLE [dbo].[Sabor_has_Engrediente] CHECK CONSTRAINT [FK_Sabor_has_Engrediente_Engrediente]
						GO
						ALTER TABLE [dbo].[Sabor_has_Engrediente]  WITH CHECK ADD  CONSTRAINT [FK_Sabor_has_Engrediente_Sabor] FOREIGN KEY([Sabor])
						REFERENCES [dbo].[Sabor] ([Id])
						GO
						ALTER TABLE [dbo].[Sabor_has_Engrediente] CHECK CONSTRAINT [FK_Sabor_has_Engrediente_Sabor]
						GO
						ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [FK_Sabor_has_EngredienteTamanho_Sabor_has_Engrediente] FOREIGN KEY([IdSaborEngrediente])
						REFERENCES [dbo].[Sabor_has_Engrediente] ([Id])
						GO
						ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho] CHECK CONSTRAINT [FK_Sabor_has_EngredienteTamanho_Sabor_has_Engrediente]
						GO
						ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [FK_Sabor_has_EngredienteTamanho_Tamanho] FOREIGN KEY([Tamanho])
						REFERENCES [dbo].[Tamanho] ([Id])
						GO
						ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho] CHECK CONSTRAINT [FK_Sabor_has_EngredienteTamanho_Tamanho]
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroClasse]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						create procedure [dbo].[pc_cadastroClasse] @id int,@descricao varchar(50),@ativo bit
						as
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM Classe WHERE ID = COALESCE(@id,0)))
							BEGIN
						
							UPDATE CLASSE SET Descricao = @descricao,Ativo = @ativo WHERE Id = @id
						
							END
						
							ELSE
							BEGIN
						
							INSERT INTO Classe (Descricao,Ativo)
										VALUES (@descricao,@ativo)
						
							END
						
						
						
						END
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroDadosSaborEngrediente]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						create Procedure [dbo].[pc_cadastroDadosSaborEngrediente](@idSaborEngrediente int, @tamanho int,@qnt decimal(6,2),@unidadeMedida int,@ativo bit)
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM Sabor_has_EngredienteTamanho WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho))
								BEGIN
						
								UPDATE Sabor_has_EngredienteTamanho 
								       SET
									    Quantidade = @QNT,
										UnidadeMedida = @unidadeMedida,
										Ativo = @ativo 
										    WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho
						
								END
						
							ELSE
						
								BEGIN
						
									INSERT INTO Sabor_has_EngredienteTamanho (Tamanho,Quantidade,UnidadeMedida,Ativo)
															      VALUES (@tamanho,@qnt,@unidadeMedida,@ativo)
								END
								
						
						END
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroEngrediente]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						Create Procedure [dbo].[pc_cadastroEngrediente] @id int ,@descricao varchar(50),@ativo bit
						as 
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM Engrediente WHERE ID = @id))
								BEGIN
							
								UPDATE Engrediente SET Descricao = @descricao,Ativo = @ativo
							 
								END
						
							ELSE
								BEGIN
						
									INSERT INTO Engrediente (Descricao,Ativo)
										             VALUES (@descricao,@ativo)
						
								END
						
						END
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroSabor]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE procedure [dbo].[pc_cadastroSabor](@id int,@descricao varchar(50),@idClasse int,@ativo bit)
						as
						
						begin
						
						
						 declare @ret int
						
							If(Exists(select 1 from Sabor where Id = @id))
								begin
						
									update Sabor set Descricao = @descricao,IdClasse = @idClasse ,Ativo = @ativo where id = @id 
						 
						        set @ret= @id
						
								end
						
							Else
								begin
						
									insert into Sabor (Descricao,IdClasse,Ativo)
						
									values (@descricao,@idClasse,@ativo)
						
									set @Ret = SCOPE_IDENTITY()
						
						 
								end
						
								select @ret
						End
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroSaborEngrediente]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						CREATE procedure [dbo].[pc_cadastroSaborEngrediente](@IDSabor int,@IDEngrediente int,@Ativo bit)
						AS
						
						BEGIN
						
						declare @ret int
						
							IF(EXISTS(SELECT 1 FROM Sabor_has_Engrediente WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente))
							BEGIN
						
							UPDATE Sabor_has_Engrediente SET Ativo = @Ativo  WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente
						
							
						
							END
						
							ELSE
						
							BEGIN
						
							INSERT INTO Sabor_has_Engrediente (Sabor,Engrediente,Ativo)
													   VALUES (@IDSabor,@IDEngrediente,@Ativo)
						
						
							END
						
						
						
						END
						GO
						/****** Object:  StoredProcedure [dbo].[pc_cadastroTamanho]    Script Date: 04/06/2023 00:48:17 ******/
						SET ANSI_NULLS ON
						GO
						SET QUOTED_IDENTIFIER ON
						GO
						Create procedure [dbo].[pc_cadastroTamanho] (@id int,@descricao varchar (50),@qntPedacos int,@ativo bit)
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM TAMANHO WHERE ID = @id))
						
								BEGIN
						
								UPDATE TAMANHO SET DESCRICAO = @descricao,QNTPEDACOS = @qntPedacos,ATIVO = @ativo WHERE ID = @id
						
								END
						
							ELSE
						
								BEGIN
						
								INSERT INTO TAMANHO (DESCRICAO,QNTPEDACOS,ATIVO)
											  VALUES(@descricao,@qntPedacos,@ativo)
						
								END
						 
						END
						
						
						GO
						USE [master]
						GO
						ALTER DATABASE [{nomePadrao}] SET  READ_WRITE 
						GO
                        
                     ";
    }

	public static string CriandoUsuario()
	{
		return $@"

				


				

				";
	}


}

