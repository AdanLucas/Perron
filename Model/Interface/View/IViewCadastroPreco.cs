using System;
using System.Collections.Generic;

namespace Model.Interface.View
{
    public interface IViewCadastroPreco : IViewPadraoCadastro
    {

        void SetarListaClasse(List<ClasseModel> ListaClasse);
        void SetarListatamanho(List<TamanhoModel> ListaTamanho);
        void SetarListaPrecosCadastrados(List<PrecoView> ListaPreco);
        TamanhoModel TamanhoSelecionado { get; }
        ClasseModel ClasseSelecioanda { get; }
        PrecoView PrecoSelecionado { get; }
        decimal PrecoInformado { get; }
        bool VisibilidadePainel { set; }
        bool HabilitarGridClasse { set; }

        void EventoGridClasse(EventHandler e);
        void EventoGridTamanho(EventHandler e);
        void EventoGridPrecos(EventHandler e);
        void EventoAdicionarPreco(EventHandler e);


    }
}
