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
    public partial class fondback : Form
    {
        public fondback()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string result = "Bonjour ";
            TimeSpan calculage;
            Int32 age = 0;
            calculage = DateTime.Now.Subtract(dt_naissance.Value);
            age = calculage.Days / 365;

            if (txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_prénom.Text == "")
                {
                    MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (civilité.Checked && !Monsieur.Checked && !Madame.Checked)
                    {
                        MessageBox.Show("Aucune Civilité n'est sélectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (Madame.Checked)
                    {
                        result += " " + Madame.Text;
                    }
                    else
                    {
                        if (Monsieur.Checked)
                        {
                            result += " " + Monsieur.Text;
                        }
                    }



                    result += " " + txt_nom.Text;
                    result += " " + txt_prénom.Text;
                    result += " vous avez " + age + "ans";
                    if (age > 18)
                    {
                        result += " vous êtes majeur depuis " + (age - 18) + "ans";
                    }
                    else
                    {
                        if (age < 18)
                        {
                            result += " vous serez majeur dans " + (18 - age) + "ans";
                        }
                    }
                    txt_afficher.Text = result;



                }
            }
        }








        private void civilité_CheckedChanged(object sender, EventArgs e)
        {
            if (civilité.Checked)
            {
                Monsieur.Visible = true;
                Madame.Visible = true;
            }
            else
            {
                Monsieur.Visible = false;
                Madame.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (difficulteBox.SelectedItem == "Difficile")
            {
                this.BackColor = Color.Orange;
            }
            if (difficulteBox.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                label1.Font = new Font(label1.Font, FontStyle.Bold);
                civilité.Font = new Font(label1.Font, FontStyle.Bold);
                Monsieur.Font = new Font(label1.Font, FontStyle.Bold);
                Madame.Font = new Font(label1.Font, FontStyle.Bold);
                Nom.Font = new Font(label1.Font, FontStyle.Bold);
                Prénom.Font = new Font(label1.Font, FontStyle.Bold);
                dt_naissance.Font = new Font(label1.Font, FontStyle.Bold);
                difficulte.Font = new Font(label1.Font, FontStyle.Bold);
                difficulteBox.Font = new Font(label1.Font, FontStyle.Bold);
                label2.Font = new Font(label1.Font, FontStyle.Bold);
                txt_prénom.Font = new Font(label1.Font, FontStyle.Bold);
                txt_nom.Font = new Font(label1.Font, FontStyle.Bold);
                txt_afficher.Font = new Font(label1.Font, FontStyle.Bold);

            }
            if (difficulteBox.SelectedItem == "Moyen")
            {
                this.BackColor = Color.Yellow;
            }
            if (difficulteBox.SelectedItem == "Facile")
            {
                this.BackColor = Color.LightBlue; 
            }
        }
    }
}



