using System;
using System.Collections.Generic;

namespace Model.Model
{
    public class PIzza
    {
        public string DescricaoSabor { get { return GetDescricaoSabor(); } }
        public List<SaborModel> Sabores { get; set; }
        public TamanhoModel Tamanho { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPizza { get; set; }
        public List<Object> Adicionais { get; set; }

        private string GetDescricaoSabor()
        {
            string retorno = "";

            if (Sabores != null || Sabores.Count > 0)
            {
                if (Sabores.Count == 1)
                    return Sabores[0].Descricao;

                else
                {
                    foreach (var sabor in Sabores)
                    {
                        retorno += $"1/{Sabores.Count.ToString()}-{sabor.Descricao}  ";

                    }
                }
            }
            return "Seleciona Um Sabor";
        }

    }

}
