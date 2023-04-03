using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Factory
{
    public static class FactoryRepository
    {
        public static IRepositorySabor Sabor()
        {
            return new RepositorySabor();
        }
        public static IRepositoryTamanho Tamanho()
        {
            return null;
        }
        public static IRepositoryEngrediente Engrediente()
        {
            return null;
        }
        public static IRepositoryDadosEngredienteSabor DadosEngredienteSabor()
        {
            return null;
        }

    }
}
