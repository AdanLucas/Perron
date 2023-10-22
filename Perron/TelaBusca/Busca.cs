using Model.Emumerator;
using Perron.TelaBusca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class Busca
    {
        private static TelaBuscaBase busca;

        public static TelaBuscaBase IniciarBuscar(ETipoBusca tipo,bool? MultiplaSelecao = false)
        {
            busca =  Activator.CreateInstance(tipo.GetTipoBuscar()) as TelaBuscaBase;
            busca.MultiSelecao = MultiplaSelecao == null ? false : (bool)MultiplaSelecao;

            return busca;
        }
    }

