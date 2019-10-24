using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace macrixTestTL
{
    [Serializable]
    public class UsersList
    {
        [XmlArray("UserList"), XmlArrayItem(typeof(User), ElementName = "User")]
        public List<User> users { get; set; }
    }
}
