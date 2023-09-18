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
       static  void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                List<Task> Tarefas = new List<Task>() { new ServiceInicarCache().IniciarCachePessoa(CacheSessao.Instancia.ListaPessoa), CacheSessao.Instancia.Iniciar() };
                 Task.WhenAll(Tarefas);
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
