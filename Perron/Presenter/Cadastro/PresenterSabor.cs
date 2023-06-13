using Perron.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterSabor : PresenterPadrao,IPresenterSabor 
    {

        private readonly IViewCadastroSabor _view;
        private IPresenterEngredienteSabor _presenterIngrediente;
        private readonly IServiceSabor _service;
        private SaborModel _sabor;

        private BuscarItemGenerico<ClasseModel> BuscaClasse = new BuscarItemGenerico<ClasseModel>();
        public PresenterSabor(IViewCadastroSabor view,IServiceSabor service) : base(view)
        {
            _view = view;
            _service = service;
            SetarControllerIngrediente(_view.PainelEngredienteSabor);
            _view.Show();
            DelegarEventos();
            base.StatusCadastro = EStatusCadastroTela.Inicio;
            
        }
        #region Metodos Privados
        private void SetarControllerIngrediente(Panel painel)
        {
            _presenterIngrediente = FactoryPresenter.EngredienteSabor(painel);

        }


        #region Comportamento Tela
        private void EstadoInicial()
        {
            _sabor = null;
            _view.VisibilidadeBotao = false;
            _view.DescricaoClasse = "";
            _view.DescricaoSabor = "";

        }
        private void EstadoNovoCadastro()
        {
            _sabor = new SaborModel();
            _sabor.Ativo = true;
            _view.VisibilidadeBotao = true;
            _view.DescricaoClasse = "";
            _view.DescricaoSabor = "";
        }
        private void EstadoItemSelecionado()
        {
            _sabor = _view.ItemSelecionadoGrid;
            SetDadosSdabor();
            _view.VisibilidadeBotao = true;
        } 
        
        #endregion

        private void BuscarClasse()
        {
            if(_sabor != null)
            {

                try
                {
                    _sabor.Classe = BuscaClasse.Get();
                }
                catch (Exception ex)
                {

                    MessagemErro(ex);
                }

            }
        }
        private void SetarClasseNaView()
        {
            if (_sabor != null)
                 _view.DescricaoClasse = _sabor.Classe.DescricaoClasse;
        }
        private void DelegarEventos()
        {
            _view.EventoNovo(this.EventoNovo);
            _view.EventoSalvar(this.EventoSalvar);
            _view.EventoDeletar(this.EventoRemover);
            _view.EventoCancelar(this.EventoCancelar);
            _view.EventoGrid(this.EventoGrid);
            _view.EventoBuscarClasse(this.EventoBuscarClasse);
            base.EventoExibicaoCadastros += EventoStatusCadastro;
            base.EventoStatusCadastroTela += _presenterIngrediente.EventoAtualizarStatusCadastro;
            base.EventoStatusCadastroTela += EventoComportamentoTela;

        }
        private void Salvar(SaborModel sabor)
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(_sabor);
                _service.Salvar(_sabor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void GetdadosSabor()
        {
            if(_sabor != null)
            {
                _sabor.Engredientes = _presenterIngrediente.GetEngredienteSabor();
                _sabor.Descricao = _view.DescricaoSabor;
                
            }
        }
        private void SetDadosSdabor()
        {
            _view.DescricaoSabor = _sabor.Descricao;
            SetarClasseNaView();
            var Lista = _sabor.GetEngredientePorStatus(EStatusCadastro.Todos);
            _presenterIngrediente.SetListaEngredienteSabor(Lista);
        }


        #endregion

        #region Metodos Publicos

        #endregion

        #region Eventos privados

        private void EventoNovo(object o , EventArgs e)
        {
            base.StatusCadastro = EStatusCadastroTela.Novo;

        }
        private void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                GetdadosSabor();
                Salvar(_sabor);
                MessageDeSucesso($"Sabor {_sabor.Descricao} salvo com sucesso!");

                base.StatusCadastro = EStatusCadastroTela.Inicio;
            }
            catch (Exception ex)
            {
                base.MessagemErro(ex);
            }
        }
        private void EventoRemover(object o, EventArgs e)
        {
            if (StatusCadastro == EStatusCadastroTela.ItemSelecionado)
            {
                _sabor.InativarCadastro();

                if (_sabor.Ativo == false)
                {
                    Salvar(_sabor);

                    base.StatusCadastro = EStatusCadastroTela.Inicio;
                }
            }
        }
        private void EventoCancelar(object o, EventArgs e)
        {
            base.StatusCadastro = EStatusCadastroTela.Inicio;
            
        }
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.ItemSelecionadoGrid != null)
            {
                base.StatusCadastro = EStatusCadastroTela.ItemSelecionado;
            }
        }
        private void EventoBuscarClasse(object o, EventArgs e)
        {
            BuscarClasse();
            SetarClasseNaView();
        }
        private void EventoStatusCadastro(object o, StatusCadastroExibidoEventArgs e)
        {
            _view.PopularGrid(_service.GetListaSabor(e.Status));
        }
        private void EventoComportamentoTela(object o, StatusCadastroTelaEventArgs e)
        {
            switch (e.statusTela)
            {
                case EStatusCadastroTela.None:
                    break;
                case EStatusCadastroTela.Inicio:
                    EstadoInicial();
                    break;

                case EStatusCadastroTela.Novo:
                    EstadoNovoCadastro();
                    break;


                case EStatusCadastroTela.Cadastrando:
                    EstadoNovoCadastro();
                    break;


                case EStatusCadastroTela.ItemSelecionado:
                    EstadoItemSelecionado();
                    break;


                default:
                    break;
            }
        }
        #endregion

    }
}
