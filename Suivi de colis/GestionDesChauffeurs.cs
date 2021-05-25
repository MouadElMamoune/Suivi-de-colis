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
    public partial class GestionDesChauffeurs : Form
    {
        public GestionDesChauffeurs()
        {
            InitializeComponent();
        }

        private void AjouterGestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesChauffeurstextBox.Text != "" && NomGestionDesChauffeurstextBox.Text != "" && PrenomGestionDesChauffeurstextBox.Text != "" && DateEmbaucheGestionDesChauffeurstextBox.Text != "" && SalaireGestionDesChauffeurstextBox.Text != "") 
            {
                ChauffeurDAO CDAO = new ChauffeurDAO();
                Chauffeur C;
                string id, nom, prenom, date_embauche;
                float salaire;
                int note;
                id = IDGestionDesChauffeurstextBox.Text;
                nom = NomGestionDesChauffeurstextBox.Text;
                prenom = PrenomGestionDesChauffeurstextBox.Text;
                date_embauche = DateEmbaucheGestionDesChauffeurstextBox.Text;
                salaire = Convert.ToInt32(SalaireGestionDesChauffeurstextBox.Text);
                note = Convert.ToInt32(NoteGestionDesChauffeursnumericUpDown.Value);
                C = new Chauffeur(id, nom, prenom, date_embauche, salaire, note);
                CDAO.Ajouter(C);
            }
        }

        private void ModifierGestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesChauffeurstextBox.Text != "" && NomGestionDesChauffeurstextBox.Text != "" && PrenomGestionDesChauffeurstextBox.Text != "" && DateEmbaucheGestionDesChauffeurstextBox.Text != "" && SalaireGestionDesChauffeurstextBox.Text != "")
            {
                ChauffeurDAO CDAO = new ChauffeurDAO();
                if (CDAO.Selectionner(IDGestionDesChauffeurstextBox.Text) != null)
                {
                    Chauffeur C;
                    string id, nom, prenom, date_embauche;
                    float salaire;
                    int note;
                    id = IDGestionDesChauffeurstextBox.Text;
                    nom = NomGestionDesChauffeurstextBox.Text;
                    prenom = PrenomGestionDesChauffeurstextBox.Text;
                    date_embauche = DateEmbaucheGestionDesChauffeurstextBox.Text;
                    salaire = Convert.ToInt32(SalaireGestionDesChauffeurstextBox.Text);
                    note = Convert.ToInt32(NoteGestionDesChauffeursnumericUpDown.Value);
                    C = new Chauffeur(id, nom, prenom, date_embauche, salaire, note);
                    CDAO.Modifier(C);
                }
            }
        }
    }
}
