using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class PC_CadastroPessoaTipoFuncionario : IScriptProcedure
    {
        public string GUID { get { return "8AE232B9-270F-4BAB-87FF-5A17F823B687"; } }
        public string Procedure { get { return "PC_CadastroPessoaTipoFuncionario"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroPessoaTipoFuncionario(@id int,@DataAdimissao datetime,@Salario decimal,@Ativo bit)
                            as
                            BEGIN
                            	DECLARE @RET INT
                            
                            	IF(EXISTS(SELECT 1 FROM PessoaTipoFuncionario where id = Coalesce(id,0)))
                            		BEGIN
                            			UPDATE PessoaTipoFuncionario SET DataAdimissao = @DataAdimissao,Salario =  @Salario,Ativo = @Ativo where id = @id
                            
                            			SET @RET = @id
                            		END
                            	ELSE
                            		BEGIN
                            		INSERT INTO PessoaTipoFuncionario (Id,Salario,DataAdimissao,Ativo)
                            		values (@id,@Salario,@DataAdimissao,@Ativo)
                            		Set @RET = @id;
                            		END
                            
                            		select @RET
                            END";
            }
         
        }
    }
}
