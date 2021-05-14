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
    class ColisDAO : DAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";
        public ColisDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Colis C)
        {
                var res = client.Cypher.Create("(c:Colis {ID :'" + C.ID + "', Longueur : '" + C.Longueur + "', Hauteur : '" + C.Hauteur + "', Largeur : '" + C.Largeur + "', Fragilite : '" + C.Fragilite + "'})").ExecuteWithoutResultsAsync();
                res.Wait();
        }

        public Colis Selectionner(string id)
        {
            Colis C = null;

            var colis = client.Cypher.Match("(c:Colis)").Where("c.ID = '" + id + "'").Return<Colis>("c").ResultsAsync; 
            colis.Wait();
            foreach (var x in colis.Result.ToList())
            {
                C = new Colis(x.ID, x.Longueur, x.Hauteur, x.Largeur, x.Fragilite);
                return C;
            }         
            return C;
        }

        public List<Colis> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(c:" + "Colis) ";
            Task<IEnumerable<Colis>> colis;
            if (D != null)
            {
                if (D.ContainsKey("ID"))
                {
                    requete += "WHERE c.ID = '" + D["ID"] + "' ";
                    compteur++;
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
                if (D.ContainsKey("Fragilite"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Fragilite = '" + D["Fragilite"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Fragilite = '" + D["Fragilite"] + "' ";
                    }
                }
            }
            colis = client.Cypher.Match(requete).Return<Colis>("c").ResultsAsync;
            colis.Wait();
            return colis.Result.ToList();
        }

        public void Supprimer(string id)
        {
            SupprimerEmplacement(id);
            var colis = client.Cypher.Match("(c:Colis)").Where("c.ID = '" + id + "'").Delete("c").ExecuteWithoutResultsAsync();
            colis.Wait();
        }

        public void AjouterEmplacement(Colis C, Destination S)
        {
            SupprimerEmplacement(C);
            var requete = client.Cypher.Match("(c:Colis)", "(s:Destination)").Where("c.ID = '" + C.ID + "'").AndWhere("s.ID = '" + S.ID + "'").Create("(s)-[:contient]->(c)").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void AjouterEmplacement(Colis col, Camion cam)
        {
            SupprimerEmplacement(col);
            var requete = client.Cypher.Match("(col:Colis)", "(cam:Camion)").Where("col.ID = '" + col.ID + "'").AndWhere("cam.ID = '" + cam.ID + "'").Create("(cam)-[:transporte]->(col)").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void SupprimerEmplacement(Colis C)
        {
            var requete = client.Cypher.Match("()-[cont:contient]->(c:Colis)").Where("c.ID = '" + C.ID + "'").Delete("cont").ExecuteWithoutResultsAsync();
            requete.Wait();
            requete = client.Cypher.Match("()-[trans:transporte]->(c:Colis)").Where("c.ID = '" + C.ID + "'").Delete("trans").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void SupprimerEmplacement(string id)
        {
            var requete = client.Cypher.Match("()-[cont:contient]->(c:Colis)").Where("c.ID = '" + id + "'").Delete("cont").ExecuteWithoutResultsAsync();
            requete.Wait();
            requete = client.Cypher.Match("()-[trans:transporte]->(c:Colis)").Where("c.ID = '" + id + "'").Delete("trans").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void Charger(Camion C, List<Colis> listeColis)
        {
            foreach (Colis col in listeColis)
            {
                AjouterEmplacement(col, C);
            }
        }

        public List<Colis> Selectionner(Destination D)
        {
            var colis = client.Cypher.Match("(c:Colis)", "(d:Destination)").Where("d.ID = '" + D.ID + "'").AndWhere("(d)-[:contient]->(c)").Return<Colis>("c").ResultsAsync;
            colis.Wait();
            return colis.Result.ToList();
        }

        public List<Colis> Selectionner(Camion cam)
        {
            var colis = client.Cypher.Match("(col:Colis)", "(cam:Camion)").Where("cam.ID = '" + cam.ID + "'").AndWhere("(cam)-[:transporte]->(col)").Return<Colis>("col").ResultsAsync;
            colis.Wait();
            return colis.Result.ToList();
        }

        /*
        public void Modifier()
        {
            var colis = client.Cypher.Match("(n:" + "Colis)").Set()
        }
        */
    }
}
