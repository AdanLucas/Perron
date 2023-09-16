﻿using System.Collections.Generic;
using System.Windows.Forms;


public static class ExComboBox
{
    public static void ConfigurarDadosComboBox<T>(this ComboBox comboBox, List<T> Lista)
    {

        if (Lista.GetType() == typeof(List<ClasseModel>))
        {
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "DescricaoClasse";
            comboBox.DataSource = Lista;
        }


    }

}

