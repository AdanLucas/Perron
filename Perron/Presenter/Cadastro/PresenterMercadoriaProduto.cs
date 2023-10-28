using Model.Model;
using Perron.Componentes;
using Perron.Extensions;
using Perron.TelaBusca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterMercadoriaProduto : IPresenterMercadoriaProduto
    {
        private PresenterProduto _cadastroProduto;
        private readonly UserControlMercadoriaProduto _view = new UserControlMercadoriaProduto();
        private Action AtualizarDadosComponetes { get; set; }

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
        private void IniciarComponenteIngrediente(IngredienteModel ingrediente)
        {
            DadosMercadoriaComponente componente = new DadosMercadoriaComponente(ingrediente);
            _view.Painel.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;

                componente.EventoAdicionarDadosIngrediente += AdicionarDadosIngrediente;
                componente.EventoRemoverIngrediente += RemoverIngrediente;
                AtualizarDadosComponetes += componente.AtualiarTela; 


        }

        #region Eventos Privados
        private void RemoverIngrediente(object sender, EventArgs args)
        {
            DadosMercadoriaComponente componente = (DadosMercadoriaComponente)sender;


        }
        private void AdicionarDadosIngrediente(object sender, EventArgs args)
        {
            IngredienteModel ingrediente = (IngredienteModel)sender;


        }
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
