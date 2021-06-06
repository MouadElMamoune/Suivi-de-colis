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
    public partial class ValidationDeplacement : Form
    {
        XDocument doc;
        List<string> listeCamions = new List<string>();
        List<string> listeDestinations = new List<string>();
        List<Colis> colisCamion = new List<Colis>();
        List<Colis> colisEmplacement = new List<Colis>();
        DeplacementDAO DEPDAO = new DeplacementDAO();

        public ValidationDeplacement()
        {
            if (File.Exists(@"../../test.xml"))
            {
                doc = XDocument.Load(@"../../test.xml");
               
            }
            else
            {
                Close();
            }
            var camions = (from x in doc.Root.Elements("livraison") select x).ToList();
            InitializeComponent();
            foreach (var camion in camions)
            {
                listeCamions.Add(camion.Attribute("idCamion").Value);
                CamionVDcomboBox.Items.AddRange(new string[] { camion.Attribute("idCamion").Value });
            }
            
        }

        private void ValiderVDbutton_Click(object sender, EventArgs e)
        {
        }

        private void CamionVDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CamionVDcomboBox.Text != "" && doc != null)
            {
                ColisDAO CDAO = new ColisDAO();
                var destinations = (from x in doc.Root.Elements("livraison").Elements("destination") where x.Parent.Attribute("idCamion").Value == CamionVDcomboBox.Text select x).ToList();
                listeDestinations.Clear();
                foreach (var dest in destinations)
                {
                    listeDestinations.Add(dest.Attribute("adressePostale").Value);
                }
                var destEmplacement = (from x in destinations.Elements("emplacement") where x.Parent.Attribute("atteint").Value == "0" select x).ToList();
                foreach (var x in destEmplacement)
                {
                    DestinationVDlabel.Text = x.Parent.Attribute("adressePostale").Value;
                    colisEmplacement.Clear();
                    foreach (var y in x.Elements())
                    {
                        colisEmplacement.Add(CDAO.Selectionner(y.Value));
                    }
                    break;
                }
                var destCamion = (from x in destinations.Elements("camion") where x.Parent.Attribute("atteint").Value == "0" select x).ToList();
                foreach (var x in destCamion)
                {
                    DestinationVDlabel.Text = x.Parent.Attribute("adressePostale").Value;
                    colisCamion.Clear();
                    foreach (var y in x.Elements())
                    {
                        colisCamion.Add(CDAO.Selectionner(y.Value));
                    }
                    break;
                }
            }
            
        }

        private void Destination1label_Click(object sender, EventArgs e)
        {

        }

        private void Destination2label_Click(object sender, EventArgs e)
        {

        }

        private void Destination3label_Click(object sender, EventArgs e)
        {

        }

        private void ValiderDestinationVDbutton_Click(object sender, EventArgs e)
        {
            if (DateDepartVDtextBox.Text != "" && DateArriveeVDtextBox.Text != "" && DestinationVDlabel.Text != "")
            {
                CamionDAO CDAO = new CamionDAO();
                DestinationDAO DDAO = new DestinationDAO();
                ColisDAO COLDAO = new ColisDAO();  
                Camion C;
                Destination D;
                C = CDAO.Selectionner(CamionVDcomboBox.Text);
                D = DDAO.SelectionnerAdressePostale(DestinationVDlabel.Text);
                Deplacement DEP = new Deplacement(DateDepartVDtextBox.Text, DateArriveeVDtextBox.Text);
                DEPDAO.Ajouter(DEP, C, DDAO.Selectionner(C), D);
                DateDepartVDtextBox.Text = "";
                DateArriveeVDtextBox.Text = "";
                var destination = (from x in doc.Root.Elements("livraison").Elements("destination") where x.Attribute("adressePostale").Value == DestinationVDlabel.Text select x).First();

                colisCamion.Clear();
                colisEmplacement.Clear();
                foreach(var x in destination.Elements("camion").ToList())
                {
                    foreach (var y in x.Elements("colis"))
                    {
                        colisCamion.Add(COLDAO.Selectionner(y.Value));
                    }
                }
                foreach (var x in destination.Elements("emplacement").ToList())
                {
                    foreach (var y in x.Elements("colis"))
                    {
                        colisEmplacement.Add(COLDAO.Selectionner(y.Value));
                    }
                }
                COLDAO.Vider(C);
                COLDAO.Vider(D);
                COLDAO.Charger(C, colisCamion);
                COLDAO.Charger(D, colisEmplacement);
                destination.Attribute("atteint").SetValue("1");
                doc.Save(@"../../test.xml");
                destination = (from x in doc.Root.Elements("livraison").Elements("destination") where x.Attribute("atteint").Value == "0"  && x.Parent.Attribute("idCamion").Value == CamionVDcomboBox.Text select x).FirstOrDefault();
                if (destination != null)
                {
                    DestinationVDlabel.Text = destination.Attribute("adressePostale").Value;
                }
                else
                {
                    DestinationVDlabel.Text = "";
                }
            }
        }
    }
}
