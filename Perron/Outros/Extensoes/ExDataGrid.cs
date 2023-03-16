using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;




public static class ExDataGrid
{
    public static void DataSourceCustomizado<T>(this DataGridView grid, List<T> lista)
    {
        foreach (var item in lista)
        {
             PegarTipoLinha<T>(grid, item);
        }
    }
    private static void PegarTipoLinha<T>(DataGridView grid, T obj)
    {
        if (obj.GetType() == typeof(EngredienteModel))
             CriarLinhaIngredientes(grid, obj);

        
            

    }
    private static void CriarLinhaIngredientes(DataGridView grid, object obj)
    {
        var ingrediente = (EngredienteModel)obj;

        var Linha = new DataGridViewRow();

        grid.ColumnCount = 3;

        grid.Columns[0].Name = "Id";
        grid.Columns[1].Name = "Descricao";
        grid.Columns[2].Name = "Ativo";
        


        Linha.CreateCells(grid);

        

        Linha.Cells[0].Value = ingrediente.Id;
        Linha.Cells[1].Value = ingrediente.Descricao;
        Linha.Cells[2].Value = ingrediente.Ativo;


        if (ingrediente.Ativo)
        {
            Linha.DefaultCellStyle.BackColor = Color.Green;
        }
        else
        {
            Linha.DefaultCellStyle.BackColor = Color.Red;
        }

        grid.Rows.Add(Linha);

    }


}


