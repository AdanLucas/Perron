using Model.Model;
using Perron.View;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Perron.Controller
{
    public class ControllerCadastroEndereco
    {

        


        UCCadastroEndereco _view;

        EnderecoModel Endereco { get { return GetDadosEndereco(); } set { SetDadosEndereco(value); } }

        EnderecoModel _endereco;

        PessoaModel _pessoa;

        public ControllerCadastroEndereco(ControlCollection control, ref PessoaModel pessoa)
        {
            _pessoa = pessoa;
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
            Endereco.IdPessoal = _pessoa.Id;
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
            _view.PopularGrid(_pessoa.Enderecos.Where(end => end.Ativo == true).ToList());
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
                _pessoa.Enderecos.Add(Endereco);
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
                       _pessoa.Enderecos.Remove(_view.EnderecoSelecionado);


                    else
                    _view.EnderecoSelecionado.Ativo = false;


                    ExibirEnderecos();
                }
            }
        }

        #endregion
    }

}
