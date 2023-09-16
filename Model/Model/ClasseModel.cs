using Model.AtribulteClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



public class ClasseModel : Aentity
{

    [Description("Descrição Classe")]

    [Required(ErrorMessage = "Descrição é Obrigatório")]
    [AtributosClasse(Descricao = "Classe", ExibirNaGrid = true)]
    public string DescricaoClasse { get; set; }

}

