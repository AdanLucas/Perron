using Model.Interface.View;
using Perron.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perron.Presenter.Cadastro
{
    public  class PresenterCadastroPreco :PresenterPadrao, IPresenterCadastroPreco
    {
        private readonly IViewCadastroPreco _view;
        private readonly IServiceCadastroPreco _service;
        private List<PrecoModel> _listaPreco;


        public PresenterCadastroPreco(IViewCadastroPreco view, IServiceCadastroPreco cadastropreco) :base(view)
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
                _listaPreco = _service.GetPrecoPorClasse((int)_view.ClasseSelecioanda.Id);
                TransformarEmViewEPopularGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }
        private void EventoAddPreco(Object o, EventArgs e)
        {
            if(_listaPreco == null)
                _listaPreco = new List<PrecoModel>();

            var preco = InstanciarPreco();

            if (VerificarExistenciadePreco())
            {
                RemoverOuInativar();

            }

            AdicionarPrecoNaLista(preco);

        }
        protected override void EventoSalvar(object o , EventArgs e)
        {
            if(_listaPreco==null || _listaPreco.Count == 0)
            {
                MessagemErro(new Exception("Nao Existe Preco Para cadastrar!"));
            }
            else
            {
                try
                {
                    _service.SalvarListaPrecos(_listaPreco);
                    MessageDeSucesso("Sabores Cadastrado Com sucesso!!");
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
                _listaPreco = _service.GetPrecoPorClasse((int)_view.ClasseSelecioanda.Id);
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
            _view.EventoGridClasse(EventoGridClasse);
            _view.EventoAdicionarPreco(EventoAddPreco);
        }
        private PrecoModel InstanciarPreco()
        {
            var model = new PrecoModel();
            model.Ativo = true;
            model.Classe = _view.ClasseSelecioanda;
            model.Tamanho = _view.TamanhoSelecionado;
            model.Preco = _view.PrecoInformado;

            return model;

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
        public bool VerificarExistenciadePreco()
        {
            if(_listaPreco ==null)
                        return false;

          return _listaPreco.Any(p => p.Classe.Id == _view.ClasseSelecioanda.Id && p.Tamanho.Id == _view.TamanhoSelecionado.Id);

        }
        private void RemoverOuInativar()
        {
            var preco = _listaPreco.Where(p => p.Classe.Id == _view.ClasseSelecioanda.Id && p.Tamanho.Id == _view.TamanhoSelecionado.Id).FirstOrDefault();
            var Index = _listaPreco.IndexOf(preco);
            

            if (preco.Id != 0)
            {
                _listaPreco[Index].Ativo = false;

            }
            else
            {
                var removeu =  _listaPreco.Remove(preco);
                     
            }
        }
        private void PopularGridClasse()
        {
            try
            {
                _view.SetarListaClasse(_service.GetClasses());
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        protected override void AlterarComportamentoTela(EComportamentoTela status)
        {
            switch (status)
            {
                case EComportamentoTela.None:
                    break;
                case EComportamentoTela.Inicio:
                    _view.SetarTamanhoDaTelaReduzido();
                    _view.VisibilidadePainel = false;
                    _view.HabilitarGridClasse = true;
                    break;
              
                case EComportamentoTela.Cadastrando:
                    _view.SetarTamanhoMaximoTela();
                    _view.VisibilidadePainel = true;
                    _view.HabilitarGridClasse = false;
                    break;

                case EComportamentoTela.ItemSelecionado:
                    break;


                default:
                    break;
            }
        }
        

    }
}
