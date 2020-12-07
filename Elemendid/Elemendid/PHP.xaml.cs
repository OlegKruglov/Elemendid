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
    public partial class PHP : ContentPage
    {
        public PHP()
        {
            InitializeComponent();
            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            Info1.Text = $"Device Model:{device}";
            Info2.Text = $"Operating System:{version}";
            Info3.Text = $"Platform:{platform}";
        }
    }
}