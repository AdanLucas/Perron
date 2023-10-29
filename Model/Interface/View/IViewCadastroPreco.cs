using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model.Interface.View
{
    public interface IViewCadastroPreco : IViewPadraoCadastro
    {

        string DescricaoClasse { set; }

         ContextMenuStrip BotaoDireito { get; }
        
        void SetarListatamanho(List<TamanhoModel> ListaTamanho);
        void SetarListaPrecosCadastrados(List<PrecoView> ListaPreco);
        TamanhoModel TamanhoSelecionado { get; }
        
        PrecoView PrecoSelecionado { get; }
        decimal PrecoInformado { get; }
        bool VisibilidadePainel { set; }
        
        void EventoGridTamanho(EventHandler e);
        void EventoGridPrecos(EventHandler e);
        void EventoAdicionarPreco(EventHandler e);


    }
}
