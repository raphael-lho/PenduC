using programme_1.Modele;
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
    public partial class menu : Form
    {
        
        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            Pan_SubForm.Controls.Add(formEnfant);
            Pan_SubForm.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        public menu()
        {
            InitializeComponent();
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(Pan_SubForm);
            SF.openChildForm(new fondback());
        }
    }
}
