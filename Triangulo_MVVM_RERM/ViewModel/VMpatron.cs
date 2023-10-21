using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Triangulo_MVVM_RERM.ViewModel
{
    public class VMpatron : BaseViewModel
    {
        string _texto;
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        public string Texto
        {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        }
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
    }
}
