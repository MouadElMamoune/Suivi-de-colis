using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Client
    {
            string id;
            string nom;
            int nombre_livraisons;
            public Client(string id ,string nom ,int nombre_livraisons)
            {
                this.id = id;
                this.nom = nom;
                this.nombre_livraisons = nombre_livraisons;
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
            public int Nombre_livraisons
            {
                get
                {
                    return nombre_livraisons;
                }

                set
                {
                    nombre_livraisons = value;
                }
            }
            
    }
}
