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
              base.StatusCadastro = EStatusCadastroTela.Inicio;
            SetListaEngredienteCadastrado(EStatusCadastro.Todos);
        }


        #region metodos Privados
        private void AlterandoStatusTela(EStatusCadastroTela status)
        {
            switch (status)
            {
                case EStatusCadastroTela.Inicio:
                    EstadoTelaInicial();
                    break;


                case EStatusCadastroTela.Novo:
                    EstadoTelaCadastrando();
                    break;


                case EStatusCadastroTela.ItemSelecionado:
                    EstadoTelaCadastroSelecionado();
                    break;

                case EStatusCadastroTela.Cadastrando:
                    break;



            }
                
        }
        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);
            _view.EventoCancelar(EventoCancelar);
            _view.EventoDeletar(EventoDeletar);
            _view.EventoNovo(EventoNovo);
            _view.EventoSalvar(EventoSalvar);
            _view.EventoBuscar(EventoBucarPorDescricao);
            EventoStatusCadastroTela += EventoStatusTela;
            EventoExibicaoCadastros += EventoSetarListaEngredienteCadastrado;
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
            if ((ListaEngredientesCadastrados != null || ListaEngredientesCadastrados.Count > 0) && (!StatusCadastro.Equals(EStatusCadastroTela.Novo) || (!StatusCadastro.Equals(EStatusCadastroTela.Cadastrando))))
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


        #region Metodos Publicos
        #endregion


    
        #region Eventos Privados
        private void EventoStatusTela(object o, StatusCadastroTelaEventArgs e)
        {
            AlterandoStatusTela(e.statusTela);
        }
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.IngredienteSelecionado != null)
            {
                SetEngredienteTela();
            }
        }
        private void EventoNovo(object o, EventArgs e)
        {
            base.StatusCadastro = EStatusCadastroTela.Novo;
            _engrediente = new EngredienteModel();
            _engrediente.Ativo = true;

        }
        private void EventoSalvar(object o, EventArgs e)
        {
            try
            {

                SetEngrediente();
                ValidarDadosEngrediente();
                AtivarIngredienteInativo(_engrediente);
                _service.Salvar(_engrediente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EventoDeletar(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void EventoCancelar(object o, EventArgs e)
        {
            base.StatusCadastro = EStatusCadastroTela.Inicio;
        } 
        private void EventoSetarListaEngredienteCadastrado(object o, StatusCadastroExibidoEventArgs e)
        {
            SetListaEngredienteCadastrado(e.Status);
            FiltrarListaPorNome(_view.DescricaoIngrediente);
        }
        private void EventoBucarPorDescricao(object o, EventArgs e)
        {
            FiltrarListaPorNome(_view.DescricaoIngrediente);
        }
        #endregion

        






    }
}
