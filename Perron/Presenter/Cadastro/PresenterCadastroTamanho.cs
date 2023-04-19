using Perron.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Presenter
{
   public class PresenterCadastroTamanho :  PresenterPadrao, IPresenterCadastroTamanho
    {

        private readonly IViewCadastroTamanho _view;
        private readonly IServiceTamanho _service;
        private TamanhoModel _tamanho;
        public PresenterCadastroTamanho(IViewCadastroTamanho view ,IServiceTamanho service) : base(view)
        {
            _view = view;
            _service = service;
            _view.Show();
            DelegarEventos();
            EstatoInicial();
        }
        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoSalvar(this.EventoSalvar);
            _view.EventoCancelar(this.EventoCancelar);
            _view.EventoNovo(this.EventoNovo);
            _view.EventoGrid(this.EventoGrid);
            _view.EventoDeletar(this.EventoInativar);
            base.EventoExibicaoCadastros += EventoPopularGrid;

        }
        private void SetdadosTamanho()
        {
            if (_tamanho == null)
            {
                _tamanho = new TamanhoModel();
                _tamanho.Ativo = true;
            }
            _tamanho.Descricao = _view.DescricaoTamanho;
            _tamanho.QntPedacos = _view.QuantidadePedaco;
        }
        private void SetDadostela()
        {
            _view.DescricaoTamanho = _tamanho.Descricao;
            _view.QuantidadePedaco = _tamanho.QntPedacos;
        }
        private void SetTamanhoSelecionadoGrid()
        {
            if (_view.ItemSelecionadoGrid != null)
            {
                _tamanho = _view.ItemSelecionadoGrid;
                SetDadostela();
                AlterarStatusTela(EStatusCadastroTela.ItemSelecionado);

            }
            else
            {
                throw new Exception("Não Existem Item Selecionado");
            }
        }
        private void EstatoInicial()
        {
            this._tamanho = new TamanhoModel();
            _tamanho.Ativo = true;
            base.AlterarStatusTela(EStatusCadastroTela.Inicio);
            _view.QuantidadePedaco = 0;
            _view.DescricaoTamanho = "";

        }
        private void ValidarDadosTamanho()
        {
            string msg = "";
            bool ret = true;


            if (_tamanho.Descricao == "")
            {
                ret = false;
                msg += "- Descrição\n";
            }
            if (_tamanho.QntPedacos == 0)
            {
                ret = false;
                msg += "- Quantidade\n";
            }

            if (!ret)
            {
                throw new Exception("Valide as Informações a Baixa:\n\r" + msg);
            }
        }
        private void Salvar()
        {
            ValidarDadosTamanho();
            _service.Salvar(_tamanho);
            base.MessageDeSucesso($"Tamanho {_tamanho.Descricao} Salvo com Sucesso");
            EstatoInicial();
        }
        #endregion

        #region Metodos Publicos





        #endregion

        #region Eventos Privados

        private void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                _tamanho.AtivarCadastroInativo();
                SetdadosTamanho();
                Salvar();
            }
            catch (Exception ex)
            {
                base.MessagemErro(ex);
            }


        }
        private void EventoCancelar(object o, EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.Inicio);
        }
        private void EventoNovo(object o, EventArgs e)
        {
            EstatoInicial();
            this.AlterarStatusTela(EStatusCadastroTela.Novo);

        }
        private void EventoInativar(object o, EventArgs e)
        {
            if (!_tamanho.InativarCadastro())
            {
                MessageDeSucesso($"Tamanho {_tamanho.Descricao} Inativado");
                this.Salvar();
            }


        }
        private void EventoGrid(object o,EventArgs e)
        {
            SetTamanhoSelecionadoGrid();
        }
        private void EventoPopularGrid(object o , StatusCadastroExibidoEventArgs e)
        {
            _view.PopularGrid(_service.GetListaTamanho(e.Status));
        }
        #endregion

        #region Eventos Publicos

        #endregion
    }


}
