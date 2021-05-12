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
    class ClientDAO : DAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";
        public ClientDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Client C)
        {
                var res = client.Cypher.Create("(c:Client {ID :'" + C.ID + "', Nom : '" + C.Nom + "', Nombre_livraisons : '" + C.Nombre_livraisons + "'})").ExecuteWithoutResultsAsync();
                res.Wait();
        }

        public Client Selectionner(string id)
        {
            Client C = null;

            var clients = client.Cypher.Match("(c:Client)").Where("c.ID = '" + id + "'").Return<Client>("c").ResultsAsync; 
            clients.Wait();
            foreach (var x in clients.Result.ToList())
            {
                C = new Client(x.ID, x.Nom, x.Nombre_livraisons);
                return C;
            }         
            return C;
        }

        public List<Client> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(c:Client) ";
            Task<IEnumerable<Client>> clients;
            if (D != null)
            {
                if (D.ContainsKey("ID"))
                {
                    requete += "WHERE c.ID = '" + D["ID"] + "' ";
                    compteur++;
                }
                if (D.ContainsKey("Nom"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Nom = '" + D["Nom"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Nom = '" + D["Nom"] + "' ";
                    }
                }
                if (D.ContainsKey("Nombre_livraisons"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Nombre_livraisons = '" + D["Nombre_livraisons"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Nombre_livraisons = '" + D["Nombre_livraisons"] + "' ";
                    }
                }
            }
            clients = client.Cypher.Match(requete).Return<Client>("c").ResultsAsync;
            clients.Wait();
            return clients.Result.ToList();
        }

        public void Supprimer(string id)
        {
            var clients = client.Cypher.Match("(c:Client)").Where("c.ID = '" + id + "'").Delete("c").ExecuteWithoutResultsAsync();
            clients.Wait();
        }

        /*
        public void Modifier()
        {
            var clients = client.Cypher.Match("(n:Client)").Set()
        }
        */
    }
}
