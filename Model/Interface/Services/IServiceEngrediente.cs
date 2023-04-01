using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IServiceEngrediente
{
    List<EngredienteModel> GetListaEngredientesCadastroados();
    void Salvar(EngredienteModel Engrediente);
    void SalvarLista(List<EngredienteModel> ListaEngrediente);

}

