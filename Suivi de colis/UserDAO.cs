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
    class UserDAO : DAO
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

        public void Ajouter(User U)
        {
                var res = client.Cypher.Create("(c:User {ID :'" + C.ID + "', Login : '" + U.Login + "', Password : '" + U.Password + "'})").ExecuteWithoutResultsAsync();
                res.Wait();
        }

        public User Selectionner(string id)
        {
            User U = null;

            var user = client.Cypher.Match("(u:User)").Where("c.ID = '" + id + "'").Return<User>("u").ResultsAsync; 
            user.Wait();
            foreach (var x in user.Result.ToList())
            {
                U = new User(x.ID, x.Login, x.Password);
                return U;
            }         
            return U;
        }

        public List<User> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(u:User) ";
            Task<IEnumerable<User>> users;
            if (D != null)
            {
                if (D.ContainsKey("ID"))
                {
                    requete += "WHERE u.ID = '" + D["ID"] + "' ";
                    compteur++;
                }
                if (D.ContainsKey("Login"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE u.Login = '" + D["Login"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND u.Login = '" + D["Login"] + "' ";
                    }
                }
                if (D.ContainsKey("Password"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE u.Password = '" + D["Password"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND u.Password = '" + D["Password"] + "' ";
                    }
                }
            }
            users = client.Cypher.Match(requete).Return<User>("u").ResultsAsync;
            users.Wait();
            return users.Result.ToList();
        }

        public void Supprimer(string id)
        {
            var user = client.Cypher.Match("(c:User)").Where("c.ID = '" + id + "'").Delete("u").ExecuteWithoutResultsAsync();
            user.Wait();
        }

        /*
        public void Modifier()
        {
            var user = client.Cypher.Match("(n:User)").Set()
        }
        */
    }
}
