using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListView.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.ConfigXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Lista> obj = new List<Lista>();
            obj.Add(new Lista{Nome = "Pedro", Sexo = "M"});
            obj.Add(new Lista{Nome = "Joao", Sexo = "M"});
            obj.Add(new Lista{Nome = "Larrisa", Sexo = "F"});
            obj.Add(new Lista{Nome = "THAIS", Sexo = "F"});
            obj.Add(new Lista{Nome = "JUAN", Sexo = "M"});
            obj.Add(new Lista{Nome = "TETEU", Sexo = "F"});
            LISTAVIEW.ItemsSource = obj;
        }
    }
}