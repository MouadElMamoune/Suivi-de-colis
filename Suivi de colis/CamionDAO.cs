using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4j.Driver;
using Neo4jClient;

namespace Suivi_de_colis
{
    class CamionDAO : DAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";
        public CamionDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Camion C)
        {
                var res = client.Cypher.Create("(c:Camion {ID :'" + C.ID + "', Matricule : '" + C.Matricule + "', Marque : '" + C.Marque + "',  Modele : '" + C.Modele + "', Poids : '" + C.Poids + "', Consommation : '" + C.Consommation + "', Longueur : '" + C.Longueur + "', Hauteur : '" + C.Hauteur + "', Largeur : '" + C.Largeur + "', Poids_max : '" + C.Poids_max + "'})").ExecuteWithoutResultsAsync();
                res.Wait();
        }

        public Camion Selectionner(string id)
        {
            Camion C = null;

            var camion = client.Cypher.Match("(c:Camion)").Where("c.ID = '" + id + "'").Return<Camion>("c").ResultsAsync; 
            camion.Wait();
            foreach (var x in camion.Result.ToList())
            {
                C = new Camion(x.ID, x.Matricule, x.Marque, x.Modele, x.Poids, x.Consommation, x.Longueur, x.Hauteur, x.Largeur, x.Poids_max);
                return C;
            }         
            return C;
        }

        public List<Camion> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(c:" + "Camion) ";
            Task<IEnumerable<Camion>> camions;
            if (D != null)
            {
                if (D.ContainsKey("ID"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.ID = '" + D["ID"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Matricule = '" + D["Matricule"] + "' ";
                    }
                }
                if (D.ContainsKey("Matricule"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Matricule = '" + D["Matricule"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Matricule = '" + D["Matricule"] + "' ";
                    }
                }
                if (D.ContainsKey("Marque"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Marque = '" + D["Marque"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Marque = '" + D["Marque"] + "' ";
                    }
                }
                if (D.ContainsKey("Modele"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Modele = '" + D["Modele"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Modele = '" + D["Modele"] + "' ";
                    }
                }
                if (D.ContainsKey("Poids"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Poids = '" + D["Poids"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Poids = '" + D["Poids"] + "' ";
                    }
                }
                if (D.ContainsKey("Consommation"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Consommation = '" + D["Consommation"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Consommation = '" + D["Consommation"] + "' ";
                    }
                }
                if (D.ContainsKey("Longueur"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Longueur = '" + D["Longueur"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Longueur = '" + D["Longueur"] + "' ";
                    }
                }
                if (D.ContainsKey("Hauteur"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Hauteur = '" + D["Hauteur"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Hauteur = '" + D["Hauteur"] + "' ";
                    }
                }
                if (D.ContainsKey("Largeur"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Largeur = '" + D["Largeur"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Largeur = '" + D["Largeur"] + "' ";
                    }
                }
                if (D.ContainsKey("Poids_max"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Poids_max = '" + D["Poids_max"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Poids_max = '" + D["Poids_max"] + "' ";
                    }
                }
            }
            camions = client.Cypher.Match(requete).Return<Camion>("c").ResultsAsync;
            camions.Wait();
            return camions.Result.ToList();
        }

        public void Supprimer(string id)
        {
            var camion = client.Cypher.Match("(c:Camion)").Where("c.ID = '" + id + "'").Delete("c").ExecuteWithoutResultsAsync();
            camion.Wait();
        }

        public void AjouterEmplacement(Camion C, Destination S)
        {
            SupprimerEmplacement(C);
            var requete = client.Cypher.Match("(c:Camion)", "(s:Destination)").Where("c.ID = '" + C.ID + "'").AndWhere("s.ID = '" + S.ID + "'").Create("(c)-[:se_trouve]->(s)").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void SupprimerEmplacement(Camion C)
        {
            var requete = client.Cypher.Match("(c:Camion)-[emp:se_trouve]->()").Where("c.ID = '" + C.ID + "'").Delete("emp").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void SupprimerEmplacement(string id)
        {
            var requete = client.Cypher.Match("(c:Camion)-[emp:se_trouve]->()").Where("c.ID = '" + id + "'").Delete("emp").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        /*
        public void Modifier()
        {
            var camion = client.Cypher.Match("(n:" + "Camion)").Set()
        }
        */
    }
}
