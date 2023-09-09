using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroDadosSaborEngrediente : IScriptProcedure
    {
        public string GUID { get { return "F29D0EEA-EF95-4D2A-A998-1C83F9E53B12"; } }
        public string Procedure { get { return "pc_cadastroDadosSaborEngrediente"; } }

        public string ScriptPrcedured 
        {
            get
            {
                return @"create Procedure pc_cadastroDadosSaborEngrediente(@idSaborEngrediente int, @tamanho int,@qnt decimal(6,2),@unidadeMedida int,@ativo bit)
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM Sabor_has_EngredienteTamanho WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho))
								BEGIN
						
								UPDATE Sabor_has_EngredienteTamanho 
								       SET
									    Quantidade = @QNT,
										UnidadeMedida = @unidadeMedida,
										Ativo = @ativo 
										    WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho
						
								END
						
							ELSE
						
								BEGIN
						
									INSERT INTO Sabor_has_EngredienteTamanho (Tamanho,Quantidade,UnidadeMedida,Ativo)
															      VALUES (@tamanho,@qnt,@unidadeMedida,@ativo)
								END
								
						
						END";
            }
         
        }
    }
}
