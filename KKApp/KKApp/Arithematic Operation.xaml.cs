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
    public partial class Arithematic_Operation : ContentPage
    {
        public Arithematic_Operation()
        {
            InitializeComponent();
            TextToSpeech.SpeakAsync("welcome to Arithmetic operation");
        }

        public float a, b, c;



        private void ADD_BUTTON_Clicked(object sender, EventArgs e)

        {
            TextToSpeech.SpeakAsync("Addition");
            if (FirstNumber_Entry.Text != string.Empty)
            {

                a = Convert.ToInt32(FirstNumber_Entry.Text);
                b = Convert.ToInt32(SecondNumber_Entry.Text);
                c = a + b;
                OP_Label.Text = c.ToString();
            }

        }
        private void SUB_BUTTON_Clicked(object sender, EventArgs e)
        {

            TextToSpeech.SpeakAsync("substract");
            if (FirstNumber_Entry.Text != string.Empty)
            {

                a = Convert.ToInt32(FirstNumber_Entry.Text);
                b = Convert.ToInt32(SecondNumber_Entry.Text);
                c = a - b;
                OP_Label.Text = c.ToString();
            }

        }
        private void DIV_BUTTON_Clicked(object sender, EventArgs e)
        {

            TextToSpeech.SpeakAsync("Division");
           
                a = Convert.ToInt32(FirstNumber_Entry.Text);
                b = Convert.ToInt32(SecondNumber_Entry.Text);
                c = (a / b);
                OP_Label.Text = c.ToString();


           





        }
        private void MUL_BUTTON_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Multiplication");
            if (FirstNumber_Entry.Text != string.Empty)
            {

                a = Convert.ToInt32(FirstNumber_Entry.Text);
                b = Convert.ToInt32(SecondNumber_Entry.Text);
                c = a * b;
                OP_Label.Text = c.ToString();
            }

        }

        private void RESET_BUTTON_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Reset");
            FirstNumber_Entry.Text = "";
            SecondNumber_Entry.Text = string.Empty;

            OP_Label.Text = "Output";
            c = 0; a = 0; b = 0;

        }

    }
}



























       