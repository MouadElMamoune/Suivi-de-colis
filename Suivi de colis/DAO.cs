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
    class DAO
    {
        IDriver pilote;
        protected BoltGraphClient client;

        public DAO(string uri = "bolt://localhost:7687", string username = "neo4j", string password = "1234")
        {
            
        }

        public DAO()
        {

        }
    }
}
