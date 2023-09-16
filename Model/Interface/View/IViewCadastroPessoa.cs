using System.Windows.Forms;

public interface IViewCadastroPessoa : IViewPadraoCadastro
{


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

