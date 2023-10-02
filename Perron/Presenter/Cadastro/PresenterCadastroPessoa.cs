﻿using Model.Emumerator;
using Model.Model;
using Perron.Controller;
using Perron.Componentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Diagnostics.Eventing.Reader;

namespace Perron.Presenter.Cadastro
{
    public class PresenterCadastroPessoa : PresenterPadrao, IPresenterCadastroPessoa
    {

        #region Propriedades
        private List<PessoaModel> ListaPessoa {  get; set; }
        private PessoaModel pessoa { get { return GetDadosPessoa(); } set { SetDadospessoa(value); } }
        private PessoaModel _pessoa;

        private ControllerCadastroEndereco controllerEndereco;

        private Action<EComportamentoTela> ExecutaAlteracaoComportamento;
        private Action<PessoaModel> AtualizaDadosEntidade { get; set;}
        private Action EventoLimparCampos { get; set; }
        private ETipoPessoa TipoPessoaCadastro { get; set; }
        private readonly IViewCadastroPessoa _view;
        private SelecaoTipoPessoa cmpTipoPessoa;
        private readonly IServiceTipoPessoa _service;
        private ICollection<IControllerTipoPessoa> _controllers = new List<IControllerTipoPessoa>();

        #endregion

        #region Contrutor
        public PresenterCadastroPessoa(IViewCadastroPessoa view, IServiceTipoPessoa service, params object[] parametro) : base(view)
        {
            TipoPessoaCadastro = parametro[0] == null ? ETipoPessoa.Pessoa : (ETipoPessoa)parametro[0];
            _view = view;
            _view.Show();
            SetarNomeTela();
            _service = service;
            cmpTipoPessoa = new SelecaoTipoPessoa(_view.PainelTipoPesso, TipoPessoaCadastro);
            cmpTipoPessoa.EventoAlterandoTipoPessoa += EventoAlterandoTipoPessoa;
            GetDadosPessoa();
            controllerEndereco = new ControllerCadastroEndereco(_view.GBEndereco.Controls, ref _pessoa);
            EventoLimparCampos += controllerEndereco.EventoLimparCampos;
            AtualizaDadosEntidade += controllerEndereco.EventoAtualizarDadosEntidade;


            DelegarEventos();
            ExecutaAlteracaoComportamento += controllerEndereco.AlterarEstadoCadastro;
            base.ComportamentoAtual = EComportamentoTela.Inicio;
            ListaPessoa = CacheSessao.Instancia.ListaPessoa;

        }
        #endregion

        #region Controller Tipo Pessoa
        private TabPage CiarTabPage(Enum tipo)
        {
            var nomeTabPage = Enum.GetName(typeof(ETipoPessoa), tipo);

            TabPage page = new TabPage();
            page.Text = "Dados " + nomeTabPage;
            page.Name = nomeTabPage;

            return page;
        }
        private void DelegarEventos()
        {
            _view.EventoBusca += EventoBuscandoPessoa;
            _view.EventoGridBusca += EventoSelecionandoPessoaBusca;
            this.EventoLimparCampos += LimparCampos;
        }
        private PessoaModel GetDadosPessoa()
        {
            try
            {
                if (_pessoa == null)
                {
                    _pessoa = new PessoaModel();
                    _pessoa.Ativo = true;
                    _pessoa.Enderecos = new List<EnderecoModel>();
                    
                }

                _pessoa.Nome = _view.Nome;
                _pessoa.Sobrenome = _view.Sobrenome;
                _pessoa.CpfCnpj = _view.CpfCnpj;
                _pessoa.Tipo = cmpTipoPessoa.TipoPessoaSelecionado;
                _pessoa.Telefone = _view.Telefone;


                return _pessoa;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void SetDadospessoa(PessoaModel pessoa)
        {
            _pessoa = pessoa;

            _view.CpfCnpj = pessoa.CpfCnpj;
            _view.Telefone = pessoa.Telefone;
            _view.Sobrenome = pessoa.Sobrenome;
            _view.Nome = pessoa.Nome;

            cmpTipoPessoa.TipoPessoaSelecionado = pessoa.Tipo;
            AtualizaDadosEntidade(_pessoa);
        }
        private bool IniciarCadastroTipoPessoa(ETipoPessoa _tipo)
        {
            var tipo = _tipo.GetArrayItemEnum().Where(tp => tp.HasFlag(_tipo)).LastOrDefault();

            IControllerTipoPessoa _controller = _controllers.Where(ctrl => ctrl.TipoController.HasFlag(tipo)).FirstOrDefault();

            if (_controller != null)
            {
                if (_controller.Entidade.Ativo == true)
                    return true;

                 _controller.Entidade.Ativo = true;
            }
                                         
            
            else
            {
                _controller = FactoryController.GerarControllerTipoPessoa(tipo);

                if (_controller == null)
                                    return false;
                
                ExecutaAlteracaoComportamento += _controller.AlterarComportamentoCadastro;
                EventoLimparCampos += _controller.LimparCampos;
                AtualizaDadosEntidade += _controller.AtulizarDadosEntidadePessoa;
                _controllers.Add(_controller);
            }

             var page = CiarTabPage(tipo);
             _controller.Iniciar(page.Controls);
             _view.TabControlTipoPessoa.TabPages.Add(page);

             return true;
        }
        private bool RemoverController(ETipoPessoa Tipo)
        {
            if (_view.TabControlTipoPessoa.TabPages.ContainsKey(Tipo.GetNomeItem()))
            {
                _view.TabControlTipoPessoa.TabPages.RemoveByKey(Tipo.GetNomeItem());
                var controller = _controllers.Where(x => x.TipoController.Equals(Tipo)).FirstOrDefault();
                _controllers.Remove(controller);
                controller = null;
                return true;
            }

            return true;
        }
        private void SetarNomeTela()
        {
            ETipoPessoa[] Itens = null;

            string nome = "Cadastro ";

            if (cmpTipoPessoa != null)
            {
                Itens = cmpTipoPessoa.TipoPessoaSelecionado.GetListEnumValue<ETipoPessoa>();
                nome += string.Join(", ", Itens.Select(t => t.GetNomeItem()));
            }

            else
                nome += "Pessoa";






            _view.DescricaoTela = nome;
        }
        #endregion

        #region Eventos
        private void EventoAlterandoTipoPessoa(object o, EventArgs e)
        {
            SetarNomeTela();

            var ck = (CheckBox)o; 
            var tipo = cmpTipoPessoa.PegarTipoPeloNome(ck.Name);


            if (ck.Checked)
            {
                ck.Checked = IniciarCadastroTipoPessoa(tipo);
            }
            else
            {
                if(ComportamentoAtual.Equals(EComportamentoTela.Cadastrando))
                     ck.Checked = !RemoverController(tipo);

                else if(ComportamentoAtual.Equals(EComportamentoTela.ItemSelecionado))
                {
                    _view.TabControlTipoPessoa.TabPages.RemoveByKey(ck.Name);

                    if(_controllers.Any(ctrl => ctrl.TipoController.HasFlag(tipo)))
                            _controllers.Where(ctrl => ctrl.TipoController.HasFlag(tipo)).FirstOrDefault().Entidade.Ativo = false;

                }
            }
        }
        private void EventoBuscandoPessoa(object o, EventArgs e)
        {
            _view.ListaPessoaSendoExibidos = ListaPessoa.Where(p=> ValidarBuscarPessoa(p)).ToList();
        }
        private void EventoSelecionandoPessoaBusca(object o,EventArgs e)
        {
            if(_view.PessaoSelecionada != null)
            {
                pessoa = _view.PessaoSelecionada;
                ComportamentoAtual = EComportamentoTela.ItemSelecionado;
            }
        }
     
        #endregion

        #region Override

        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Cadastrando;
        }
        protected override  void EventoSalvar(object o, EventArgs e)
        {
             SalvarCadastro();
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            EstadoInicialTela();
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            try
            {
                if (pessoa != null && (MessageBox.Show($"Deseja Inativar {pessoa.Nome} ??","Inativar??",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
                {
                    pessoa.Ativo = false;

                    this.SalvarCadastro();
                }
            }
             catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion
        private void EstadoInicialTela()
        {
            this.EventoLimparCampos();
            this._controllers.Clear();
            this._view.TabControlTipoPessoa.TabPages.Clear();
            pessoa = new PessoaModel();
            pessoa.Ativo = true;
        }
        private void LimparCampos()
        {
            _view.CpfCnpj = "";
            _view.Telefone = "";
            _view.Nome = "";
            _view.Sobrenome = "";
        }
        private void ExecutaAlteracaoComportamentoCadastro(EComportamentoTela comportamento)
        {
            if (ExecutaAlteracaoComportamento != null)
                    ExecutaAlteracaoComportamento(comportamento);

        }
        private  void SalvarCadastro()
        {
            
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        ValidarCadastroPessoa();

                         pessoa.Id = _service.Salvar(pessoa);
                        AtualizaDadosEntidade(pessoa);
                        foreach (var item in _controllers)
                        { 
                            item.Salvar();
                        }
                        tran.Complete();
                        ComportamentoAtual = EComportamentoTela.Inicio;
                        MessageDeSucesso("Cadastrado Com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        tran.Dispose();

                        MessagemErro(ex);
                    }
                }
            
        }
        private void ValidarCadastroPessoa()
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(pessoa);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarBuscarPessoa(PessoaModel pessoa)
        {
            bool status = false;
            bool busca;
            bool Todos = (GetstatusDosCadastrados().HasFlag(EStatusCadastro.Todos));

            if (GetstatusDosCadastrados().HasFlag(EStatusCadastro.Ativo))
                status = pessoa.Ativo==true;

            else if (GetstatusDosCadastrados().HasFlag(EStatusCadastro.Inativo))
                status = pessoa.Ativo == false;


            else
                status = false;


            busca = pessoa.Nome.ToUpper().Contains(_view.TextoBusca.ToUpper());
            

            var ret = busca & (Todos || status);

            return ret;

        }

        #region Comportamentos Tela
        protected void ComportamentoNovo()
        {
            EstadoInicialTela();

            if (cmpTipoPessoa.TipoPessoaSetado.HasFlag(ETipoPessoa.Pessoa))
            {
                cmpTipoPessoa.Enabled = true;
                cmpTipoPessoa.RemoverCheck();
            }
        }
        protected override void ComportamentoInicioTela()
        {
            EventoLimparCampos();
            pessoa = new PessoaModel();

            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                _view.SetarTamanhoDaTelaReduzido();
                cmpTipoPessoa.Enabled = false;
                cmpTipoPessoa.RemoverCheck();

            }
            else
                _view.SetarTamanhoMaximoTela();

        }
        protected override void ComportamentoCadastrando()
        {
            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                _view.SetarTamanhoMaximoTela();
                cmpTipoPessoa.Enabled = true;
                cmpTipoPessoa.RemoverCheck();

            }
        }
        protected override void ComportamentoItemSelecionado()
        {
            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                cmpTipoPessoa.Enabled = true;
                _view.SetarTamanhoMaximoTela();
            }

        }
        protected override void AlterandoComportamentoTela()
        {
            
            ExecutaAlteracaoComportamentoCadastro(base.ComportamentoAtual);
        }

        #endregion
    }
}
