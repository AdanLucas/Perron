
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public interface IViewPadraoCadastro
{


    #region Visiblidade Componentes

    bool VisibilidadeBotaoSalvar { set; }
    bool VisibilidadeBotaoNovo { set; }
    bool VisibilidadeBotaoDeletar { set; }
    bool VisibilidadeBotaoCancelar { set; }
    bool VisibilidadeckAtivo { set; }
    bool VisibilidadeckInativo { set; }

    bool VisualizarCadastrosAtivo { get; }
    bool VisualizarCadastrosInativos { get; }

    #region Metodos

    void RemoverCheck();

    #endregion

    #endregion

    #region Eventos

    void EventoFecharForms(FormClosedEventHandler e);
    void EventoNovo(EventHandler e);
    void EventoSalvar(EventHandler e);
    void EventoDeletar(EventHandler e);
    void EventoCancelar(EventHandler e);
    void EventockAtivo(EventHandler e);
    void EventockInativo(EventHandler e);

    #endregion



}

