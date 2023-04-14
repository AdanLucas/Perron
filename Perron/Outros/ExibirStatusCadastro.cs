using Perron;
using System.Windows.Forms;
using System.Drawing;

public class ExibirStatusCadastro
{
    private Panel _painel;

    private UserControlExibirStatusCadastro _view;


    public ExibirStatusCadastro(Panel painel)
    {
        _painel = painel;
        IniciarView(painel);

    }



    private void IniciarView(Panel painel)
    {
        _view = new UserControlExibirStatusCadastro();
        painel.Controls.Add(_view);
        _painel.Visible = false;

    }
    private void StatusAtivo()
    {
        if (!_painel.Visible)
            _painel.Visible = true;


        _view.Status.BackColor = Color.Green;
    }
    private void StatusInativo()
    {
        if (!_painel.Visible)
            _painel.Visible = true;


        _view.Status.BackColor = Color.Red;
    }


    public void SetarStatus(bool Status)
    {
        if (Status)
            StatusAtivo();

        else
            StatusInativo();
    }


}

