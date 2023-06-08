using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Tabela
{
    internal class Sabor_has_EngredienteTamanho : IScriptTabela
    {
        public string GUID => "BC85D9F9-152B-43FE-AEDB-F07987B6F6B6";

        public string NomeTabela => "Sabor_has_EngredienteTamanho";

        public string Script 
        { 
            get 
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[IdSaborEngrediente] [int] NULL,
    						[Tamanho] [int] NULL,
    						[Quantidade] [decimal](6, 2) NULL,
    						[UnidadeMedida] [int] NULL,
    						[Ativo] [bit] NULL
    					) ON [PRIMARY]"
                 ;
            } 
        }
    }
}
