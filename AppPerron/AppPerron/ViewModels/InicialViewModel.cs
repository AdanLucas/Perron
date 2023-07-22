using AppPerron.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppPerron.ViewModels
{
    public class InicialViewModel: BaseViewModel
    {
        public string Tittle { get=> tittle;   set => SetProperty(ref tittle, value);  }

        public string tittle;
        public Image Imagem{ get; set; }

        private ViewPrincial _view;

        public InicialViewModel()
        {
            _view = new ViewPrincial();
            _view.BindingContext = this;
            Application.Current.MainPage = _view;
        }

    }
}
