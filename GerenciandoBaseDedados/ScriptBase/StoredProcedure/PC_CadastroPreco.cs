using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    public class PC_CadastroPreco : IScriptProcedure
    {
        public string GUID { get { return "8AE232B9-270F-4BAB-87FF-5A17F823B687"; } }
        public string Prcedure { get { return "PC_CadastroPreco"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroPreco(@id int,@Idclasse int,@IDTamanho int,@Preco Decimal,@Ativo bit)
                    as
                    BEGIN
                    
                    
                    	IF(EXISTS(SELECT 1 FROM Preco where IDClasse = @Idclasse and IDTamanho = @IDTamanho))
                    	BEGIN
                    
                    	UPDATE PRECO SET ATIVO = 0 WHERE ID IN (SELECT TOP 1 ID FROM Preco where IDClasse = @Idclasse and IDTamanho = @IDTamanho ORDER BY ID desc)
                    
                    	END
                    
                    	INSERT INTO PRECO (IDClasse,IDTamanho,Preco,Ativo)
                    				Values (@Idclasse,@IDTamanho,@Preco,@Ativo)
                    
                    END";
            }
         
        }
    }
}
