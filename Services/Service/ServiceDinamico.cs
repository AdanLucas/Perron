using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services.Service
{
   public static class ServiceDinamico<T>
    {

        static RepositoryDinamico<T> _repo = new RepositoryDinamico<T>();
        

        public static List<T> GetLista()
        {
            return _repo.GetLista();
        }



    }
}
