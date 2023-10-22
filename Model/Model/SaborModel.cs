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
    public List<IngredienteModel> Ingredientes { get; set; }
    


}

