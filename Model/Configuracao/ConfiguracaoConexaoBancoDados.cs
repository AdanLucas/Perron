using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public class ConfiguracaoConexaoBancoDados
{
    public bool LocalDb { get; set; }
    public string Instancia { get; set; }
    public string Banco { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }

}

