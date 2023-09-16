using System;
using System.Windows.Forms;

public interface IViewPrincipal
{


    void Show();
    void Close();

    #region Eventos
    void EventoFechar(FormClosedEventHandler e);
    //void EventoAbrirTela(EventHandler e);

    void EventoAbrirTelaIngredientes(EventHandler e);
    void EventoAbrirTelaCadastroSabor(EventHandler e);
    void EventoAbrirtelaCadastroClasse(EventHandler e);
    void EventoAbrirtelaCadastroTAmanho(EventHandler e);
    void EventoAbrirTelaCadastroPreco(EventHandler e);
    void EventoAbrirTelaCadastroPessoa(EventHandler e);


    #endregion


}

