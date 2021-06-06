using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivi_de_colis
{
    public partial class GestionDesCamions : Form
    {
        public GestionDesCamions()
        {
            InitializeComponent();
        }
        
        private void AjouterGestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesCamionstextBox.Text != "") 
            {
                CamionDAO CDAO = new CamionDAO();
                Camion C;
                string id = IDGestionDesCamionstextBox.Text;
                string matricule = MatriculeGestionDesCamionstextBox.Text;
                string marque = MarqueGestionDesCamionstextBox.Text;
                string modele = ModeleGestionDesCamionstextBox.Text;
                float poids = float.Parse(PoidsGestionDesCamionstextBox.Text);
                float consommation = float.Parse(ConsommationTextBox.Text);
                float longueur = float.Parse(LongueurtextBox.Text);
                float hauteur = float.Parse(HauteurtextBox.Text);
                float largeur = float.Parse(LargeurtextBox.Text);
                float poids_max = float.Parse(PoidsMaxtextBox.Text);
                C = new Camion(id, matricule, marque, modele, poids, consommation, longueur, hauteur, largeur, poids_max);
                CDAO.Ajouter(C);
            }
        }

        private void ModifierGestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesCamionstextBox.Text != "" && MatriculeGestionDesCamionstextBox.Text != "" && MarqueGestionDesCamionstextBox.Text != "" && ModeleGestionDesCamionstextBox.Text != "" && PoidsGestionDesCamionstextBox.Text != "" && ConsommationTextBox.Text != "" && LongueurtextBox.Text != "" && HauteurtextBox.Text != "" && LargeurtextBox.Text != "" && PoidsMaxtextBox.Text != "")
            {
                CamionDAO CDAO = new CamionDAO();
                if (CDAO.Selectionner(IDGestionDesCamionstextBox.Text) != null)
                {
                    Camion C;
                    string id = IDGestionDesCamionstextBox.Text;
                    string matricule = MatriculeGestionDesCamionstextBox.Text;
                    string marque = MarqueGestionDesCamionstextBox.Text;
                    string modele = ModeleGestionDesCamionstextBox.Text;
                    float poids = float.Parse(PoidsGestionDesCamionstextBox.Text);
                    float consommation = float.Parse(ConsommationTextBox.Text);
                    float longueur = float.Parse(LongueurtextBox.Text);
                    float hauteur = float.Parse(HauteurtextBox.Text);
                    float largeur = float.Parse(LargeurtextBox.Text);
                    float poids_max = float.Parse(PoidsMaxtextBox.Text);
                    C = new Camion(id, matricule, marque, modele, poids, consommation, longueur, hauteur, largeur, poids_max);
                    CDAO.Modifier(C);
                }
            }
        }

        private void SupprimerGestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesCamionstextBox.Text != "")
            {
                CamionDAO CDAO = new CamionDAO();
                if (CDAO.Selectionner(IDGestionDesCamionstextBox.Text) != null)
                {
                    CDAO.Supprimer(IDGestionDesCamionstextBox.Text);
                }
            }

        }
    }
}
