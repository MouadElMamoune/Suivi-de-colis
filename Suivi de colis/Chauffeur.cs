using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Chauffeur
    {
            string id;
            string nom;
            string prenom;
            string date_embauche;
            float salaire;
            float note;
            public Camion(string id, string nom, string prenom, string date_embauche, float salaire, float note)
            {
                this.id = id;
                this.nom = nom;
                this.prenom = prenom;
                this.date_embauche = date_embauche;
                this.salaire = salaire;
                this.note = note;
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
            public string Nom
            {
                get
                {
                    return nom;
                }

                set
                {
                    nom = value;
                }
            }
            public string Prenom
            {
                get
                {
                    return prenom;
                }

                set
                {
                    prenom = value;
                }
            }
            public string Date_embauche
            {
                get
                {
                    return date_embauche;
                }

                set
                {
                    date_embauche = value;
                }
            }
            public float Salaire
            {
                get
                {
                    return salaire;
                }

                set
                {
                    salaire = value;
                }
            }
            public float Note
            {
                get
                {
                    return note;
                }

                set
                {
                    note = value;
                }
            }
            

        
    }
}
