using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterIngrediente : PresenterPadrao, IPresenterIngrediente
    {
        private readonly IViewCadastroIngrediente _view;
        private readonly IServiceIngrediente _service;
        private IngredienteModel ingrediente { get { return GetDadosIngrediente(); } set { SetEngrediente(value); } }

        private IngredienteModel _ingrediente;
        private List<IngredienteModel> ListaEngredientesCadastrados;
        public PresenterIngrediente(IViewCadastroIngrediente view, IServiceIngrediente service) : base(view)
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
        protected override void AlterandoComportamentoTela()
        {
            if (ComportamentoAtual.HasFlag(EComportamentoTela.Inicio))
                _view.EventoBuscar += EventoBucarPorDescricao;

            else
                _view.EventoBuscar -= EventoBucarPorDescricao;
        }
        protected override void ComportamentoInicioTela()
        {
            _view.SetarTamanhoMaximoTela();
            _view.HabilitaComboTipoMedida = false;
            SetListaEngredienteCadastrado(EStatusCadastro.none);
            EstadoInicial();
        }
        protected override void ComportamentoCadastrando()
        {
            _view.SetarTamanhoDaTelaReduzido();
            _view.HabilitaComboTipoMedida = true;
            _view.DescricaoIngrediente = "";
        }
        protected override void ComportamentoItemSelecionado()
        {
            _view.HabilitaComboTipoMedida = true;
        }
        #endregion


        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);

        }
        private IngredienteModel GetDadosIngrediente()
        {
            _ingrediente.Descricao = _view.DescricaoIngrediente;
            _ingrediente.TipoMedida = _view.TipoMedida;

            return _ingrediente;
        }
        private void SetEngrediente(IngredienteModel ingrediente)
        {
            _ingrediente = ingrediente;
            _ingrediente = _view.IngredienteSelecionado;
            _view.DescricaoIngrediente = _ingrediente.Descricao;
            _view.TipoMedida = _ingrediente.TipoMedida;
        }

        private void AtivarIngredienteInativo(IngredienteModel _engrediente)
        {
            if (_engrediente.Ativo == false)
            {
                if (MessageBox.Show("Deseja Ativa a Mercadoria?", "Ativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _engrediente.Ativo = true;
                }
            }
        }
        private void ValidarDadosEngrediente()
        {
            bool ret = true;

            string Erro = "";

            if (ingrediente.Descricao == "")
            {
                ret = false;
                Erro += "Infome Uma Decsricao Para o Engrediente;\n";

            }
            if (ingrediente.TipoMedida == 0)
            {
                ret = false;
                Erro += "Selecione a Unidade de Medida Do Ingrediente;\n";
            }

            if (!ret)
                throw new Exception(Erro);
        }
        private void EstadoInicial()
        {
            _ingrediente = new IngredienteModel();
            _ingrediente.Ativo = true;
            _view.DescricaoIngrediente = null;
            _view.TipoMedida = EUnidadeMedida.Nd;
        }
        private void SetListaEngredienteCadastrado(EStatusCadastro status)
        {
            var Lista = _service.GetListaEngredientesCadastroados();


            switch (status)
            {
                case EStatusCadastro.none:
                    ListaEngredientesCadastrados = new List<IngredienteModel>();
                    break;
                    ;
                case EStatusCadastro.Todos:
                    ListaEngredientesCadastrados = Lista;
                    break;
                case EStatusCadastro.Ativo:
                    ListaEngredientesCadastrados = Lista.Where(l => l.Ativo == true).ToList();
                    break;

                case EStatusCadastro.Inativo:
                    ListaEngredientesCadastrados = Lista.Where(l => l.Ativo == false).ToList();
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
                ingrediente = _view.IngredienteSelecionado;
                base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
            }
        }
        private void EventoBucarPorDescricao(object o, EventArgs e)
        {
            FiltrarListaPorNome(_view.DescricaoIngrediente);
        }


        #region Evento override
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {

                ValidarDadosEngrediente();
                AtivarIngredienteInativo(ingrediente);
                _service.Salvar(ingrediente);
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                base.MessageDeSucesso($"Engrediente {ingrediente.Descricao} Cadastrado com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            if (MessageBox.Show($"Deseja Remover o Ingrendiente {ingrediente.Descricao} ??", "Remover??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ingrediente.Ativo = false;
                _service.Salvar(ingrediente);
                ComportamentoAtual = EComportamentoTela.Inicio;
            }

        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;
        }
        #endregion

        #endregion








    }
}
