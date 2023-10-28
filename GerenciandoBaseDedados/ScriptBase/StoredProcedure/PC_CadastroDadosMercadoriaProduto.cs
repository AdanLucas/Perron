namespace Repository.ScriptBase.StoredProcedure
{
    internal class PC_CadastroDadosMercadoriaProduto : IScriptProcedure
    {
        public string GUID { get { return "F29D0EEA-EF95-4D2A-A998-1C83F9E53B12"; } }
        public string Procedure { get { return "PC_CadastroDadosMercadoriaProduto"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroDadosMercadoriaProduto (@IdProdutoMercadoria int, @tamanho int,@quantidade decimal(6,2))
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM DadosMercadoriaProduto WHERE idProdutoMercadoria = @IdProdutoMercadoria AND Tamanho = @tamanho))
								BEGIN
						
								UPDATE DadosMercadoriaProduto 
								       SET
									    Quantidade = @quantidade
										
										    WHERE IdProdutoMercadoria = @IdProdutoMercadoria AND Tamanho = @tamanho
						
								END
						
							ELSE
						
								BEGIN
						
									INSERT INTO DadosMercadoriaProduto (IdProdutoMercadoria,Tamanho,Quantidade)
															      VALUES (@IdProdutoMercadoria,@tamanho,@quantidade)
								END
								
						
						END";
            }

        }
    }
}
