﻿using Perron.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Outros
{
    public class BuscarItemGenerico<T>
    {

        public EventHandlerGenerico<T> EventoTermino;

       private FrmBuscarItem _view = new FrmBuscarItem();
        public BuscarItemGenerico(List<T> Lista)
        {
            _view.PopularLista<T>(Lista);
        }
        private DialogResult AbrirTelaDialor()
        {
           return _view.ShowDialog();
        }
        private void NotificarEvento(T item)
        {
            if (EventoTermino != null)
            {
                EventoTermino(this, new EventArgsGenerico<T> {Item = item});
            }
        }
       private T GetItem()
        {
            return _view.GetItemSelecionado<T>();
        }


       public void Buscar()
        {
           if(AbrirTelaDialor() == DialogResult.OK)
            {
                _view.Close();
                NotificarEvento(GetItem());
            }
        }


        
    }
}
