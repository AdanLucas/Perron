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

            AlterarStatusTela(EStatusCadastroTela.Inicio);

        }

        #region Metodos Privados

        private void DelegarEventos()
        {
            _view.EventoSalvar(this.EventoSalvar);
            _view.EventoDeletar(this.EventoInativar);
            base.EventoExibicaoCadastros += EventoExibirCadastros;
            base.EventoStatusCadastroTela += EventoAlterarStatusCadastro;
            _view.EventoNovo(this.EventoNovoCadastro);
            _view.EventoCancelar(this.EventoCancelar);
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
        public void SetClasseNaView()
        {
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
            

        }
        private void EstadoNovoCadastro()
        {
            _classe = new ClasseModel();
            _classe.Ativo = true;
            _view.DescricaoClasse = "";
            _view.PopularGridClasse(null);

        }
        private void EstadoItemSelecionado()
        {
            SetItemSelecionado();
        }
        private void SetItemSelecionado()
        {
            _classe = _view.ClasseSelecionadaGrid;
            SetClasseNaView();

        }
        #endregion

        #region Metodos Publicos




        #endregion


        #region Eventos Privados

        private void EventoExibirCadastros(object o,StatusCadastroExibidoEventArgs e)
        {
            _view.PopularGridClasse(_serivce.GetlistaClasse(e.Status));
        }
        private void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                GetClasseView();
                ValidadorModel.ValidarModeloLancaExcecao(_classe);
                _classe.AtivarCadastroInativo();
                _serivce.Salvar(_classe);
                MessageDeSucesso($"Classe {_classe.DescricaoClasse} cadastrada Com sucesso!");
                AlterarStatusTela(EStatusCadastroTela.Inicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void EventoInativar(object o , EventArgs e)
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
                AlterarStatusTela(EStatusCadastroTela.Inicio);
            }
        }
        private void EventoNovoCadastro(object o , EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.Novo);
        }
        private void EventoCancelar(object o, EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.Inicio);

        }
        private void EventoGrid(object o,EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.ItemSelecionado);
        }
        #endregion

        private void EventoAlterarStatusCadastro(object o,StatusCadastroTelaEventArgs e)
        {
            switch (e.statusTela)
            {
             
                case EStatusCadastroTela.Inicio:
                    EstadoInicial();
                    break;


                case EStatusCadastroTela.Novo:
                    EstadoNovoCadastro();
                    break;


                case EStatusCadastroTela.Cadastrando:
                    break;


                case EStatusCadastroTela.ItemSelecionado:
                    EstadoItemSelecionado();
                    break;


                default:
                    break;
            }
        }

    }
}
