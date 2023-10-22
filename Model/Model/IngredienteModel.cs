using Model.AtribulteClasses;
using System.ComponentModel.DataAnnotations;

public class IngredienteModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]


    [AtributosClasse(ExibirNaGrid = true,Descricao ="Engrediente")]
    public string Descricao { get; set; }

    [AtributosClasse(ExibirNaGrid = false)]
    public EUnidadeMedida TipoMedida { get; set; }

    [AtributosClasse(ExibirNaGrid = true, Descricao = "Descrição Unidade Medida")]
    public string DescricaoTipoMedida
    {
        get
        {
            return TipoMedida.GetDescription();
        }

    }

}

