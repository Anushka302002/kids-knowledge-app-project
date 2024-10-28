using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KKApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Marathi_Letters : ContentPage
    {
        public Marathi_Letters()
        {
            InitializeComponent();
        }

        private void अ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("a");
        }

        private void आ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("aaah");
        }

        private void इ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("E");
        }

        private void ई_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Ee");
        }

        private void उ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("uoh");
        }

        private void ऊ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("uoh");
        }

        private void ए_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("A");
        }

        private void ऐ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Aaii");
        }

        private void ओ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("O");
        }

        private void औ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("ou");
        }

        private void अं_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Ahm");
        }

        private void अः_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Aha");
        }
    }
}