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
	public partial class Animals : ContentPage
	{
		public Animals ()
		{
			InitializeComponent ();
		}

        private void Elephant_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Elephant");
        }

        private void Lion_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Lion");
        }

        private void Tiger_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Tiger");
        }

        private void zebra_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("zebra");
        }

        private void Camel_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Camel");
        }

        private void Cow_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Cow");
        }

        private void Giraffe_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Giraffe");
        }

        private void Horse_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Horse");
        }

        private void Cat_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Cat");
        }

        private void Dog_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Dog");
        }

       
    }
}