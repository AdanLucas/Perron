using Perron.TelaBusca;
using Perron.TelaBusca.Enum;
using System;
using Perron.Extensions;

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

