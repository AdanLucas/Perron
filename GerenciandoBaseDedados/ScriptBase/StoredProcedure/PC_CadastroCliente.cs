using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.StoredProcedure
{
    public class PC_CadastroCliente : IScriptProcedure
    {
        public string GUID => "7AB35AF6-1436-4FF6-B237-2198D479AF7E";

        public string Procedure => "PC_CadastroCliente";

        public string ScriptPrcedured => $@"CREATE PROCEDURE PC_CadastroCliente (@ID int,@Ativo Bit)
											AS                                            
											BEGIN
											
												IF(EXISTS(SELECT 1 FROM CLIENTE WHERE ID = COALESCE(@ID,0)
												BEGIN 
												UPDATE CLIENTE SET ATIVO = @Ativo WHERE ID = @ID
												END
												
												ELSE
												BEGIN
											
												INSERT INTO CLIENTE (ID,ATIVO)
												VALUES (@ID,@Ativo)
											
												END
											END ";
    }
}
