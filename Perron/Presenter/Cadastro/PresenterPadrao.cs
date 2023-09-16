using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Perron.Controller
{
    public abstract class PresenterPadrao
    {
        #region Propriedades
        private readonly IViewPadraoCadastro _view;

        protected Aentity Entidade { get { return entidade; } set { AlterandoEntidade(value); } }
        private Aentity entidade { get; set; }

        public EComportamentoTela ComportamentoAtual { get { return comportamentoAtual; } set { SetarComportamentoTela(value); } }
        private EComportamentoTela comportamentoAtual { get; set; }
        #endregion

        #region Eventos

        #endregion

        #region Construtor
        public PresenterPadrao(IViewPadraoCadastro view)
        {
            _view = view;
            DelegarEventos();
        }
        #endregion

        #region VIRTUAL

        #region Eventos
        protected virtual void EventoSalvar(object o, EventArgs e) { }
        protected virtual void EventoNovo(object o, EventArgs e) { }
        protected virtual void EventoCancelar(object o, EventArgs e) { }
        protected virtual void EventoRemover(object o, EventArgs e) { }

        #endregion

        #region Metodos

        protected virtual void ComportamentoInicioTela() { }
        protected virtual void ComportamentoItemSelecionado() { }
        protected virtual void ComportamentoCadastrando() { }
        protected virtual void AlterandoComportamentoTela() { }


        protected virtual void AlterarComportamentoTela(EComportamentoTela status) { AlterandoComportamentoTela(); }
        protected virtual void AlterarStatusCadastroExibidos(EStatusCadastro status) { }

        #endregion

        #endregion

        #region PROTECTED
        protected void MessageDeSucesso(String msg)
        {
            MessageBox.Show($"{msg}!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        protected void MessagemErro(Exception ex)
        {
            ControllerNotificao.MessagemErro(ex);
        }
        protected void MessagemErro(Exception ex, StackTrace st)
        {
            MessageBox.Show(ex.Message + "\n\r" + ex.InnerException + "\n\r" + ex.StackTrace.ToString(), "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Metodos Privados
        private void AlterandoEntidade(Aentity _entidade)
        {
            if (_entidade.Ativo == false)
            {
                _view.VisibilidadeBotaoDeletar = false;
            }
            else
            {
                _view.VisibilidadeBotaoDeletar = true;
            }

            this.entidade = _entidade;
        }
        private void DelegarEventos()
        {
            _view.EventockAtivo(EventoCheckStatusCadastro);
            _view.EventockInativo(EventoCheckStatusCadastro);
            _view.EventoCancelar(this.EventoCancelar);
            _view.EventoSalvar(this.EventoSalvar);
            _view.EventoNovo(this.EventoNovo);
            _view.EventoDeletar(this.EventoRemover);
        }
        private void SetarComportamentoTela(EComportamentoTela status)
        {
            comportamentoAtual = status;
            EstadoBotoes();
            AlterarComportamentoTela(status);
        }
        private void EstadoBotoes()
        {
            switch (comportamentoAtual)
            {
                case EComportamentoTela.None:
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = false;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.RemoverCheck();
                    ComportamentoInicioTela();
                    break;

                case EComportamentoTela.Inicio:
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = true;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = true;
                    _view.VisibilidadeckInativo = true;
                    _view.RemoverCheck();
                    ComportamentoInicioTela();
                    break;

                case EComportamentoTela.Cadastrando:
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.RemoverCheck();
                    this.ComportamentoCadastrando();
                    break;

                case EComportamentoTela.ItemSelecionado:

                    if (_view.VisualizarCadastrosInativos)
                        _view.VisibilidadeBotaoDeletar = false;
                    else
                        _view.VisibilidadeBotaoDeletar = true;

                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    this.ComportamentoItemSelecionado();
                    break;

                case EComportamentoTela.Novo:
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.RemoverCheck();
                    this.ComportamentoCadastrando();
                    break;

                default:
                    break;
            }
        }
        private void NotificarEventoAlterarStatusCadastroExibido(EStatusCadastro status)
        {
            AlterarStatusCadastroExibidos(status);
        }
        private EStatusCadastro GetstatusDosCadastrados()
        {
            if (_view.VisualizarCadastrosAtivo && _view.VisualizarCadastrosInativos)
                return EStatusCadastro.Todos;

            else if (_view.VisualizarCadastrosAtivo)
                return EStatusCadastro.Ativo;

            else if (_view.VisualizarCadastrosInativos)
                return EStatusCadastro.Inativo;


            return EStatusCadastro.none;
        }

        #endregion

        #region Evento Privados
        private void EventoCheckStatusCadastro(object o, EventArgs e)
        {
            NotificarEventoAlterarStatusCadastroExibido(GetstatusDosCadastrados());
        }
        #endregion
    }


}
