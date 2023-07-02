using Model.Emumerator;
using Model.Model;
using Perron.Controller;
using Perron.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;

namespace Perron.Presenter.Cadastro
{
    public class PresenterCadastroPessoa : PresenterPadrao, IPresenterCadastroPessoa
    {

        #region Propriedades

        private PessoaModel _pessoa = new PessoaModel();
        private ETipoPessoa TipoPessoaCadastro { get; set; }
        private readonly IViewCadastroPessoa _view;
        private TipoPessoaComponente _componenteSelecaoTipoPessoa;
        private readonly IServiceTipoPessoa _service;
        private ICollection<IControllerTipoPessoa> _controllers = new List<IControllerTipoPessoa>();
        private event EventHandlerGenerico<Object[]> EventoComportamentoCadastro; 

       

        #endregion

        #region Contrutor
        public PresenterCadastroPessoa(ETipoPessoa tipo, IViewCadastroPessoa view, IServiceTipoPessoa service) : base(view)
        {
            TipoPessoaCadastro = tipo;
            _view = view;
            _view.Show();
            SetarNomeTela();
            _service = service;
            _componenteSelecaoTipoPessoa = new TipoPessoaComponente(_view.PainelTipoPesso, TipoPessoaCadastro);
            _componenteSelecaoTipoPessoa.EventoAlterandoTipoPessoaSelecionado += EventoCriarTabPage;
            base.ComportamentoAtual = EComportamentoTela.Inicio;
            DefinirComportamentoCadastro(TipoPessoaCadastro);

        }
        #endregion

        #region Controller Tipo Pessoa
        private TabPage CiarTabPage(Enum tipo)
        {
            var nomeTabPage = Enum.GetName(typeof(ETipoPessoa), tipo);

            TabPage page = new TabPage();
            page.Text =  "Dados "+nomeTabPage;
            page.Name = nomeTabPage;

            return page;
        }
        private IControllerTipoPessoa InstanciarController(string NomeController)
        {
            try
            {
                Type tipo = Type.GetType(NomeController);

                if (tipo != null)
                    return Activator.CreateInstance(tipo) as IControllerTipoPessoa;

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void CriarRemoverController(ETipoPessoa tipo)
        {
            try
            {
                foreach (var item in tipo.GetArrayItemEnum())
                {
                    if (item != ETipoPessoa.Pessoa)
                    {
                        if (tipo.HasFlag(item))
                            IniciarCadastroTipoPessoa(item);

                        else
                            RemoverCadastroTipoPessoa(item);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void IniciarCadastroTipoPessoa(ETipoPessoa tipo)
        {
            try
            {
                var page = CiarTabPage(tipo);

                if (!_view.TabControlTipoPessoa.TabPages.ContainsKey(page.Name))
                {
                    IControllerTipoPessoa _controller = InstanciarController(tipo.GetDadosController());

                    if (_controller != null)
                    {
                        _controller.SetarUserEmTabPage(page);
                        EventoComportamentoCadastro += _controller.EventoComportamento;
                        _controllers.Add(_controller);
                        _view.TabControlTipoPessoa.TabPages.Add(page);
                    }
                    else
                        throw new Exception($"Nao Foi Possivel Criar Controller {page.Name}");
                }
            }
            catch (Exception ex)
            {

                MessagemErro(ex);
            }
        }
        private bool RemoverCadastroTipoPessoa(ETipoPessoa Tipo)
        {
            if (_view.TabControlTipoPessoa.TabPages.ContainsKey(Tipo.GetNomeItem()))
            {
                _view.TabControlTipoPessoa.TabPages.RemoveByKey(Tipo.GetNomeItem());
                var controller = _controllers.Where(x => x.GetType().Equals(Type.GetType(Tipo.GetDadosController()))).FirstOrDefault();


                if (!_controllers.Remove(controller))
                    throw new Exception("Nao Foi Possivel Remover o Controller");

                else
                    return true;
            }
            else
                return true;


        }
        private void RemoverTodosControllers()
        {
            try
            {
                ETipoPessoa tipo = new ETipoPessoa();
                var tipos = tipo.GetArrayItemEnum();

                foreach (var t in tipos)
                {
                    RemoverCadastroTipoPessoa(t);
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
                var TipoCadastro = _componenteSelecaoTipoPessoa.TipoPessoaSelecionado;
                
                foreach (var item in _pessoa.Tipo.GetListEnumValue<ETipoPessoa>())
                {
                    if (!TipoCadastro.HasFlag(item) && item != ETipoPessoa.Pessoa)
                    {
                        var controller = InstanciarController(item.GetDadosController());
                        controller.Salvar(_pessoa, false);
                        _pessoa.Tipo -= (ETipoPessoa)item;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DefinirComportamentoCadastro(ETipoPessoa tipo)
        {
            try
            {

                if (tipo.HasFlag(ETipoPessoa.Pessoa))
                {
                }
                else
                {
                    IniciarCadastroTipoPessoa(tipo);

                }
            }
            catch (Exception ex)
            {
                MessagemErro(ex);
            }
        }
        private void SetarNomeTela()
        {
            string nome = "Cadastro ";

            var Itens = TipoPessoaCadastro.GetListEnumValue<ETipoPessoa>();
       

            nome += string.Join(", ", Itens.Select(t=>t.GetNomeItem()));

            _view.DescricaoTela = nome;
        }
        #endregion

        #region Eventos
        private void EventoNotificarEvento(EComportamentoTela comportamento)
        {
            if (EventoComportamentoCadastro != null)
            {
                object[] paramentros = new object[] { comportamento,_pessoa };

                EventoComportamentoCadastro(this, new EventArgsGenerico<Object[]> { Item = paramentros });
            }
        }
        private void EventoCriarTabPage(object o, EventArgsGenerico<ETipoPessoa> e)
        {
            CriarRemoverController(e.Item);
        } 
        #endregion
        
        #region Override

        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
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
        protected override void AlterarComportamentoTela(EComportamentoTela status)
        {
            SetarComportamento(status);
        } 
        
        #endregion
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

                        _service.Salvar(_pessoa);


                        foreach (var item in _controllers)
                        {
                            item.Salvar(_pessoa,true);
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


            }catch (Exception ex)
            {
                throw ex;
            }
        }
        

        #region Comportamentos Tela

        private void SetarComportamento(EComportamentoTela comportamento)
        {
            switch (comportamento)
            {
                case EComportamentoTela.None:
                    break;

                case EComportamentoTela.Inicio:
                    ComportamentoInicio();
                    break;

                case EComportamentoTela.Novo:
                    ComportamentoNovo();
                    break;

                case EComportamentoTela.Cadastrando:
                    ComportamentoCadastrando();
                    break;

                case EComportamentoTela.ItemSelecionado:
                    ComportamentoItemSelecionado();
                    break;


                default:
                    break;
            }
        }
        private void ComportamentoNovo()
        {
            if (_componenteSelecaoTipoPessoa.TipoPessoaSetado.HasFlag(ETipoPessoa.Pessoa))
            {
                SetarAlturaMaxima();
                _componenteSelecaoTipoPessoa.Enabled = true;
                _componenteSelecaoTipoPessoa.RemoverCheck();
            }
            else
            {
                EventoNotificarEvento(EComportamentoTela.Cadastrando);
            }

            
        }
        private void ComportamentoInicio()
        {
            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                SetarAlturaMinina();
                _componenteSelecaoTipoPessoa.Enabled = false;
                _componenteSelecaoTipoPessoa.RemoverCheck();
                RemoverTodosControllers();


            } 
            else
            {
                EventoNotificarEvento(EComportamentoTela.Inicio);
                SetarAlturaMaxima();
            }
        }
        private void ComportamentoCadastrando()
        {
            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                SetarAlturaMaxima();
                _componenteSelecaoTipoPessoa.Enabled = true;
                _componenteSelecaoTipoPessoa.RemoverCheck(); 
            }
            else
            {

            }
        }
        private void ComportamentoCancelar()
        {
            
        } 
        private void ComportamentoItemSelecionado()
        {
            if (TipoPessoaCadastro.HasFlag(ETipoPessoa.Pessoa))
            {
                _componenteSelecaoTipoPessoa.Enabled = true; 
            }
            else
            {

            }
        }
        private void SetarAlturaMaxima()
        {
            _view.AlturaTela = 600;
        }
        private void SetarAlturaMinina()
        {
            _view.AlturaTela = 316;
        }

        #endregion
    }
}
