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
    public partial class Colors : ContentPage
    {
        public Colors()
        {
            InitializeComponent();
        }
        private void Yellow_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Yellow_Label.Text);
        }

        private void Blue_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Blue_Label.Text);
        }

        private void Pink_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Pink_Label.Text);
        }

        private void Green_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Green_Label.Text);
        }

        private void Red_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Red_Label.Text);
        }

        private void Purple_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Purple_Label.Text);
        }

        private void Orange_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Orange_Label.Text);
        }

        private void LightBlue_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(LightBlue_Label.Text);
        }

        private void Brown_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Brown_Label.Text);
        }

        private void LightGreen_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(LightGreen_Label.Text);
        }

        private void White_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(White_Label.Text);
        }

        private void Black_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(Black_Label.Text);
        }
    }
}