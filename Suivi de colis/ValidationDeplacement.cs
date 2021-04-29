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
    public partial class ValidationDeplacement : Form
    {
        List<List<Destination>> listeTrajets;
        List<Label> listeMessages;
        public ValidationDeplacement()
        {
            List<List<Destination>> listeTrajets;
            int nbTrajets;
            listeTrajets = new List<List<Destination>>();
            nbTrajets = 7; //Il faut implémanter une méthode qui nous renvoie le nombre de trajets pas encore effectués
            for (int i = 0; i < nbTrajets; i++)
            {
                List<Destination> trajet = new List<Destination>();
                trajet.Add(new Destination(i.ToString(), "", "")); //Il faut implémanter une méthode qui renvoie les trajets pas encore effectués
                trajet.Add(new Destination((i * 4).ToString(), "", ""));
                trajet.Add(new Destination((i * 5).ToString(), "", ""));
                listeTrajets.Add(trajet);
            }
            InitializeComponent();
            
            MessageBox.Show("COUCOU");
            this.listeTrajets = listeTrajets;
            
            
        }

        private void ValiderVDbutton_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (List<Destination> trajet in listeTrajets)
            {
                List<Label> listeMessages;
                listeMessages = new List<Label>();
                int i = 0;
                foreach (Destination D in trajet)
                {
                    Label message = new Label();
                    message.Name = "message_" + i + j;
                    message.Size = new System.Drawing.Size(10, 10);
                    message.Font = new Font("Arial", 16);
                    message.Location = new System.Drawing.Point(50 + 20 * i, 50 + 40 * j);
                    message.Text = D.ID;
                    listeMessages.Add(message);
                    i++;
                }
                j++;
                this.listeMessages = listeMessages;
            }

            foreach (Label message in listeMessages)
            {
                Controls.Add(message);
            }
        }
    }
}
