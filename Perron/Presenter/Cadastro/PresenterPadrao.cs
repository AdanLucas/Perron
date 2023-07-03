using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public abstract class PresenterPadrao
    {
        #region Propriedades
        private readonly IViewPadraoCadastro _view; 
        public EComportamentoTela ComportamentoAtual { get{ return comportamentoAtual; } set { SetarComportamentoTela(value); } }
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
        protected virtual void EventoSalvar(object o, EventArgs e) {  }
        protected virtual void EventoNovo(object o, EventArgs e) {  }
        protected virtual void EventoCancelar(object o, EventArgs e) {  }
        protected virtual void EventoRemover(object o, EventArgs e) {  }
        
           #endregion

           #region Metodos

        protected virtual void AlterarComportamentoTela(EComportamentoTela status) { }
        protected virtual void AlterarStatusCadastroExibidos(EStatusCadastro status) { }

        #endregion

        #endregion

        #region PROTECTED
        protected void MessageDeSucesso(String msg)
        {
            MessageBox.Show($"{msg}!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }
        protected void MessagemErro(Exception ex)
        {
            ControllerNotificao.MessagemErro(ex);
        }
        protected void MessagemErro(Exception ex,StackTrace st)
        {
            MessageBox.Show(ex.Message + "\n\r" + ex.InnerException + "\n\r" + ex.StackTrace.ToString(), "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected void AlterarAlturaTela(int altura)
        {
            _view.AlturaTela = altura;
        } 
        #endregion

        #region Metodos Privados
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
                    break;

                case EComportamentoTela.Inicio:
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = true;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = true;
                    _view.VisibilidadeckInativo = true;
                    _view.RemoverCheck();
                    break;

                case EComportamentoTela.Cadastrando:
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.RemoverCheck();
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
                    break;

                case EComportamentoTela.Novo:
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.RemoverCheck();
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
