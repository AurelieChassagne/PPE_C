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
            this.btnChoixSpe = new System.Windows.Forms.Button();
            this.cbxChoixSpe = new System.Windows.Forms.ComboBox();
            this.lblChoixSpe = new System.Windows.Forms.Label();
            this.dgvListPraticien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.gbxDataPrat = new System.Windows.Forms.GroupBox();
            this.txbCoefConfPrat = new System.Windows.Forms.TextBox();
            this.txbCoefNotPrat = new System.Windows.Forms.TextBox();
            this.txtSpecialitePrat = new System.Windows.Forms.TextBox();
            this.lblCoefConfPrat = new System.Windows.Forms.Label();
            this.lblCoefNotPrat = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txbMailPrat = new System.Windows.Forms.TextBox();
            this.txbRaisonSocialPrat = new System.Windows.Forms.TextBox();
            this.txbAdressePrat = new System.Windows.Forms.TextBox();
            this.txbContactNomPrat = new System.Windows.Forms.TextBox();
            this.txbTelPrat = new System.Windows.Forms.TextBox();
            this.txbCodePrat = new System.Windows.Forms.TextBox();
            this.lblMailPrat = new System.Windows.Forms.Label();
            this.lblContactNomPrat = new System.Windows.Forms.Label();
            this.lblTelPrat = new System.Windows.Forms.Label();
            this.lblCodePrat = new System.Windows.Forms.Label();
            this.lblRaisonSocial = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.cbxChoisirPrat = new System.Windows.Forms.ComboBox();
            this.lblChoisirPrat = new System.Windows.Forms.Label();
            this.lblPraticiens = new System.Windows.Forms.Label();
            this.lblFichePrat = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noù = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPraticien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxDataPrat.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.btnChoixSpe);
            this.tabPage3.Controls.Add(this.cbxChoixSpe);
            this.tabPage3.Controls.Add(this.lblChoixSpe);
            this.tabPage3.Controls.Add(this.dgvListPraticien);
            this.tabPage3.Controls.Add(this.btnConfirmer);
            this.tabPage3.Controls.Add(this.gbxDataPrat);
            this.tabPage3.Controls.Add(this.cbxChoisirPrat);
            this.tabPage3.Controls.Add(this.lblChoisirPrat);
            this.tabPage3.Controls.Add(this.lblPraticiens);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1073, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Les praticiens";
            // 
            // btnChoixSpe
            // 
            this.btnChoixSpe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChoixSpe.Font = new System.Drawing.Font("Impact", 7.25F);
            this.btnChoixSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoixSpe.Location = new System.Drawing.Point(418, 96);
            this.btnChoixSpe.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoixSpe.Name = "btnChoixSpe";
            this.btnChoixSpe.Size = new System.Drawing.Size(80, 23);
            this.btnChoixSpe.TabIndex = 21;
            this.btnChoixSpe.Text = "Ok";
            this.btnChoixSpe.UseVisualStyleBackColor = false;
            // 
            // cbxChoixSpe
            // 
            this.cbxChoixSpe.FormattingEnabled = true;
            this.cbxChoixSpe.Location = new System.Drawing.Point(212, 99);
            this.cbxChoixSpe.Name = "cbxChoixSpe";
            this.cbxChoixSpe.Size = new System.Drawing.Size(175, 21);
            this.cbxChoixSpe.TabIndex = 20;
            // 
            // lblChoixSpe
            // 
            this.lblChoixSpe.AutoSize = true;
            this.lblChoixSpe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixSpe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblChoixSpe.Location = new System.Drawing.Point(26, 99);
            this.lblChoixSpe.Name = "lblChoixSpe";
            this.lblChoixSpe.Size = new System.Drawing.Size(152, 17);
            this.lblChoixSpe.TabIndex = 19;
            this.lblChoixSpe.Text = "Choisir une spécialité :";
            // 
            // dgvListPraticien
            // 
            this.dgvListPraticien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListPraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPraticien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.noù,
            this.adresse,
            this.telephone,
            this.email,
            this.specialite});
            this.dgvListPraticien.Location = new System.Drawing.Point(29, 134);
            this.dgvListPraticien.Name = "dgvListPraticien";
            this.dgvListPraticien.Size = new System.Drawing.Size(491, 320);
            this.dgvListPraticien.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(104, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 57);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(16, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(205, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(109, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmer.Font = new System.Drawing.Font("Impact", 7.25F);
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmer.Location = new System.Drawing.Point(418, 69);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(80, 23);
            this.btnConfirmer.TabIndex = 16;
            this.btnConfirmer.Text = "Ok";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            // 
            // gbxDataPrat
            // 
            this.gbxDataPrat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDataPrat.Controls.Add(this.lblFichePrat);
            this.gbxDataPrat.Controls.Add(this.txbCoefConfPrat);
            this.gbxDataPrat.Controls.Add(this.txbCoefNotPrat);
            this.gbxDataPrat.Controls.Add(this.txtSpecialitePrat);
            this.gbxDataPrat.Controls.Add(this.groupBox2);
            this.gbxDataPrat.Controls.Add(this.lblCoefConfPrat);
            this.gbxDataPrat.Controls.Add(this.lblCoefNotPrat);
            this.gbxDataPrat.Controls.Add(this.lblSpecialite);
            this.gbxDataPrat.Controls.Add(this.txbMailPrat);
            this.gbxDataPrat.Controls.Add(this.txbRaisonSocialPrat);
            this.gbxDataPrat.Controls.Add(this.txbAdressePrat);
            this.gbxDataPrat.Controls.Add(this.txbContactNomPrat);
            this.gbxDataPrat.Controls.Add(this.txbTelPrat);
            this.gbxDataPrat.Controls.Add(this.txbCodePrat);
            this.gbxDataPrat.Controls.Add(this.lblMailPrat);
            this.gbxDataPrat.Controls.Add(this.lblContactNomPrat);
            this.gbxDataPrat.Controls.Add(this.lblTelPrat);
            this.gbxDataPrat.Controls.Add(this.lblCodePrat);
            this.gbxDataPrat.Controls.Add(this.lblRaisonSocial);
            this.gbxDataPrat.Controls.Add(this.lblAdresse);
            this.gbxDataPrat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDataPrat.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxDataPrat.Location = new System.Drawing.Point(531, 29);
            this.gbxDataPrat.Name = "gbxDataPrat";
            this.gbxDataPrat.Size = new System.Drawing.Size(526, 425);
            this.gbxDataPrat.TabIndex = 15;
            this.gbxDataPrat.TabStop = false;
            // 
            // txbCoefConfPrat
            // 
            this.txbCoefConfPrat.Location = new System.Drawing.Point(228, 304);
            this.txbCoefConfPrat.Name = "txbCoefConfPrat";
            this.txbCoefConfPrat.Size = new System.Drawing.Size(183, 26);
            this.txbCoefConfPrat.TabIndex = 19;
            // 
            // txbCoefNotPrat
            // 
            this.txbCoefNotPrat.Location = new System.Drawing.Point(228, 272);
            this.txbCoefNotPrat.Name = "txbCoefNotPrat";
            this.txbCoefNotPrat.Size = new System.Drawing.Size(183, 26);
            this.txbCoefNotPrat.TabIndex = 18;
            // 
            // txtSpecialitePrat
            // 
            this.txtSpecialitePrat.Location = new System.Drawing.Point(161, 240);
            this.txtSpecialitePrat.Name = "txtSpecialitePrat";
            this.txtSpecialitePrat.Size = new System.Drawing.Size(250, 26);
            this.txtSpecialitePrat.TabIndex = 17;
            // 
            // lblCoefConfPrat
            // 
            this.lblCoefConfPrat.AutoSize = true;
            this.lblCoefConfPrat.Location = new System.Drawing.Point(19, 307);
            this.lblCoefConfPrat.Name = "lblCoefConfPrat";
            this.lblCoefConfPrat.Size = new System.Drawing.Size(203, 20);
            this.lblCoefConfPrat.TabIndex = 16;
            this.lblCoefConfPrat.Text = "Coefficient de confiance :";
            // 
            // lblCoefNotPrat
            // 
            this.lblCoefNotPrat.AutoSize = true;
            this.lblCoefNotPrat.Location = new System.Drawing.Point(18, 275);
            this.lblCoefNotPrat.Name = "lblCoefNotPrat";
            this.lblCoefNotPrat.Size = new System.Drawing.Size(194, 20);
            this.lblCoefNotPrat.TabIndex = 15;
            this.lblCoefNotPrat.Text = "Coefficient de notoriété :";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(21, 243);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(88, 20);
            this.lblSpecialite.TabIndex = 14;
            this.lblSpecialite.Text = "Spécialité :";
            // 
            // txbMailPrat
            // 
            this.txbMailPrat.Location = new System.Drawing.Point(195, 201);
            this.txbMailPrat.Name = "txbMailPrat";
            this.txbMailPrat.Size = new System.Drawing.Size(308, 26);
            this.txbMailPrat.TabIndex = 13;
            // 
            // txbRaisonSocialPrat
            // 
            this.txbRaisonSocialPrat.Location = new System.Drawing.Point(366, 54);
            this.txbRaisonSocialPrat.Name = "txbRaisonSocialPrat";
            this.txbRaisonSocialPrat.Size = new System.Drawing.Size(137, 26);
            this.txbRaisonSocialPrat.TabIndex = 12;
            // 
            // txbAdressePrat
            // 
            this.txbAdressePrat.Location = new System.Drawing.Point(102, 127);
            this.txbAdressePrat.Name = "txbAdressePrat";
            this.txbAdressePrat.Size = new System.Drawing.Size(401, 26);
            this.txbAdressePrat.TabIndex = 11;
            // 
            // txbContactNomPrat
            // 
            this.txbContactNomPrat.Location = new System.Drawing.Point(253, 92);
            this.txbContactNomPrat.Name = "txbContactNomPrat";
            this.txbContactNomPrat.Size = new System.Drawing.Size(250, 26);
            this.txbContactNomPrat.TabIndex = 10;
            // 
            // txbTelPrat
            // 
            this.txbTelPrat.Location = new System.Drawing.Point(253, 169);
            this.txbTelPrat.Name = "txbTelPrat";
            this.txbTelPrat.Size = new System.Drawing.Size(250, 26);
            this.txbTelPrat.TabIndex = 9;
            // 
            // txbCodePrat
            // 
            this.txbCodePrat.Location = new System.Drawing.Point(78, 55);
            this.txbCodePrat.Name = "txbCodePrat";
            this.txbCodePrat.Size = new System.Drawing.Size(56, 26);
            this.txbCodePrat.TabIndex = 8;
            // 
            // lblMailPrat
            // 
            this.lblMailPrat.AutoSize = true;
            this.lblMailPrat.Location = new System.Drawing.Point(21, 204);
            this.lblMailPrat.Name = "lblMailPrat";
            this.lblMailPrat.Size = new System.Drawing.Size(134, 20);
            this.lblMailPrat.TabIndex = 7;
            this.lblMailPrat.Text = "Mail du contact :";
            // 
            // lblContactNomPrat
            // 
            this.lblContactNomPrat.AutoSize = true;
            this.lblContactNomPrat.Location = new System.Drawing.Point(18, 95);
            this.lblContactNomPrat.Name = "lblContactNomPrat";
            this.lblContactNomPrat.Size = new System.Drawing.Size(137, 20);
            this.lblContactNomPrat.TabIndex = 6;
            this.lblContactNomPrat.Text = "Nom du contact :";
            // 
            // lblTelPrat
            // 
            this.lblTelPrat.AutoSize = true;
            this.lblTelPrat.Location = new System.Drawing.Point(21, 172);
            this.lblTelPrat.Name = "lblTelPrat";
            this.lblTelPrat.Size = new System.Drawing.Size(93, 20);
            this.lblTelPrat.TabIndex = 5;
            this.lblTelPrat.Text = "Téléphone :";
            // 
            // lblCodePrat
            // 
            this.lblCodePrat.AutoSize = true;
            this.lblCodePrat.Location = new System.Drawing.Point(19, 57);
            this.lblCodePrat.Name = "lblCodePrat";
            this.lblCodePrat.Size = new System.Drawing.Size(59, 20);
            this.lblCodePrat.TabIndex = 2;
            this.lblCodePrat.Text = "Code :";
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.AutoSize = true;
            this.lblRaisonSocial.Location = new System.Drawing.Point(240, 57);
            this.lblRaisonSocial.Name = "lblRaisonSocial";
            this.lblRaisonSocial.Size = new System.Drawing.Size(120, 20);
            this.lblRaisonSocial.TabIndex = 3;
            this.lblRaisonSocial.Text = "Raison sociale :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(21, 127);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(75, 20);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse :";
            // 
            // cbxChoisirPrat
            // 
            this.cbxChoisirPrat.FormattingEnabled = true;
            this.cbxChoisirPrat.Location = new System.Drawing.Point(212, 71);
            this.cbxChoisirPrat.Name = "cbxChoisirPrat";
            this.cbxChoisirPrat.Size = new System.Drawing.Size(175, 21);
            this.cbxChoisirPrat.TabIndex = 14;
            // 
            // lblChoisirPrat
            // 
            this.lblChoisirPrat.AutoSize = true;
            this.lblChoisirPrat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoisirPrat.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblChoisirPrat.Location = new System.Drawing.Point(26, 72);
            this.lblChoisirPrat.Name = "lblChoisirPrat";
            this.lblChoisirPrat.Size = new System.Drawing.Size(140, 17);
            this.lblChoisirPrat.TabIndex = 13;
            this.lblChoisirPrat.Text = "Choisir un praticien :";
            // 
            // lblPraticiens
            // 
            this.lblPraticiens.AutoSize = true;
            this.lblPraticiens.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPraticiens.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPraticiens.Location = new System.Drawing.Point(30, 14);
            this.lblPraticiens.Name = "lblPraticiens";
            this.lblPraticiens.Size = new System.Drawing.Size(261, 44);
            this.lblPraticiens.TabIndex = 12;
            this.lblPraticiens.Text = "Les praticiens";
            // 
            // lblFichePrat
            // 
            this.lblFichePrat.AutoSize = true;
            this.lblFichePrat.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblFichePrat.Location = new System.Drawing.Point(19, 17);
            this.lblFichePrat.Name = "lblFichePrat";
            this.lblFichePrat.Size = new System.Drawing.Size(154, 22);
            this.lblFichePrat.TabIndex = 20;
            this.lblFichePrat.Text = "Fiche praticien :";
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            // 
            // noù
            // 
            this.noù.HeaderText = "Nom";
            this.noù.Name = "noù";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // specialite
            // 
            this.specialite.HeaderText = "Spécialité";
            this.specialite.Name = "specialite";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPraticien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxDataPrat.ResumeLayout(false);
            this.gbxDataPrat.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvListPraticien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.GroupBox gbxDataPrat;
        private System.Windows.Forms.TextBox txbCoefConfPrat;
        private System.Windows.Forms.TextBox txbCoefNotPrat;
        private System.Windows.Forms.TextBox txtSpecialitePrat;
        private System.Windows.Forms.Label lblCoefConfPrat;
        private System.Windows.Forms.Label lblCoefNotPrat;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txbMailPrat;
        private System.Windows.Forms.TextBox txbRaisonSocialPrat;
        private System.Windows.Forms.TextBox txbAdressePrat;
        private System.Windows.Forms.TextBox txbContactNomPrat;
        private System.Windows.Forms.TextBox txbTelPrat;
        private System.Windows.Forms.TextBox txbCodePrat;
        private System.Windows.Forms.Label lblMailPrat;
        private System.Windows.Forms.Label lblContactNomPrat;
        private System.Windows.Forms.Label lblTelPrat;
        private System.Windows.Forms.Label lblCodePrat;
        private System.Windows.Forms.Label lblRaisonSocial;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.ComboBox cbxChoisirPrat;
        private System.Windows.Forms.Label lblChoisirPrat;
        private System.Windows.Forms.Label lblPraticiens;
        private System.Windows.Forms.Button btnChoixSpe;
        private System.Windows.Forms.ComboBox cbxChoixSpe;
        private System.Windows.Forms.Label lblChoixSpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn noù;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialite;
        private System.Windows.Forms.Label lblFichePrat;
    }
}