using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public abstract class PresenterPadrao
    {
        #region View
        private readonly IViewPadraoCadastro _view; 
        #endregion

        #region Eventos
        public event StatusCadastroExibidoEventHandler EventoExibicaoCadastros;
        public event StatusCadastroTelaEventhandler EventoStatusCadastroTela;
        #endregion

        #region Construtor
        public EStatusCadastroTela StatusCadastro {  get; private set; }
        public PresenterPadrao(IViewPadraoCadastro view)
        {
            _view = view;
            DelegarEventos();
        }
        #endregion




        #region Metodos Publicos

        public void AlterarStatusTela(EStatusCadastroTela status)
        {
            StatusCadastro = status;
            NotificarEventoStatusTela();
        }
        public void MessageDeSucesso(String msg)
        {
            MessageBox.Show($"{msg}!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MessagemErro(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion




         #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventockAtivo(EventoCkativo);
            _view.EventockInativo(EventoCkativo);
            EventoStatusCadastroTela += this.EventoAlterarStausCadastro;
        }
        private void EstadoBotoes()
        {
            switch (StatusCadastro)
            {
                case EStatusCadastroTela.None:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = false;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.RemoverCheck();

                    break;

                case EStatusCadastroTela.Inicio:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = true;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = true;
                    _view.VisibilidadeckInativo = true;
                    _view.RemoverCheck();

                    break;

                case EStatusCadastroTela.Cadastrando:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;
                    _view.RemoverCheck();

                    break;

                case EStatusCadastroTela.ItemSelecionado:

                    _view.VisibilidadeBotaoDeletar = true;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;

                    break;
                case EStatusCadastroTela.Novo:

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
        private void NotificarEventoExibicaoCadastros()
        {
            if (EventoExibicaoCadastros != null)
            {
                EventoExibicaoCadastros(this, new StatusCadastroExibidoEventArgs { Status = GetstatusDosCadastrados() });
            }


        }
        private void NotificarEventoStatusTela()
        {
            if (EventoExibicaoCadastros != null)
            {
                EventoStatusCadastroTela(this, new StatusCadastroTelaEventArgs { statusTela = StatusCadastro});
            }


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
        private void EventoCkInativo(object o ,EventArgs e)
        {
            NotificarEventoExibicaoCadastros();
        }
        private void EventoCkativo(object o, EventArgs e)
        {
            NotificarEventoExibicaoCadastros();
        }
        private void EventoAlterarStausCadastro(object o, EventArgs e)
        {
            EstadoBotoes();
            
        }
        #endregion


    }


}
