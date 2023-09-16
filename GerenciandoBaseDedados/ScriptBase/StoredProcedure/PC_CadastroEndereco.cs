using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.StoredProcedure
{
    internal class PC_CadastroEndereco : IScriptProcedure
    {
        public string GUID => "7F20270E-70E4-44BC-A0A2-76B69EF42800";

        public string Procedure => "PC_CadastroEndereco";

        public string ScriptPrcedured => @"CREATE PROCEDURE PC_CadastroEndereco (@ID int,@IDPessoa int,@Descricao varchar(50),@Rua varchar(MAX),@Numero varchar(10), @Bairro varchar(max),@Cidade varchar(max), @Ativo bit)
                                            AS
                                            BEGIN 
                                            
                                            IF(EXISTS(SELECT 1 FROM Endereco WHERE ID = COALESCE(@ID,0)))
                                            BEGIN
                                            
                                            UPDATE Endereco SET Descricao = @Descricao,RUA = @Rua,NUMERO = @Numero,Bairro = @Bairro,CIDADE = @Cidade,Ativo = @Ativo WHERE ID = @ID
                                            
                                            END
                                            
                                            		ELSE
                                            		BEGIN
                                            		
                                            		INSERT INTO ENDERECO (IdPessoa,DESCRICAO,Rua,Numero,BAIRRO,CIDADE,Ativo)
                                            		VALUES(@IDPessoa,@DESCRICAO,@Rua,@Numero,@Bairro,@Cidade,@Ativo)
                                            
                                            		END
                                            
                                            END";
    }
}
