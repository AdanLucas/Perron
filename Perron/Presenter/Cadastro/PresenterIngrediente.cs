using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterIngrediente : PresenterPadrao , IPresenterEngrediente
    {
        private readonly IViewCadastroIngrediente _view;
        private readonly IServiceEngrediente _service;
        private EngredienteModel _engrediente;
        private List<EngredienteModel> ListaEngredientesCadastrados;
        public PresenterIngrediente(IViewCadastroIngrediente view,IServiceEngrediente service) : base(view)
        {
            _view = view;
            _view.Show();
            _service = service;
            DelegarEventos();
              base.ComportamentoAtual = EComportamentoTela.Inicio;
            SetListaEngredienteCadastrado(EStatusCadastro.Todos);
        }


        #region metodos Privados

        #region override
        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            SetListaEngredienteCadastrado(status);
            FiltrarListaPorNome(_view.DescricaoIngrediente);
        }
        protected override void AlterarComportamentoTela(EComportamentoTela status)
        {
      
            switch (status)
            {
                case EComportamentoTela.Inicio:
                    EstadoTelaInicial();
                    break;


                case EComportamentoTela.Novo:
                    EstadoTelaCadastrando();
                    break;


                case EComportamentoTela.ItemSelecionado:
                    EstadoTelaCadastroSelecionado();
                    break;

                case EComportamentoTela.Cadastrando:
                    break;
            }
                
        }
        #endregion


        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);
            _view.EventoBuscar(EventoBucarPorDescricao);
      
        }
        private void SetEngrediente()
        {
            _engrediente.Descricao = _view.DescricaoIngrediente;

        }
        private void SetEngredienteTela()
        {
            _view.DescricaoIngrediente = _engrediente.Descricao;
        }
        private void EstadoTelaInicial()
        {
            base.AlterarAlturaTela(411);
            _view.VisibilidadeGroupEngredientes = true;
            SetListaEngredienteCadastrado(EStatusCadastro.none);
            EstadoInicial();
        }
        private void EstadoTelaCadastrando()
        {
            base.AlterarAlturaTela(182);
            _view.VisibilidadeGroupEngredientes = false;
            _view.DescricaoIngrediente = "";
        }
        private void EstadoTelaCadastroSelecionado()
        {
            
        }
        private void AtivarIngredienteInativo(EngredienteModel _engrediente)
        {
            if (_engrediente.Ativo == false)
            {
                if(MessageBox.Show("Deseja Ativa a Mercadoria?", "Ativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _engrediente.Ativo = true; 
                }
            }
        }
        private void ValidarDadosEngrediente()
        {
            bool ret = true;

            string Erro="";

            if(_engrediente.Descricao == "")
            {   
                ret = false;
                Erro += "Infome Uma Decsricao Para o Engrediente;\n";

            }

            if (!ret)
                throw new Exception(Erro);
        }
        private void EstadoInicial()
        {
            _engrediente = new EngredienteModel();
            _engrediente.Ativo = true;
            _view.DescricaoIngrediente = null;
        }
        private void SetListaEngredienteCadastrado(EStatusCadastro status)
        {
            var Lista = _service.GetListaEngredientesCadastroados(); 


            switch (status)
            {
                case EStatusCadastro.none:
                    ListaEngredientesCadastrados = new List<EngredienteModel>();
                    break;
                    ;
                case EStatusCadastro.Todos:
                    ListaEngredientesCadastrados = Lista;
                    break;
                case EStatusCadastro.Ativo:
                    ListaEngredientesCadastrados = Lista.Where(l => l.Ativo = true).ToList();
                    break;

                case EStatusCadastro.Inativo:
                    ListaEngredientesCadastrados = Lista.Where(l => l.Ativo = false).ToList();
                    break;

                default:
                    break;
            }


        }
        private void FiltrarListaPorNome(string Descricao)
        {
            if ((ListaEngredientesCadastrados != null || ListaEngredientesCadastrados.Count > 0) && (!ComportamentoAtual.Equals(EComportamentoTela.Novo) || (!ComportamentoAtual.Equals(EComportamentoTela.Cadastrando))))
            {
                if (String.IsNullOrEmpty(Descricao))
                {
                    _view.PopularGridIngredientes(ListaEngredientesCadastrados);
                }
                else
                {
                    _view.PopularGridIngredientes(ListaEngredientesCadastrados.Where(l => l.Descricao.Contains(Descricao)).ToList());
                }
            }
        }
        #endregion
    
        #region Eventos Privados
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.IngredienteSelecionado != null)
            {
                SetEngredienteTela();
            }
        }
        private void EventoBucarPorDescricao(object o, EventArgs e)
        {
            FiltrarListaPorNome(_view.DescricaoIngrediente);
        }
        private void EventoGridCadastrado(object o, EventArgs e)
        {
            if(_view.IngredienteSelecionado!= null)
            {
                _engrediente =_view.IngredienteSelecionado;
                SetEngredienteTela();
                

            }
        }

        #region Evento override
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
            _engrediente = new EngredienteModel();
            _engrediente.Ativo = true;

        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                SetEngrediente();
                ValidarDadosEngrediente();
                AtivarIngredienteInativo(_engrediente);
                _service.Salvar(_engrediente);
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                base.MessageDeSucesso($"Engrediente {_engrediente.Descricao} Cadastrado com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;
        } 
        #endregion

        #endregion

        






    }
}
