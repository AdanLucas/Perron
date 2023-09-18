using System;
using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;

public class FuncionarioModel : Aentity
{
    [Required(ErrorMessage= "Informe a Data de Adimissão!")]
    public DateTime DataAdimissao { get; set; }


    [Required(ErrorMessage = "Informe o Salario!")]
    public decimal? Salario { get; set; }

}

