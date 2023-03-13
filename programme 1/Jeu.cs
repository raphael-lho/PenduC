using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace programme_1
{
    public partial class Jeu : Form

    {
        public static string motatrouver;
        public static string motaafficher;
        public static int compteur = 1;
        public Int32 dureeTotal = 0;
        public Int32 dureeCout = 0;

        private int totaltimer;
        public Timer timer;

        List<string> listeMotaTrouver;


        public Jeu()

        {

            Init();

        }
        public Jeu(String LePrenomNomDuJoueur, String LaDifficulteChoisi)
        {
            Init();
            txt_PrenomNom.Text = LePrenomNomDuJoueur;
            txt_difficulte.Text = LaDifficulteChoisi;

            //timer
            timer = new Timer(); //Instancie un objet timer de la classe 
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
  
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dureeTotal++;
            progressBar.Increment(1);
            textBoxTimer.Text = dureeTotal + " secondes";

            if (progressBar.Value == 10)
            {
                compteur++;
                ChangerIMG(compteur, pb_pendu);
                progressBar.Value=(0);
                dureeCout++;
                victoire();
            }
        }





        private void Init()
        {
            InitializeComponent();
            listeMotaTrouver = new List<string> { "Francophile", "Chlorophylle", "Conspirateur", "Qualification", "Attraction", "Cornemuse", "Tourisme", "Diapason", "Brouhaha" };
            motatrouver = choisirMotATrouver(listeMotaTrouver);
            motaafficher = genererMotAfficher(motatrouver);
            txt_motAtrouver.Text = motaafficher;
        }
      
        

        private void btn_Z_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
                
            Verifier((sender as Button).Text.ToString(), txt_motAtrouver);

            ChangerIMG(compteur, pb_pendu);
            dureeCout = 0;

            (sender as Button).Enabled = false;

            victoire();
        }

        public void victoire()

        {

            DialogResult msg;

            if (compteur >= 9)
            {
                timer.Stop();

                msg = MessageBox.Show("Vous avez perdu !! \r\nVous deviez trouver le mot: " + motatrouver + "\r\nVoulez vous faire une autre partie ??",

                "You loose",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Exclamation,

                MessageBoxDefaultButton.Button1);

                if (msg == DialogResult.Yes)
                {
                    remiseAZero(txt_motAtrouver, listeMotaTrouver);
                }

                else
                {
                    fondback Accueil = new fondback();

                    Accueil.Show();

                    this.Hide();
                }
            }

            if (motatrouver == motaafficher)
            {
                timer.Stop();

                msg = MessageBox.Show("Bravo, vous avez gagné !! \r\nVous avez trouver le mot: " + motatrouver + " En " + dureeTotal + " secondes.\r\nVoulez vous faire une autre partie ??",

                "You win",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.None,

                MessageBoxDefaultButton.Button1);

                if (msg == DialogResult.Yes)
                {
                    remiseAZero(txt_motAtrouver, listeMotaTrouver);
                }

                else
                {
                    fondback Accueil = new fondback();
                    Accueil.Show();
                    this.Hide();
                }
            }
        }

        public void remiseAZero(TextBox txt, List<String> listeATrouver)

        {

            motaafficher = "";

            motatrouver = "";

            compteur = 1;

            motatrouver = choisirMotATrouver(listeATrouver);

            motaafficher = genererMotAfficher(motatrouver);

            txt.Text = motaafficher;

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                    c.Enabled = true;
            }

            ChangerIMG(compteur, pb_pendu);
            dureeTotal = 0;
            timer.Start();
        }

        public static void Verifier(String lettretape, TextBox txt_afficher)

        {

            bool lettreOK = false;

            int I = 0;

            char[] cArray = motatrouver.ToCharArray();

            char[] motaff = motaafficher.ToCharArray();

            motaafficher = "";
            while (I < motatrouver.Length)
            {
                if (cArray[I] == Convert.ToChar(lettretape))
                {
                    motaafficher += lettretape;
                    lettreOK = true;
                }
                else
                    motaafficher += motaff[I];
                I++;
            }
            if (!lettreOK) compteur++;
            txt_afficher.Text = motaafficher;
        }
        public static void ChangerIMG(Int32 nbcmpt, PictureBox pb_pendu)
        {
            switch (nbcmpt)
            {
                case 1:
                    pb_pendu.Image = Properties.Resources.C1;
                    pb_pendu.Refresh();
                    break;
                case 2:
                    pb_pendu.Image = Properties.Resources.C2;
                    pb_pendu.Refresh();
                    break;
                case 3:
                    pb_pendu.Image = Properties.Resources.C3;
                    pb_pendu.Refresh();
                    break;
                case 4:
                    pb_pendu.Image = Properties.Resources.C4;
                    pb_pendu.Refresh();
                    break;
                case 5:
                    pb_pendu.Image = Properties.Resources.C5;
                    pb_pendu.Refresh();
                    break;
                case 6:
                    pb_pendu.Image = Properties.Resources.C6;
                    pb_pendu.Refresh();
                    break;
                case 7:
                    pb_pendu.Image = Properties.Resources.C7;
                    pb_pendu.Refresh();
                    break;
                case 8:
                    pb_pendu.Image = Properties.Resources.C8;
                    pb_pendu.Refresh();
                    break;
                case 9:
                    pb_pendu.Image = Properties.Resources.C9;
                    pb_pendu.Refresh();
                    break;
            }
        }

        public string genererMotAfficher(String mottrouver)
        {
            string motaff = "";
            int I = 0;

            while (I < mottrouver.Length)
            {
                motaff += "_ ";
                I++;
            }
            return motaff;
        }

        public string choisirMotATrouver(List<String> listeATrouver)
        {
            Random aleatoire = new Random();
            int nbAleatoire = aleatoire.Next(listeATrouver.Count);
            string motchoisi = listeATrouver[nbAleatoire].ToUpper();
            return motchoisi;
        }

      
    }
}
