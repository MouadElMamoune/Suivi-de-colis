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
        List<string>[] listeColisACharger;
        List<string>[] listeColisADecharger;
        int indice = 0;
        int nbDestinations;
        string idCamion;
        string[] listeDestination;

        public string[] ListeDestination { get => listeDestination; set => listeDestination = value; }
        internal List<string>[] ListeColisACharger { get => listeColisACharger; set => listeColisACharger = value; }
        public List<string>[] ListeColisADecharger { get => listeColisADecharger; set => listeColisADecharger = value; }
        public int NbDestinations { get => nbDestinations; set => nbDestinations = value; }
        public string IdCamion { get => idCamion; set => idCamion = value; }

        public ColisChargement(string id, int nb)
        {
            idCamion = id;
            nbDestinations = nb;
            listeColisACharger = new List<string>[nbDestinations];
            listeColisADecharger = new List<string>[nbDestinations];
            listeDestination = new string[nbDestinations];
            InitializeComponent();
            PrécédentCCbutton.Visible = false;
            CamionCCcomboBox.Text = idCamion;
            DestinationDAO DDAO = new DestinationDAO();
            List<Destination> listeDestinations;
            listeDestinations = DDAO.Selectionner();
            foreach (Destination D in listeDestinations)
            {
                DestinationCCcomboBox.Items.Add(D.Adresse_postale);
            }
            /*
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
            listeColis.Add(new Colis("C9", 10, 12, 13, true));
            listeColis.Add(new Colis("C10", 15, 14, 10, false));
            listeColis.Add(new Colis("C11", 11, 11, 11, false));
            listeColis.Add(new Colis("C12", 15, 17, 8, false));
            listeColis.Add(new Colis("C13", 10, 12, 13, true));
            listeColis.Add(new Colis("C14", 15, 14, 10, false));
            listeColis.Add(new Colis("C15", 11, 11, 11, false));
            listeColis.Add(new Colis("C16", 15, 17, 8, false));
            if (listeColis != null)
            {
                foreach (Colis C in listeColis)
                {
                    ColisCCChargercheckedListBox.Items.AddRange(new object[] { C.ID });
                }
                //ColisCCcheckedListBox.CheckedItems
            }
            */
        }

        private void CamionCCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColisCCChargercheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDernierChecked;
            indiceDernierChecked = ColisCCChargercheckedListBox.SelectedIndex;

            if (indice == 0)
            {
                if (ColisCCDechargercheckedListBox.Items.Count == 0)
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            else
            {
                List<string> listeIds = new List<string>();
                foreach (string colis in ColisCCDechargercheckedListBox.Items)
                {
                    listeIds.Add(colis);
                }
                if (Enumerable.SequenceEqual(listeColisADecharger[indice - 1], listeIds))
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            if (indiceDernierChecked >= 0)
            {
                if (ColisCCChargercheckedListBox.GetItemChecked(indiceDernierChecked) && ColisCCChargercheckedListBox.Enabled)
                {
                    var x = ColisCCChargercheckedListBox.SelectedItem;
                    ColisCCDechargercheckedListBox.Items.AddRange(new string[] { x.ToString() });
                    ColisCCChargercheckedListBox.Items.RemoveAt(indiceDernierChecked);
                }
            }

            //indiceDernierChecked = ColisCCChargercheckedListBox.Items.Count - 1;
            //ColisCCDechargercheckedListBox.Items.AddRange(ColisCCChargercheckedListBox.GetItemChecked(indiceDernierChecked));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ColisCCDechargercheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (indice == 0)
            {
                if (ColisCCDechargercheckedListBox.Items.Count == 0)
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            else
            {
                List<string> listeIds = new List<string>();
                foreach (string colis in ColisCCDechargercheckedListBox.Items)
                {
                    listeIds.Add(colis);
                }
                if (Enumerable.SequenceEqual(listeColisADecharger[indice - 1], listeIds))
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            int indiceDernierChecked;
            indiceDernierChecked = ColisCCDechargercheckedListBox.SelectedIndex;
            if (indiceDernierChecked >= 0)
            {
                if (ColisCCDechargercheckedListBox.GetItemChecked(indiceDernierChecked) && ColisCCChargercheckedListBox.Enabled)
                {
                    var x = ColisCCDechargercheckedListBox.SelectedItem;
                    ColisCCChargercheckedListBox.Items.AddRange(new string[] { x.ToString() });
                    ColisCCDechargercheckedListBox.Items.RemoveAt(indiceDernierChecked);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SuivantCCbutton_Click(object sender, EventArgs e)
        {
            if (DestinationCCcomboBox.Text != "")
            {
                ColisDAO CDAO = new ColisDAO();
                listeColisACharger[indice] = new List<string>();
                listeColisADecharger[indice] = new List<string>();
                listeDestination[indice] = DestinationCCcomboBox.Text;
                if (indice < nbDestinations - 1)
                {
                    DestinationCCcomboBox.Items.Remove(listeDestination[indice]);
                }
                if (indice > 0)
                {
                    DestinationCCcomboBox.Items.AddRange(new string[] { listeDestination[indice - 1] });
                }
                foreach (string colis in ColisCCChargercheckedListBox.Items)
                {

                    listeColisACharger[indice].Add(colis);
                }
                foreach (string colis in ColisCCDechargercheckedListBox.Items)
                {
                    listeColisADecharger[indice].Add(colis);
                }
                if (indice < nbDestinations - 1)
                {
                    indice++;
                    PrécédentCCbutton.Visible = true;
                    //ColisCCChargercheckedListBox.Items.Clear();
                    //ColisCCChargercheckedListBox.Enabled = false;
                }
                DestinationPLlabel.Text = "Destination " + (indice + 1);
                CamionDAO CAMDAO = new CamionDAO();
                ColisDAO COLDAO = new ColisDAO();
                List<Colis> L = new List<Colis>();
                foreach (string colis in listeColisADecharger[indice - 1])
                {
                    L.Add(COLDAO.Selectionner(colis));
                }
                Camion C = CAMDAO.Selectionner(idCamion);
                //C.VerifierCapacite
                if (SuivantCCbutton.Text == "Terminer")
                {
                    Close();
                }
                    if (indice == nbDestinations - 1)
                {
                    SuivantCCbutton.Text = "Terminer";
                }
                else
                {
                    SuivantCCbutton.Text = "Suivant";
                }
                
            }
        }

        private void PrécédentCCbutton_Click(object sender, EventArgs e)
        {
            //DestinationCCcomboBox.Items.AddRange(new string[] { listeDestination[indice-1] });
            ColisDAO CDAO = new ColisDAO();
            listeColisACharger[indice] = null;
            listeColisADecharger[indice] = null;
            //listeDestination[indice] = null;

            if (indice > 0)
            {
                DestinationCCcomboBox.Items.AddRange(new string[] { listeDestination[indice - 1] });
            }
            if (indice > 1)
            {
                DestinationCCcomboBox.Items.Remove(listeDestination[indice - 2]);
            }
            indice--;
            DestinationCCcomboBox.SelectedItem = listeDestination[indice];
            ColisCCDechargercheckedListBox.Items.Clear();
            ColisCCChargercheckedListBox.Items.Clear();
            foreach (string colis in listeColisACharger[indice])
            {
                ColisCCChargercheckedListBox.Items.AddRange(new string[] { colis });
            }
            foreach (string colis in listeColisADecharger[indice])
            {
                ColisCCDechargercheckedListBox.Items.AddRange(new string[] { colis });
            }
            DestinationPLlabel.Text = "Destination " + (indice + 1);
            SuivantCCbutton.Visible = true;
            if (indice == 0)
            {
                PrécédentCCbutton.Visible = false;
            }
          
        }

        private void DestinationCCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColisDAO CDAO = new ColisDAO();
            List<Colis> listeColis;

            if (DestinationCCcomboBox.Text != "")
            {
                ColisCCChargercheckedListBox.Enabled = true;
            }
            else
            {
                ColisCCChargercheckedListBox.Enabled = false;
            }
            if (indice == 0)
            {
                if (ColisCCDechargercheckedListBox.Items.Count == 0)
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            else
            {
                List<string> listeIds = new List<string>();
                foreach (string colis in ColisCCDechargercheckedListBox.Items)
                {
                    listeIds.Add(colis);
                }
                if (Enumerable.SequenceEqual(listeColisADecharger[indice - 1], listeIds))
                {
                    DestinationCCcomboBox.Enabled = true;
                }
                else
                {
                    DestinationCCcomboBox.Enabled = false;
                }
            }
            ColisCCChargercheckedListBox.Items.Clear();
            if (!listeDestination.Contains(DestinationCCcomboBox.Text) || indice == 0)
            {
                DestinationDAO DDAO = new DestinationDAO();
                Dictionary<string, object> D = new Dictionary<string, object>();
                D.Add("Adresse_postale", DestinationCCcomboBox.Text);
                listeColis = CDAO.Selectionner(DDAO.Selectionner(D).First());       
                foreach (Colis C in listeColis)
                {
                    if (indice == 0 && listeColisADecharger[indice] != null)
                    {
                        foreach (string colis in listeColisADecharger[indice])
                        {
                            
                            if (C.ID != colis)
                            {
                                ColisCCChargercheckedListBox.Items.AddRange(new string[] { C.ID });
                            }
                        }
                    }
                    else
                    {
                        ColisCCChargercheckedListBox.Items.AddRange(new string[] { C.ID });
                    }
                    
                }
            }
            else
            {
                if (listeColisADecharger[indice - 1] != null)
                {
                    ColisCCDechargercheckedListBox.Items.Clear();
                    foreach (string colis in listeColisADecharger[indice - 1])
                    {
                        ColisCCDechargercheckedListBox.Items.AddRange(new string[] { colis });
                    }
                }
                int i = 0;
                foreach (string dest in listeDestination)
                {
                    if (dest == DestinationCCcomboBox.Text)
                    {
                        break;
                    }
                    i++;
                }
                if (listeDestination[i] != null)
                {
                    if (listeColisACharger[i] != null)
                    {
                        foreach (string colis in listeColisACharger[i])
                        {
                            ColisCCChargercheckedListBox.Items.AddRange(new string[] { colis });
                        }
                    }
                }
            }
        }

        private void TerminerCCbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
