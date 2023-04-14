using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class FactoryService
{
    public static IServiceEngrediente Engrediente()
    {




        return null;
    }
    public static IServiceSabor Sabor()
    {





        return null;
    }
    public static IServiceClasse Classe()
    {
        var reposotiry = FactoryRepository.Classe();

        return new ServiceClasse(reposotiry);
    }

}

