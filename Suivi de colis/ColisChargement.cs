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
    public partial class ColisChargement : Form
    {
        internal List<Colis> listeColisACharger = new List<Colis>();

        public ColisChargement()
        {
            InitializeComponent();
            List<Colis> listeColis = null;
            listeColis = new List<Colis>();
            listeColis.Add(new Colis("C1", 10, 12, 13, true));
            listeColis.Add(new Colis("C2", 15, 14, 10, false));
            listeColis.Add(new Colis("C3", 11, 11, 11, false));
            listeColis.Add(new Colis("C4", 15, 17, 8, false));
            listeColis.Add(new Colis("C5", 10, 12, 13, true));
            listeColis.Add(new Colis("C6", 15, 14, 10, false));
            listeColis.Add(new Colis("C7", 11, 11, 11, false));
            listeColis.Add(new Colis("C8", 15, 17, 8, false));
            if (listeColis != null)
            {
                foreach (Colis C in listeColis)
                {
                    ColisCCcheckedListBox.Items.AddRange(new object[] { C.ID });
                }
                //ColisCCcheckedListBox.CheckedItems
            }
        }

        private void CamionCCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChargerCCbutton_Click(object sender, EventArgs e)
        {
            foreach (string colisId in ColisCCcheckedListBox.CheckedItems)
            {
                listeColisACharger.Add(new Colis(colisId));
                //normalement colisACharger.Add(ColisDAO.chercher(colisId));
            }
            this.Close();
        }
    }
}
