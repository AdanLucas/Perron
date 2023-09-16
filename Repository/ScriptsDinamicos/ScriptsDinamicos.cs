using System;

namespace Repository.ScriptsDinamicos
{
    public class ScriptsDinamicos<T>
    {

        public string GetScript()
        {
            if (this.GetType() == typeof(ScriptsDinamicos<EngredienteModel>))
            {
                return "Select * from Engrediente";
            }
            if (this.GetType() == typeof(ScriptsDinamicos<ClasseModel>))
            {
                return "select Id,Descricao as DescricaoClasse,Ativo from Classe";
            }
            if (this.GetType() == typeof(ScriptsDinamicos<TamanhoModel>))
            {
                return "Select * From Tamanho";
            }
            if (this.GetType() == typeof(ScriptsDinamicos<SaborModel>))
            {
                return "select * from Sabor";
            }
            else
            {
                throw new Exception("Tipo Não Encontrados");
            }
        }

    }
}
