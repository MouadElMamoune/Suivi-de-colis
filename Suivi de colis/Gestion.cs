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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void GestionDesChauffeursbutton_Click(object sender, EventArgs e)
        {
            GestionDesChauffeurs G = new GestionDesChauffeurs();
            G.ShowDialog();
        }

        private void GestionDesCamionsbutton_Click(object sender, EventArgs e)
        {
            GestionDesCamions G = new GestionDesCamions();
            G.ShowDialog();
        }

        private void GestionDesColisbutton_Click(object sender, EventArgs e)
        {
            new GestionDesColis().ShowDialog();
        }

        private void GestionDesClientsbutton_Click(object sender, EventArgs e)
        {
            new GestionDesClients().ShowDialog();
        }

        private void GestionDesDestinationsbutton_Click(object sender, EventArgs e)
        {
            new GestionDesDestinations().ShowDialog();
        }
    }
}
