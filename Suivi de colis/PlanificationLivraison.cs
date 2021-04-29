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
    public partial class PlanificationLivraison : Form
    {
        List<Colis> listeColisACharger = new List<Colis>();
        List<Destination> trajet = new List<Destination>();
        public PlanificationLivraison()
        {
        InitializeComponent();
        }

        private void ColisPLbutton_Click(object sender, EventArgs e)
        {
            ColisChargement CC = new ColisChargement();
            CC.ShowDialog();
            listeColisACharger = CC.listeColisACharger;
            ColisChargePLdataGridView.Rows.Clear();
            if (listeColisACharger.Count != 0)
            {
                foreach (Colis C in listeColisACharger)
                {
                    ColisChargePLdataGridView.Rows.Add(C.ID);
                }
            }
        }

        private void CamionPLcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {      
        }

        private void DestinationPLbutton_Click(object sender, EventArgs e)
        {
            if (NbDestinationPLnumericUpDown.Value > 0)
            {
                DestinationDesignation DD = new DestinationDesignation(Convert.ToInt32(NbDestinationPLnumericUpDown.Value));
                TrajetPLdataGridView.Rows.Clear();
                DD.ShowDialog();
                trajet = DD.trajet;
                if (trajet.Count != 0)
                {
                    foreach (Destination D in trajet)
                    {
                        TrajetPLdataGridView.Rows.Add(D.ID);
                    }
                }
            }
        }

        private void NbDestinationPLnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrajetPLdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
