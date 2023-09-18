using Model.Emumerator;
using Model.Model;
using Perron.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoCliente : ControllerCadastroTipoPessoaBase
    {
        
        
        public ControllerTipoCliente() : base(ETipoPessoa.Cliente) {}

        protected override UserControl IniciarUserControl()
        {
            return new UCCliente();
        }
        protected override void SalvarCadastro()
        {
            try
            {
                ValidadorModel.ValidarModeloLancaExcecao(Entidade as ClienteModel);
                _service.Salvar(Entidade as ClienteModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected override Aentity GetDadosEntidade()
        {
            if (entidade == null)
            {
                entidade = new ClienteModel();
                entidade.Ativo = true;
            }

            var funcionario = entidade as ClienteModel;


            try
            {
                var view = (UCCliente)_view;
                funcionario.Id = _pessoa.Id;

                return entidade as ClienteModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        protected override void SetDadosEntidade(Aentity _entidade)
        {
            if (entidade == null)
                entidade = new ClienteModel();

            var view = (UCCliente)_view;
            var entt = _entidade as ClienteModel;

            entidade = entt;
        }
        

    }
}
