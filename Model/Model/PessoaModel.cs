using Model.AtribulteClasses;
using Model.Emumerator;
using Model.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class PessoaModel : Aentity
{
    [Required(ErrorMessage = "Nome é Obrigatório")]


    [AtributosClasse(ExibirNaGrid = true,Descricao ="Nome")]
    public string Nome { get; set; }


    [AtributosClasse(ExibirNaGrid = false)]
    public string Sobrenome { get; set; }


    [AtributosClasse(ExibirNaGrid = false)]
    public string CpfCnpj { get; set; }


    [Required(ErrorMessage = "Telefone é Obrigatório")]



    [AtributosClasse(ExibirNaGrid = false)]
    public string Telefone { get; set; }


    [AtributosClasse(ExibirNaGrid = false)]
    public ETipoPessoa Tipo { get; set; }


    [AtributosClasse(ExibirNaGrid = true, Descricao = "Tipo De Cadastro")]
    public List<EnderecoModel> Enderecos { get; set; }



    [AtributosClasse(ExibirNaGrid = true,Descricao ="Tipo De Cadastro")]
    public string DescricaoTipoPessoa 
    { 
        get 
        {
            var lista = Tipo.GetListEnumValue();
            return string.Join(" | ", lista);
        } 
    }


    [AtributosClasse(ExibirNaGrid = true,Descricao ="Endereços Cadastrados")]
    public string EnderecosCadatrados
    {
        get
        {
            if (Enderecos == null || Enderecos.Count < 1)
                return "";

            else { return string.Join(" | ", Enderecos.Select(end => end.Descricao)); }
        }
    }
}

