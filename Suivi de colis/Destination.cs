using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Destination
    {
        string id;
        string adresse_postale;
        string coordonnees_GPS;
        public Destination(string id ,string addresse_postale = "",string coordonnees_GPS = "")
        {
            this.id = id;
            this.adresse_postale = addresse_postale;
            this.coordonnees_GPS = coordonnees_GPS;
        }

        public Destination()
        {

        }

        public string ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Adresse_postale
        {
            get
            {
                return adresse_postale;
            }

            set
            {
                adresse_postale = value;
            }
        }
        public string Coordonnees_GPS
        {
            get
            {
                return coordonnees_GPS;
            }

            set
            {
                coordonnees_GPS = value;
            }
        }
            
    }
}
