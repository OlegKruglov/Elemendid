using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Pyt_btn = new Button { Text = "Vibrate" };
            Button JS_btn = new Button { Text = "Flashlight" };
            Button J_btn = new Button { Text = "Browser" };
            Button C_btn = new Button { Text = "C" };
            Button PHP_btn = new Button { Text = "Device Info" };
            Button SQL_btn = new Button { Text = "SQL" };
            Button TTS_btn = new Button { Text = "Text to Speech" };
            Button Map_btn = new Button { Text = "Map" };
            StackLayout st = new StackLayout();
            st.Children.Add(Pyt_btn);
            st.Children.Add(JS_btn);
            st.Children.Add(J_btn);
            st.Children.Add(C_btn);
            st.Children.Add(PHP_btn);
            st.Children.Add(SQL_btn);
            st.Children.Add(TTS_btn);
            st.Children.Add(Map_btn);
            Content = st;
            Pyt_btn.Clicked += Pyt_btn_Clicked;
            TTS_btn.Clicked += TTS_btn_Clicked;
            Map_btn.Clicked += Map_btn_Clicked;
            JS_btn.Clicked += JS_btn_Clicked;
            J_btn.Clicked += J_btn_Clicked;
            PHP_btn.Clicked += PHP_btn_Clicked;
        }

        private async void PHP_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PHP());
        }

        private async void J_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Java());
        }

        private async void JS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JavaScript());
        }

        private async void Map_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }

        private async void TTS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextToSpeech());
        }

        private async void Pyt_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Python());
        }
    }
}
