namespace programme_1
{
    partial class fondback
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_prénom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.Label();
            this.Monsieur = new System.Windows.Forms.RadioButton();
            this.Madame = new System.Windows.Forms.RadioButton();
            this.dt_naissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.civilité = new System.Windows.Forms.CheckBox();
            this.difficulteBox = new System.Windows.Forms.ComboBox();
            this.difficulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réponse";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_afficher
            // 
            this.txt_afficher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Location = new System.Drawing.Point(246, 42);
            this.txt_afficher.Multiline = true;
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(471, 77);
            this.txt_afficher.TabIndex = 1;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(304, 371);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(126, 70);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Push Me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_prénom
            // 
            this.txt_prénom.Location = new System.Drawing.Point(304, 229);
            this.txt_prénom.Name = "txt_prénom";
            this.txt_prénom.Size = new System.Drawing.Size(291, 20);
            this.txt_prénom.TabIndex = 4;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(132, 185);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 3;
            this.Nom.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(304, 182);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(291, 20);
            this.txt_nom.TabIndex = 6;
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(132, 232);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(49, 13);
            this.Prénom.TabIndex = 5;
            this.Prénom.Text = "Prénom :";
            // 
            // Monsieur
            // 
            this.Monsieur.AutoSize = true;
            this.Monsieur.Location = new System.Drawing.Point(304, 137);
            this.Monsieur.Name = "Monsieur";
            this.Monsieur.Size = new System.Drawing.Size(37, 17);
            this.Monsieur.TabIndex = 7;
            this.Monsieur.TabStop = true;
            this.Monsieur.Text = "Mr";
            this.Monsieur.UseVisualStyleBackColor = true;
            this.Monsieur.Visible = false;
            // 
            // Madame
            // 
            this.Madame.AutoSize = true;
            this.Madame.Location = new System.Drawing.Point(451, 137);
            this.Madame.Name = "Madame";
            this.Madame.Size = new System.Drawing.Size(48, 17);
            this.Madame.TabIndex = 8;
            this.Madame.TabStop = true;
            this.Madame.Text = "Mme";
            this.Madame.UseVisualStyleBackColor = true;
            this.Madame.Visible = false;
            // 
            // dt_naissance
            // 
            this.dt_naissance.Location = new System.Drawing.Point(304, 272);
            this.dt_naissance.Name = "dt_naissance";
            this.dt_naissance.Size = new System.Drawing.Size(186, 20);
            this.dt_naissance.TabIndex = 9;
            this.dt_naissance.Value = new System.DateTime(2004, 9, 4, 16, 23, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date de Naissance :";
            // 
            // civilité
            // 
            this.civilité.AutoSize = true;
            this.civilité.Location = new System.Drawing.Point(135, 133);
            this.civilité.Name = "civilité";
            this.civilité.Size = new System.Drawing.Size(65, 17);
            this.civilité.TabIndex = 11;
            this.civilité.Text = "Civilité ?";
            this.civilité.UseVisualStyleBackColor = true;
            this.civilité.CheckedChanged += new System.EventHandler(this.civilité_CheckedChanged);
            // 
            // difficulteBox
            // 
            this.difficulteBox.FormattingEnabled = true;
            this.difficulteBox.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile",
            "Enfer"});
            this.difficulteBox.Location = new System.Drawing.Point(304, 320);
            this.difficulteBox.Name = "difficulteBox";
            this.difficulteBox.Size = new System.Drawing.Size(121, 21);
            this.difficulteBox.TabIndex = 12;
            this.difficulteBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // difficulte
            // 
            this.difficulte.AutoSize = true;
            this.difficulte.Location = new System.Drawing.Point(132, 323);
            this.difficulte.Name = "difficulte";
            this.difficulte.Size = new System.Drawing.Size(54, 13);
            this.difficulte.TabIndex = 13;
            this.difficulte.Text = "Difficulté :";
            // 
            // fondback
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 560);
            this.Controls.Add(this.difficulte);
            this.Controls.Add(this.difficulteBox);
            this.Controls.Add(this.civilité);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_naissance);
            this.Controls.Add(this.Madame);
            this.Controls.Add(this.Monsieur);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.txt_prénom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_afficher);
            this.Controls.Add(this.label1);
            this.Name = "fondback";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
     


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_prénom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.RadioButton Monsieur;
        private System.Windows.Forms.RadioButton Madame;
        private System.Windows.Forms.DateTimePicker dt_naissance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox civilité;
        private System.Windows.Forms.ComboBox difficulteBox;
        private System.Windows.Forms.Label difficulte;
    }
}

