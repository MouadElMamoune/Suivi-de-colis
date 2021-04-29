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
    public class Greeting
    {
        public string message;
        public Greeting(string mes)
        {
            message = mes;
        }
    }

    public class Test
    {
        public Test()
        {
            IDriver _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "1234"), config => config.WithEncryptionLevel(EncryptionLevel.None));
            var client = new BoltGraphClient(_driver);
            client.ConnectAsync().Wait();
            MessageBox.Show(client.IsConnected.ToString());
            //client.Cypher.Create("(j:Book { title : 'Antigone' , prix : '100' }) <-[rel:POSSEDE]-(p:Person { nom : 'El Mamoune', prenom : 'Mouad' })").;
            var query = client.Cypher.Match("(n:Greeting)").Return<string>("n").ResultsAsync;
            query.Wait();
            foreach (var x in query.Result.ToList())
            {
                MessageBox.Show(x);
            }
    

            /*
            IDriver _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "1234"), config => config.WithEncryptionLevel(EncryptionLevel.None));
            var client = new BoltGraphClient(_driver);
            var session = _driver.Session();
            string message = "Mohamed";
            var greeting = session.WriteTransaction(tx =>
                                                        {
                                                            var res = tx.Run("CREATE (a:Greeting) " +
                                                            "SET a.message = $message " +
                                                            "RETURN a.message + ', from node ' + id(a)",
                                                            new { message });
                                                            return res.Single()[0].As<string>();
                                                        });
            MessageBox.Show(greeting);
            //var results = await session.RunAsync("MATCH (m:Movie) RETURN m");
            */



        }
    }
}
