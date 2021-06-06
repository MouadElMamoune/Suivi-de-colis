using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Colis
    {
        string id;
        float longueur;
        float hauteur;
        float largeur;
        bool fragilite;
        float poids;
        public Colis(string id ,float longueur = 0,float hauteur = 0, float largeur = 0, bool fragilite = false, float poids = 0)
        {
            this.id = id;
            this.longueur = longueur;
            this.hauteur = hauteur;
            this.largeur = largeur;
            this.fragilite = fragilite;
            this.poids = poids;
        }

        public Colis()
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
            
        public float Longueur
        {
            get
            {
                return longueur;
            }

            set
            {
                longueur = value;
            }
        }
        public float Hauteur
        {
            get
            {
                return hauteur;
            }

            set
            {
                hauteur = value;
            }
        }
        public float Largeur
        {
            get
            {
                return largeur;
            }

            set
            {
                largeur = value;
            }
        }
        public bool Fragilite
        {
            get
            {
                return fragilite;
            }

            set
            {
                fragilite = value;
            }
        }

        public float Poids
        {
            get
            {
                return poids;
            }

            set
            {
                poids = value;
            }
        }
    }
}
