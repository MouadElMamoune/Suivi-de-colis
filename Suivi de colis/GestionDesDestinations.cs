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
    public partial class GestionDesDestinations : Form
    {
        public GestionDesDestinations()
        {
            InitializeComponent();
        }
        
        private void AjouterGestionDesColisbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesDestinationstextBox.Text != "") 
            {
                DestinationDAO DDAO = new DestinationDAO();
                Destination D = new Destination(IDGestionDesDestinationstextBox.Text, adresse_postaleGestionDesDestinationstextBox.Text, coordonnees_GPSGestionDesDestinationstextBox.Text);
                DDAO.Ajouter(D);
            }
        }

        private void ModifierGestionDesColisbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesDestinationstextBox.Text != "")
            {
                DestinationDAO DDAO = new DestinationDAO();
                if (CDAO.Selectionner(IDGestionDesDestinationstextBox.Text) != null)
                {
                    DestinationDAO DDAO = new DestinationDAO();
                    Destination D = new Destination(IDGestionDesDestinationstextBox.Text, adresse_postaleGestionDesDestinationstextBox.Text, coordonnees_GPSGestionDesDestinationstextBox.Text);
                    DDAO.Modifier(D);
                }
            }
        }
    }
}
