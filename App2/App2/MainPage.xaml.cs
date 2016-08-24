using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class NavigationPage : ContentPage
    {
        private Menu menu;

        public NavigationPage()
        {
            InitializeComponent();
        }

        public NavigationPage(Menu menu)
        {
            this.menu = menu;
        }

        async void login (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }
}
