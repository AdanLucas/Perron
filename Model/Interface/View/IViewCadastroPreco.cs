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
        void SetarListaClasse(List<ClasseModel> ListaClasse);
        void SetarListatamanho(List<TamanhoModel> ListaTamanho);
        void SetarListaPrecosCadastrados(List<object> ListaPreco);
        TamanhoModel TamanhoSelecionado { get; }
        ClasseModel ClasseSelecioanda { get; }
        decimal PrecoInformado { get; }
        void EventoGridClasse(EventHandler e);
        void EventoGridTamanho(EventHandler e);
        void EventoGridPrecos(EventHandler e);



    }
}
