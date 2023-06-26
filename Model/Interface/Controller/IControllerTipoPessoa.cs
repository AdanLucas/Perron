using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public interface IControllerTipoPessoa
{

    void EventoComportamento(object o, EventArgsGenerico<object[]> e);
    void SetarUserEmTabPage(TabPage page);
    void Salvar(int IdPessoa ,bool ativo);
    

}

