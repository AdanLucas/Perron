using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class  StringConexao
    {
         public static string Base = $"Data Source={DadosConexaoBanco.Instancia}; Initial Catalog={DadosConexaoBanco.Base}; User Id={DadosConexaoBanco.Usuario}; Password={DadosConexaoBanco.Senha};";
         public static string Master = $"Data Source={DadosConexaoBanco.Instancia}; Initial Catalog=master; User Id={DadosConexaoBanco.Usuario}; Password={DadosConexaoBanco.Senha};";
}

