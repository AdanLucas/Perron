using Model.Emumerator;
using Perron.Extensions;
using Perron.Presenter;
using Perron.TelaBusca.Enum;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterProduto : PresenterPadrao, IPresenterProduto
    {

        public TabControl TabControl{ get { return _view.TabControl; } }
        public Action NotificarAteracaoComportamentoTela { get; set; } 
        public ProdutoModel Produto { get { return _produto; } }
        public KeyPressEventHandler EventoTeclaPressionada { get { return this._view.EventoTeclaPressionada; } set { _view.EventoTeclaPressionada += value; } }

        private ProdutoModel _produto;
        private readonly IViewCadastroProduto _view;
        private readonly IServiceProduto _service;

        
        public PresenterProduto(IViewCadastroProduto view, IServiceProduto service) : base(view)
        {
            _view = view;
            _service = service;
            ConfigurarGrid();
            _produto = new ProdutoModel();
            SetarControllerIngrediente();
            _view.Show();
            DelegarEventos();
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }
        #region Metodos Privados
        private void SetarControllerIngrediente()
        {
           FactoryPresenter.MercadoriaProduto(this);

        }


        #region Comportamento Tela
        protected override void ComportamentoInicioTela()
        {
            _produto = new ProdutoModel();
            _view.VisibilidadeBotao = false;
            _view.DescricaoClasse = "";
            _view.DescricaoProduto = "";

        }
        protected override void ComportamentoCadastrando()
        {
            _produto = new ProdutoModel();
            _produto.Ativo = true;
            _view.VisibilidadeBotao = true;
            _view.DescricaoClasse = "";
            _view.DescricaoProduto = "";
        }
        protected override void ComportamentoItemSelecionado()
        {
     
        }

        #endregion
        private void ConfigurarGrid()
        {
            _view.DgvProdutosCadastrados.AutoGenerateColumns = false;
            _view.DgvProdutosCadastrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _view.DgvProdutosCadastrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _view.DgvProdutosCadastrados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _view.DgvProdutosCadastrados.DefaultCellStyle.SelectionBackColor = Color.Green;
            _view.DgvProdutosCadastrados.DefaultCellStyle.SelectionForeColor = Color.Black;

            var columDescricao = new DataGridViewTextBoxColumn();

            columDescricao.HeaderText = "Descricao";
            columDescricao.DataPropertyName = "Descricao";
            columDescricao.ReadOnly = false;
            columDescricao.Frozen = false;
            

            _view.DgvProdutosCadastrados.Columns.Add(columDescricao);

        }
        private void BuscarClasse()
        {
            if (_produto != null)
            {
                try
                {
                    _produto.Classe = Busca.IniciarBuscar(ETipoBusca.CLASSE).ObterSelecionado<ClasseModel>();

                }
                catch 
                {
                }

            }
        }
        private void SetarClasseNaView()
        {
            if (_produto != null)
                _view.DescricaoClasse = _produto.Classe.DescricaoClasse;
        }
        private void DelegarEventos()
        {
            _view.EventoGrid(this.EventoGrid);
            _view.EventoBuscarClasse(this.EventoBuscarClasse);

        }
        private void Salvar()
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(_produto);
                _service.Salvar(_produto);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void GetdadosSabor()
        {
            if (_produto != null)
            {
                _produto.Descricao = _view.DescricaoProduto;
            }
        }
        private void SetDadosSdabor()
        {
            _view.DescricaoProduto = _produto.Descricao;
            SetarClasseNaView();
        }


        #endregion

        #region Metodos Publicos

        #endregion

        #region Eventos privados
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;

        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                GetdadosSabor();
                Salvar();
                MessageDeSucesso($"Sabor {_produto.Descricao} salvo com sucesso!");

                base.ComportamentoAtual = EComportamentoTela.Inicio;
            }
            catch (Exception ex)
            {
                base.MessagemErro(ex);
            }
        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            if (base.ComportamentoAtual == EComportamentoTela.ItemSelecionado)
            {
                _produto.InativarCadastro();

                if (_produto.Ativo == false)
                {
                    Salvar();

                    base.ComportamentoAtual = EComportamentoTela.Inicio;
                }
            }
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }

        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.ItemSelecionadoGrid != null)
            {
                _produto = _view.ItemSelecionadoGrid;
                SetDadosSdabor();
                _view.VisibilidadeBotao = true;

                base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
            }
        }
        private void EventoBuscarClasse(object o, EventArgs e)
        {
            try
            {
                BuscarClasse();
                SetarClasseNaView();
            }
            catch { }
        }

        protected override void AlterandoComportamentoTela()
        {
            if (this.NotificarAteracaoComportamentoTela != null)
                            this.NotificarAteracaoComportamentoTela();
        }

        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            _view.DgvProdutosCadastrados.DataSource = _service.GetListaProduto(status);
        }

        #endregion

    }
}
