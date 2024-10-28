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
	public partial class Birds : ContentPage
	{
		public Birds ()
		{
			InitializeComponent ();
		}

        private void Peacock_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Peacock");
        }

        private void Parrot_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Parrot");
        }

        private void Crow_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Crow");
        }

        private void Sparrow_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Sparrow");
        }

        private void Owl_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Owl");
        }

        private void Pigeon_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Pigeon");
        }

        private void Duck_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Duck");
        }

        private void Cock_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Cock");
        }

        private void Swan_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Swan");
        }

        private void penguin_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Penguin");
        }
    }
}