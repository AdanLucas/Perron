
using System;
using System.Drawing;
using System.Windows.Forms;

public interface IViewPadraoCadastro
{
    void Show();
    void Close();

    #region Visiblidade Componentes

    bool VisibilidadeBotaoSalvar { set; }
    bool VisibilidadeBotaoNovo { set; }
    bool VisibilidadeBotaoDeletar { set; }
    bool VisibilidadeBotaoCancelar { set; }
    bool VisibilidadeckAtivo { set; }
    bool VisibilidadeckInativo { set; }
    Size TamanhoTela { set; }
    bool VisualizarCadastrosAtivo { get; set; }
    bool VisualizarCadastrosInativos { get; set; }
    bool SetarVisiblidadeCKStatus { set; }

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
    void SetarTamanhoDaTelaReduzido();
    void SetarTamanhoMaximoTela();

    #endregion



}

