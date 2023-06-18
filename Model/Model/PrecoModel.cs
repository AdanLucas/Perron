using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrecoModel : Aentity
{
    public TamanhoModel Tamanho { get; set; }
    public ClasseModel Classe { get; set; }
    public decimal Preco { get; set; }
}

