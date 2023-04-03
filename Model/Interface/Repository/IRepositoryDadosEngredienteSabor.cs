using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface IRepositoryDadosEngredienteSabor
    {
       void SalvarDadosEngredienteSabor(DadosSaborEngredienteModel Dados);
       List<DadosSaborEngredienteModel> GetListaDadosPorSabor(int IdSabor);

    }

