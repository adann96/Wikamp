using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikamp
{
    public class Student
    {
        public String studentLogin;
        public String studentPassword;
        public String studentName;
        public String studentSurname;
        public String faculty;
        public String street;
        public String accNo;
        public String flatNo;
        public String city;
        public String postalCode, wydzial;

        public Student(String studentLogin, String studentPassword, String studentName, String studentSurname, String faculty, String street, String accNo, String flatNo, String city, String postalCode, String wydzial)
        {
            this.studentLogin = studentLogin;
            this.studentPassword = studentPassword;
            this.studentName = studentName;
            this.studentSurname = studentSurname;
            this.faculty = faculty;
            this.street = street;
            this.accNo = accNo;
            this.flatNo = flatNo;
            this.city = city;
            this.postalCode = postalCode;
            this.wydzial = wydzial;
        }
    }
}
