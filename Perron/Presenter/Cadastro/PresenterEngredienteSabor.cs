using Perron.Presenter.Outros;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterEngredienteSabor : IPresenterEngredienteSabor
    {
        private readonly IViewCadastroEngredienteSabor _view;
        private readonly PresenterGetEstatusCadastro _status;

        private EStatusCadastroTela _statusCadastro;

        #region Listas

        private List<EngredienteModel> ListaEngredienteCadastrados;
        private List<EngredienteModel> ListaEngredienteSabor;
        #endregion




        #region Construtor
        public PresenterEngredienteSabor(IViewCadastroEngredienteSabor view)
        {
            _view = view;

            SetarListaEngredienteCadastrados();
            ExibirEngredienteCadastrados("");
            _status = new PresenterGetEstatusCadastro(_view.PainelStatus);
            DelegarEventos();
            _status.Visibilidade(true);
        }

        #endregion

        #region Metodos Publicos
        public List<EngredienteModel> GetEngredienteSabor()
        {
            return ListaEngredienteSabor;
           
        }

        public void StatusCadastro(EStatusCadastroTela status)
        {
            _statusCadastro = status;
            Setstatus();
        }

        private void Setstatus()
        {
            switch (_statusCadastro)
            {
               
                case EStatusCadastroTela.None:
                     break;


                case EStatusCadastroTela.Inicio:
                    this.StatusDeCadastroInicial();
                     break;


                case EStatusCadastroTela.Novo:
                    this.StatusCadastroEditandoCadastrando();
                    break;

                case EStatusCadastroTela.Cadastrando:
                    this.StatusCadastroEditandoCadastrando();
                    break;

                case EStatusCadastroTela.ItemSelecionado:
                    this.StatusCadastroEditandoCadastrando();
                    break;


                default:
                    break;
            }



        }
        public void SetListaEngredienteSabor(List<EngredienteModel> Lista)
        {
            if (Lista.Count > 0)
            {
                ListaEngredienteSabor = Lista;
                _status.SetStatus(EStatusCadastro.Ativo);
                ExibirEngredienteSabor();
            }
        }
        #endregion


        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoBuscaEngredienteCadastrados(this.EventoBuscaEngredienteCadastrado);
            _view.EventoBuscaEngredienteSabor(this.EventoBuscaEngredienteSabor);
            _view.EventoGridEngredientesCadastrados(this.EventoGridEngredientesCadastrado);
            _view.EventoGridEngredientesSabor(this.EventoGridEngredientesSabor);
            _status.EventoStatus += EventoStatusCadastroView;


        }
        private void SetarListaEngredienteCadastrados()
        {
            var Lista = ServiceDinamico<EngredienteModel>.GetLista();
            if (Lista.Count > 0)
                ListaEngredienteCadastrados = Lista;
        }
        private void ExibirEngredienteCadastrados(String Busca)
        {
            if (ListaEngredienteCadastrados != null)
            {
                if (ListaEngredienteCadastrados.Count > 0)
                {
                    List<EngredienteModel> Lista;

                    if (Busca == "")
                    {
                        Lista = ListaEngredienteCadastrados;
                    }
                    else
                    {
                        Lista = ListaEngredienteCadastrados.Where(c => c.Descricao.Contains(Busca) && c.Ativo == true).ToList();
                    }

                        _view.PopularGridEngredientesCadastrados(Lista);
                }
            }
        }
        private List<EngredienteModel> FiltrarListaPorStatus(List<EngredienteModel> ListaIn)
        {
            switch (_status.GetStatus())
            {
                case EStatusCadastro.none:
                    return null;

                case EStatusCadastro.Todos:
                    return ListaIn;

                case EStatusCadastro.Ativo:
                    return ListaIn.Where(E => E.Ativo == true).ToList();

                case EStatusCadastro.Inativo:
                    return ListaIn.Where(E => E.Ativo == false).ToList();
            }

            return null;

        }
        private List<EngredienteModel> FiltrarListaPorDescricao(List<EngredienteModel> LinstaIn)
        {
            var ListOut = new List<EngredienteModel>();

            if (ListaEngredienteSabor != null)
            {
                var Busca = _view.BuscarEngredientesSabor;

                if (ListaEngredienteSabor.Count > 0)
                {


                    if (Busca == "")
                    {
                        return LinstaIn;
                    }
                    else
                    {
                        return LinstaIn.Where(c => c.Descricao.Contains(Busca) && c.Ativo).ToList();
                    }

                }

            }
            else
            {
                
                throw new Exception("Lista Completa esta Nula");

            }

            return null;
        }
        private void StatusDeCadastroInicial()
        {
            _view.GbEndredientesCadastrados.Visible = true;
            _view.GbEndredientesSabor.Visible = false;
            _view.GbEndredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            _status.Visibilidade(false);
            ResetListaEngredienteSabor();

        }
        private void StatusDeCadastroSelecionado()
        {
            _view.GbEndredientesCadastrados.Visible = false;
            _view.GbEndredientesSabor.Visible = true;
            _view.GbEndredientesSabor.Dock = System.Windows.Forms.DockStyle.Fill;
            _status.Visibilidade(true);
        }
        private void StatusCadastroEditandoCadastrando()
        {
            ResetListaEngredienteSabor();
            _view.GbEndredientesCadastrados.Visible = true;
            _view.GbEndredientesSabor.Visible = true;
            _view.GbEndredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            _view.GbEndredientesSabor.Dock = System.Windows.Forms.DockStyle.Top;
            _status.Visibilidade(false);


        }
        private void ResetListaEngredienteSabor()
        {
            ListaEngredienteSabor = new List<EngredienteModel>();
            ExibirEngredienteSabor();

        }
        private void AdicionarEngredienteListaSabor(EngredienteModel Engrediente)
        {
            if (MessageBox.Show($"Deseja Adicionar o Engrediente {Engrediente.Descricao} ao Sabor?", "Adicionar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ListaEngredienteSabor == null)
                    ListaEngredienteSabor = new List<EngredienteModel>();

                ListaEngredienteSabor.Add(Engrediente);
                _status.SetStatus(EStatusCadastro.Ativo);
                ExibirEngredienteSabor();
            }
        }
        private void InativarEngredienteLista()
        {
            int Indice = ListaEngredienteSabor.IndexOf(_view.EngredienteSelecionadoGridEngredienteSabor);
            ListaEngredienteSabor[Indice].InativarCadastro();
            if (ListaEngredienteSabor[Indice].Ativo == false)
            {
                MessageBox.Show("Engrediente Inativado com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AtivarEngredienteLista()
        {
            int Indice = ListaEngredienteSabor.IndexOf(_view.EngredienteSelecionadoGridEngredienteSabor);

            ListaEngredienteSabor[Indice].AtivarCadastroInativo();

            if (ListaEngredienteSabor[Indice].Ativo == true)
            {
                MessageBox.Show("Engrediente Ativo Com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
            }


        }
        private void ExibirEngredienteSabor()
        {

            var LIstaPorStatus = FiltrarListaPorStatus(ListaEngredienteSabor);
            var ListaPorDescricao = FiltrarListaPorDescricao(LIstaPorStatus);
            _view.PopularGridEngredientesSabor(ListaPorDescricao);


        }




        #endregion


        #region Eventos Privados

        private void EventoGridEngredientesCadastrado(object o, EventArgs e)
        {
            if (_view.EngredienteSelecionadoGridEngredienteCadastrado != null)
            {
                if(_statusCadastro.Equals(EStatusCadastroTela.Novo) || _statusCadastro.Equals(EStatusCadastroTela.Cadastrando) || _statusCadastro.Equals(EStatusCadastroTela.ItemSelecionado))
                {
                    var Engrediente = _view.EngredienteSelecionadoGridEngredienteCadastrado;
                    this.AdicionarEngredienteListaSabor(Engrediente);
                }
            }
        }
        private void EventoGridEngredienteSabor(object o, EventArgs e)
        {
            if (_view.EngredienteSelecionadoGridEngredienteSabor != null && (_statusCadastro != EStatusCadastroTela.Novo))
            {
                InativarEngredienteLista();
            }



        }
        private void EventoBuscaEngredienteCadastrado(object o, EventArgs e)
        {
            this.ExibirEngredienteCadastrados(_view.BuscarEngredientesCadastrados);
        }
        private void EventoBuscaEngredienteSabor(object o, EventArgs e)
        {
            ExibirEngredienteSabor();
        }
        private void EventoGridEngredientesSabor(object o, EventArgs e)
        {
            if (_statusCadastro == EStatusCadastroTela.ItemSelecionado)
            {
                InativarEngredienteLista();
                ExibirEngredienteSabor();
            }
        } 
        private void EventoStatusCadastroView(object o , StatusCadastroExibidoEventArgs e)
        {
            this.ExibirEngredienteSabor();
        }




        #endregion


        #region Eventos Publicos


        public void EventoAtualizarStatusCadastro(object o, StatusCadastroTelaEventArgs e)
        {
            _statusCadastro = e.statusTela;
            Setstatus();

        }

        #endregion
    }
}
