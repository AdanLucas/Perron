using System.ComponentModel.DataAnnotations;


public class TamanhoModel : Aentity
{
    
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public EUnidadeMedida? TipoQuantidade { get; set; }

    public string DescricaoQuantidade { get { return $"{Quantidade} {this.TipoQuantidade.GetDescription()}"; } }

}

