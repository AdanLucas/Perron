using System.ComponentModel.DataAnnotations;

public class IngredienteModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string Descricao { get; set; }
    public EUnidadeMedida TipoMedida { get; set; }

    public string DescricaoTipoMedida
    {
        get
        {
            return TipoMedida.GetDescription();
        }

    }

}

