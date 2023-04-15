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
        #endregion

        #region Construtor
        public PresenterPadrao(IViewPadraoCadastro view)
        {
            _view = view;
            DelegarEventos();
        }
        #endregion

        private void DelegarEventos()
        {
            _view.EventockAtivo(EventoCkativo);
            _view.EventockInativo(EventoCkativo);
        }

        #region Metodos Publicos

        public void EstadoBotoes(EStatusCadastroTela statusTela)
        {
            switch (statusTela)
            {
                case EStatusCadastroTela.None:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = false;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;

                    break;

                case EStatusCadastroTela.Inicio:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = true;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = true;
                    _view.VisibilidadeckInativo = true;

                    break;

                case EStatusCadastroTela.Cadastrando:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;

                    break;

                case EStatusCadastroTela.ItemSelecionado:

                    _view.VisibilidadeBotaoDeletar = true;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = true;
                    _view.VisibilidadeckInativo = true;

                    break;
                case EStatusCadastroTela.Novo:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;
                    _view.VisibilidadeckAtivo = false;
                    _view.VisibilidadeckInativo = false;

                    break;

                default:
                    break;
            }
        }
        public void RemoverCkeck()
        {
            _view.RemoverCheck();
        }
        #endregion


         #region Metodos Privados
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
        public void MessageDeSucesso(String msg)
        {
            MessageBox.Show($"{msg}!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MessagemErro(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void NotificarEventoExibicaoCadastros()
        {
            if (EventoExibicaoCadastros != null)
            {
                EventoExibicaoCadastros(this, new StatusCadastroExibidoEventArgs { Status = GetstatusDosCadastrados() });
            }


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

        #endregion


    }


}
