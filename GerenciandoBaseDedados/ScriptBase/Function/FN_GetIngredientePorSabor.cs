using Model.Interface.BancoDeDados;

namespace GerenciandoBaseDedados.ScriptBase.Function
{
    internal class FN_GetIngredientePorSabor : IScriptFunction
    {
        public string GUID { get => "B1E5EF24-E1DE-408D-A11C-71C32D7762C7"; }
        public string Function { get => "FN_GetIngredientePorSabor"; }

        public string ScriptFunction
        {
            get
            {
                return $@"CREATE FUNCTION FN_GetIngredientePorSabor (@sabor int)
                           returns table return 
                           (
                           select
                            Ingrediente.Id
                            ,Ingrediente.Descricao
                            ,SaborIngrediente.Ativo 
                            from Mercadoria AS Ingrediente
                                     JOIN  Sabor_has_Ingrediente as SaborIngrediente ON(Ingrediente.Id = SaborIngrediente.Ingrediente)
                                          where SaborIngrediente.Sabor = @sabor)";
            }
        }
    }
}
