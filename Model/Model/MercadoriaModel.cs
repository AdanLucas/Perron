using Model.AtribulteClasses;
using Model.Emumerator;
using System.ComponentModel.DataAnnotations;

public class MercadoriaModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]


    [AtributosClasse(ExibirNaGrid = true,Descricao ="Mercadoria")]
    public string Descricao { get; set; }

    [AtributosClasse(ExibirNaGrid = false)]
    public EUnidadeMedida? TipoMedida { get; set; }

    [AtributosClasse(ExibirNaGrid = true, Descricao = "Descrição Unidade Medida")]
    public string DescricaoTipoMedida
    {
        get
        {
            return TipoMedida.GetDescription();
        }
    }

    public ETipoMercadoria? TipoMercadoria { get; set; }


    public string DescricaoTipoMercadoria
    {
        get
        {
            return TipoMercadoria.GetDescription();
        }
    }


}

