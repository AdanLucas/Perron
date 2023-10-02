using System;


public class DadosSaborEngredienteModel
{
    public SaborModel Sabor { get; set; }
    public IngredienteModel Engrediente { get; set; }
    public TamanhoModel Tamanho { get; set; }
    public Decimal Quantidade { get; set; }
    public EUnidadeMedida UnidadeMedida { get; set; }
    public bool Ativo { get; set; }


}

