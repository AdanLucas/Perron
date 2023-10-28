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
    public class ControllerMercadoriaProduto : IPresenterMercadoriaProduto
    {
        private PresenterProduto _cadastroProduto;
        private readonly UserControlMercadoriaProduto _view = new UserControlMercadoriaProduto();
        private Action AtualizarDadosComponetes { get; set; }

        private KeyEventHandler EventoNotificarComponentesIngrediente { get; set;}

        #region Construtor
        public ControllerMercadoriaProduto(PresenterProduto cadastroProduto)
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
                foreach (var ingrediente in _cadastroProduto.Produto.Ingredientes)
                {
                    IniciarComponenteIngrediente(ingrediente);
                } ;
                
            }
            catch{ }
        }
        private void NotificarEventoComponenteIngrediente(IngredienteModel componenteIngrediente,Keys tipo)
        {
            if (componenteIngrediente != null && EventoNotificarComponentesIngrediente != null)
                            EventoNotificarComponentesIngrediente(componenteIngrediente, new KeyEventArgs(tipo));
        }
        #endregion
        private void IniciarComponenteIngrediente(IngredienteModel ingrediente)
        {
            DadosMercadoriaComponente componente = new DadosMercadoriaComponente(ingrediente);
            _view.Painel.Controls.Add(componente);
            componente.Dock = DockStyle.Top;

                componente.EventoAdicionarDadosIngrediente += AdicionarDadosIngrediente;
                componente.EventoRemoverIngrediente += RemoverIngrediente;
                AtualizarDadosComponetes += componente.AtualiarTela;
                EventoNotificarComponentesIngrediente += componente.EventoNotificao;
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
