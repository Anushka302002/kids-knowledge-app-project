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
	public partial class Flowers : ContentPage
	{
		public Flowers ()
		{
			InitializeComponent ();
		}

        private void Rose_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Rose");
        }

        private void Sunflower_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Sunflower");
        }

        private void Marigold_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Marigold");
        }

        private void Lotus_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Lotus");
        }

        private void Lily_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Lily");
        }

        private void Hibiscus_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Hibiscus");
        }

        private void Tulip_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Tulip");
        }

        private void Daisy_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Daisy");
        }

        private void Mogra_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Mogra");
        }

        private void Dahlia_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Dahlia");
        }
    }
}