using Model.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class ProdutoModel : Aentity
{
    public string Descricao { get; set; }
    public ClasseModel Classe { get; set; }
    public List<IngredienteModel> Ingredientes { get; set; }
}

