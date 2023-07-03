using Model.Emumerator;
using Perron.View;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;



namespace Perron.Controller
{

    public class ControllerTipoFuncionario : ControllerCadastroTipoPessoaBase
    {



        public ControllerTipoFuncionario() : base(ETipoPessoa.Funcionario) {  }


        private UCTipoFuncionario _view;

        private FuncionarioModel funcionario { get {return GetDadosFuncionario();} set { _funcionario = value; } }
        private FuncionarioModel _funcionario { get; set; }
        private FuncionarioModel GetDadosFuncionario()
        {
           if(_funcionario==null)
                     _funcionario = new FuncionarioModel();

            try 
            {
                _funcionario.Id = _pessoal.Id;
                _funcionario.Salario = _view.Salario;
                _funcionario.DataAdimissao = _view.DatraContrato;

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
        protected override void SalvarCadastro(bool ativo)
        {
            try
            {
                funcionario.Id = _pessoal.Id;
                funcionario.Ativo = ativo;
                _service.Salvar(funcionario);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }


    }
}
