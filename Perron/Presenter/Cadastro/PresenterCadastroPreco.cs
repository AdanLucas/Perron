using Model.Interface.View;
using Perron.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Presenter.Cadastro
{
    public class PresenterCadastroPreco : PresenterPadrao, IPresenterCadastroPreco
    {
        private readonly IViewCadastroPreco _view;
        private readonly IServiceCadastroPreco _service;
        private List<PrecoModel> _listaPreco;
        private ClasseModel _classe;

        public PresenterCadastroPreco(IViewCadastroPreco view, IServiceCadastroPreco cadastropreco) : base(view)
        {
            _view = view;
            _service = cadastropreco;
            _view.SetarVisiblidadeCKStatus = false;
            AbrirTela();
            DelegarEventos();
            this.ComportamentoAtual = EComportamentoTela.Inicio;
        }

        #region Eventos Privados
        private void EventoGridClasse(object o, EventArgs e)
        {
            try
            {
                TransformarEmViewEPopularGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }
        private void EventoAddPreco(Object o, EventArgs e)
        {
            if (_listaPreco == null)
                _listaPreco = new List<PrecoModel>();

            var preco = InstanciarPreco();

            if (VerificarExistenciadePreco())
            {
                RemoverOuInativar();

            }

            AdicionarPrecoNaLista(preco);

        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            if (_listaPreco == null || _listaPreco.Count == 0)
            {
                MessagemErro(new Exception("Nao Existe Preco Para cadastrar!"));
            }
            else
            {
                try
                {
                    _service.SalvarListaPrecos(_listaPreco);
                    MessageDeSucesso("Produtos Cadastrado Com sucesso!!");
                    base.ComportamentoAtual = EComportamentoTela.Inicio;
                }
                catch (Exception ex)
                {
                    MessagemErro(ex);
                }

            }
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            try
            {
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                _listaPreco = null;
                TransformarEmViewEPopularGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }

        }
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Cadastrando;
        }
        #endregion

        private void DelegarEventos()
        {
            _view.EventoAdicionarPreco(EventoAddPreco);
        }
        private PrecoModel InstanciarPreco()
        {
            var model = new PrecoModel();
            model.Ativo = true;
            model.Tamanho = _view.TamanhoSelecionado;
            model.Preco = _view.PrecoInformado;

            return model;

        }
        private void Remover()
        {
            if (ComportamentoAtual.Equals(EComportamentoTela.ItemSelecionado))
                                 _service.RemoverTodosVinculoDeClasseComPrecos(_classe.Id);

            _classe = null;

            if(_classe == null)
            {
                _view.BotaoDireito.Items["menuBotaoDireitoAdicionarClasse"].Visible = true;
                _view.BotaoDireito.Items["menuBotaoDireitoRemoverClasse"].Visible = false;

            }

            _view.DescricaoClasse = "";

        }
        private void AdicionarClasse()
        {
            _classe = Busca.IniciarBuscar(TelaBusca.Enum.ETipoBusca.CLASSE).ObterSelecionado<ClasseModel>();

            if(_classe != null)
            {
                _view.BotaoDireito.Items["menuBotaoDireitoAdicionarClasse"].Visible = false;
                _view.BotaoDireito.Items["menuBotaoDireitoRemoverClasse"].Visible = true;

            }
        }
        private void AdicionarPrecoNaLista(PrecoModel preco)
        {
            _listaPreco.Add(preco);
            TransformarEmViewEPopularGrid();
        }
        private void TransformarEmViewEPopularGrid()
        {
            var Lista = new List<PrecoView>();

            foreach (var item in _listaPreco)
            {
                if (item.Ativo)
                {
                    var _preco = new PrecoView();
                    _preco.Index = _listaPreco.IndexOf(item);
                    _preco.Tamanho = item.Tamanho.Descricao;
                    _preco.Preco = item.Preco;
                    Lista.Add(_preco);
                }
            }

            _view.SetarListaPrecosCadastrados(Lista);

        }
        private void PopularGridTamanho()
        {
            try
            {
                _view.SetarListatamanho(_service.GetTamanhos());
            }
            catch (Exception ex) { throw ex; }
        }
        private void AbrirTela()
        {
            try
            {
                PopularGridClasse();
                PopularGridTamanho();

                _view.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }
        protected override void AlterandoComportamentoTela()
        {
            switch (ComportamentoAtual)
            {
                case EComportamentoTela.None:
                    break;
                case EComportamentoTela.Inicio:
                    _view.SetarTamanhoDaTelaReduzido();
                    _view.VisibilidadePainel = false;
                    
                    break;

                case EComportamentoTela.Cadastrando:
                    _view.SetarTamanhoMaximoTela();
                    _view.VisibilidadePainel = true;
                    
                    break;

                case EComportamentoTela.ItemSelecionado:
                    break;


                default:
                    break;
            }
        }


    }
}
