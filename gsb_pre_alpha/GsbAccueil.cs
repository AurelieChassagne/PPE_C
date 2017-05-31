using applicationGSB;
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
    public partial class GsbAccueil : Form
    {
        /// <summary>
        /// permet de remplir au chargement de la page le dataGridView et le comboBoxe
        /// grace au méthode chargerProduit() et chargerFamille()
        /// </summary>
        public GsbAccueil()
        {
            InitializeComponent();
            List<Produit> LesProduits = DAOProduit.chargerProduit();
            for (int i = 0; i < LesProduits.Count(); i++)
            {
                Famille fam = DAOFamille.RechercherFamille(LesProduits[i]);
                Console.Write(i);
                dgvProduits.Rows.Add(LesProduits[i].GetNom(), LesProduits[i].GetDosage(), LesProduits[i].Getprix(),
                    LesProduits[i].GetContreIndic(), LesProduits[i].GetEfets(), fam.GetNom());
            }


            List<Famille> LesFamille = DAOFamille.chargerFamille();
            for (int i = 0; i < LesFamille.Count(); i++)
            {
                Console.Write(i);
                cbxFamille.Items.Add(LesFamille[i].GetNom());
            }
        }
        /// <summary>
        /// Permet de recharger le dataGridView par rapport au nom que l'on met dans le texte box
        /// grâce à la méthode RechercheProduit(string nom)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechercherProduit_TextChanged(object sender, EventArgs e)
        {
            dgvProduits.Rows.Clear();
            List<Produit> LeProduit = DAOProduit.RechercherProduit(txtRechercherProduit.Text);
            for (int i = 0; i < LeProduit.Count(); i++)
            {
                Famille fam = DAOFamille.RechercherFamille(LeProduit[i]);
                Console.Write(i);
                dgvProduits.Rows.Add(LeProduit[i].GetNom(), LeProduit[i].GetDosage(), LeProduit[i].Getprix(),
                    LeProduit[i].GetContreIndic(), LeProduit[i].GetEfets(), fam.GetNom());
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
            Famille LaFamille = DAOFamille.RechercherIdFamille(cbxFamille.Text.ToString());
            Produit LeProduit = new Produit(txtNom.Text, txtDosage.Text, Double.Parse(txtPrix.Text), txtContre.Text,
                txtEffet.Text, LaFamille.GetId());
            DAOProduit.CreerProduit(LeProduit);
        }
        /// <summary>
        /// Lorsqu'on appuie sur le bouton modifier on appele la méthode ModifierProduit pour modifier 
        /// la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Famille LaFamille = DAOFamille.RechercherIdFamille(cbxFamille.Text.ToString());
            Produit LeProduit = new Produit(Int32.Parse(txtReference.Text), txtNom.Text, txtDosage.Text, 
                Double.Parse(txtPrix.Text), txtContre.Text, txtEffet.Text, LaFamille.GetId());
            DAOProduit.ModifierProduit(LeProduit);
        }
        /// <summary>
        /// Lorsqu'on appuie sur le bouton supprimer on appele la méthode SupprimerProduit pour supprimer dans 
        /// la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Produit LeProduit = new Produit(Int32.Parse(txtReference.Text));
            DAOProduit.SupprimerProduit(LeProduit);
        }
        /// <summary>
        /// On nettoie le DataGridView,
        /// Lorsqu'on appuie sur le bouton rafraichir on appele la méthode chargerProduit pour remplir
        /// le dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRafraichire_Click(object sender, EventArgs e)
        {
            dgvProduits.Rows.Clear();
            List<Produit> LesProduits = DAOProduit.chargerProduit();
            for (int i = 0; i < LesProduits.Count(); i++)
            {
                Famille fam = DAOFamille.RechercherFamille(LesProduits[i]);
                Console.Write(i);
                dgvProduits.Rows.Add(LesProduits[i].GetNom(), LesProduits[i].GetDosage(), LesProduits[i].Getprix(),
                    LesProduits[i].GetContreIndic(), LesProduits[i].GetEfets(), fam.GetNom());
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
            object NomMedClick = dgvProduits.Rows[e.RowIndex].Cells[0].Value;
            RemplirInfo(NomMedClick);
        }
        /// <summary>
        /// Permet de remplir les champs des texte boxe
        /// </summary>
        /// <param name="nomMedClick"></param>
        private void RemplirInfo(object nomMedClick)
        {
            Produit LeProduits;
            LeProduits = DAOProduit.RemplirInfoMed(nomMedClick.ToString());
            txtReference.Text = LeProduits.GetReference().ToString();
            txtNom.Text = LeProduits.GetNom();
            txtDosage.Text = LeProduits.GetDosage();
            txtPrix.Text = LeProduits.Getprix().ToString();
            txtEffet.Text = LeProduits.GetEfets();
            txtContre.Text = LeProduits.GetContreIndic();
            Famille LaFamille = DAOFamille.RechercherFamille(LeProduits);
            cbxFamille.Text = LaFamille.GetNom();
        }
        /// <summary>
        /// Permet d'ouvrire une autre forme pour aller modifier, ajouter, supprimer les familles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFamille_Click_1(object sender, EventArgs e)
        {
            GsbFamille frmFamille = new GsbFamille();
            frmFamille.Show();
        }
    }
}
