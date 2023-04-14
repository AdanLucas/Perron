using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IServiceClasse
    {
        void Salvar(ClasseModel classe);
        ClasseModel GetClasseporId(int Id);
        List<ClasseModel> GetlistaClasse(EStatusCadastro statusCadastro);

    }

