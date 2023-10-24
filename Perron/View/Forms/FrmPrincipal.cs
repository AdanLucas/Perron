using System;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmPrincipal : Form, IViewPrincipal
    {

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        public void EventoAbrirtelaCadastroClasse(EventHandler e)
        {
            this.menuItemClasse.Click += e;
        }
        public void EventoAbrirTelaCadastroProduto(EventHandler e)
        {
            menuItemProduto.Click += e;
        }
        public void EventoAbrirtelaCadastroTAmanho(EventHandler e)
        {
            menuItemTamanho.Click += e;
        }
        public void EventoAbrirTelaIngredientes(EventHandler e)
        {
            menuItemIngrediente.Click += e;
        }
        public void EventoAbrirTelaCadastroPreco(EventHandler e)
        {
            menuItemCadastroPreco.Click += e;
        }
        public void EventoAbrirTelaCadastroPessoa(EventHandler e)
        {
            menuItemCadastroPessoa.Click += e;
        }
        public void EventoFechar(FormClosedEventHandler e)
        {
            FormClosed += e;
        }
    }
}
