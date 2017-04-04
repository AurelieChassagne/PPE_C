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
        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Famille LaFamille = DAOFamille.RechercherIdFamille(cbxFamille.Text.ToString());
            Produit LeProduit = new Produit(txtNom.Text, txtDosage.Text, Double.Parse(txtPrix.Text), txtContre.Text,
                txtEffet.Text, LaFamille.GetId());
            DAOProduit.CreerProduit(LeProduit);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Famille LaFamille = DAOFamille.RechercherIdFamille(cbxFamille.Text.ToString());
            Produit LeProduit = new Produit(Int32.Parse(txtReference.Text), txtNom.Text, txtDosage.Text, 
                Double.Parse(txtPrix.Text), txtContre.Text, txtEffet.Text, LaFamille.GetId());
            DAOProduit.ModifierProduit(LeProduit);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Produit LeProduit = new Produit(Int32.Parse(txtReference.Text));
            DAOProduit.SupprimerProduit(LeProduit);
        }

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

        private void dgvProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomMedClick = dgvProduits.Rows[e.RowIndex].Cells[0].Value;
            RemplirInfo(NomMedClick);
        }

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

        private void btnFamille_Click(object sender, EventArgs e)
        {
            GsbFamille frmFamille = new GsbFamille();
            frmFamille.Show();
        }
    }
}
