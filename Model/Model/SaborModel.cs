using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class SaborModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Classe é Obrigatório")]
    public ClasseModel Classe { get; set; }

    [Required(ErrorMessage = "Engredientes é Obrigatório")]
    public List<IngredienteModel> Engredientes { private get; set; }
    public List<IngredienteModel> GetEngredientePorStatus(EStatusCadastro Status)
    {
        List<IngredienteModel> ret;

        switch (Status)
        {
            case EStatusCadastro.Todos:

                return Engredientes;

            case EStatusCadastro.Ativo:

                return ret = Engredientes.Where(e => e.Ativo == true).ToList();

            case EStatusCadastro.Inativo:

                return ret = Engredientes.Where(e => e.Ativo == false).ToList();

        }

        return null;
    }


}

