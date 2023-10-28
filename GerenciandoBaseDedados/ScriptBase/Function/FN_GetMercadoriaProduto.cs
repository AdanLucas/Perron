using Model.Interface.BancoDeDados;

namespace GerenciandoBaseDedados.ScriptBase.Function
{
    internal class FN_GetMercadoriaProduto : IScriptFunction
    {
        public string GUID { get => "B1E5EF24-E1DE-408D-A11C-71C32D7762C7"; }
        public string Function { get => "FN_GetMercadoriaProduto"; }

        public string ScriptFunction
        {
            get
            {
                return $@"CREATE FUNCTION FN_GetMercadoriaProduto (@produto int)
                           returns table return 
                           (
                           select
                            Ingrediente.Id
                            ,Ingrediente.Descricao
                            ,MercadoriaProduto.Ativo 
                            from Mercadoria AS Ingrediente
                                     JOIN  Produto_has_Mercadoria as MercadoriaProduto ON(Ingrediente.Id = MercadoriaProduto.Mercadoria)
                                          where MercadoriaProduto.Produto = @produto)";
            }
        }
    }
}
