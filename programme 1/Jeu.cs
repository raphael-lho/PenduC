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
        public Jeu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        public static void ChangerIMG(Int32 nbcmpt, PictureBox pb_pendu)
        {
            pb_pendu.Image = Properties.Resources.C1;
            pb_pendu.Refresh();
        }

        public static string motatrouver = "";

        public partial class Jeu : Form
        {
            public static string motatrouver = "";
        }
    }
}
