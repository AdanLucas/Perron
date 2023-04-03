using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SaborModel
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    ClasseModel classe { get; set; }
    public List<EngredienteModel> Engredientes { private get; set; }
    public bool Ativo { get; set; }

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

