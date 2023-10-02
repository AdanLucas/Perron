using Model.Emumerator;
using System;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerCadastroTipoPessoaBase : IControllerTipoPessoa
    {

        protected  UserControl _view;
        public Aentity Entidade { get { return GetDadosEntidade(); } set { SetDadosEntidade(value);} }
        protected Aentity entidade { get; set; }

        
        public ETipoPessoa TipoController { get; set; }
        

        protected PessoaModel _pessoa;
        protected IServiceTipoPessoa _service;

        #region Construtor
        protected ControllerCadastroTipoPessoaBase(ETipoPessoa tipo)
        {
            TipoController = tipo;
            _service = FactoryService.CadastroTipoPessoa(tipo);


        }
        #endregion

        #region Private
        private void SetarComportamentoTela(EComportamentoTela comporamento)
        {
            switch (comporamento)
            {
                case EComportamentoTela.Inicio:
                    ComportamentoInicio();
                    break;

                case EComportamentoTela.Novo:
                    ComportamentoNovo();
                    break;

                case EComportamentoTela.Cadastrando:
                    ComportamentoPopularCadastrando();
                    break;

                case EComportamentoTela.ItemSelecionado:
                    ComportamentoCadastrando();
                    break;

                case EComportamentoTela.None:
                    ComportamentoNone();
                    break;
            }
        }
        #endregion

        #region Protected
        protected virtual UserControl IniciarUserControl() { return null; }
        protected virtual void ComportamentoPopularCadastrando() { }
        protected virtual void ComportamentoInicio() { }
        protected virtual void ComportamentoNovo() { }
        protected virtual void ComportamentoCadastrando() { }
        protected virtual void ComportamentoNone() { }
        protected virtual void SalvarCadastro() { }
        protected virtual void SetDadosEntidade(Aentity entidade) { }
        protected virtual Aentity GetDadosEntidade() { return null; }

        #endregion

        #region public
        public void AtulizarDadosEntidadePessoa(PessoaModel pessoa)
        {
            _pessoa = pessoa;

            if(_pessoa.Id == null)
                        LimparCampos();

            else
            {
                Entidade = _service.GetCadastroPorId((int)_pessoa.Id) as Aentity;
                Entidade.Ativo = true;

            }

            

        }
        
        public void Salvar()
        {
            try
            {
                SalvarCadastro();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual void SetarUserEmTabPage(TabPage page) { }

        public void AlterarComportamentoCadastro(EComportamentoTela comportamento)
        {
            SetarComportamentoTela(comportamento);
        }

        public void Iniciar(Control.ControlCollection local)
        {
           
            _view = IniciarUserControl();
            local.Add(_view);
            _view.Dock = DockStyle.Fill;
            

        }

        public virtual void LimparCampos(){ }














        #endregion
    }
}
