using Perron.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerCadastroVinculoPrecoTamanhoComProduto
    {
        private readonly PresenterProduto _presenterProduto;

        private readonly UCCadastroTamanhoPreco_Produto _view = new UCCadastroTamanhoPreco_Produto();

       public ControllerCadastroVinculoPrecoTamanhoComProduto(PresenterProduto presenterProduto)
        {
            _presenterProduto = presenterProduto;
            IniciarTabPage();
        }

        #region Metodos Privados
        private void IniciarTabPage()
        {
            var page = new TabPage();

            page.Text = "Tamanho / Preço";
            page.Name = "TamanhoPreco";
            page.Controls.Add(_view);
            _view.Dock = DockStyle.Fill;
            _presenterProduto.TabControl.TabPages.Add(page);
        }


        #endregion
    }
}
