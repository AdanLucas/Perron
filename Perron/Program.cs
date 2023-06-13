using Perron.Factory.Controller;
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
        static  void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Task tarefa = ConfiguracoesGlobais.Instancia.Iniciar();
                Task.WaitAll(tarefa);
                FactoryPresenter.Principal();
                Application.Run();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
