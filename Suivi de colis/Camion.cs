using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Camion
    {
            string id;
            string matricule;
            string marque;
            string modele;
            float poids;
            float consommation;
            float longueur;
            float hauteur;
            float largeur;
            float poids_max;
            public Camion(string id, string matricule = "", string marque = "", string modele = "", float poids = 0, float consommation = 0, float longueur = 0, float hauteur = 0, float largeur = 0, float poids_max = 0)
            {
                this.id = id;
                this.matricule = matricule;
                this.marque = marque;
                this.modele = modele;
                this.poids = poids;
                this.consommation = consommation;
                this.longueur = longueur;
                this.hauteur = hauteur;
                this.largeur = largeur;
                this.poids_max = poids_max;
            }

            public Camion()
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
            public string Matricule
            {
                get
                {
                    return matricule;
                }

                set
                {
                    matricule = value;
                }
            }
            public string Marque
            {
                get
                {
                    return marque;
                }

                set
                {
                    marque = value;
                }
            }
            public string Modele
            {
                get
                {
                    return modele;
                }

                set
                {
                    modele = value;
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
            public float Consommation
            {
                get
                {
                    return consommation;
                }

                set
                {
                    consommation = value;
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
            public float Poids_max
            {
                get
                {
                    return poids_max;
                }

                set
                {
                    poids_max = value;
                }
            }
        public float CalculerVolume()
        {
            return longueur * largeur * hauteur;
        }

        public bool VerifierCapacite(List<Colis> listeColis)
        {
            float somme_longueur = 0;
            float somme_largeur = 0;
            float somme_hauteur = 0;

            foreach (Colis C in listeColis)
            {
                somme_longueur += C.Longueur;
                somme_largeur += C.Largeur;
                if (C.Fragilite)
                {
                    somme_hauteur += hauteur;
                }
                else
                {
                    somme_hauteur += C.Hauteur;
                }
            }
            return CalculerVolume() > (somme_longueur * somme_largeur * somme_hauteur);
        }

        
    }
}
