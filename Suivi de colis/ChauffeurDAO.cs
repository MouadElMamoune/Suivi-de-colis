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
    class ChauffeurDAO : DAO
    {
        IDriver pilote;
        BoltGraphClient client;
        static string uri = "bolt://localhost:7687";
        static string username = "neo4j";
        static string password = "1234";
        public ChauffeurDAO()
        {
            pilote = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password), config => config.WithEncryptionLevel(EncryptionLevel.None));
            client = new BoltGraphClient(pilote);
            client.ConnectAsync().Wait();
        }

        public void Ajouter(Chauffeur C)
        {
                var res = client.Cypher.Create("(c:Chauffeur {ID :'" + C.ID + "', Nom : '" + C.Nom + "', Prenom : '" + C.Prenom + "',  Date_embauche : '" + C.Date_embauche + "', Salaire : '" + C.Salaire + "', Note : '" + C.Note + "'})").ExecuteWithoutResultsAsync();
                res.Wait();
        }

        public Chauffeur Selectionner(string id)
        {
            Chauffeur C = null;

            var chauffeur = client.Cypher.Match("(c:Chauffeur)").Where("c.ID = '" + id + "'").Return<Chauffeur>("c").ResultsAsync; 
            chauffeur.Wait();
            foreach (var x in chauffeur.Result.ToList())
            {
                C = new Chauffeur(x.ID, x.Nom, x.Prenom, x.Date_embauche, x.Salaire, x.Note);
                return C;
            }         
            return C;
        }

        public List<Chauffeur> Selectionner(Dictionary<string, object> D = null)
        {
            int compteur = 0;
            string requete = "(c:Chauffeur) ";
            Task<IEnumerable<Chauffeur>> chauffeurs;
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
                if (D.ContainsKey("Prenom"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Prenom = '" + D["Prenom"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Prenom = '" + D["Prenom"] + "' ";
                    }
                }
                if (D.ContainsKey("Date_embauche"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Date_embauche = '" + D["Date_embauche"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Date_embauche = '" + D["Date_embauche"] + "' ";
                    }
                }
                if (D.ContainsKey("Salaire"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Salaire = '" + D["Salaire"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Salaire = '" + D["Salaire"] + "' ";
                    }
                }
                if (D.ContainsKey("Note"))
                {
                    if (compteur == 0)
                    {
                        requete += "WHERE c.Note = '" + D["Note"] + "' ";
                        compteur++;
                    }
                    else
                    {
                        requete += "AND c.Note = '" + D["Note"] + "' ";
                    }
                }
            }
            chauffeurs = client.Cypher.Match(requete).Return<Chauffeur>("c").ResultsAsync;
            chauffeurs.Wait();
            return chauffeurs.Result.ToList();
        }

        public void Supprimer(string id)
        {
            var chauffeur = client.Cypher.Match("(c:Chauffeur)").Where("c.ID = '" + id + "'").Delete("c").ExecuteWithoutResultsAsync();
            chauffeur.Wait();
        }


        public void Modifier(Chauffeur C)
        {
            var chauffeur = client.Cypher.Match("(c:" + "Chauffeur)").Where("c.ID = '" + C.ID + "'").Set("c.Nom = '" + C.Nom + "'").Set("c.Prenom = '" + C.Prenom + "'").Set("c.Date_embauche = '" + C.Date_embauche + "'").Set("c.Salaire = '" + C.Salaire + "'").Set("c.Note = '" + C.Note + "'").ExecuteWithoutResultsAsync();
            chauffeur.Wait();
        }
    }
}
