using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KKApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }


        private void Letters_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Letters());
            TextToSpeech.SpeakAsync("letters");

        }

        private void Numbers_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Numbers());
            TextToSpeech.SpeakAsync("numbers");

        }

        private void Colors_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Colors());
            TextToSpeech.SpeakAsync("colors");

        }

        private void Animals_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Animals());
            TextToSpeech.SpeakAsync("animals");

        }

        private void Birds_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Birds());
            TextToSpeech.SpeakAsync("birds");

        }

        private void Fruits_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fruits());
            TextToSpeech.SpeakAsync("fruits");

        }

        private void Flowers_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Flowers());
            TextToSpeech.SpeakAsync("flowers");

        }

        private void Puzzles_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Puzzles());
            TextToSpeech.SpeakAsync("puzzles");

        }

        private void ArithematicOperation_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Arithematic_Operation());
            TextToSpeech.SpeakAsync("Arithematic operation");

        }

        private void MarathiLetters_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Marathi_Letters());
            TextToSpeech.SpeakAsync("marathi letters");

        }

        private void Vegetables_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Vegetables());
            TextToSpeech.SpeakAsync("vegetables");

        }

        private void Poems_Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Poems());
            TextToSpeech.SpeakAsync("poems");

        }
    }
}
