using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmCadastroProduto : FrmPadraoCadastro, IViewCadastroProduto
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
            ConfigurarBotao();
            this.tabControl1.KeyPress += this.NotificarEventoTeclapressionada;
        }

        private void ConfigurarBotao()
        {
            btnBuscarClasse.Image = Properties.Resources.Buscar25;
            btnBuscarClasse.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarClasse.FlatStyle = FlatStyle.Popup;
        }
        private void NotificarEventoTeclapressionada(object sender,KeyPressEventArgs args)
        {
            if (EventoTeclaPressionada != null)
                EventoTeclaPressionada(sender, args);

        }

        public DataGridView DgvProdutosCadastrados { get {return dgvProdutosCadastrados; } }

        public KeyPressEventHandler EventoTeclaPressionada { get; set; }
        public string DescricaoProduto
        {
            get { return txtDescricaoProduto.Text; }
            set { txtDescricaoProduto.Text = value; }

        }
        public TabControl TabControl
        {
            get { return this.tabControl1; }
        }
        public string DescricaoClasse
        {
            set { txtClasse.Text = value; }
        }
        public void EventoBuscarClasse(EventHandler e)
        {
            btnBuscarClasse.Click += e;
        }
        public bool VisibilidadeBotao
        {
            set { btnBuscarClasse.Visible = value; }
        }
        public ProdutoModel ItemSelecionadoGrid
        {
            get
            {
                try
                {
                    return (ProdutoModel)dgvProdutosCadastrados.CurrentRow.DataBoundItem;
                }
                catch
                {

                    return null;
                }
            }

        }
        public void EventoGrid(EventHandler e)
        {
            dgvProdutosCadastrados.DoubleClick += e;
        }

        public void PopularGrid(List<ProdutoModel> Lista)
        {
            dgvProdutosCadastrados.DataSource = null;

            if (Lista != null)
            {
                dgvProdutosCadastrados.DataSource = Lista;
                dgvProdutosCadastrados.Columns["Id"].Visible = false;
                dgvProdutosCadastrados.Columns["Ativo"].Visible = false;
                dgvProdutosCadastrados.Columns["Classe"].Visible = false;
            }


        }
    }
}
