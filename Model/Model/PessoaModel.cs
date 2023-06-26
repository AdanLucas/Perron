using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class PessoaModel : Aentity
    {
        public string Nome { get; set; }
        public string Sobrenome  { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public ETipoPessoa Tipo{ get; set; }
    }
}
