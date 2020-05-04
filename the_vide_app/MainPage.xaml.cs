using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace the_vide_app
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == bomb)
            {
                await DisplayAlert("Ouch!", "Well, try again m8..", "Ancearca dinnou.");
                bomb = new Random().Next(1, 4).ToString();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Welcome to The ViDE app!", "Here is the start of your fashionify journey!", "Cool!");
        }
    }
}
