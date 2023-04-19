using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class ClasseModel : Aentity
{

    [Description("Descrição Classe")]

    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string DescricaoClasse { get; set; }



}

