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
            //InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GestionDesClients
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "GestionDesClients";
            this.Load += new System.EventHandler(this.GestionDesClients_Load);
            this.ResumeLayout(false);

        }

        private void GestionDesClients_Load(object sender, EventArgs e)
        {

        }
        private void AjouterGestionDesClientsbutton_Click(object sender, EventArgs e)
        {   
            if (IDGestionDesClientstextBox.Text != "") 
            {
            ClientDAO CDAO = new ClientDAO();
            //Client C = new Client(IDGestionDesCamionstextBox.Text, NomGestionDesClientstextBox.Text, Convert.ToInt32(nombre_livraisonsGestionDesClientsnumericUpDown.Value));
            //CDAO.Ajouter(C);
            }
        }

        private void ModifierGestionDesClientsbutton_Click(object sender, EventArgs e)
        {
            if (IDGestionDesClientstextBox.Text != "")
            {
                ClientDAO CDAO = new ClientDAO();
                if (CDAO.Selectionner(IDGestionDesClientstextBox.Text) != null)
                {
                  //Client C = new Client(IDGestionDesCamionstextBox.Text, NomGestionDesClientstextBox.Text, Convert.ToInt32(nombre_livraisonsGestionDesClientsnumericUpDown.Value));
                  //CDAO.Modifier(C);
                }
            }
        }
    }
}

