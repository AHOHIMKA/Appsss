using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appsss
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoPage : ContentPage
    {
        public LogoPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //int ph = 1;
            //for (int i = 0; i <= 80; i++)
            //{

            //    photologo.Source = $"claw{ph}.png";
            //    await Task.Delay(1);
            //    ph++;
            //    if (ph == 20) { ph = 1; }

            //}

            //photologo.Source = "cat1.png";
            //await Task.Delay(1000);
            //photologo.Source = "cat2.png";
            //await Task.Delay(1000);
            //photologo.Source = "cat3.png";
            //await Task.Delay(1000);

            // Ждем 5 секунд перед переходом на главную страницу
            await Task.Delay(5000);

            // Переходим на MainPage
            var newPage = new AppShell(); 
            await Navigation.PushAsync(newPage);
           // await Navigation.PushAsync(new AppShell());
        }
    }
}