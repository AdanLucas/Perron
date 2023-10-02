using Model.Emumerator;
using System;
using System.ComponentModel;
using System.Reflection;


public static class ExtensionEnum
{
    public static string GetDescription(this Enum value)
    {
        try
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
        catch (Exception)
        {

            return "";
        }
    }
    public static T[] GetArrayItemEnum<T>(this T tipo) where T : Enum
    {
        T[] Tipos = (T[])Enum.GetValues(typeof(T));

        return Tipos;
    }
    public static String GetDadosController(this Enum Tipo)
    {
        FieldInfo elementEnum = Tipo.GetType().GetField(Tipo.ToString());
        //Se o Length for 0, significa que o Enum não tem nenhum elemento
        if (elementEnum != null)
        {
            object[] customAttributeComando = elementEnum.GetCustomAttributes(typeof(EComando), false);

            return (customAttributeComando.Length == 0) ? "" : ((EComando)customAttributeComando[0]).Controller;
        }
        else
            return "";
    }
    public static String GetDadosRepository(this ETipoPessoa tipo)
    {
        FieldInfo elementEnum = tipo.GetType().GetField(tipo.ToString());
        //Se o Length for 0, significa que o Enum não tem nenhum elemento
        if (elementEnum != null)
        {
            object[] customAttributeComando = elementEnum.GetCustomAttributes(typeof(EComando), false);

            return (customAttributeComando.Length == 0) ? "" : ((EComando)customAttributeComando[0]).Repository;
        }
        else
            return "";
    }
    public static String GetDadosService(this ETipoPessoa tipo)
    {
        FieldInfo elementEnum = tipo.GetType().GetField(tipo.ToString());
        //Se o Length for 0, significa que o Enum não tem nenhum elemento
        if (elementEnum != null)
        {
            object[] customAttributeComando = elementEnum.GetCustomAttributes(typeof(EComando), false);

            return (customAttributeComando.Length == 0) ? "" : ((EComando)customAttributeComando[0]).Service;
        }
        else
            return "";
    }
    public static String GetNomeItem(this ETipoPessoa tipo)
    {
        return Enum.GetName(typeof(ETipoPessoa), tipo);
    }
    public static T[] GetListEnumValue<T>(this ETipoPessoa tipo) where T : Enum
    {
        int qnt = 0;
        T[] origem = (T[])Enum.GetValues(tipo.GetType());

        int index = 0;

        foreach (var item in origem)
        {
            if (tipo.HasFlag(item))
            {
                qnt++;
            }
        }

        T[] destino = new T[qnt];

        foreach (var item in origem)
        {
            if (tipo.HasFlag(item))
            {
                destino.SetValue(item, index);
                index++;
            }
        }


        return destino;
    }

}

