using Perron.TelaBusca;
using Perron.TelaBusca.Enum;
using System;
using Perron.Extensions;

public static class Busca
    {
        private static TelaBuscaBase busca;

        public static TelaBuscaBase IniciarBuscar(ETipoBusca tipo)
        {
            busca =  Activator.CreateInstance(tipo.GetTipoBuscar()) as TelaBuscaBase;
            return busca;
        }
    }

