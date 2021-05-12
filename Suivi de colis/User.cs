using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivi_de_colis
{
    class User
    {
            string id;
            string login;
            string password;
            int compteur = 0;
            public User(string id ,string login ,string password)
            {
                this.id = id;
                this.login = login;
                this.password = password;
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
            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    login = value;
                }
            }
            public string Password
            {
                get
                {
                    return password;
                }

                set
                {
                    password = value;
                }
            }
            /*
            bool Connecte()
            {
                while (compteur < 10)
                {
                    (login == "admin" && password == "123456" ? break : ++compteur);
                }
                return (compteur < 10)
            }            
            }
            */
    }
}
