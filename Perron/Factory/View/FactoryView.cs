﻿using Perron;
using Perron.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class FactoryView
{


    public static IViewPrincipal Principal()
    {
        return new FrmPrincipal();
    }
    public static IViewCadastroIngrediente CadastroIngrediente(IViewPrincipal viewPrincipal)
    {
        var viewIngrediente = new FrmCadastroIngrediente();

        viewIngrediente.MdiParent = (FrmPrincipal)viewPrincipal;


        return viewIngrediente;
    }
    public static IViewCadastroSabor CadastroSabor(IViewPrincipal viewPrincipal)
    {
        var viewCadastroSabor = new FrmCadastroSabor();

        viewCadastroSabor.MdiParent = (FrmPrincipal)viewPrincipal;

        return viewCadastroSabor;


    }
    public static IViewCadastroEngredienteSabor CadastroEngredienteSabor(Panel painel)
    {
        var userControl = new UserControlEngredienteSabor();

        painel.Controls.Add(userControl);

        return userControl;

    }



}

