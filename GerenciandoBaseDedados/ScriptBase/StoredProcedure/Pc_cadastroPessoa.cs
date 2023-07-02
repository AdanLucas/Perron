using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class Pc_cadastroPessoa : IScriptProcedure
    {
        public string GUID { get { return "8AE232B9-270F-4BAB-87FF-5A17F823B687"; } }
        public string Prcedure { get { return "Pc_cadastroPessoa"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroPessoa(@Id int,@Nome varchar(50),@Sobrenome varchar(50),@CpfCnpj varchar(50),@Telefone varchar(50),@Tipo int,@Ativo bit)
						AS
						BEGIN
						
						DECLARE @RET INT
						
						
							IF(EXISTS(SELECT 1 FROM PESSOA WHERE ID = COALESCE(@Id,0)))
								BEGIN
								
								UPDATE Pessoa SET Ativo = @Ativo,Nome = @Nome,Sobrenome = @Sobrenome,Tipo = @TIPO,CpfCnpj = @CpfCnpj,Telefone = @Telefone where ID = @Id
								  
								  set @RET  = @Id;
								END
							
							ELSE
								BEGIN
								
								insert into Pessoa (Nome,Sobrenome,CpfCnpj,Tipo,Telefone,Ativo)
								Values(@Nome,@Sobrenome,@CpfCnpj,@Tipo,@Telefone,@Ativo)
						
								set @RET = SCOPE_IDENTITY();
						
								END
						
						  SELECT @RET
						
						END";
            }
         
        }
    }
}
