using System.Collections.Generic;


public interface IServiceClasse
{
    void Salvar(ClasseModel classe);
    ClasseModel GetClasseporId(int Id);
    List<ClasseModel> GetlistaClasse(EStatusCadastro statusCadastro);

}

