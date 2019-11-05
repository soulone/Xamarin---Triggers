using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();



            Item1.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new Trigger.Data());

            };
            Item2.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new Trigger.Event());
            };

            Item3.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new Trigger.Propertly());

            };
            Item4.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new Trigger.Style());

            };

            Item5.Clicked += async (sender, e) =>
            {
             await Navigation.PushAsync(new Trigger.MultiTrigger());

            };


        }
    }
}
