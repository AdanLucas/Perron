using Model.Emumerator;
using Perron.View;
using System;
using System.Windows.Forms;



namespace Perron.Controller
{

    public class ControllerTipoFuncionario : ControllerCadastroTipoPessoaBase
    {



        public ControllerTipoFuncionario() : base(ETipoPessoa.Funcionario) { }


        

        private FuncionarioModel funcionario { get { return GetDadosFuncionario(); } set { _funcionario = value; } }
        private FuncionarioModel _funcionario { get; set; }
        private FuncionarioModel GetDadosFuncionario()
        {
            if (_funcionario == null)
                _funcionario = new FuncionarioModel();

            try
            {
                var view = (UCTipoFuncionario)_view;
                _funcionario.Id = _pessoal.Id;
                _funcionario.Salario = view.Salario;
                _funcionario.DataAdimissao = view.DatraContrato;

                return _funcionario;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public override void SetarUserEmTabPage(TabPage page)
        {
            _view = new UCTipoFuncionario();
            page.Controls.Add(_view);
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
                funcionario.Id = _pessoal.Id;
                _service.Salvar(funcionario);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }


    }
}
