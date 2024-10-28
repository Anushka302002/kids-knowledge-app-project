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

        private void Apple_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Apple");
        }

        private void Lemon_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Lemon");
        }

        private void Grapes_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Grapes");
        }

        private void Orange_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Orange");
        }

        private void Strawberry_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Strawberry");
        }

        private void Mango_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Mango");
        }

        private void Banana_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Banana");
        }

        private void Watermelon_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Watermelon");
        }

        private void Pineapple_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Pineapple");
        }

        private void Cococnut_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Coconut");
        }
    }
}