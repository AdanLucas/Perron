using Model.Emumerator;
using Perron.Extensions;
using Perron.Presenter;
using Perron.TelaBusca.Enum;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterSabor : PresenterPadrao, IPresenterSabor
    {

        public TabControl TabControl{ get { return _view.TabControl; } }

        public SaborModel Sabor { get { return _sabor; } }
        public KeyPressEventHandler EventoTeclaPressionada { get { return this._view.EventoTeclaPressionada; } set { _view.EventoTeclaPressionada += value; } }

        private SaborModel _sabor;
        private readonly IViewCadastroSabor _view;
        private readonly IServiceSabor _service;

        
        public PresenterSabor(IViewCadastroSabor view, IServiceSabor service) : base(view)
        {
            _view = view;
            _service = service;
            _sabor = new SaborModel();
            SetarControllerIngrediente();
            _view.Show();
            DelegarEventos();
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }
        #region Metodos Privados
        private void SetarControllerIngrediente()
        {
           FactoryPresenter.EngredienteSabor(this);

        }


        #region Comportamento Tela
        protected override void ComportamentoInicioTela()
        {
            _sabor = new SaborModel();
            _view.VisibilidadeBotao = false;
            _view.DescricaoClasse = "";
            _view.DescricaoSabor = "";

        }
        protected override void ComportamentoCadastrando()
        {
            _sabor = new SaborModel();
            _sabor.Ativo = true;
            _view.VisibilidadeBotao = true;
            _view.DescricaoClasse = "";
            _view.DescricaoSabor = "";
        }
        protected override void ComportamentoItemSelecionado()
        {
             _sabor = _view.ItemSelecionadoGrid;
            SetDadosSdabor();
            _view.VisibilidadeBotao = true;
        }

        #endregion

        private void BuscarClasse()
        {
            if (_sabor != null)
            {
                try
                {
                    _sabor.Classe = (ClasseModel)Busca.IniciarBuscar(ETipoBusca.CLASSE).ObterItemSelecionado().ObterUnico<ClasseModel>();

                }
                catch 
                {
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
            _view.EventoGrid(this.EventoGrid);
            _view.EventoBuscarClasse(this.EventoBuscarClasse);

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
            if (_sabor != null)
            {
                _sabor.Descricao = _view.DescricaoSabor;
            }
        }
        private void SetDadosSdabor()
        {
            _view.DescricaoSabor = _sabor.Descricao;
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
                Salvar(_sabor);
                MessageDeSucesso($"Sabor {_sabor.Descricao} salvo com sucesso!");

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
                _sabor.InativarCadastro();

                if (_sabor.Ativo == false)
                {
                    Salvar(_sabor);

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
            
        }

        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            _view.PopularGrid(_service.GetListaSabor(status));
        }

        #endregion

    }
}
