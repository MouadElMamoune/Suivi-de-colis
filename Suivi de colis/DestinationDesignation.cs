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
    public partial class DestinationDesignation : Form
    {
        int nbDestinations;
        int nb = 1;
        internal List<Destination> trajet = new List<Destination>();
        public DestinationDesignation(int nb)
        {
            nbDestinations = nb;
            InitializeComponent();
            DestinationDDlabel.Text = "Destination 1";
            List<Destination> listeDestinations = new List<Destination>();
            listeDestinations.Add(new Destination("D1", "Beni Makada", "200° 40°"));
            listeDestinations.Add(new Destination("D2", "Hassnouna", "300° 40°"));
            listeDestinations.Add(new Destination("D3", "Marchane", "250° 90°"));
            listeDestinations.Add(new Destination("D4", "Dradeb", "100° 10°"));
            foreach (Destination d in listeDestinations)
            {
                DestinationDDcomboBox.Items.AddRange(new object[] { d.ID });
            }

        }

        private void CamionDDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinationDDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContinuerDDbutton_Click(object sender, EventArgs e)
        {
            nb++;
            if (nb <= nbDestinations)
            {
                DestinationDDlabel.Text = "Destination " + nb;
                trajet.Add(new Destination(DestinationDDcomboBox.Text, "", ""));
                DestinationDDcomboBox.Items.Remove(DestinationDDcomboBox.Text);
                DestinationDDcomboBox.Text = "";
            }
            else
            {
                trajet.Add(new Destination(DestinationDDcomboBox.Text, "", ""));
                Close();
            }
        }
    }
}
