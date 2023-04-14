using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SaborModel:Aentity
{
    public string Descricao { get; set; }
    public ClasseModel Classe { get; set; }
    public List<EngredienteModel> Engredientes { private get; set; }
    public List<EngredienteModel> GetEngredientePorStatus(EStatusCadastro Status)
    {
        List<EngredienteModel> ret;

        switch (Status)
        {
            case EStatusCadastro.Todos:

                return Engredientes;

            case EStatusCadastro.Ativo:

                return ret = Engredientes.Where(e => e.Ativo == true).ToList();

            case EStatusCadastro.Inativo:

                return ret = Engredientes.Where(e => e.Ativo == false).ToList();

        }

        return null;
    }


}

