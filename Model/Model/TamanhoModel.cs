using System.ComponentModel.DataAnnotations;


public class TamanhoModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Quantidade de Pedaços é Obrigatório")]
    public int QntPedacos { get; set; }

}

