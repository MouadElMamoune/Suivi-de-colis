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
    public partial class GestionDesClients : Form
    {
        public GestionDesClients()
        {
            InitializeComponent();
        }
        private void AjouterGestionDesColisbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesColistextBox.Text != "") 
            {
                ColisDAO CDAO = new ColisDAO();
                Colis C = new Colis(IDGestionDesColistextBox.Text, float.Parse(LongeurGestionDesColistextBox.Text), float.parse(HauteurGestionDesColistextBox.Text), float.parse(LargeurGestionDesColisTxtBox.Text), checkBox1.Checked);
                CDAO.Ajouter(C);
            }
        }

        private void ModifierGestionDesColisbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesColistextBox.Text != "")
            {
                ColisDAO CDAO = new ColisDAO();
                if (CDAO.Selectionner(IDGestionDesColistextBox.Text) != null)
                {
                    Colis C = new Colis(IDGestionDesColistextBox.Text, float.Parse(LongeurGestionDesColistextBox.Text), float.parse(HauteurGestionDesColistextBox.Text), float.parse(LargeurGestionDesColisTxtBox.Text), checkBox1.Checked);
                    CDAO.Modifier(C);
                }
            }
        }
    }
}
