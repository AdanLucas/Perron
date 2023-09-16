﻿using Model.Emumerator;
using System;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerCadastroTipoPessoaBase : IControllerTipoPessoa
    {

        protected virtual UserControl _view;

        public ETipoPessoa TipoController { get; set; }
        public Func<PessoaModel> GetDadosPessoa { get; set; }

        protected PessoaModel _pessoal;
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
        #endregion


        #region public

        public void EventoComportamento(EComportamentoTela comportamento)
        {
            SetarComportamentoTela(comportamento);
        }
        public void Salvar(PessoaModel Pessoa)
        {
            try
            {
                _pessoal = Pessoa;
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
            throw new NotImplementedException();
        }

        public void Iniciar(Control.ControlCollection local)
        {
            _view = IniciarUserControl();
            local.Add(_view);
            _view.Dock = DockStyle.Fill;
        }

        public void AlterarStatusCadastro(bool status)
        {
            throw new NotImplementedException();
        }

        public void RemoverTipoCadastro()
        {
            throw new NotImplementedException();
        }

        public void RemoverTipoCadastro(ETipoPessoa tipo)
        {
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }












        #endregion
    }
}
