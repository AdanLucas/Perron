using Perron.View.Componentes;
using System;


public static class InformandoValorComponente 
{
    private static FrmInformandoValor view = new FrmInformandoValor();


    public static decimal ObterValor()
    {
        view.EventoOK += Ok;

        var result = view.ShowDialog();

        if (result == System.Windows.Forms.DialogResult.OK)
            return view.Valor;

        else return 0;
    }

    private static void Ok(object sender, EventArgs args)
    {
        view.DialogResult = System.Windows.Forms.DialogResult.OK;
        view.Close();
    }


}

