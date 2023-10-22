using Model.Emumerator;
using Perron.TelaBusca;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterIngredienteSabor : IPresenterIngredienteSabor
    {
        private PresenterSabor _cadastroSabor;
        private readonly UserControlEngredienteSabor _view = new UserControlEngredienteSabor();
        

        #region Construtor
        public PresenterIngredienteSabor(PresenterSabor cadastroSabor)
        {
            _cadastroSabor = cadastroSabor;
            IniciarTabPage();
            DelegarEventos();
            
        }

        #endregion

        #region Metodos Publicos
        private void AlterandoComportamento()
        {
            switch (_cadastroSabor.ComportamentoAtual)
            {

                case EComportamentoTela.None:
                    break;


                case EComportamentoTela.Inicio:
                    this.StatusDeCadastroInicial();
                    break;


                case EComportamentoTela.Novo:
                    this.StatusCadastroEditandoCadastrando();
                    break;

                case EComportamentoTela.Cadastrando:
                    this.StatusCadastroEditandoCadastrando();
                    break;

                case EComportamentoTela.ItemSelecionado:
                    this.StatusCadastroEditandoCadastrando();
                    break;


                default:
                    break;
            }



        }
 
        #endregion


        #region Metodos Privados
        private void IniciarTabPage()
        {
            var page = new TabPage();

            page.Text = "Ingredientes";

            page.Controls.Add(_view);
            _view.Dock = DockStyle.Fill;
            _cadastroSabor.TabControl.TabPages.Add(page);

        }
        private void DelegarEventos()
        {
            _cadastroSabor.EventoTeclaPressionada += EventoAdicionarIngrediente;
            _cadastroSabor.EventoAlterarComportamento += AlterandoComportamento;
        }
        private void StatusDeCadastroInicial()
        {
            
            
            ResetListaEngredienteSabor();

        }
        private void StatusCadastroEditandoCadastrando()
        {
            ResetListaEngredienteSabor();
        }
        private void ResetListaEngredienteSabor()
        {
            if (_cadastroSabor.Sabor.Ingredientes == null)
                         _cadastroSabor.Sabor.Ingredientes = new List<IngredienteModel>(); 
            
            ExibirEngredienteSabor();

        }
        private void ExibirEngredienteSabor()
        {
            try
            {
                
                _view.DataItem.DataSource = _cadastroSabor.Sabor.Ingredientes;
                
            }
            catch{ }
        }
        #endregion


        #region Eventos Privados
        private void EventoAdicionarIngrediente(object o, KeyPressEventArgs eventArgs)
        {
            if (eventArgs.KeyChar.Equals('\u0001')) /*Buscar CTRL + A */
            {
                _cadastroSabor.Sabor.Ingredientes = Busca.IniciarBuscar(ETipoBusca.INGREDIENTE,true).ObterItemSelecionado() as List<IngredienteModel>;
                ExibirEngredienteSabor();
            }
        }
        #endregion
    }
}
