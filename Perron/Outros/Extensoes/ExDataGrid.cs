using Model.AtribulteClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;




public static class ExDataGrid
{
    public static void DataSourceCuston<T>(this DataGridView dgv, List<T> List)
    {

        if (List == null || List.Count < 1)
        {
            dgv.DataSource = null;
            return;
        }

        Type type = typeof(T);
        dgv.DataSource = List;

        PropertyInfo[] propriedades = type.GetProperties();

        foreach (PropertyInfo prop in propriedades)
        {
            try
            {

                bool? ExibirNaGrid = PegarValorAtributosClasse(prop, "ExibirNaGrid") as bool?;

                if (ExibirNaGrid != null)
                {
                    if ((bool)ExibirNaGrid)
                    {
                        var membro = (string)PegarValorAtributosClasse(prop, "Descricao");
                        dgv.Columns[$"{prop.Name}"].HeaderText = membro == null ? prop.Name : membro;

                    }
                    else
                    {
                        dgv.Columns[prop.Name].Visible = false;

                    }

                }
                else
                    dgv.Columns[prop.Name].Visible = false;
            }
            catch {}
        }
    }
    private static object PegarValorAtributosClasse(PropertyInfo prop, string membroAtributo)
    {
        try
        {
            var att = prop.CustomAttributes.Where(atb => atb.AttributeType.Equals(typeof(AtributosClasse))).FirstOrDefault();

            if (att == null)
                return null;

            return att.NamedArguments.Where(arg => arg.MemberName.Equals(membroAtributo)).FirstOrDefault().TypedValue.Value;
        }
        catch { return null; }
    }

}


