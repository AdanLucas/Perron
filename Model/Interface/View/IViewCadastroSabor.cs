﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroSabor : IViewPadraoCadastro
{

    string DescricaoSabor { get; set; }
    string DescricaoClasse { set; }
     TabControl TabControl { get; }
    bool VisibilidadeBotao { set; }
    void EventoBuscarClasse(EventHandler e);
    void EventoGrid(EventHandler e);
    SaborModel ItemSelecionadoGrid { get; }
    void PopularGrid(List<SaborModel> Lista);
    KeyPressEventHandler EventoTeclaPressionada { get; set; }

}

