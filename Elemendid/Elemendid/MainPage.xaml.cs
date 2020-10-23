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
            Button Pyt_btn = new Button { Text = "Python" };
            Button JS_btn = new Button { Text = "JavaScript" };
            Button J_btn = new Button { Text = "Java" };
            Button CS_btn = new Button { Text = "C#" };
            Button C_btn = new Button { Text = "C" };
            Button Swift_btn = new Button { Text = "Swift" };
            Button PHP_btn = new Button { Text = "PHP" };
            Button SQL_btn = new Button { Text = "SQL" };
            StackLayout st = new StackLayout();
            st.Children.Add(Pyt_btn);
            st.Children.Add(JS_btn);
            st.Children.Add(J_btn);
            st.Children.Add(CS_btn);
            st.Children.Add(C_btn);
            st.Children.Add(Swift_btn);
            st.Children.Add(PHP_btn);
            st.Children.Add(SQL_btn);
            Content = st;
            Pyt_btn.Clicked += Pyt_btn_Clicked;
        }

        private async void Pyt_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Python());
        }
    }
}
