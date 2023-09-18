using Model.Emumerator;
using System;

namespace Perron.Controller
{
    public static class FactoryController
    {

        public static IControllerTipoPessoa GerarControllerTipoPessoa(ETipoPessoa tipo)
        {
            try
            {

                IControllerTipoPessoa controller = null;

                Type type = Type.GetType(tipo.GetDadosController());

                if (type != null)
                    controller = Activator.CreateInstance(type) as IControllerTipoPessoa;

                controller.TipoController = tipo;

                return controller;
            }
            catch{ return null; }
        }

    }
}
