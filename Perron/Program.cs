using Perron.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dados = ConfiguracoesGlobais.Instancia.ConfiguracaoInicial.API;
            FactoryPresenter.Principal();
            Application.Run();
        }
    }
}
