using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Suivi_de_colis
{
    public partial class PlanificationLivraison : Form
    {
        List<Camion> listeCamions;
        List<string>[] listeColisACharger;
        List<string>[] listeColisADecharger;
        string[] listeDestinations;
        string idCamion;
        int nbDestinations;
        XDocument doc;
        public PlanificationLivraison()
        {
            CamionDAO CDAO = new CamionDAO();
            DestinationDAO DDAO = new DestinationDAO();
            listeCamions = CDAO.Selectionner();
            if (File.Exists(@"../../test.xml"))
            {
                doc = XDocument.Load(@"../../test.xml");
            } 
            InitializeComponent();
            foreach (Camion C in listeCamions) 
            {
                CamionPLcomboBox.Items.Add(C.ID);
            }
        }

        private void TrajetPLbutton_Click(object sender, EventArgs e)
        {
            string idCam;
            if (CamionPLcomboBox.Text != "" && NbDestinationPLnumericUpDown.Value > 0)
            {
                idCam = CamionPLcomboBox.Text;
                if (File.Exists(@"../../test.xml"))
                {
                    var livraison = (from x in doc.Root.Elements("livraison") where x.Attribute("idCamion").Value == idCam select x).FirstOrDefault();
                    if (livraison == null)
                    {
                        ColisChargement CC = new ColisChargement(idCam, Convert.ToInt32(NbDestinationPLnumericUpDown.Value));
                        CC.ShowDialog();
                        TrajetPLdataGridView.Rows.Clear();
                        listeDestinations = CC.ListeDestination;
                        listeColisACharger = CC.ListeColisACharger;
                        listeColisADecharger = CC.ListeColisADecharger;
                        idCamion = CC.IdCamion;
                        nbDestinations = CC.NbDestinations;
                        foreach (var x in CC.ListeDestination)
                        {
                            TrajetPLdataGridView.Rows.Add(x);
                        }
                    }
                }
                else
                {
                    ColisChargement CC = new ColisChargement(idCam, Convert.ToInt32(NbDestinationPLnumericUpDown.Value));
                    CC.ShowDialog();
                    TrajetPLdataGridView.Rows.Clear();
                    listeDestinations = CC.ListeDestination;
                    listeColisACharger = CC.ListeColisACharger;
                    listeColisADecharger = CC.ListeColisADecharger;
                    idCamion = CC.IdCamion;
                    nbDestinations = CC.NbDestinations;
                    foreach (var x in CC.ListeDestination)
                    {
                        TrajetPLdataGridView.Rows.Add(x);
                    }
                }
            }            
        }

        private void CamionPLcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
        }

        private void NbDestinationPLnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrajetPLdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValiderPLbutton_Click(object sender, EventArgs e)
        {
            if (TrajetPLdataGridView.Rows.Count != 0 || true)
            {
                if (!File.Exists(@"../../test.xml"))
                {
                    doc = new XDocument(new XElement("livraisons"));
                }
                doc.Root.Add(new XElement("livraison", new XAttribute("idCamion", idCamion), new XAttribute("nbDestinations", nbDestinations)));
                var livraison = (from x in doc.Root.Elements("livraison") where x.Attribute("idCamion").Value == idCamion select x).FirstOrDefault();
                int i = 1;
                foreach (var destination in listeDestinations)
                {
                    if (i-1 < nbDestinations)
                    {
                        livraison.Add(new XElement("destination", new XAttribute("num", i), new XAttribute("adressePostale", destination), new XElement("camion"), new XElement("emplacement")));
                        var destCharger = (from x in livraison.Elements("destination") where x.Attribute("num").Value == i.ToString() select x).FirstOrDefault();
                        var destDecharger = (from x in livraison.Elements("destination") where x.Attribute("num").Value == i.ToString() select x).FirstOrDefault();

                        foreach (var colis in listeColisACharger[i - 1])
                        {
                            destCharger.Element("emplacement").Add(new XElement("colis", colis));
                        }
                        
                        foreach (var colis in listeColisADecharger[i - 1])
                        {
                            destCharger.Element("camion").Add(new XElement("colis", colis));
                        }
                        i++;         
                    }
                }
                doc.Save(@"../../test.xml");
                TrajetPLdataGridView.Rows.Clear();
            }    
        }
    }
}