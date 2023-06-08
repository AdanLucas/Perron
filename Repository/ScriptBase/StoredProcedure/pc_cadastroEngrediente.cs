using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroEngrediente : IScriptProcedure
    {
        public string GUID { get { return "229A15BF-4725-4867-AA7C-6F8C44ECB87A"; } }
        public string Prcedure { get { return "pc_cadastroEngrediente"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"Create Procedure pc_cadastroEngrediente @id int ,@descricao varchar(50),@ativo bit
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
                          
                          END";
            }
         
        }
    }
}
