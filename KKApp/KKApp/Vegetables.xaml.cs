using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KKApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vegetables : ContentPage
    {
        public Vegetables()
        {
            InitializeComponent();
        }

        private void Tomato_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Tomato");
        }

        private void Capsicum_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Capsicum");
        }

        private void Carrot_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Carrot");
        }

        private void Pumpkin_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Pumpkin");
        }

        private void Cucumber_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Cucumber");
        }

        private void Beetroot_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Beetroot");
        }

        private void Onion_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Onion");
        }

        

        private void LadyFinger_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("LadyFinger");
        }

        private void Brinjal_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Brinjal");
        }

        private void Potato_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Potato");
        }
    }
}