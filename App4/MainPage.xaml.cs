using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToolbarItem About = new ToolbarItem()
            {
                Text = "О программе",
                Order = ToolbarItemOrder.Secondary,
                Priority = 2
            };
            ToolbarItems.Add(About);
            About.Clicked += About_Clicked;

            ToolbarItem Garbage = new ToolbarItem()
            {
                Text = "Помойка",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1
            };
            ToolbarItems.Add(Garbage);
        }

        private async void About_Clicked(object sender, EventArgs e) => await DisplayAlert("О программе", "Сделано\nРожновым Владимиром\nE-mail: Rozhnov.vova@gmail.com", "Закрыть");
       

        private void StartButtnForCloseApp_Clicked(object sender, EventArgs e) => Environment.Exit(0);

    }
}
