using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.Function
{
    internal class FN_GetEngredientePorSabor : IScriptFunction
    {
        public string GUID { get => "B1E5EF24-E1DE-408D-A11C-71C32D7762C7"; }
        public string Function { get => "FN_GetEngredientePorSabor"; }

        public string ScriptFunction
        {
            get
            {
                return $@"CREATE FUNCTION FN_GetEngredientePorSabor (@sabor int)
                           returns table return 
                           (
                           select
                            Engrediente.Id
                            ,Engrediente.Descricao
                            ,SaborEngrediente.Ativo 
                            from Engrediente AS Engrediente
                           JOIN  Sabor_has_Engrediente as SaborEngrediente ON(Engrediente.Id = SaborEngrediente.Engrediente)
                           where SaborEngrediente.Sabor = @sabor)";
            }
        }
    }
}
