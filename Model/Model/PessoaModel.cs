using Model.Emumerator;
using Model.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class PessoaModel : Aentity
{
    [Required(ErrorMessage = "Nome é Obrigatório")]
    public string Nome { get; set; }


    public string Sobrenome { get; set; }
    public string CpfCnpj { get; set; }


    [Required(ErrorMessage = "Telefone é Obrigatório")]
    public string Telefone { get; set; }

    public ETipoPessoa Tipo { get; set; }
    public List<EnderecoModel> Enderecos { get; set; }
}

