using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikamp
{
    public class Lecturer
    {
        public String stopien;
        public String imie;
        public String nazwisko;
        public String login;
        public String password;

        public Lecturer(string stopien, string imie, string nazwisko, string login, string password)
        {
            this.stopien = stopien;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = login;
            this.password = password;
        }
    }
}
