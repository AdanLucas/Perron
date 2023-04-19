using Perron.View.Forms;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Presenter
{
    public  class BuscarItemGenerico<T>
    {

        public EventHandlerGenerico<T> EventoTermino;

       private FrmBuscarItem _view = new FrmBuscarItem();

        
        public BuscarItemGenerico()
        {
            _view.PopularLista<T>(ServiceDinamico<T>.GetLista());
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


       public T Get()
        {
            if (AbrirTelaDialor() == DialogResult.OK)
            {
                return GetItem();
            }
            else 
            {
                throw new Exception("Cancelado Pelo usuario");
            }
            
        }


        
    }
}
