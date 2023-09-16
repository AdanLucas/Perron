using Model.Emumerator;
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

namespace Perron.Presenter.Cadastro
{
    public class PresenterCadastroPessoa : PresenterPadrao, IPresenterCadastroPessoa
    {

        #region Propriedades

        private PessoaModel pessoa { get { return GetDadosPessoa(); } set { SetDadospessoa(value); } }
        private PessoaModel _pessoa;

        private ControllerCadastroEndereco controllerEndereco;

        private Action<EComportamentoTela> ExecutaAlteracaoComportamento;
        private Action ExecutarCadastro;

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
            cmpTipoPessoa.EventoAlterandoTipoPessoaSelecionado += EventoCriarTabPage;
            GetDadosPessoa();
            controllerEndereco = new ControllerCadastroEndereco(_view.GBEndereco.Controls, ref _pessoa);
            ExecutaAlteracaoComportamento += controllerEndereco.AlterarEstadoCadastro;
            base.ComportamentoAtual = EComportamentoTela.Inicio;
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


        }
        private void IniciarCadastroTipoPessoa(ETipoPessoa tipo)
        {
            foreach (var item in tipo.GetArrayItemEnum())
            {
                IControllerTipoPessoa _controller = null;

                if (!_view.TabControlTipoPessoa.TabPages.ContainsKey(item.GetNomeItem()))
                {
                    var page = CiarTabPage(item);

                    _controller = FactoryController.GerarControllerTipoPessoa(tipo);

                    if (_controller != null)
                    {
                        _controller.Iniciar(page.Controls);
                        _controller.GetDadosPessoa += GetDadosPessoa;
                        ExecutaAlteracaoComportamento += _controller.AlterarComportamentoCadastro;
                        ExecutarCadastro += _controller.Salvar;
                        _controllers.Add(_controller);
                        _view.TabControlTipoPessoa.TabPages.Add(page);
                    }
                }
            }

        }
        private void RemoverController(ETipoPessoa Tipo)
        {
            if (_view.TabControlTipoPessoa.TabPages.ContainsKey(Tipo.GetNomeItem()))
            {
                _view.TabControlTipoPessoa.TabPages.RemoveByKey(Tipo.GetNomeItem());
                var controller = _controllers.Where(x => x.TipoController.Equals(Tipo)).FirstOrDefault();
                controller.RemoverTipoCadastro();
                _controllers.Remove(controller);
                controller = null;
            }
        }
        private void RemoverTodosControllers()
        {
            try
            {
                ETipoPessoa tipo = new ETipoPessoa();
                var tipos = tipo.GetArrayItemEnum();

                foreach (var t in tipos)
                {
                    RemoverController(t);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ValidarRemoverTipoPessoaCadastro()
        {
            try
            {

                if (_pessoa != null)
                {
                    var TipoCadastro = cmpTipoPessoa.TipoPessoaSelecionado;

                    foreach (var item in _pessoa.Tipo.GetListEnumValue<ETipoPessoa>())
                    {
                        if (!TipoCadastro.HasFlag(item) && item != ETipoPessoa.Pessoa)
                        {
                            var controller = _controllers.Where(ctrl => ctrl.TipoController.HasFlag(item)).FirstOrDefault();
                            controller.Salvar();
                            _pessoa.Tipo -= (ETipoPessoa)item;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SetarNomeTela()
        {
            string nome = "Cadastro ";

            var Itens = TipoPessoaCadastro.GetListEnumValue<ETipoPessoa>();


            nome += string.Join(", ", Itens.Select(t => t.GetNomeItem()));

            _view.DescricaoTela = nome;
        }
        #endregion

        #region Eventos
        private void EventoRemoverTipoPessoa(object o, EventArgsGenerico<ETipoPessoa> e)
        {
            if (MessageBox.Show($"Deseja Remover o Tipo de Cadastro {e.Item.GetNomeItem()} ??", "Remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoverController(e.Item);
                }
                catch (Exception ex)
                {
                    cmpTipoPessoa.TipoPessoaSelecionado |= e.Item;
                    throw ex;
                }


            }
            else
               cmpTipoPessoa.TipoPessoaSelecionado |= e.Item;
            


        }
        private void EventoCriarTabPage(object o, EventArgsGenerico<ETipoPessoa> e)
        {
            IniciarCadastroTipoPessoa(e.Item);
        }
        #endregion

        #region Override

        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
            _pessoa.Id = 10;
        }
        protected override async void EventoSalvar(object o, EventArgs e)
        {
            await SalvarCadastro();
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;
        }
        protected override void EventoRemover(object o, EventArgs e)
        {

        }


        #endregion
        private void ExecutaAlteracaoComportamentoCadastro(EComportamentoTela comportamento)
        {
            if (ExecutaAlteracaoComportamento != null)
                    ExecutaAlteracaoComportamento(comportamento);

        }
        private async Task SalvarCadastro()
        {
            await Task.Run(() =>
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        ValidarCadastroPessoa();
                        ValidarRemoverTipoPessoaCadastro();
                        

                        _pessoa.Id = _service.Salvar(pessoa);

                        foreach (var item in _controllers)
                        { 
                            item.Salvar();
                        }

                        tran.Complete();

                        MessageDeSucesso("Cadastrado Com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        tran.Dispose();

                        MessagemErro(ex);
                    }
                }
            });
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
        private void VinculandoEventoPararemoverTipoPessoa()
        {
            if (ComportamentoAtual.Equals(EComportamentoTela.ItemSelecionado))
            {
                cmpTipoPessoa.EventoRemovendoTipoPessoa -= EventoRemoverTipoPessoa;
                cmpTipoPessoa.EventoRemovendoTipoPessoa += EventoRemoverTipoPessoa;
            }
            else
            {
                cmpTipoPessoa.EventoRemovendoTipoPessoa -= EventoRemoverTipoPessoa;
            }
        }


        #region Comportamentos Tela
        protected void ComportamentoNovo()
        {
            if (cmpTipoPessoa.TipoPessoaSetado.HasFlag(ETipoPessoa.Pessoa))
            {
                cmpTipoPessoa.Enabled = true;
                cmpTipoPessoa.RemoverCheck();
            }
        }
        protected override void ComportamentoInicioTela()
        {


            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                _view.SetarTamanhoDaTelaReduzido();
                cmpTipoPessoa.Enabled = false;
                cmpTipoPessoa.RemoverCheck();
                RemoverTodosControllers();

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
            }

        }
        protected override void AlterandoComportamentoTela()
        {
            VinculandoEventoPararemoverTipoPessoa();
            ExecutaAlteracaoComportamentoCadastro(base.ComportamentoAtual);

        }

        #endregion
    }
}
