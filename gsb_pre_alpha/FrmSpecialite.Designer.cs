namespace gsb_pre_alpha
{
    partial class FrmSpecialite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpecialite));
            this.dgvListSpécialite = new System.Windows.Forms.DataGridView();
            this.gbxDataPrat = new System.Windows.Forms.GroupBox();
            this.lblFichePrat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRafraichirSpe = new System.Windows.Forms.Button();
            this.btnAnnulerSpe = new System.Windows.Forms.Button();
            this.btnAjouterSpe = new System.Windows.Forms.Button();
            this.btnSupprimerSpe = new System.Windows.Forms.Button();
            this.btnModifierSpe = new System.Windows.Forms.Button();
            this.txbNomSpe = new System.Windows.Forms.TextBox();
            this.txbIdSpe = new System.Windows.Forms.TextBox();
            this.lblIdSpe = new System.Windows.Forms.Label();
            this.lblNomSpe = new System.Windows.Forms.Label();
            this.lblSpe = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSpécialite)).BeginInit();
            this.gbxDataPrat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListSpécialite
            // 
            this.dgvListSpécialite.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListSpécialite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSpécialite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom});
            this.dgvListSpécialite.Location = new System.Drawing.Point(24, 65);
            this.dgvListSpécialite.Name = "dgvListSpécialite";
            this.dgvListSpécialite.Size = new System.Drawing.Size(526, 151);
            this.dgvListSpécialite.TabIndex = 26;
            this.dgvListSpécialite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSpécialite_CellContentClick);
            // 
            // gbxDataPrat
            // 
            this.gbxDataPrat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDataPrat.Controls.Add(this.lblFichePrat);
            this.gbxDataPrat.Controls.Add(this.groupBox2);
            this.gbxDataPrat.Controls.Add(this.txbNomSpe);
            this.gbxDataPrat.Controls.Add(this.txbIdSpe);
            this.gbxDataPrat.Controls.Add(this.lblIdSpe);
            this.gbxDataPrat.Controls.Add(this.lblNomSpe);
            this.gbxDataPrat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDataPrat.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxDataPrat.Location = new System.Drawing.Point(24, 225);
            this.gbxDataPrat.Name = "gbxDataPrat";
            this.gbxDataPrat.Size = new System.Drawing.Size(526, 212);
            this.gbxDataPrat.TabIndex = 25;
            this.gbxDataPrat.TabStop = false;
            // 
            // lblFichePrat
            // 
            this.lblFichePrat.AutoSize = true;
            this.lblFichePrat.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblFichePrat.Location = new System.Drawing.Point(19, 17);
            this.lblFichePrat.Name = "lblFichePrat";
            this.lblFichePrat.Size = new System.Drawing.Size(202, 22);
            this.lblFichePrat.TabIndex = 20;
            this.lblFichePrat.Text = "Créer une spécialité :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRafraichirSpe);
            this.groupBox2.Controls.Add(this.btnAnnulerSpe);
            this.groupBox2.Controls.Add(this.btnAjouterSpe);
            this.groupBox2.Controls.Add(this.btnSupprimerSpe);
            this.groupBox2.Controls.Add(this.btnModifierSpe);
            this.groupBox2.Location = new System.Drawing.Point(43, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 57);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btnRafraichirSpe
            // 
            this.btnRafraichirSpe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRafraichirSpe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRafraichirSpe.BackgroundImage")));
            this.btnRafraichirSpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRafraichirSpe.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnRafraichirSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRafraichirSpe.Location = new System.Drawing.Point(16, 14);
            this.btnRafraichirSpe.Name = "btnRafraichirSpe";
            this.btnRafraichirSpe.Size = new System.Drawing.Size(35, 36);
            this.btnRafraichirSpe.TabIndex = 23;
            this.btnRafraichirSpe.UseVisualStyleBackColor = false;
            this.btnRafraichirSpe.Click += new System.EventHandler(this.btnRafraichirSpe_Click);
            // 
            // btnAnnulerSpe
            // 
            this.btnAnnulerSpe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerSpe.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnulerSpe.Location = new System.Drawing.Point(61, 13);
            this.btnAnnulerSpe.Name = "btnAnnulerSpe";
            this.btnAnnulerSpe.Size = new System.Drawing.Size(87, 37);
            this.btnAnnulerSpe.TabIndex = 22;
            this.btnAnnulerSpe.Text = "Annuler";
            this.btnAnnulerSpe.UseVisualStyleBackColor = false;
            this.btnAnnulerSpe.Click += new System.EventHandler(this.btnAnnulerSpe_Click);
            // 
            // btnAjouterSpe
            // 
            this.btnAjouterSpe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouterSpe.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouterSpe.Location = new System.Drawing.Point(155, 13);
            this.btnAjouterSpe.Name = "btnAjouterSpe";
            this.btnAjouterSpe.Size = new System.Drawing.Size(87, 37);
            this.btnAjouterSpe.TabIndex = 8;
            this.btnAjouterSpe.Text = "Ajouter";
            this.btnAjouterSpe.UseVisualStyleBackColor = false;
            this.btnAjouterSpe.Click += new System.EventHandler(this.btnAjouterSpe_Click);
            // 
            // btnSupprimerSpe
            // 
            this.btnSupprimerSpe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimerSpe.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSupprimerSpe.Location = new System.Drawing.Point(345, 13);
            this.btnSupprimerSpe.Name = "btnSupprimerSpe";
            this.btnSupprimerSpe.Size = new System.Drawing.Size(87, 38);
            this.btnSupprimerSpe.TabIndex = 10;
            this.btnSupprimerSpe.Text = "Supprimer";
            this.btnSupprimerSpe.UseVisualStyleBackColor = false;
            this.btnSupprimerSpe.Click += new System.EventHandler(this.btnSupprimerSpe_Click);
            // 
            // btnModifierSpe
            // 
            this.btnModifierSpe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifierSpe.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSpe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifierSpe.Location = new System.Drawing.Point(249, 13);
            this.btnModifierSpe.Name = "btnModifierSpe";
            this.btnModifierSpe.Size = new System.Drawing.Size(87, 37);
            this.btnModifierSpe.TabIndex = 9;
            this.btnModifierSpe.Text = "Modifier";
            this.btnModifierSpe.UseVisualStyleBackColor = false;
            this.btnModifierSpe.Click += new System.EventHandler(this.btnModifierSpe_Click);
            // 
            // txbNomSpe
            // 
            this.txbNomSpe.Location = new System.Drawing.Point(187, 92);
            this.txbNomSpe.Name = "txbNomSpe";
            this.txbNomSpe.Size = new System.Drawing.Size(137, 26);
            this.txbNomSpe.TabIndex = 12;
            // 
            // txbIdSpe
            // 
            this.txbIdSpe.Location = new System.Drawing.Point(187, 54);
            this.txbIdSpe.Name = "txbIdSpe";
            this.txbIdSpe.Size = new System.Drawing.Size(56, 26);
            this.txbIdSpe.TabIndex = 8;
            // 
            // lblIdSpe
            // 
            this.lblIdSpe.AutoSize = true;
            this.lblIdSpe.Location = new System.Drawing.Point(19, 57);
            this.lblIdSpe.Name = "lblIdSpe";
            this.lblIdSpe.Size = new System.Drawing.Size(91, 20);
            this.lblIdSpe.TabIndex = 2;
            this.lblIdSpe.Text = "Identifiant :";
            // 
            // lblNomSpe
            // 
            this.lblNomSpe.AutoSize = true;
            this.lblNomSpe.Location = new System.Drawing.Point(19, 95);
            this.lblNomSpe.Name = "lblNomSpe";
            this.lblNomSpe.Size = new System.Drawing.Size(125, 20);
            this.lblNomSpe.TabIndex = 3;
            this.lblNomSpe.Text = "Nom spécialité :";
            // 
            // lblSpe
            // 
            this.lblSpe.AutoSize = true;
            this.lblSpe.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSpe.Location = new System.Drawing.Point(30, 9);
            this.lblSpe.Name = "lblSpe";
            this.lblSpe.Size = new System.Drawing.Size(279, 44);
            this.lblSpe.TabIndex = 22;
            this.lblSpe.Text = "Les Spécialités";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom Spécialité";
            this.Nom.MinimumWidth = 10;
            this.Nom.Name = "Nom";
            // 
            // FrmSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 455);
            this.Controls.Add(this.dgvListSpécialite);
            this.Controls.Add(this.gbxDataPrat);
            this.Controls.Add(this.lblSpe);
            this.Name = "FrmSpecialite";
            this.Text = "FrmSpecialite";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSpécialite)).EndInit();
            this.gbxDataPrat.ResumeLayout(false);
            this.gbxDataPrat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListSpécialite;
        private System.Windows.Forms.GroupBox gbxDataPrat;
        private System.Windows.Forms.Label lblFichePrat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRafraichirSpe;
        private System.Windows.Forms.Button btnAnnulerSpe;
        private System.Windows.Forms.Button btnAjouterSpe;
        private System.Windows.Forms.Button btnSupprimerSpe;
        private System.Windows.Forms.Button btnModifierSpe;
        private System.Windows.Forms.TextBox txbNomSpe;
        private System.Windows.Forms.TextBox txbIdSpe;
        private System.Windows.Forms.Label lblIdSpe;
        private System.Windows.Forms.Label lblNomSpe;
        private System.Windows.Forms.Label lblSpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    }
}