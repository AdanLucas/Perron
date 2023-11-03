public class PrecoModel : Aentity
{
    public TamanhoModel Tamanho { get; set; }
    public decimal Preco { get; set; }
    public string DescricaoTamanho  { get { return this.Tamanho.Descricao; } }
    public string DescricaoPreco { get { return $"R$ {Preco}"; } }
}

