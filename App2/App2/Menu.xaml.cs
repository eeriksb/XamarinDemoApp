using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        async void add_place(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformationPage());
        }
    }
}
