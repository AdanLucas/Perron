using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterMercadoria : PresenterPadrao, IPresenterMercadoria
    {
        private readonly IViewCadastroMercadoria _view;
        private readonly IServiceMercadoria _service;
        private MercadoriaModel mercadoria { get { return GetDadosMercadoria(); } set { SetMercadoria(value); } }

        private MercadoriaModel _mercadoria;
        private List<MercadoriaModel> ListaMercadoriaCadastrados;
        public PresenterMercadoria(IViewCadastroMercadoria view, IServiceMercadoria service) : base(view)
        {
            _view = view;
            _view.Show();
            _service = service;
            DelegarEventos();
            base.ComportamentoAtual = EComportamentoTela.Inicio;
            SetListaMercadoriaCadastrado(EStatusCadastro.Todos);
        }


        #region metodos Privados

        #region override
        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            SetListaMercadoriaCadastrado(status);
            FiltrarListaPorNome(_view.DescricaoMercadoria);
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
            SetListaMercadoriaCadastrado(EStatusCadastro.none);
            EstadoInicial();
        }
        protected override void ComportamentoCadastrando()
        {
            _view.SetarTamanhoDaTelaReduzido();
            _view.HabilitaComboTipoMedida = true;
            _view.DescricaoMercadoria = "";
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
        private MercadoriaModel GetDadosMercadoria()
        {
            _mercadoria.Descricao = _view.DescricaoMercadoria;
            _mercadoria.TipoMedida = _view.TipoMedida;

            return _mercadoria;
        }
        private void SetMercadoria(MercadoriaModel mercadoria)
        {
            _mercadoria = mercadoria;
            _mercadoria = _view.MercadoriaSelecionado;
            _view.DescricaoMercadoria = _mercadoria.Descricao;
            _view.TipoMedida = _mercadoria.TipoMedida;
        }

        private void AtivarMercadoriaInativo(MercadoriaModel _engrediente)
        {
            if (_engrediente.Ativo == false)
            {
                if (MessageBox.Show("Deseja Ativa a Mercadoria?", "Ativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _engrediente.Ativo = true;
                }
            }
        }
        private void ValidarDadosMercadoria()
        {
            bool ret = true;

            string Erro = "";

            if (mercadoria.Descricao == "")
            {
                ret = false;
                Erro += "Infome Uma Decsricao Para o mercadoria;\n";

            }
            if (mercadoria.TipoMedida == 0)
            {
                ret = false;
                Erro += "Selecione a Unidade de Medida Do mercadoria;\n";
            }

            if (!ret)
                throw new Exception(Erro);
        }
        private void EstadoInicial()
        {
            _mercadoria = new MercadoriaModel();
            _mercadoria.Ativo = true;
            _view.DescricaoMercadoria = null;
            _view.TipoMedida = EUnidadeMedida.Nd;
        }
        private void SetListaMercadoriaCadastrado(EStatusCadastro status)
        {
            var Lista = _service.GetListaMercadoriaCadastrados();


            switch (status)
            {
                case EStatusCadastro.none:
                    ListaMercadoriaCadastrados = new List<MercadoriaModel>();
                    break;
                    ;
                case EStatusCadastro.Todos:
                    ListaMercadoriaCadastrados = Lista;
                    break;
                case EStatusCadastro.Ativo:
                    ListaMercadoriaCadastrados = Lista.Where(l => l.Ativo == true).ToList();
                    break;

                case EStatusCadastro.Inativo:
                    ListaMercadoriaCadastrados = Lista.Where(l => l.Ativo == false).ToList();
                    break;

                default:
                    break;
            }


        }
        private void FiltrarListaPorNome(string Descricao)
        {
            if ((ListaMercadoriaCadastrados != null || ListaMercadoriaCadastrados.Count > 0) && (!ComportamentoAtual.Equals(EComportamentoTela.Novo) || (!ComportamentoAtual.Equals(EComportamentoTela.Cadastrando))))
            {
                if (String.IsNullOrEmpty(Descricao))
                {
                    _view.PopularGridIngredientes(ListaMercadoriaCadastrados);
                }
                else
                {
                    _view.PopularGridIngredientes(ListaMercadoriaCadastrados.Where(l => l.Descricao.Contains(Descricao)).ToList());
                }
            }
        }
        #endregion

        #region Eventos Privados
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.MercadoriaSelecionado != null)
            {
                mercadoria = _view.MercadoriaSelecionado;
                base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
            }
        }
        private void EventoBucarPorDescricao(object o, EventArgs e)
        {
            FiltrarListaPorNome(_view.DescricaoMercadoria);
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

                ValidarDadosMercadoria();
                AtivarMercadoriaInativo(mercadoria);
                _service.Salvar(mercadoria);
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                base.MessageDeSucesso($"Mercadoria {mercadoria.Descricao} Cadastrado com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            if (MessageBox.Show($"Deseja Remover o Mercadoria {mercadoria.Descricao} ??", "Remover??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mercadoria.Ativo = false;
                _service.Salvar(mercadoria);
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
