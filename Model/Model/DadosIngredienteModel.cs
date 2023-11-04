using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class DadosIngredienteModel
    {
       public TamanhoModel Tamanho { get; set; }
       public decimal Quantidade { get; set; }

        public string DescricaoTamanho { get{ return $"{Tamanho.Descricao}"; } }

        

    }

}
