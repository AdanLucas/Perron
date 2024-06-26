﻿using Model.Model;
using Perron.Presenter.Cadastro;
using Perron.View;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Perron.Controller
{
    public class ControllerCadastroEndereco
    {

        private PresenterCadastroPessoa _presenderPessoa { get; set; }


        UCCadastroEndereco _view;

       public Action EventoLimparCampos { get; set; }
       public Action<PessoaModel> EventoExibirDadosEntidade { get; set; }
        EnderecoModel Endereco { get { return GetDadosEndereco(); } set { SetDadosEndereco(value); } }

        EnderecoModel _endereco;

        

        public ControllerCadastroEndereco(ControlCollection control, PresenterCadastroPessoa presenderPessoa)
        {
            _presenderPessoa = presenderPessoa;
            _view = new UCCadastroEndereco();
            control.Add(_view);
            _view.Dock = DockStyle.Fill;
            DelegarEventos();


        }
        private void DelegarEventos()
        {
            _view.EventoAdd += EventoAddEndereco;
            _view.EventoRemove += EventoRemoverEndereco;
            _view.EventoGrid += EventoGridEndereco;
            this.EventoLimparCampos += LimparCampos;
            this.EventoExibirDadosEntidade += CarregarDadosEntidade;

        }
        private void CarregarDadosEntidade(PessoaModel pessoa)
        {
            ExibirEnderecos();
        }
        private void ValidarDadosEndereco(EnderecoModel endereco)
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(endereco);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void NovoCadastro()
        {
            var Endereco = new EnderecoModel();
            Endereco.IdPessoal = _presenderPessoa.pessoa.Id;
            Endereco.Ativo = true;
            this.Endereco = Endereco;


        }
        public void AlterarEstadoCadastro(EComportamentoTela comportamento)
        {
            switch (comportamento)
            {
                case EComportamentoTela.Inicio:

                    _view.VisibidadeBotoes = false;
                    _view.HabilitarCampos = false;
                    NovoCadastro();
                    break;

                case EComportamentoTela.Cadastrando:
                    _view.VisibidadeBotoes = true;
                    _view.HabilitarCampos = true;
                    break;

                case EComportamentoTela.Novo:
                    _view.VisibidadeBotoes = true;
                    _view.HabilitarCampos = true;
                    break;

                case EComportamentoTela.ItemSelecionado:
                    _view.VisibidadeBotoes = true;
                    _view.HabilitarCampos = true;
                    break;
            }
        }
        private EnderecoModel GetDadosEndereco()
        {
            if (_endereco == null)
            {
                _endereco = new EnderecoModel();
                _endereco.Ativo = true;
            }

            _endereco.Descricao = _view.Descricao;
            _endereco.Rua = _view.Rua;
            _endereco.Numero = _view.Numero;
            _endereco.Bairro = _view.Bairro;
            _endereco.Cidade = _view.Cidade;


            return _endereco;
        }
        private void SetDadosEndereco(EnderecoModel endereco)
        {
            _endereco = endereco;
            _view.Rua = endereco.Rua;
            _view.Bairro = endereco.Bairro;
            _view.Numero = endereco.Numero;
            _view.Descricao = endereco.Descricao;
            _view.Cidade = endereco.Cidade;

        }
        private void ExibirEnderecos()
        {
            try
            {
                _view.PopularGrid(_presenderPessoa.pessoa.Enderecos.Where(end => end.Ativo == true).ToList());
            }
            catch {  }
        }
        private void LimparCampos()
        {
            Endereco = new EnderecoModel();
            Endereco.Numero = "";
            Endereco.Ativo = true;
            Endereco.Rua = "";
            Endereco.Descricao = "";
            Endereco.Bairro = "";
            Endereco.Cidade = "";
            Endereco.IdPessoal = _presenderPessoa.pessoa.Id;
            _view.PopularGrid(null);
        }

        #region Eventos
        private void EventoGridEndereco(object o, EventArgs e)
        {
            if (_view.EnderecoSelecionado != null)
            {
                Endereco = _view.EnderecoSelecionado;
            }
        }
        private void EventoAddEndereco(object o, EventArgs e)
        {
            try
            {
                ValidarDadosEndereco(Endereco);
                _presenderPessoa.pessoa.Enderecos.Add(Endereco);
                ExibirEnderecos();
                NovoCadastro();

                MessageBox.Show("Endereco Adicionado Com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                ControllerNotificao.MessagemErro(ex);
            }



        }
        private void EventoRemoverEndereco(object o, EventArgs e)
        {
            if (_view.EnderecoSelecionado != null)
            {

                if (MessageBox.Show("Remover Endereço ??", "Remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(_view.EnderecoSelecionado.Id == 0)
                       _presenderPessoa.pessoa.Enderecos.Remove(_view.EnderecoSelecionado);


                    else
                    _view.EnderecoSelecionado.Ativo = false;


                    ExibirEnderecos(); 
                }
            }
        }

        #endregion
    }

}
