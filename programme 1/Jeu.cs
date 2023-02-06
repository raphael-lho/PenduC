using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_1
{
    public partial class Jeu : Form
    {

        public static string motatrouver = "VOITURE";
        public static string motaafficher = "_______";
        public static int compteur = 0;

    
        public Jeu()
        {
            InitializeComponent();
        }

        public static void ChangerIMG(Int32 nbcmpt, PictureBox pb_pendu)
        {
            pb_pendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("C" + nbcmpt);
            pb_pendu.Refresh();
        }

        public static void Verifier(String lettretape, TextBox txt_afficher)
        {
            bool verif = false;
            string generationMot = "";
            for (int i = 0; i < motatrouver.Length; i++)
        {
                if (motatrouver[i] == Convert.ToChar(lettretape))
                {

        }
                else
                {

                }
            }

            if (!verif)
        {

            }

            motaafficher = generationMot;
            txt_afficher.Text = motaafficher;
        }

        private void btn_A_click(DataObjectMethodType sender, EventArgs e)
        {

        }
    }
}
