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
    public partial class SQL : ContentPage
    {
        public SQL()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(ent.Text,out int val))
            {
                var mile = UnitConverters.MilesToMeters(val);
                var mile2 = UnitConverters.MilesToKilometers(val);
                var unit = UnitConverters.PoundsToKilograms(val);
                lab.Text = $"Meters:{mile}, Kilometeres:{mile2}";
                lab2.Text = $"Kilograms:{unit}";
            }
        }
    }
}