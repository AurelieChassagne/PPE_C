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
    public partial class GsbFamille : Form
    {
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

        private void dgvProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomMedClick = dgvFamille.Rows[e.RowIndex].Cells[0].Value;
            RemplirInfo(NomMedClick);
        }
        private void RemplirInfo(object nomMedClick)
        {
            Famille LaFamille;
            LaFamille = DAOFamille.RemplirInfoMed(nomMedClick.ToString());
            txtReference.Text = LaFamille.GetId().ToString();
            txtNom.Text = LaFamille.GetNom();
        }

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(int.Parse(txtReference.Text), txtNom.Text);
            DAOFamille.CreerFamille(LaFamille);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(Int32.Parse(txtReference.Text));
            DAOFamille.SupprimerFamille(LaFamille);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Famille LaFamille = new Famille(Int32.Parse(txtReference.Text), txtNom.Text);
            DAOFamille.ModifierFamille(LaFamille);
        }

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
