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
                return @"CREATE PROCEDURE PC_CadastroDadosMercadoriaProduto (@IdProdutoMercadoria int, @tamanho int,@qnt decimal(6,2),@ativo bit)
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM DadosMercadoriaProduto WHERE idProdutoMercadoria = @IdProdutoMercadoria AND Tamanho = @tamanho))
								BEGIN
						
								UPDATE DadosMercadoriaProduto 
								       SET
									    Quantidade = @QNT,
										Ativo = @ativo 
										    WHERE IdProdutoMercadoria = @IdProdutoMercadoria AND Tamanho = @tamanho
						
								END
						
							ELSE
						
								BEGIN
						
									INSERT INTO DadosMercadoriaProduto (Tamanho,Quantidade,Ativo)
															      VALUES (@tamanho,@qnt,@ativo)
								END
								
						
						END";
            }

        }
    }
}
