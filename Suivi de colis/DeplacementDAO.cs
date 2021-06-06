using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver;
using Neo4jClient;

namespace Suivi_de_colis
{
    class DeplacementDAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";

        public DeplacementDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Deplacement dep, Camion C, Destination S, Destination D)
        {
            var requete = client.Cypher.Match("(c:Camion)", "(s:Destination)").Where("c.ID = '" + C.ID + "'").AndWhere("s.ID = '" + S.ID + "'").Create("(S)-[dep:de {Date_de_depart : '" + dep.Date_de_depart + "', Date_arrive : '" + dep.Date_arrive + "'}]->(c)").ExecuteWithoutResultsAsync();
            requete.Wait();
            requete = client.Cypher.Match("(c:Camion)", "(d:Destination)").Where("c.ID = '" + C.ID + "'").AndWhere("d.ID = '" + D.ID + "'").Create("(c)-[dep:à {Date_de_depart : '" + dep.Date_de_depart + "', Date_arrive : '" + dep.Date_arrive + "'}]->(d)").ExecuteWithoutResultsAsync();
            requete.Wait();
        }

        public void Supprimer(Deplacement dep, Camion C, Destination S, Destination D)
        {
            var requete = client.Cypher.Match("(s:Destination { ID : '" + S.ID + "' })-[dep:de]->(c:Camion { ID : '" + C.ID + "' })").Delete("dep").ExecuteWithoutResultsAsync();
            requete.Wait();
            requete = client.Cypher.Match("(c:Camion { ID : '" + C.ID + "' })-[dep:à]->(d:Destination { ID : '" + D.ID + "' })").Delete("dep").ExecuteWithoutResultsAsync();
            requete.Wait();
        }
    }
}
