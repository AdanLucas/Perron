using Perron.Controller;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Presenter
{
  
    public class PresenterClasse : PresenterPadrao, IPresenterClasse
    {

        private readonly IViewClasse _view;
        private ClasseModel _classe;
        private readonly IServiceClasse _serivce;

        public PresenterClasse(IViewClasse view,IServiceClasse service) : base(view)
        {
            _view = view;
            _view.Show();
            _serivce = service;
            DelegarEventos();
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }

        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoGrid(this.EventoGrid);
        }
        private void ValidarClasse()
        {
            bool ret = true;
            string msg = "";

            if(_classe.DescricaoClasse == "")
            {
                msg  += "- Informa A descrição da Classe por favor\n\r";
                ret = false;
            }


            if (!ret)
                throw new Exception(msg);


        }
        public  void SetClasseNaView()
        {
            _classe = _view.ClasseSelecionadaGrid;
            _view.DescricaoClasse = _classe.DescricaoClasse;
        }
        private void GetClasseView()
        {
            if (_classe == null)
            {
                _classe = new ClasseModel();
                _classe.Ativo = true;
            }

            _classe.DescricaoClasse = _view.DescricaoClasse;
        }
        private void EstadoInicial()
        {
            _classe = null;
            _view.DescricaoClasse = "";
            _view.SetarTamanhoMaximoTela();
            _view.VisibilidadeGroupBoxClassesCadastrados = true;



        }
        private void EstadoNovoCadastro()
        {
            _classe = new ClasseModel();
            _classe.Ativo = true;
            _view.DescricaoClasse = "";
            _view.PopularGridClasse(null);
            _view.SetarTamanhoDaTelaReduzido();
            _view.VisibilidadeGroupBoxClassesCadastrados = false;

        }
        private void EstadoItemSelecionado()
        {
            SetItemSelecionado();
        }
        private void SetItemSelecionado()
        {
            SetClasseNaView();
        }
        #endregion

        #region Eventos Privados
        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            _view.PopularGridClasse(_serivce.GetlistaClasse(status));
        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                GetClasseView();
                ValidadorModel.ValidarModeloLancaExcecao(_classe);
                _classe.AtivarCadastroInativo();
                _serivce.Salvar(_classe);
                MessageDeSucesso($"Classe {_classe.DescricaoClasse} cadastrada Com sucesso!");
                base.ComportamentoAtual = EComportamentoTela.Inicio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        protected override void EventoRemover(object o , EventArgs e)
        {
            if(_view.ClasseSelecionadaGrid == null)
            {
                MessageBox.Show("Selecione Um Cadastro para Inativar!", "Sem Classe Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _classe = _view.ClasseSelecionadaGrid;
                _classe.InativarCadastro();
                _serivce.Salvar(_classe);
                base.ComportamentoAtual = EComportamentoTela.Inicio;
            }
        }
        protected override void EventoNovo(object o , EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;

        }
        private void EventoGrid(object o,EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
        }
        protected override void AlterarComportamentoTela(EComportamentoTela status)
        {
       
            switch (status)
            {
             
                case EComportamentoTela.Inicio:
                    EstadoInicial();
                    break;


                case EComportamentoTela.Novo:
                    EstadoNovoCadastro();
                    break;


                case EComportamentoTela.Cadastrando:
                    break;


                case EComportamentoTela.ItemSelecionado:
                    EstadoItemSelecionado();
                    break;

                default:
                    break;
            }
        }
        #endregion


    }
}
