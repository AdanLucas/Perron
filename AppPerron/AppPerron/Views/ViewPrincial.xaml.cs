using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPerron.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPrincial : ContentPage
    {

        public string tittle;

        public ViewPrincial()
        {
            InitializeComponent();
        }
    }
}