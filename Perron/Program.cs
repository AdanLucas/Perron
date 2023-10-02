using Services.Service;
using System;
using System.Collections.Generic;
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
       static   void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                
                Task.WaitAll(CacheSessao.Instancia.Iniciar());
                CacheSessao.Instancia.ListaPessoa =  new ServiceInicarCache().IniciarCachePessoa();

                FactoryPresenter.Principal();
                Application.Run();

            }
            catch {}
        }
    }
}
