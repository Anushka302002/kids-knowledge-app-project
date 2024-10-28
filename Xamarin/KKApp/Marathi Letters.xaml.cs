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
    public partial class Marathi_Letters : ContentPage
    {
        public Marathi_Letters()
        {
            InitializeComponent();
        }

        private void अ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(अ_Label.Text);
        }

        private void आ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(आ_Label.Text);
        }

        private void इ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(इ_Label.Text);
        }

        private void ई_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(ई_Label.Text);
        }

        private void उ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(उ_Label.Text);
        }

        private void ऊ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(ऊ_Label.Text);
        }

        private void ए_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(ए_Label.Text);
        }

        private void ऐ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(ऐ_Label.Text);
        }

        private void ओ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(ओ_Label.Text);
        }

        private void औ_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(औ_Label.Text);
        }

        private void अं_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(अं_Label.Text);
        }

        private void अः_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(अः_Label.Text);
        }
    }
}