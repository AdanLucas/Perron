using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Presenter.Outros
{
    public class PresenterGetEstatusCadastro
    {
        UserControlStatusCadastro _view;

        public event StatusCadastroExibidoEventHandler EventoStatus;

        Panel _painel;


       public PresenterGetEstatusCadastro(Panel painel)
        {
            _painel = painel;
            InstanciarView(painel);
            _painel.Visible = false;
            DelegarEcventos();

        }
        #region Metodos Privados
        private void DelegarEcventos()
        {
            _view.EventockAtivo(this.EventoCkView);
            _view.EventockInativo(this.EventoCkView);
        }
        private void InstanciarView(Panel painel)
        {
            _view = new UserControlStatusCadastro();
            painel.Controls.Add(_view);
            _view.Dock = DockStyle.Fill;
        }
        private EStatusCadastro GetStatusView()
        {
            if (_view.Ativo == true && _view.Inativo == true)
                return EStatusCadastro.Todos;
           else if (_view.Ativo == true)
                return EStatusCadastro.Ativo;
           else if (_view.Inativo == true)
                return EStatusCadastro.Inativo;


            return EStatusCadastro.none;
        }
        private void NotificarEvento()
        {
            if (this.EventoStatus != null)
                EventoStatus(this, new StatusCadastroExibidoEventArgs { Status = this.GetStatusView() });
        }
        #endregion

        #region Eventos Privados
        private void EventoCkView(object o, EventArgs e)
        {
            NotificarEvento();
        }
        #endregion


        #region Eventos Publicos

        public void DesmarcarTodos()
        {
            _view.RemoverCeck();
        }
        public void Visibilidade(bool visibilidade)
        {
            _painel.Visible = visibilidade;
        }
        public EStatusCadastro GetStatus()
        {
            return this.GetStatusView();
        }
        public void SetStatus(EStatusCadastro status)
        {
            switch (status) 
            {
                case EStatusCadastro.none:
                    _view.Ativo = false;
                    _view.Inativo = false;
                    break;

                case EStatusCadastro.Ativo:
                    _view.Ativo = true;
                    _view.Inativo = false;
                    break;

                case EStatusCadastro.Inativo:
                    _view.Ativo = false;
                    _view.Inativo = true;
                    break;

                case EStatusCadastro.Todos:
                    _view.Ativo = true;
                    _view.Inativo = true;
                    break;


            }

        }
        private  bool SetarStatusAtivo { set { _view.Ativo = value; } }
        private bool SetarStatusInativo { set { _view.Inativo = value; } }
        #endregion
    }
}
