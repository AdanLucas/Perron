using System.Data;

public class ScriptCriacaoBase
{


    static IDbConnection _conn;


    public ScriptCriacaoBase(IDbConnection conn)
    {
        _conn = conn;
    }

    public void CriacaoBase(string NomeBase)
    {

        var dbocommand = _conn.CreateCommand();
        dbocommand.Connection = _conn;


        var sql = $@"	CREATE DATABASE [{NomeBase}]


	            ALTER DATABASE [{NomeBase}] SET COMPATIBILITY_LEVEL = 140

    					
    					IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
    					begin
    					EXEC [{NomeBase}].[dbo].[sp_fulltext_database] @action = 'enable'
    					end
    					ALTER DATABASE [{NomeBase}] SET ANSI_NULL_DEFAULT OFF 
    					ALTER DATABASE [{NomeBase}] SET ANSI_NULLS OFF 
    					ALTER DATABASE [{NomeBase}] SET ANSI_PADDING OFF 
    					ALTER DATABASE [{NomeBase}] SET ANSI_WARNINGS OFF 
    					ALTER DATABASE [{NomeBase}] SET ARITHABORT OFF 
    					ALTER DATABASE [{NomeBase}] SET AUTO_CLOSE OFF 
    					ALTER DATABASE [{NomeBase}] SET AUTO_SHRINK OFF 
    					ALTER DATABASE [{NomeBase}] SET AUTO_UPDATE_STATISTICS ON 
    					ALTER DATABASE [{NomeBase}] SET CURSOR_CLOSE_ON_COMMIT OFF 
    					ALTER DATABASE [{NomeBase}] SET CURSOR_DEFAULT  GLOBAL 
    					ALTER DATABASE [{NomeBase}] SET CONCAT_NULL_YIELDS_NULL OFF 
    					ALTER DATABASE [{NomeBase}] SET NUMERIC_ROUNDABORT OFF 
    					ALTER DATABASE [{NomeBase}] SET QUOTED_IDENTIFIER OFF 
    					ALTER DATABASE [{NomeBase}] SET RECURSIVE_TRIGGERS OFF 
    					ALTER DATABASE [{NomeBase}] SET  DISABLE_BROKER 
    					ALTER DATABASE [{NomeBase}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
    					ALTER DATABASE [{NomeBase}] SET DATE_CORRELATION_OPTIMIZATION OFF 
    					ALTER DATABASE [{NomeBase}] SET TRUSTWORTHY OFF 
    					ALTER DATABASE [{NomeBase}] SET ALLOW_SNAPSHOT_ISOLATION OFF
    					ALTER DATABASE [{NomeBase}] SET PARAMETERIZATION SIMPLE 
    					ALTER DATABASE [{NomeBase}] SET READ_COMMITTED_SNAPSHOT OFF 
    					ALTER DATABASE [{NomeBase}] SET HONOR_BROKER_PRIORITY OFF 
    					ALTER DATABASE [{NomeBase}] SET RECOVERY FULL 
    					ALTER DATABASE [{NomeBase}] SET  MULTI_USER 
    					ALTER DATABASE [{NomeBase}] SET PAGE_VERIFY CHECKSUM
    					ALTER DATABASE [{NomeBase}] SET DB_CHAINING OFF
    					ALTER DATABASE [{NomeBase}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
    					ALTER DATABASE [{NomeBase}] SET TARGET_RECOVERY_TIME = 60 SECONDS 
    					ALTER DATABASE [{NomeBase}] SET DELAYED_DURABILITY = DISABLED 
    					ALTER DATABASE [{NomeBase}] SET QUERY_STORE = OFF";




        dbocommand.CommandText = sql;
        dbocommand.ExecuteNonQuery();
        dbocommand.Dispose();
    }






}



