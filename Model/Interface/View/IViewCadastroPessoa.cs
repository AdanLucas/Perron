using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroPessoa : IViewPadraoCadastro
{

    EventHandler EventoGridBusca { get; set; }
    EventHandler EventoBusca { get; set; }
    List<PessoaModel> ListaPessoaSendoExibidos { set; }
    PessoaModel PessaoSelecionada { get; }
    string TextoBusca { get; }
    string DescricaoTela { set; }
    string Nome { get; set; }
    string Sobrenome { get; set; }
    string CpfCnpj { get; set; }
    string Telefone { get; set; }
    Panel PainelTipoPesso { get; }
    TabControl TabControlTipoPessoa { get; }
    DataGridView GridViewBusca { get; }
    GroupBox GBEndereco { get; }
}

