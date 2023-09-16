using Perron.Properties;
using Perron.View;
using System;
using System.Windows.Forms;


public static class ControllerNotificao
{

    private static FrmNotificacao _view = new FrmNotificacao();

    static DialogResult dialogResult;

    public static DialogResult ValidarCampoVazio(ref string campo)
    {
        var result = _view.ShowDialog();

        if (result == DialogResult.OK)
        {
            campo = _view.Text;

            return DialogResult.OK;
        }
        else if (result == DialogResult.Ignore)
        {
            return DialogResult.Ignore;
        }

        return DialogResult.Cancel;
    }
    public static DialogResult MessagemErro(Exception ex)
    {
        _view.Text = "Erro!!";
        _view.pbImagem.Image = Resources.BotaoAbort;

        _view.TextoPrincipal = ex.Message;
        _view.TextoLongo = ex.StackTrace;

        if (ex.InnerException != null)
            _view.TextoRodape = ex.InnerException.Message;

        _view.BotaoCancelar.Click += EventoCancelar;
        _view.BotaoOk.Click += EventoOk;

        _view.ShowDialog();

        return dialogResult;
    }
    private static void EventoCancelar(object o, EventArgs e)
    {
        _view.Close();
        dialogResult = DialogResult.Cancel;
    }
    private static void EventoOk(object o, EventArgs e)
    {
        _view.Close();
        dialogResult = DialogResult.OK;
    }



}

