using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerCadastroTipoPessoaBase : IControllerTipoPessoa
    {

        protected PessoaModel _pessoal;
        protected ETipoPessoa _tipo;
        protected IServiceTipoPessoa _service;

        #region Construtor
        protected ControllerCadastroTipoPessoaBase(ETipoPessoa tipo)
        {
            try
            {
                _tipo = tipo;
                _service = FactoryService.CadastroTipoPessoa(_tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
        protected virtual void ComportamentoPopularCadastrando() {  }
        protected virtual void ComportamentoInicio() {  }
        protected virtual void ComportamentoNovo() {  }         
        protected virtual void ComportamentoCadastrando() {  }
        protected virtual void ComportamentoNone() {  }
        protected virtual void SalvarCadastro() { }
        protected virtual void SalvarCadastro(bool ativo) { }
        #endregion


        #region public

        public void EventoComportamento(object o, EventArgsGenerico<object[]> e)
        {
            _pessoal = (PessoaModel)e.Item[1];
            SetarComportamentoTela((EComportamentoTela)e.Item[0]);
        }
        public void Salvar(PessoaModel Pessoa, bool ativo) 
        {
            try
            {
                _pessoal = Pessoa;
                SalvarCadastro(ativo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual void SetarUserEmTabPage(TabPage page) { }
        
        #endregion
    }
}
