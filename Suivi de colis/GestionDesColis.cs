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
    public partial class GestionDesColis : Form
    {
        public GestionDesColis()
        {
            InitializeComponent();
        }
        
        private void AjouterGestionDesColisbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesColistextBox.Text != "") 
            {
                ColisDAO CDAO = new ColisDAO();
                Colis C = new Colis(IDGestionDesColistextBox.Text, float.Parse(LongeurGestionDesColistextBox.Text), float.Parse(HauteurGestionDesColistextBox.Text), float.Parse(LargeurGestionDesColisTxtBox.Text), checkBox1.Checked);
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
                    Colis C = new Colis(IDGestionDesColistextBox.Text, float.Parse(LongeurGestionDesColistextBox.Text), float.Parse(HauteurGestionDesColistextBox.Text), float.Parse(LargeurGestionDesColisTxtBox.Text), checkBox1.Checked);
                    //CDAO.Modifier(C);
                }
            }
        }

        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GestionDesColis
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "GestionDesColis";
            this.Load += new System.EventHandler(this.GestionDesColis_Load);
            this.ResumeLayout(false);

        }
        */

        private void GestionDesColis_Load(object sender, EventArgs e)
        {

        }
    }
}
