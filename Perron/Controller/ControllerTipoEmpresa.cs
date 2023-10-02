using Model.Emumerator;
using Model.Model;
using Perron.View;
using System;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoEmpresa : ControllerCadastroTipoPessoaBase
    {
        public ControllerTipoEmpresa() : base(ETipoPessoa.Empresa) {}

        protected override UserControl IniciarUserControl()
        {

            if(_view == null)
            return new UCCadastroEmpresa();

            return _view;

        }
        protected override Aentity GetDadosEntidade()
        {
            if (entidade == null)
            {
                entidade = new EmpresaModel();
                entidade.Ativo = true;

            }

            var funcionario = entidade as EmpresaModel;


            try
            {
                var view = (UCCadastroEmpresa)_view;
                funcionario.Id = _pessoa.Id;

                return entidade as EmpresaModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        protected override void SetDadosEntidade(Aentity _entidade)
        {
            if (entidade == null)
                entidade = new EmpresaModel();

            var view = (UCCadastroEmpresa)_view;
            var entt = _entidade as EmpresaModel;

            entidade = entt;
        }
        protected override void ComportamentoCadastrando()
        {

        }
        protected override void ComportamentoNone()
        {

        }
        protected override void ComportamentoInicio()
        {

        }
        protected override void ComportamentoNovo()
        {

        }
        protected override void ComportamentoPopularCadastrando()
        {

        }
        protected override void SalvarCadastro()
        {
            try
            {
                

                ValidadorModel.ValidarModeloLancaExcecao(Entidade as EmpresaModel);
                _service.Salvar(Entidade as EmpresaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
