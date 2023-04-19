using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TamanhoModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Quantidade de Pedaços é Obrigatório")]
    public int QntPedacos { get; set; }

}

