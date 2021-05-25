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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlanifierLivraisonbutton_Click(object sender, EventArgs e)
        {
            PlanificationLivraison PL = new PlanificationLivraison();
            PL.ShowDialog();
        }

        private void SuiviActuelbutton_Click(object sender, EventArgs e)
        {
            ValidationDeplacement VD = new ValidationDeplacement();
            VD.ShowDialog();
        }

        private void Gestionbutton_Click(object sender, EventArgs e)
        {
            Gestion G = new Gestion();
            G.ShowDialog();
        }
    }
}
