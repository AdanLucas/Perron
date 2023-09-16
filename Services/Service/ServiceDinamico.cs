using System.Collections.Generic;

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
