
using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public static class CriandoBaseSql
{
	public static string nomePadrao { get { return ConfiguracaoInicial.Instancia.Configuracao.ConexaoBancoDados.Banco; } }
	private static string usuario { get { return ConfiguracaoInicial.Instancia.Configuracao.ConexaoBancoDados.Usuario; } }
   
    public static string ScriptBase()
    {
        return $@"	CREATE DATABASE [{nomePadrao}]


	            ALTER DATABASE [{nomePadrao}] SET COMPATIBILITY_LEVEL = 140

    					
    					IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
    					begin
    					EXEC [{nomePadrao}].[dbo].[sp_fulltext_database] @action = 'enable'
    					end
    					ALTER DATABASE [{nomePadrao}] SET ANSI_NULL_DEFAULT OFF 
    					ALTER DATABASE [{nomePadrao}] SET ANSI_NULLS OFF 
    					ALTER DATABASE [{nomePadrao}] SET ANSI_PADDING OFF 
    					ALTER DATABASE [{nomePadrao}] SET ANSI_WARNINGS OFF 
    					ALTER DATABASE [{nomePadrao}] SET ARITHABORT OFF 
    					ALTER DATABASE [{nomePadrao}] SET AUTO_CLOSE OFF 
    					ALTER DATABASE [{nomePadrao}] SET AUTO_SHRINK OFF 
    					ALTER DATABASE [{nomePadrao}] SET AUTO_UPDATE_STATISTICS ON 
    					ALTER DATABASE [{nomePadrao}] SET CURSOR_CLOSE_ON_COMMIT OFF 
    					ALTER DATABASE [{nomePadrao}] SET CURSOR_DEFAULT  GLOBAL 
    					ALTER DATABASE [{nomePadrao}] SET CONCAT_NULL_YIELDS_NULL OFF 
    					ALTER DATABASE [{nomePadrao}] SET NUMERIC_ROUNDABORT OFF 
    					ALTER DATABASE [{nomePadrao}] SET QUOTED_IDENTIFIER OFF 
    					ALTER DATABASE [{nomePadrao}] SET RECURSIVE_TRIGGERS OFF 
    					ALTER DATABASE [{nomePadrao}] SET  DISABLE_BROKER 
    					ALTER DATABASE [{nomePadrao}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
    					ALTER DATABASE [{nomePadrao}] SET DATE_CORRELATION_OPTIMIZATION OFF 
    					ALTER DATABASE [{nomePadrao}] SET TRUSTWORTHY OFF 
    					ALTER DATABASE [{nomePadrao}] SET ALLOW_SNAPSHOT_ISOLATION OFF
    					ALTER DATABASE [{nomePadrao}] SET PARAMETERIZATION SIMPLE 
    					ALTER DATABASE [{nomePadrao}] SET READ_COMMITTED_SNAPSHOT OFF 
    					ALTER DATABASE [{nomePadrao}] SET HONOR_BROKER_PRIORITY OFF 
    					ALTER DATABASE [{nomePadrao}] SET RECOVERY FULL 
    					ALTER DATABASE [{nomePadrao}] SET  MULTI_USER 
    					ALTER DATABASE [{nomePadrao}] SET PAGE_VERIFY CHECKSUM
    					ALTER DATABASE [{nomePadrao}] SET DB_CHAINING OFF
    					ALTER DATABASE [{nomePadrao}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
    					ALTER DATABASE [{nomePadrao}] SET TARGET_RECOVERY_TIME = 60 SECONDS 
    					ALTER DATABASE [{nomePadrao}] SET DELAYED_DURABILITY = DISABLED 
    					ALTER DATABASE [{nomePadrao}] SET QUERY_STORE = OFF";
    }
    public static string CriandoUsuario()
	{
		return $@"
                    if not exists (select top 1 1 from sys.sysusers where name = '{usuario}')
                    BEGIN
                        CREATE USER [{usuario}] FOR LOGIN [{usuario}]
						EXEC sp_addrolemember N'db_ddladmin', N'{usuario}'
	                    EXEC sp_addrolemember N'db_datareader', N'{usuario}'; 
                        EXEC sp_addrolemember N'db_backupoperator', N'{usuario}' 
						EXEC sp_addrolemember N'db_datawriter',  N'{usuario}' 
                    END;
				";
	}
    public static string DropDataBase()
    {
        return $@"Drop Database [{nomePadrao}]";
    }


}



