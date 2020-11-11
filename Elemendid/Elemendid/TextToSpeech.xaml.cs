using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeech : ContentPage
    {
        float Volume_;
        float Pitch_;
        public TextToSpeech()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SpeechOptions settings = new SpeechOptions()
            {
                Volume = Volume_,
                Pitch = Pitch_,
            };
            if (ent.Text != null) { await Xamarin.Essentials.TextToSpeech.SpeakAsync(ent.Text, settings); }
        }
        private void pit_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Volume_ = (float)vol.Value;
        }

        private void vol_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Pitch_ = (float)pit.Value;
        }
    }
}