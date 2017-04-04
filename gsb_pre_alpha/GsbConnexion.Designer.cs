namespace gsb_pre_alpha
{
    partial class GSBConnexion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblRep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratoire Galaxy Swiss Bourdin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(175, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(289, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login : ";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(426, 217);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(133, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdp.Location = new System.Drawing.Point(426, 281);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(133, 20);
            this.txtMdp.TabIndex = 5;
            // 
            // btnConnection
            // 
            this.btnConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConnection.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnConnection.Location = new System.Drawing.Point(388, 391);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(195, 32);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblRep
            // 
            this.lblRep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRep.AutoSize = true;
            this.lblRep.ForeColor = System.Drawing.Color.Red;
            this.lblRep.Location = new System.Drawing.Point(463, 345);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(0, 13);
            this.lblRep.TabIndex = 7;
            this.lblRep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GSBConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1112, 523);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GSBConnexion";
            this.Text = "GSB Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblRep;
    }
}

