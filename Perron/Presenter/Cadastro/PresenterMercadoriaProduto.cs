using Model.Model;
using Perron.Extensions;
using Perron.TelaBusca.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterMercadoriaProduto : IPresenterMercadoriaProduto
    {
        private PresenterProduto _cadastroProduto;
        private readonly UserControlMercadoriaProduto _view = new UserControlMercadoriaProduto();
        

        #region Construtor
        public PresenterMercadoriaProduto(PresenterProduto cadastroProduto)
        {
            _cadastroProduto = cadastroProduto;
            IniciarTabPage();
            DelegarEventos();
            
        }

        #endregion

        #region Metodos Publicos
        private void AlterandoComportamento()
        {
            switch (_cadastroProduto.ComportamentoAtual)
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

            page.Text = "Mercadoria";

            page.Controls.Add(_view);
            _view.Dock = DockStyle.Fill;
            _cadastroProduto.TabControl.TabPages.Add(page);

        }
        private void DelegarEventos()
        {
            _cadastroProduto.EventoTeclaPressionada += EventoAdicionarIngrediente;
            _cadastroProduto.EventoAlterarComportamento += AlterandoComportamento;
        }
        private void StatusDeCadastroInicial()
        {
            ResetListaMercadoriaProduto();
        }
        private void StatusCadastroEditandoCadastrando()
        {
            ResetListaMercadoriaProduto();
        }
        private void ResetListaMercadoriaProduto()
        {
            if (_cadastroProduto.Produto.Ingredientes == null)
                _cadastroProduto.Produto.Ingredientes = new List<IngredienteModel>(); 
            
            ExibirEngredienteSabor();

        }
        private void ExibirEngredienteSabor()
        {
            try
            {
                
                _view.DataItem.DataSource = _cadastroProduto.Produto.Ingredientes;
                
            }
            catch{ }
        }
        #endregion


        #region Eventos Privados
        private void EventoAdicionarIngrediente(object o, KeyPressEventArgs eventArgs)
        {
            if (eventArgs.KeyChar.Equals('\u0001')) /*Buscar CTRL + A */
            {
                _cadastroProduto.Produto.Ingredientes = Busca.IniciarBuscar(ETipoBusca.INGREDIENTE).ObterSelecaoMultipla<IngredienteModel>();
                ExibirEngredienteSabor();
            }
        }
        #endregion
    }
}
