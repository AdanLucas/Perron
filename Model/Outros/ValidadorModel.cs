using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


public static class ValidadorModel
{
    public static void ValidarModeloLancaExcecao(object obj)
    {
        var resultadoValidacao = new List<ValidationResult>();

        var contexto = new ValidationContext(obj, null, null);

        Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);

        if (resultadoValidacao.Count > 0)
        {
            IList<String> listaMensagensErros = resultadoValidacao.Select(x => x.ErrorMessage).ToList();

            string textoErros = String.Join("\r\n", listaMensagensErros);

            throw new ValidationException(textoErros);
        }
    }
}

