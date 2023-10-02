using Model.AtribulteClasses;
using System.Runtime.CompilerServices;

public abstract class Aentity
{

    [AtributosClasse(ExibirNaGrid = false)]
    public long? Id { get; set; }


    [AtributosClasse(ExibirNaGrid = false)]
    public bool Ativo { get; set; }

}

