namespace gsb_pre_alpha
{
    partial class GsbAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFamille = new System.Windows.Forms.Button();
            this.btnRafraichire = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffetThera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContreIndic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFamille = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEffet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRechercherProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.btnFamille);
            this.tabPage1.Controls.Add(this.btnRafraichire);
            this.tabPage1.Controls.Add(this.btnSupprimer);
            this.tabPage1.Controls.Add(this.btnModifier);
            this.tabPage1.Controls.Add(this.btnAjouter);
            this.tabPage1.Controls.Add(this.dgvProduits);
            this.tabPage1.Controls.Add(this.cbxFamille);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtContre);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtEffet);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtPrix);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDosage);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.txtReference);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtRechercherProduit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Les produits";
            // 
            // btnFamille
            // 
            this.btnFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamille.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFamille.Location = new System.Drawing.Point(493, 98);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Size = new System.Drawing.Size(110, 38);
            this.btnFamille.TabIndex = 24;
            this.btnFamille.Text = "Famille";
            this.btnFamille.UseVisualStyleBackColor = true;
            this.btnFamille.Click += new System.EventHandler(this.btnFamille_Click_1);
            // 
            // btnRafraichire
            // 
            this.btnRafraichire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichire.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRafraichire.Location = new System.Drawing.Point(609, 98);
            this.btnRafraichire.Name = "btnRafraichire";
            this.btnRafraichire.Size = new System.Drawing.Size(110, 38);
            this.btnRafraichire.TabIndex = 23;
            this.btnRafraichire.Text = "Rafraichire";
            this.btnRafraichire.UseVisualStyleBackColor = true;
            this.btnRafraichire.Click += new System.EventHandler(this.btnRafraichire_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimer.Location = new System.Drawing.Point(725, 98);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 38);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnModifier.Location = new System.Drawing.Point(841, 98);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 38);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouter.Location = new System.Drawing.Point(957, 98);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 38);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Dosage,
            this.Prix,
            this.EffetThera,
            this.ContreIndic,
            this.Famille});
            this.dgvProduits.Location = new System.Drawing.Point(423, 140);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.Size = new System.Drawing.Size(644, 329);
            this.dgvProduits.TabIndex = 19;
            this.dgvProduits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduits_CellDoubleClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Dosage
            // 
            this.Dosage.HeaderText = "Dosage";
            this.Dosage.Name = "Dosage";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // EffetThera
            // 
            this.EffetThera.HeaderText = "Effet therapeutique";
            this.EffetThera.Name = "EffetThera";
            // 
            // ContreIndic
            // 
            this.ContreIndic.HeaderText = "Contre Indication";
            this.ContreIndic.Name = "ContreIndic";
            // 
            // Famille
            // 
            this.Famille.HeaderText = "Famille";
            this.Famille.Name = "Famille";
            // 
            // cbxFamille
            // 
            this.cbxFamille.FormattingEnabled = true;
            this.cbxFamille.Location = new System.Drawing.Point(90, 201);
            this.cbxFamille.Name = "cbxFamille";
            this.cbxFamille.Size = new System.Drawing.Size(253, 21);
            this.cbxFamille.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(10, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Famille :";
            // 
            // txtContre
            // 
            this.txtContre.Location = new System.Drawing.Point(10, 356);
            this.txtContre.Multiline = true;
            this.txtContre.Name = "txtContre";
            this.txtContre.Size = new System.Drawing.Size(357, 84);
            this.txtContre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(10, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Contre indication :";
            // 
            // txtEffet
            // 
            this.txtEffet.Location = new System.Drawing.Point(13, 250);
            this.txtEffet.Multiline = true;
            this.txtEffet.Name = "txtEffet";
            this.txtEffet.Size = new System.Drawing.Size(357, 84);
            this.txtEffet.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(10, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Effet therapeutique :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(230, 172);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(68, 20);
            this.txtPrix.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(175, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prix :";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(90, 175);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(68, 20);
            this.txtDosage.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dosage :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(243, 140);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(123, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(110, 140);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(68, 20);
            this.txtReference.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(187, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Référence :";
            // 
            // txtRechercherProduit
            // 
            this.txtRechercherProduit.Location = new System.Drawing.Point(190, 62);
            this.txtRechercherProduit.Name = "txtRechercherProduit";
            this.txtRechercherProduit.Size = new System.Drawing.Size(153, 20);
            this.txtRechercherProduit.TabIndex = 3;
            this.txtRechercherProduit.TextChanged += new System.EventHandler(this.txtRechercherProduit_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechercher produit :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(372, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les produits";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Les visiteurs";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1073, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Les praticiens";
            // 
            // GsbAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1105, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "GsbAccueil";
            this.Text = "GsbAccueil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRafraichire;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.ComboBox cbxFamille;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEffet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRechercherProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffetThera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContreIndic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
        private System.Windows.Forms.Button btnFamille;
    }
}