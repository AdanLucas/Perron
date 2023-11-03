using Model.Interface.View;
using Perron.Controller;
using Perron.Extensions;
using Perron.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Presenter.Cadastro
{
    public class PresenterCadastroPreco : PresenterPadrao, IPresenterCadastroPreco
    {
        private TamanhoModel _tamanho;
        private ClasseModel _classe;
        private readonly IViewCadastroPreco _view;
        private readonly IServiceCadastroPreco _service;
        private List<PrecoModel> _listaPreco = new List<PrecoModel>();
        
        private TamanhoModel tamanho { get {return _tamanho;}set { SetarTamanho(value); } }
        private ClasseModel classe { get { return _classe; } set { SetarClasse(value); } }

        public PresenterCadastroPreco(IViewCadastroPreco view, IServiceCadastroPreco cadastropreco) : base(view)
        {
            _view = view;
            this.ConfigurarGridPreco();
            _service = cadastropreco;
            IniciarListaTamanhos();
            _view.SetarVisiblidadeCKStatus = false;
            AbrirTela();
            DelegarEventos();
            this.ComportamentoAtual = EComportamentoTela.Inicio;
            
        }
        private void SetarTamanho(TamanhoModel tamanho)
        {
            if(tamanho == null)
                _view.DescricaoTamanho ="";

            else
            {
                _tamanho = tamanho;
                _view.DescricaoTamanho = tamanho.Descricao + tamanho.DescricaoQuantidade;

            }
        }
        private void SetarClasse(ClasseModel classe)
        {
            if (classe == null)
                _view.DescricaoClasse = "";

            else
            {
                _classe = classe;
                _view.DescricaoClasse = classe.DescricaoClasse; 
            }

        }



        #region Eventos Privados
        private void EventoAddPreco(Object o, EventArgs e)
        {
            var preco = InstanciarPreco();
            AdicionarPrecoNaLista(preco);

        }
        private void EventoAdicionarClasse(object sender,EventArgs args)
        {
            AdicionarClasse();
        }
        private void EventoRemoverClasse(object sender, EventArgs args)
        {
            RemoverClasse();
        }
        private void EventoAdicionarTamanho(object sender,EventArgs args)
        {

        }
        private void EventoRemoverTamanho(object sender, EventArgs args)
        {

        }

        protected override void EventoSalvar(object o, EventArgs e)
        {
            if (_listaPreco == null || _listaPreco.Count == 0)
            {
                MessagemErro(new Exception("Nao Existe Preco Para cadastrar!"));
            }
            else
            {
                try
                {
                    _service.SalvarListaPrecos(_listaPreco,_classe);
                    MessageDeSucesso("Produtos Cadastrado Com sucesso!!");
                    base.ComportamentoAtual = EComportamentoTela.Inicio;
                }
                catch (Exception ex)
                {
                    MessagemErro(ex);
                }

            }
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            try
            {
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                _listaPreco = new List<PrecoModel>();
                PopularListaPrecos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }

        }
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Cadastrando;
        }

        #endregion
        private void IniciarListaTamanhos()
        {
            this._listaPreco = _service.GetListaPreco();
        }
        
        private void ConfigurarGridPreco()
        {
            _view.GridPrecos.AutoGenerateColumns = false;
            _view.GridPrecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _view.GridPrecos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _view.GridPrecos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _view.GridPrecos.DefaultCellStyle.SelectionBackColor = Color.Green;
            _view.GridPrecos.DefaultCellStyle.SelectionForeColor = Color.Black;


            var colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.Name = "Descricao";
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.DataPropertyName = "DescricaoTamanho";
            colunaDescricao.ReadOnly = true;
            colunaDescricao.Width = 200;
            _view.GridPrecos.Columns.Add(colunaDescricao);

            var colunaQuantidade = new DataGridViewTextBoxColumn();
            colunaQuantidade.Name = "Quantidade";
            colunaQuantidade.HeaderText = "Quantidade";
            colunaQuantidade.DataPropertyName = "DescricaoPreco";
            colunaQuantidade.ReadOnly = true;
            colunaQuantidade.Width = 200;
            _view.GridPrecos.Columns.Add(colunaQuantidade);
        }
        private void DelegarEventos()
        {
            _view.EventoAdicionarPreco(EventoAddPreco);
            _view.BotaoDireitoClasse.Items["menuBotaoDireitoAdicionarClasse"].Click += EventoAdicionarClasse;
            _view.BotaoDireitoClasse.Items["menuBotaoDireitoRemoverClasse"].Click += EventoRemoverClasse;
            _view.BotaoDireitoTamanho.Items["menuBotaoDireitoAdicionarTamanho"].Click += EventoAdicionarTamanho;
            _view.BotaoDireitoTamanho.Items["menuBotaoDireitoRemoverTamanho"].Click += EventoRemoverTamanho;

        }
        private PrecoModel InstanciarPreco()
        {
            var model = new PrecoModel();
            model.Ativo = true;
            model.Tamanho = tamanho;
            model.Preco = _view.PrecoInformado;

            return model;

        }
        private void RemoverClasse()
        {
            if (ComportamentoAtual.Equals(EComportamentoTela.ItemSelecionado))
                if (MessageBox.Show("Deseja Remover a Classe ?? \r Todos os Vinculos de preço com essa Classe Seram removidos!", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _service.RemoverTodosVinculoDeClasseComPrecos(_classe.Id);

                else
                    return;
         

            _classe = null;

            if(_classe == null)
            {
                AlterarVisibilidadeMenuBotaoDireitoCadastroClasse(true, false);
            }

            _view.DescricaoClasse = "";

        }
        private void AdicionarClasse()
        {
            classe = Busca.IniciarBuscar(TelaBusca.Enum.ETipoBusca.CLASSE).ObterSelecionado<ClasseModel>();

            if(_classe != null)
            {
                AlterarVisibilidadeMenuBotaoDireitoCadastroClasse(false, true);
               _view.DescricaoClasse = _classe.DescricaoClasse;
            }
        }
        private void AdicioarTamanho()
        {
            var tamanhoSelecionado = Busca.IniciarBuscar(TelaBusca.Enum.ETipoBusca.TAMANHO).ObterSelecionado<TamanhoModel>();


            if (_listaPreco.Any(preco => preco.Tamanho.Equals(tamanhoSelecionado)))
                        MessageBox.Show("Ja existe Preco cadastrado para Esse Tamanho", "Cadastro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else
            {
                tamanho = tamanhoSelecionado;
                AlterarVisibilidadeMenuBotaoDireitoCadastroTamanho(false, true);
            }

        }
        private void RemoverTamanho()
        {
            tamanho = null;
        }
        private void AdicionarPrecoNaLista(PrecoModel preco)
        {
            _listaPreco.Add(preco);
            PopularListaPrecos();
        }
        private void PopularListaPrecos()
        {
            _view.GridPrecos.DataSource = null;
            _view.GridPrecos.DataSource = _listaPreco;
            
        }
        private void AbrirTela()
        {
            try
            {

                PopularListaPrecos();
                _view.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }
        private void AlterarVisibilidadeMenuBotaoDireitoCadastroClasse(bool Adicionar,bool Remover)
        {
            _view.BotaoDireitoClasse.Items["menuBotaoDireitoAdicionarClasse"].Visible = Adicionar;
            _view.BotaoDireitoClasse.Items["menuBotaoDireitoRemoverClasse"].Visible = Remover;
        }
        private void AlterarVisibilidadeMenuBotaoDireitoCadastroTamanho(bool Adicionar, bool Remover)
        {
            _view.BotaoDireitoTamanho.Items["menuBotaoDireitoAdicionarTamanho"].Visible = Adicionar;
            _view.BotaoDireitoTamanho.Items["menuBotaoDireitoRemoverTamanho"].Visible = Remover;
        }
        protected override void AlterandoComportamentoTela()
        {
            switch (ComportamentoAtual)
            {
                case EComportamentoTela.None:
                    break;
                case EComportamentoTela.Inicio:
                    _view.SetarTamanhoDaTelaReduzido();
                    
                    
                    break;

                case EComportamentoTela.Cadastrando:
                    _view.SetarTamanhoMaximoTela();
                    
                    
                    break;

                case EComportamentoTela.ItemSelecionado:
                    break;


                default:
                    break;
            }
        }
        protected override void ComportamentoInicioTela()
        {
            _view.SetarTamanhoMaximoTela();
            _view.GbDadosCadastro.Visible = false;
            _view.GbDadosCadastro.Dock = DockStyle.None;
            _view.GbPrecosCadastrados.Visible = true;
            _view.GbPrecosCadastrados.Dock = DockStyle.Fill;


            _view.SetarTamanhoDaTelaReduzido();
            this.PopularListaPrecos();
        }
        protected override void ComportamentoCadastrando()
        {
            _view.SetarTamanhoMaximoTela();
            _view.GbDadosCadastro.Visible = true;
            _view.GbDadosCadastro.Dock = DockStyle.None;
            _view.GbPrecosCadastrados.Visible = true;
            _view.GbPrecosCadastrados.Dock = DockStyle.None;
        }
        protected override void ComportamentoItemSelecionado()
        {
            
        }

    }
}
