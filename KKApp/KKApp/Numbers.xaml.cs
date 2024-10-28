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
    public partial class Numbers : ContentPage
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void zero_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("zero");
        }
        private void one_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("one");
        }

        private void two_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("two");
        }

        private void three_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("three");
        }

        private void four_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("four");
        }

        private void five_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("ive");
        }

        private void six_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("six");
        }

        private void seven_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("seven");
        }

        private void eight_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("eight");
        }

        private void nine_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("nine");
        }

       
    }
}