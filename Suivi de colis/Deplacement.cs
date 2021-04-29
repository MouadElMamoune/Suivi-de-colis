using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class Deplacement
    {
            string id;
            string date_de_depart;
            string date_de_arrive;
            public Deplacement(string id ,string date_de_depart ,string date_de_arrive)
            {
                this.id = id;
                this.date_de_depart = date_de_depart;
                this.date_de_arrive = date_de_arrive;
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
            public string Date_de_depart
            {
                get
                {
                    return date_de_depart;
                }

                set
                {
                    date_de_depart = value;
                }
            }
            public string Date_de_arrive
            {
                get
                {
                    return date_de_arrive;
                }

                set
                {
                    date_de_arrive = value;
                }
            }
            
    }
}
