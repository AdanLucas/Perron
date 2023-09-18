using Model.Emumerator;
using Model.Model;
using Perron.View;
using System;
using System.Dynamic;
using System.Windows.Forms;



namespace Perron.Controller
{

    public class ControllerTipoFuncionario : ControllerCadastroTipoPessoaBase
    {
        public ControllerTipoFuncionario() : base(ETipoPessoa.Funcionario) {}

        protected override Aentity GetDadosEntidade()
        {
            if (entidade == null)
            {
                entidade = new FuncionarioModel();
                entidade.Ativo = true;

            }

              var funcionario = entidade as FuncionarioModel;


            try
            {
                var view = (UCTipoFuncionario)_view;
                funcionario.Id = _pessoa.Id;
                funcionario.Salario = view.Salario;
                funcionario.DataAdimissao = view.DatraContrato;

                return entidade as FuncionarioModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        protected override void SetDadosEntidade(Aentity _entidade)
        {
            if (entidade == null)
                entidade = new FuncionarioModel();

            var view = (UCTipoFuncionario)_view;
            var entt = _entidade as FuncionarioModel;

            view.Salario = entt.Salario;
            view.DatraContrato = entt.DataAdimissao;

           entidade = entt;
        }
        protected override void ComportamentoPopularCadastrando()
        {

        }
        protected override void ComportamentoInicio()
        {

        }
        protected override void ComportamentoNovo()
        {

        }
        protected override void SalvarCadastro()
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(Entidade as FuncionarioModel);
                _service.Salvar(Entidade as FuncionarioModel);

            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        protected override UserControl IniciarUserControl()
        {
            return new UCTipoFuncionario();
        }


    }
}
