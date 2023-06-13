using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroTamanho : IScriptProcedure
    {
        public string GUID { get { return "37DC2640-7FFF-4C84-A5DF-B2478654F233";}}
        public string Prcedure { get { return "pc_cadastroTamanho"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"CREATE PROCEDURE [dbo].[pc_cadastroTamanho] (@id int,@descricao varchar (50),@qntPedacos int,@ativo bit)
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
                            END";
            }
         
        }
    }
}
