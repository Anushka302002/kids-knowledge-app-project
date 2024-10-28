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
    public partial class Letters : ContentPage
    {
        public Letters()
        {
            InitializeComponent();
        }
        private void A_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("A");
        }

        private void J_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("J");
        }

        private void T_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("T");
        }

        private void B_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("B");
        }

        private void C_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("C");
        }

        private void D_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("D");
        }

        private void E_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("E");
        }

        private void F_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("F");
        }

        private void G_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("G");
        }

        private void H_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("H");
        }

        private void I_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("I");
        }

        private void K_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("K");
        }

        private void L_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("L");
        }

        private void M_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("M");
        }

        private void N_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("N");
        }

        private void O_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("O");
        }

        private void P_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("P");
        }

        private void Q_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Q");
        }

        private void R_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("R");
        }

        private void S_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("S");
        }

        private void U_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("U");
        }

        private void V_Label_Clicked(object sender, EventArgs e)
        {
          TextToSpeech.SpeakAsync("V");
        }

        private void W_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("W");
        }

        private void X_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("X");
        }

        private void Y_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Y");
        }

        private void Z_Label_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("zed");
        }
    }
}