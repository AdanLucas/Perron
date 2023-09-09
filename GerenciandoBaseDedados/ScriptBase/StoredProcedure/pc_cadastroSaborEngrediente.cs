using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroSaborEngrediente : IScriptProcedure
    {
        public string GUID { get { return "84B5EE0B-17E1-49E9-A2FA-A460CDE62B2E"; } }
        public string Procedure { get { return "pc_cadastroSaborEngrediente"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"CREATE PROCEDURE [dbo].[pc_cadastroSaborEngrediente](@IDSabor int,@IDEngrediente int,@Ativo bit)
                            AS
                            BEGIN
                            declare @ret int
                            
                            	IF(EXISTS(SELECT 1 FROM Sabor_has_Engrediente WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente))
                            	    BEGIN
                            	        UPDATE Sabor_has_Engrediente SET Ativo = @Ativo  WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente
                            	    END
                            	ELSE
                            
                            	BEGIN
                            	IF(@Ativo = 1)
                            		BEGIN
                            			INSERT INTO Sabor_has_Engrediente (Sabor,Engrediente,Ativo) VALUES (@IDSabor,@IDEngrediente,@Ativo)
                            		END
                            	END
                            END";
            }
         
        }
    }
}
