using AppPerron.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppPerron.Controller
{


    public class ControllerInicial : Application
    {

       InicialViewModel _viewModel;

        public ControllerInicial()
        {
            _viewModel = new InicialViewModel();

            _viewModel.Tittle = "teste";
        }

    }
}
