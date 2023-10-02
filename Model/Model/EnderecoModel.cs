using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Model
{
    public class EnderecoModel : Aentity
    {
        

        public Int64? IdPessoal { get; set; }

        [AtribulteClasses.AtributosClasse(Descricao = "Descrição", ExibirNaGrid = true)]
        [Required(ErrorMessage = "Descrição é Obrigatório")]
        public string Descricao { get; set; }

        [AtribulteClasses.AtributosClasse(Descricao = "Rua", ExibirNaGrid = true)]
        [Required(ErrorMessage = "Rua é Obrigatório")]
        public string Rua { get; set; }


        [AtribulteClasses.AtributosClasse(Descricao = "Numero da Residencia", ExibirNaGrid = true)]
        [Required(ErrorMessage = "Numero é Obrigatório")]
        public string Numero { get; set; }

        [AtribulteClasses.AtributosClasse(ExibirNaGrid = false)]
        [Required(ErrorMessage = "Bairro é Obrigatório")]
        public string Bairro { get; set; }

        [AtribulteClasses.AtributosClasse(ExibirNaGrid = false)]
        [Required(ErrorMessage = "Cidade é Obrigatório")]
        public string Cidade { get; set; }

     

    }
}
