using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace macrixTestTL
{
    [Serializable]
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetName { get; set; }
        public string houseNumber { get; set; }
        public string apartmentNumber { get; set; }
        public string postalCode { get; set; }
        public string town { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDate { get; set; }
        public string age { get; set; }
        public User(string fname, string lname, string streetname, string housenr, string apartmentnr, string postalcode, string town, string phonenr, DateTime birthday)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.streetName = streetname;
            this.houseNumber = housenr;
            this.apartmentNumber = apartmentnr;
            this.postalCode = postalcode;
            this.town = town;
            this.phoneNumber = phonenr;
            this.birthDate = birthday;
            this.age = (DateTime.Now.Year - this.birthDate.Year).ToString();
        }
        public User()
        {
            //if(this.birthDate != null)
            //{
            //    this.age = (DateTime.Now.Year - this.birthDate.Year).ToString();
            //}
        }
    }
}
