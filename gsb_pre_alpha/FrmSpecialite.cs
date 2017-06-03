using applicationGSB;
using PreparationBaseDeDonne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_pre_alpha
{
    public partial class FrmSpecialite : Form
    {
        public FrmSpecialite()
        {
            InitializeComponent();

            List<Specialite> LesSpecialites = Specialite.chargerSpecialite();
            for (int i = 0; i < LesSpecialites.Count(); i++)
            {
                Console.Write(i);
                dgvListSpécialite.Rows.Add(LesSpecialites[i].Id, LesSpecialites[i].Nom);
            }
        }

        /// <summary>
        ///  Permet de remplir les champs des texte boxe au click dans une ligne du tableau
        /// </summary>
        /// <param name="sender"></param>
        private void dgvListSpécialite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           int IdSpeClick = int.Parse(dgvListSpécialite.Rows[e.RowIndex].Cells[0].Value.ToString());
            RemplirInfo(IdSpeClick);
        }

        /// <summary>
        ///  Permet de remplir les champs des texte boxe
        /// </summary>
        /// <param name="IdSpeClick"></param>
        private void RemplirInfo(int IdSpeClick)
        {
            Specialite LaSpe;
            LaSpe = DaoSpecialite.RechercherSpecialiteParId(IdSpeClick); 
            txbIdSpe.Text = LaSpe.Id.ToString();
            txbNomSpe.Text = LaSpe.Nom;
        }

        /// <summary>
        ///  Permet de créer un nouvel objet spécialite dans la bdd
        /// </summary>
        /// <param name="sender"></param>
        private void btnAjouterSpe_Click(object sender, EventArgs e)
        {
            Specialite LaSpe = new Specialite(int.Parse(null), txbNomSpe.Text);
            DaoSpecialite.CreerSpecialite(LaSpe);
        }

        /// <summary>
        ///  Permet de modifier une spécialite dans la bdd
        /// </summary>
        /// <param name="sender"></param>
        private void btnModifierSpe_Click(object sender, EventArgs e)
        {
            Specialite LaSpe = new Specialite(int.Parse(txbIdSpe.Text), txbNomSpe.Text);
            DaoSpecialite.ModifierSpecialite(LaSpe);
        }

        /// <summary>
        ///  Permet de supprimer une spécialite dans la bdd
        /// </summary>
        /// <param name="sender"></param>
        private void btnSupprimerSpe_Click(object sender, EventArgs e)
        {
            Specialite LaSpe = new Specialite(Int32.Parse(txbIdSpe.Text), null);
            DaoSpecialite.SupprimerSpecialite(LaSpe);
        }

        /// <summary>
        ///  vide les textbox du formulaire
        /// </summary>
        /// <param name="sender"></param>
        private void btnAnnulerSpe_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in Parent.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                    ctl.Text = "";
            }
        }

        /// <summary>
        ///  Permet de rafraichir le tableau
        /// </summary>
        /// <param name="sender"></param>
        private void btnRafraichirSpe_Click(object sender, EventArgs e)
        {
            List<Specialite> LesSpecialites = Specialite.chargerSpecialite();
            for (int i = 0; i < LesSpecialites.Count(); i++)
            {
                Console.Write(i);
                dgvListSpécialite.Rows.Add(LesSpecialites[i].Id, LesSpecialites[i].Nom);
            }
        }

    }
}
