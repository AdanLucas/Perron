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
        
        private ClienteModel _cliente;
        public ControllerTipoCliente() : base(ETipoPessoa.Cliente) { }

        protected override UserControl IniciarUserControl()
        {
            return new UCCliente();
        }
        protected override void SalvarCadastro()
        {
            try
            {
                _service.Salvar(_cliente);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
