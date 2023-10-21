using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Triangulo_MVVM_RERM.ViewModel
{
    public class VMCalcuTriangulo : BaseViewModel
    {
        string _tipo;
        float _base;
        float _altura;
        float _lado1;
        float _lado2;
        float _areaTriangulo;
        public VMCalcuTriangulo(INavigation navigation)
        {
            Navigation = navigation;
        }
        public string Tipo
        {
            get { return _tipo; }
            set { SetValue(ref _tipo, value); }
        }
        public float Base
        {
            get { return _base; }
            set { SetValue(ref _base, value); }
        }
        public float Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public float Lado1
        {
            get { return _lado1; }
            set { SetValue(ref _lado1, value); }
        }
        public float Lado2
        {
            get { return _lado2; }
            set { SetValue(ref _lado2, value); }
        }
        public float AreaTriangulo
        {
            get { return _areaTriangulo; }
            set { SetValue(ref _areaTriangulo, value); }
        }
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularTriangulo(float b, float a)
        {
            AreaTriangulo = (b * a) / 2;
        }
        public async void BtnCalcularTriangulo()
        {
            CalcularTriangulo(Base, Altura);
            if(Base <= 0 || Altura <= 0 || Lado1 <= 0 || Lado2 <= 0)
            {
                Tipo = "No es un triángulo (Base, Altura y lados deben ser números positivos)";
            }
            else
            {
                if(Base == Lado1 && Base == Lado2)
                {
                    Tipo = "Es un triángulo Equilátero";
                }
                else if(Base == Lado1 || Lado1 == Lado2 || Base == Lado2)
                {
                    Tipo = "Es un triángulo Isósceles";
                }
                else
                {
                    Tipo = "Es un triángulo Escaleno";
                }
            }
            await DisplayAlert("Estado", Tipo, "Sair");
        }
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularIMCCommand => new Command(BtnCalcularTriangulo);
    }
}
