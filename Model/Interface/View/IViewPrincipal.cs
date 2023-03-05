using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public interface IViewPrincipal
{


    void Show();
    void Close();

    #region Eventos
    void EventoFechar(FormClosedEventHandler e);
    //void EventoAbrirTela(EventHandler e);

    void EventoAbrirTelaIngredientes(EventHandler e);

    #endregion


}

