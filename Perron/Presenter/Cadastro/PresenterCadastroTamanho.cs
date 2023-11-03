using Perron.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perron.Presenter
{
    public class PresenterCadastroTamanho : PresenterPadrao, IPresenterCadastroTamanho
    {

        private readonly IViewCadastroTamanho _view;
        private readonly IServiceTamanho _service;

        private TamanhoModel _tamanho;

        #region Construtor
        public PresenterCadastroTamanho(IViewCadastroTamanho view, IServiceTamanho service) : base(view)
        {
            _view = view;
            _service = service;
            _view.Show();
            DelegarEventos();
            EstatoInicial();
            IniciarComponentes();
            ConfigurarGrid();
        }
        #endregion

        #region Metodos Privados
        private void IniciarComponentes()
        {
            _view.ComboTIpoQuantidade.DataSource = EUnidadeMedida.Nd.GetArrayItemEnum();
        }
        private void DelegarEventos()
        {
            _view.EventoGrid(this.EventoGrid);
        }
        private void SetdadosTamanho()
        {
            if (_tamanho == null)
            {
                _tamanho = new TamanhoModel();
                _tamanho.Ativo = true;
            }
            _tamanho.Descricao = _view.DescricaoTamanho;
            _tamanho.Quantidade = _view.Quantidade;
            _tamanho.TipoQuantidade = _view.ComboTIpoQuantidade.SelectedItem as EUnidadeMedida?;
        }
        private void SetDadostela()
        {
            _view.DescricaoTamanho = _tamanho.Descricao;
            _view.Quantidade = _tamanho.Quantidade;
            _view.ComboTIpoQuantidade.SelectedItem = _tamanho.TipoQuantidade;
        }
        private void SetTamanhoSelecionadoGrid()
        {
            if (_view.ItemSelecionadoGrid != null)
            {
                _tamanho = _view.ItemSelecionadoGrid;
                SetDadostela();
                base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;

            }
            else
            {
                throw new Exception("Não Existem Item Selecionado");
            }
        }
        private void EstatoInicial()
        {
            this._tamanho = new TamanhoModel();
            _tamanho.Ativo = true;
            base.ComportamentoAtual = EComportamentoTela.Inicio;
            _view.Quantidade = 0;
            _view.DescricaoTamanho = "";

        }
        private void ValidarDadosTamanho()
        {
            string msg = "";
            bool ret = true;


            if (_tamanho.Descricao == "")
            {
                ret = false;
                msg += "- Descrição\n";
            }
            if (_tamanho.Quantidade == 0)
            {
                ret = false;
                msg += "- Quantidade\n";
            }

            if (!ret)
            {
                throw new Exception("Valide as Informações a Baixa:\n\r" + msg);
            }
        }
        private void ConfigurarGrid()
        {

            _view.GridTamanho.AutoGenerateColumns = false;
            _view.GridTamanho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _view.GridTamanho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _view.GridTamanho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _view.GridTamanho.DefaultCellStyle.SelectionBackColor = Color.Green;
            _view.GridTamanho.DefaultCellStyle.SelectionForeColor = Color.Black;


            var colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.Name = "Descricao";
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.DataPropertyName = "Descricao";
            colunaDescricao.ReadOnly = true;
            colunaDescricao.Width = 200;
            _view.GridTamanho.Columns.Add(colunaDescricao);

            var colunaQuantidade = new DataGridViewTextBoxColumn();
            colunaQuantidade.Name = "Quantidade";
            colunaQuantidade.HeaderText = "Quantidade";
            colunaQuantidade.DataPropertyName = "DescricaoQuantidade";
            colunaQuantidade.ReadOnly = true;
            colunaQuantidade.Width = 200;
            _view.GridTamanho.Columns.Add(colunaQuantidade);

        }
        private void Salvar()
        {
            ValidarDadosTamanho();
            _service.Salvar(_tamanho);
            base.MessageDeSucesso($"Tamanho {_tamanho.Descricao} Salvo com Sucesso");
            EstatoInicial();
        }
        #endregion

        #region Metodos override
        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            _view.GridTamanho.DataSource = _service.GetListaTamanho(status);
        }

        #endregion

        #region Eventos protected override

        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                _tamanho.AtivarCadastroInativo();
                SetdadosTamanho();
                Salvar();
            }
            catch (Exception ex)
            {
                base.MessagemErro(ex);
            }


        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;
        }
        protected override void EventoNovo(object o, EventArgs e)
        {
            EstatoInicial();
            base.ComportamentoAtual = EComportamentoTela.Novo;

        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            if (!_tamanho.InativarCadastro())
            {
                MessageDeSucesso($"Tamanho {_tamanho.Descricao} Inativado");
                this.Salvar();
            }


        }
        private void EventoGrid(object o, EventArgs e)
        {
            SetTamanhoSelecionadoGrid();
        }
        #endregion

    }


}
