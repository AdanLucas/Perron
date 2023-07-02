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
        private FuncionarioModel _funcionario { get {return GetDadosFuncionario(); } set { } }
        private FuncionarioModel GetDadosFuncionario()
        {
           if(_funcionario==null)
                     _funcionario = new FuncionarioModel();

            try 
            {
                _funcionario.Id = _pessoal.Id;
                _funcionario.Salario = _view.Salario;
                _funcionario.DataContratado = _view.DatraContrato;

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
                _funcionario.Id = _pessoal.Id;
                _funcionario.Ativo = ativo;
                _service.Salvar(_funcionario);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }


    }
}
