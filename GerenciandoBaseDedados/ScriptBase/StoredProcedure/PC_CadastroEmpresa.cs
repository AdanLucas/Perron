using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.StoredProcedure
{
    public class PC_CadastroEmpresa : IScriptProcedure
    {
        public string GUID => "7AB35AF6-1436-4FF6-B237-2198D479AF7E";

        public string Procedure => "PC_CadastroEmpresa";

        public string ScriptPrcedured => $@"CREATE PROCEDURE PC_CadastroEmpresa (@ID int,@Ativo Bit)
											AS                                            
											BEGIN
											
												IF(EXISTS(SELECT 1 FROM EMPRESA WHERE ID = COALESCE(@ID,0)
												BEGIN 
												UPDATE EMPRESA SET ATIVO = @Ativo WHERE ID = @ID
												END
												
												ELSE
												BEGIN
											
												INSERT INTO EMPRESA (ID,ATIVO)
												VALUES (@ID,@Ativo)
											
												END
											END ";
    }
}
