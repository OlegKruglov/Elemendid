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
            Button Tbl_btn = new Button { Text = "Table Page" };
            Button Date_btn = new Button { Text = "Date" };
            Button btn2 = new Button { Text = "Page3" };
            Button btn3 = new Button { Text = "Page4" };
            Button btn4 = new Button { Text = "Page5" };
            Button btn5 = new Button { Text = "Page6" };
            Button btn6 = new Button { Text = "Page7" };
            Button btn7 = new Button { Text = "Page8" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            st.Children.Add(Date_btn);
            st.Children.Add(btn2);
            st.Children.Add(btn3);
            st.Children.Add(btn4);
            st.Children.Add(btn5);
            st.Children.Add(btn6);
            st.Children.Add(btn7);
            Content = st;
            Tbl_btn.Clicked += Tbl_btn_Clicked;
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table());
        }
    }
}
