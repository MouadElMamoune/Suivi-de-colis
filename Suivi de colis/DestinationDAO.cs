using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver;
using Neo4jClient;

namespace Suivi_de_colis
{
    class DestinationDAO : DAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";

        public DestinationDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Destination D)
        {
            var res = client.Cypher.Create("(d:Destination {ID :'" + D.ID + "', Adresse_postale : '" + D.Adresse_postale + "', Coordonnees_GPS : '" + D.Coordonnees_GPS + "'})").ExecuteWithoutResultsAsync();
            res.Wait();
        }

        public Destination Selectionner(string id)
        {
            Destination D = null;

            var camion = client.Cypher.Match("(d:Destination)").Where("d.ID = '" + id + "'").Return<Destination>("d").ResultsAsync;
            camion.Wait();
            foreach (var x in camion.Result.ToList())
            {
                D = new Destination(x.ID, x.Adresse_postale, x.Coordonnees_GPS);
                return D;
            }
            return D;
        }

        public List<Destination> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(d:Destination) ";
            Task<IEnumerable<Destination>> destinations;
            if (D != null)
            {
                if (D.ContainsKey("ID"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE d.ID = '" + D["ID"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND d.ID = '" + D["ID"] + "' ";
                    }
                }
                if (D.ContainsKey("Adresse_postale"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE d.Adresse_postale = '" + D["Adresse_postale"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND d.Adresse_postale = '" + D["Adresse_postale"] + "' ";
                    }
                }
                if (D.ContainsKey("Coordonees_GPS"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE d.Coordonees_GPS = '" + D["Coordonees_GPS"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND d.Coordonees_GPS = '" + D["Coordonees_GPS"] + "' ";
                    }
                }
            }
            destinations = client.Cypher.Match(requete).Return<Destination>("d").ResultsAsync;
            destinations.Wait();
            return destinations.Result.ToList();
        }

        public void Supprimer(string id)
        {
            var camion = client.Cypher.Match("(d:" + "Destination)").Where("d.ID = '" + id + "'").Delete("d").ExecuteWithoutResultsAsync();
            camion.Wait();
        }

        public Destination Selectionner(Camion C)
        {
            var dest = client.Cypher.Match("(d:Destination)", "(c:Camion)").Where("c.ID = '" + C.ID + "'").AndWhere("(c)-[:se_trouve]->(d)").Return<Destination>("d").ResultsAsync;
            dest.Wait();
            return dest.Result.First();
        }
    }


}
