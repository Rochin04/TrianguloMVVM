using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulo_MVVM_RERM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Triangulo_MVVM_RERM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTriangulo : ContentPage
    {
        public ViewTriangulo()
        {
            InitializeComponent();
            BindingContext = new VMCalcuTriangulo(Navigation);
        }
    }
}