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
    }
}
