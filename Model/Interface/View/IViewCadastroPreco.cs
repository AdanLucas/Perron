using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model.Interface.View
{
    public interface IViewCadastroPreco : IViewPadraoCadastro
    {

        string DescricaoClasse { set; }
        string DescricaoTamanho { set; }

        ContextMenuStrip BotaoDireitoClasse { get; }
        ContextMenuStrip BotaoDireitoTamanho { get; }

        DataGridView GridPrecos { get; }
        decimal PrecoInformado { get; }
        GroupBox GbDadosCadastro { get; }
        GroupBox GbPrecosCadastrados { get; }

        void EventoAdicionarPreco(EventHandler e);


    }
}
