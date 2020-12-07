using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Java : ContentPage
    {
        public Java()
        {
            InitializeComponent();
        }
        public class BrowserTest
    {
}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.google.ru/");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}