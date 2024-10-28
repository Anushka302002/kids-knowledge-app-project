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
	public partial class Fruits : ContentPage
	{
		public Fruits ()
		{
			InitializeComponent ();
		}

        private void apple(object sender, EventArgs e)
        {

            TextToSpeech.SpeakAsync("Apple");
        }
        private void lemon(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("lemon");
        }
        private void grapes(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("grapes");
        }
        private void orange(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("orange");
        }
        private void strawberry(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("strawberry");
        }
        private void mango(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("mango");

        }
        private void banana(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("banana");
        }
        private void watermelon(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("watermelon");
        }
        private void pineapple(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("pineapple");
        }
        private void coconut(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("coconut");
        }

    }
}