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
    public partial class GsbFamille : Form
    {

        /// <summary>
        /// permet de remplir au chargement de la page le dataGridView
        /// grace au méthode chargerFamille()
        /// </summary>
        public GsbFamille()
        {
            InitializeComponent();
            List<Famille> LesFamilles = DAOFamille.chargerFamille();
            for (int i = 0; i < LesFamilles.Count(); i++)
            {
                Console.Write(i);
                dgvFamille.Rows.Add(LesFamilles[i].GetId(), LesFamilles[i].GetNom());
            }
        }
        /// <summary>
        /// Lorsqu'on click deux fois sur le dataGridView on vas remplir les information dans 
        /// les textes boxe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomMedClick = dgvFamille.Rows[e.RowIndex].Cells[0].Value;
            RemplirInfo(NomMedClick);
        }
        /// <summary>
        ///  Permet de remplir les champs des texte boxe
        /// </summary>
        /// <param name="nomMedClick"></param>
        private void RemplirInfo(object nomMedClick)
        {
            Famille LaFamille;
            LaFamille = DAOFamille.RemplirInfoMed(nomMedClick.ToString());
            txtReference.Text = LaFamille.GetId().ToString();
            txtNom.Text = LaFamille.GetNom();
        }
        /// <summary>
        /// Permet de recharger le dataGridView par rapport au nom que l'on met dans le texte box
        /// grâce à la méthode RechercherNomFamille(string nom)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechercherFamille_TextChanged(object sender, EventArgs e)
        {
            dgvFamille.Rows.Clear();
            List<Famille> LaFamille = DAOFamille.RechercherNomFamille(txtRechercherFamille.Text);
            for (int i = 0; i < LaFamille.Count(); i++)
            {
                Console.Write(i);
                dgvFamille.Rows.Add(LaFamille[i].GetId(), LaFamille[i].GetNom());
            }
        }
        /// <summary>
        /// Lorsqu'on appuie sur le bouton ajouter on appele la méthode CreerProduit pour l'ajouter à 
        /// la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(txtNom.Text);
            DAOFamille.CreerFamille(LaFamille);
        }
        /// <summary>
        /// Lorsqu'on appuie sur le bouton supprimer on appele la méthode SupprimerProduit pour supprimer dans 
        /// la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(Int32.Parse(txtReference.Text));
            DAOFamille.SupprimerFamille(LaFamille);
        }
        /// <summary>
        /// Lorsqu'on appuie sur le bouton modifier on appele la méthode ModifierProduit pour modifier 
        /// la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(Int32.Parse(txtReference.Text), txtNom.Text);
            DAOFamille.ModifierFamille(LaFamille);
        }
        /// <summary>
        /// On nettoie le DataGridView,
        /// Lorsqu'on appuie sur le bouton rafraichir on appele la méthode chargerFamille pour remplir
        /// le dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRafraichire_Click(object sender, EventArgs e)
        {
            dgvFamille.Rows.Clear();
            List<Famille> LesFamilles = DAOFamille.chargerFamille();
            for (int i = 0; i < LesFamilles.Count(); i++)
            {
                Console.Write(i);
                dgvFamille.Rows.Add(LesFamilles[i].GetId(), LesFamilles[i].GetNom());
            }
        }
    }
}
