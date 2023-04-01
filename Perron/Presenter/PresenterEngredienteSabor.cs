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
        private readonly IServiceEngrediente _serviceEngrendiente;
        




        #region Listas

        private List<EngredienteModel> ListaEngredienteCadastrados;
        private List<EngredienteModel> ListaEngridienteSabor; 
        #endregion




        #region Construtor
        public PresenterEngredienteSabor(IViewCadastroEngredienteSabor view)
        {
            _view = view;
            DelegarEventos();
            //SetarListaEngredienteCadastrados();
            //ExibirEngredienteCadastrados("");

        }

        #endregion

        #region Metodos Publicos
        public List<EngredienteModel> GetEngredienteSabor()
        {
            return ListaEngredienteCadastrados;
        }
        public void StatusCadastro(EStatusCadastroTela status)
        {
            switch (status)
            {
                 case EStatusCadastroTela.None:

                    break;


                case EStatusCadastroTela.Inicio:

                    this.StatusDeCadastroInicial();

                    break;


                case EStatusCadastroTela.Novo:

                    this.StatusCadastroEditandoCadastrando();
                    this.ResetListaEngredienteSabor();

                    break;
                case EStatusCadastroTela.Cadastrando:

                    this.StatusCadastroEditandoCadastrando();

                    break;

                case EStatusCadastroTela.ItemSelecionado:

                    this.StatusDeCadastroSelecionado();

                    break;


                default:
                    break;
            }



        }

        #endregion


        #region Metodos Privados

        private void DelegarEventos()
        {
            _view.EventoBuscaEngredienteCadastrados(this.EventoBuscaEngredienteCadastrado);
            _view.EventoBuscaEngredienteSabor(this.EventoBuscaEngredienteSabor);

        }
        private void SetarListaEngredienteCadastrados()
        {
            var Lista = _serviceEngrendiente.GetListaEngredientesCadastroados();

            if (Lista.Count > 0)
                ListaEngredienteCadastrados = Lista;
        }
        private void ExibirEngredienteCadastrados(String Busca)
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
                   Lista = ListaEngredienteCadastrados.Where(c => c.Descricao.Contains(Busca)).ToList();
                   _view.PopularGridEngredientesCadastrados(Lista);
                }

            }
        }
        private void ExibirEngredienteSabor(String Busca)
        {
            if (ListaEngridienteSabor.Count > 0)
            {
                List<EngredienteModel> Lista;

                if (Busca == "")
                {
                    Lista = ListaEngridienteSabor;
                }
                else
                {
                    Lista = ListaEngridienteSabor.Where(c => c.Descricao.Contains(Busca)).ToList();
                    _view.PopularGridEngredientesSabor(Lista);
                }

            }
        }
        private void StatusDeCadastroInicial()
        {
            _view.GbEndredientesCadastrados.Visible = true;
            _view.GbEndredientesSabor.Visible = false;
            _view.GbEndredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        private void StatusDeCadastroSelecionado()
        {
            _view.GbEndredientesCadastrados.Visible = false;
            _view.GbEndredientesSabor.Visible = true;
            _view.GbEndredientesSabor.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        private void StatusCadastroEditandoCadastrando()
        {
            _view.GbEndredientesCadastrados.Visible = true;
            _view.GbEndredientesSabor.Visible = true;
            _view.GbEndredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            _view.GbEndredientesSabor.Dock = System.Windows.Forms.DockStyle.Top;


        }
        private void ResetListaEngredienteSabor()
        {
            ListaEngridienteSabor = new List<EngredienteModel>();

        }
        private void AdicionarEngredienteListaSabor(EngredienteModel Engrediente)
        {
            if(MessageBox.Show($"Deseja Adicionar o Engrediente {Engrediente.Descricao} ao Sabor?", "Adicionar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaEngridienteSabor.Add(Engrediente);
                this.ExibirEngredienteSabor("");
            }
        }





        #endregion

        
        #region Metodos Privados

        private void EventoGridEngredientesCadastrado(object o, EventArgs e)
        {
            if(_view.EngredienteSelecionadoGridEngredienteCadastrado != null)
            {
                var Engrediente = _view.EngredienteSelecionadoGridEngredienteCadastrado;
                this.AdicionarEngredienteListaSabor(Engrediente);
            }
        }
        private void EventoGridEngredienteSabor(object o, EventArgs e)
        {



            if (_view.EngredienteSelecionadoGridEngredienteSabor != null)
            {
                var Engrediente = _view.EngredienteSelecionadoGridEngredienteCadastrado;



            }



        }
        private void EventoBuscaEngredienteCadastrado(object o, EventArgs e)
        {
            this.ExibirEngredienteCadastrados(_view.BuscarEngredientesCadastrados);
        }
        private void EventoBuscaEngredienteSabor(object o, EventArgs e)
        {
            this.ExibirEngredienteSabor(_view.BuscarEngredientesSabor);
        }



        #endregion
    }
}
