using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public interface IViewCadastroSabor : IViewPadraoCadastro
{

    void Show();
    void Close();

    string DescricaoSabor { get; set; }

    int IdClasse { get; }

    Panel PainelEngredienteSabor { get; }

    void PopularComboClasse(List<ClasseModel> ListaClasse);


}

