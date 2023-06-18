using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.Interface.View
{
    public interface IViewCadastroPreco : IViewPadraoCadastro
    {
        void Show();
        void Close();
        void SetarListaClasse(List<ClasseModel> ListaClasse);
        void SetarListatamanho(List<TamanhoModel> ListaTamanho);
        void SetarListaPrecosCadastrados(List<PrecoView> ListaPreco);
        TamanhoModel TamanhoSelecionado { get; }
        ClasseModel ClasseSelecioanda { get; }
        PrecoView PrecoSelecionado { get; }
        decimal PrecoInformado { get; }
        bool VisibilidadePainel { set; }
        void EventoGridClasse(EventHandler e);
        void EventoGridTamanho(EventHandler e);
        void EventoGridPrecos(EventHandler e);
        void EventoAdicionarPreco(EventHandler e);


    }
}
