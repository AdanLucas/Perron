using Model.Interface.View;
using Perron.Controller;
using Perron.Extensions;
using Perron.Properties;
using System;
using System.Collections.Generic;
using System.Data;
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
        private PrecoModel precoSelecionado { get; set; }
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
            {
                _tamanho = null;
                _view.DescricaoTamanho ="";
                
            }
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
        private void EstadoInicial()
        {
            this.SetarClasse(null);
            this.SetarTamanho(null);
            this.AlterarVisibilidadeMenuBotaoDireitoCadastroClasse(true, false);
            this.AlterarVisibilidadeMenuBotaoDireitoCadastroTamanho(true, false);
            _view.PrecoInformado = 0;
        }



        #region Eventos Privados
        private void EventoAddPreco(Object o, EventArgs e)
        {
            try
            {
                var preco = InstanciarPreco();
                ValidarDadosPreco(preco);
                AdicionarPrecoNaLista(preco);
                EstadoInicial();
            }
            catch (SyntaxErrorException ex)
            {
                MessagemErro(ex);
            }

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
            AdicioarTamanho();
            AlterarVisibilidadeMenuBotaoDireitoCadastroTamanho(false, true);
        }
        private void EventoRemoverTamanho(object sender, EventArgs args)
        {
            RemoverTamanho();
            AlterarVisibilidadeMenuBotaoDireitoCadastroTamanho(true, false);
        }
        private void EventoGridPrecos(object sender , EventArgs args)
        {
            this.precoSelecionado = _view.GridPrecos.CurrentRow.DataBoundItem as PrecoModel;

            if (this.precoSelecionado != null)
                        this.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
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
                    EstadoInicial();
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
                _listaPreco = _service.GetListaPreco();
                PopularListaPrecos();
                EstadoInicial();
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
        protected override void EventoRemover(object o, EventArgs e)
        {
            precoSelecionado.Ativo = false;
            this.PopularListaPrecos();

        }
        #endregion
        private void IniciarListaTamanhos()
        {
            this._listaPreco = _service.GetListaPreco();
        }
        private void ValidarDadosPreco(PrecoModel preco)
        {
            if (preco.Preco <= 0)
                throw new SyntaxErrorException("Informe Um valor maior que 0");

            if (preco.Tamanho == null)
                throw new SyntaxErrorException("Selecione Um Tamanho para Vincular ao Preco");

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
            _view.GridPrecos.DoubleClick += EventoGridPrecos;

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
        private bool AdicioarTamanho()
        {
            var tamanhoSelecionado = Busca.IniciarBuscar(TelaBusca.Enum.ETipoBusca.TAMANHO).ObterSelecionado<TamanhoModel>();


            if (_listaPreco.Any(preco => preco.Tamanho.Equals(tamanhoSelecionado)))
            {
                        MessageBox.Show("Ja existe Preco cadastrado para Esse Tamanho", "Cadastro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return false;
            }


            else
            {
                tamanho = tamanhoSelecionado;
                return true;
            }

        }
        private void RemoverTamanho()
        {
            tamanho = null;
        }
        private void ValidarPrecoCadastrado(PrecoModel preco)
        {
            if (_listaPreco.Any(Item => preco.Tamanho.Id.Equals(Item.Tamanho.Id)))
                     throw new SyntaxErrorException("Já existem Preco Com esse tamanho Vinculado");
        }
        private void AdicionarPrecoNaLista(PrecoModel preco)
        {
            try
            {
                ValidarPrecoCadastrado(preco);
                _listaPreco.Add(preco);
                PopularListaPrecos();
            }
            catch (SyntaxErrorException ex)
            {
                MessagemErro(ex);
            }
        }
        private void PopularListaPrecos()
        {
            _view.GridPrecos.DataSource = null;
            _view.GridPrecos.DataSource = _listaPreco.Where(preco=>preco.Ativo.Equals(true)).ToList();
            
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
