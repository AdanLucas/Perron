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
            this.StatusCadastro = EStatusCadastroTela.Inicio;

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
        private void EventoNovoCadastro(object o,EventArgs e)
        {
            base.StatusCadastro = EStatusCadastroTela.Cadastrando;
        }
        private void EventoSalvarListaPreco(object o , EventArgs e)
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
                    base.StatusCadastro = EStatusCadastroTela.Inicio;
                }
                catch (Exception ex)
                {
                    MessagemErro(ex);
                }

            }
        }
        #endregion

        protected override void AtualizarStatusTela()
        {
            MessageBox.Show("Seu teste Deu Certo!");
        }
        private void DelegarEventos()
        {
            _view.EventoGridClasse(EventoGridClasse);
            _view.EventoAdicionarPreco(EventoAddPreco);
            base.EventoStatusCadastroTela += EventoStatusCadastro;
            _view.EventoSalvar(EventoSalvarListaPreco);
            _view.EventoNovo(EventoNovoCadastro);
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
        private void EventoStatusCadastro(object o,StatusCadastroTelaEventArgs e)
        {
            StatusCadastroAtual(e.statusTela);
        }
        private void StatusCadastroAtual(EStatusCadastroTela status)
        {
            switch (status)
            {
                case EStatusCadastroTela.None:
                    break;
                case EStatusCadastroTela.Inicio:
                    _view.AlturaTela = 468;
                    _view.VisibilidadePainel = false;
                    break;
              
                case EStatusCadastroTela.Cadastrando:
                    _view.AlturaTela = 550;
                    _view.VisibilidadePainel = true;
                    break;
                case EStatusCadastroTela.ItemSelecionado:
                    break;
                default:
                    break;
            }
        }
        private void EventoInativarPreco(object o, EventArgs e)
        {
            //if (MessageBox.Show($@"Deseja Inativar o Preco da Classe {_view.ClasseSelecioanda.DescricaoClasse} do Tamanho {_view.TamanhoSelecionado.Descricao} ?", "Inativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) 
            //{
            //    try
            //    {
            //        RemoverOuInativar();
            //        MessageDeSucesso("Inativado Com Sucesso!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessagemErro(ex);
            //    }


            //}

        }

    }
}
