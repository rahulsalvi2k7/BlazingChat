using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingChat.Shared
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
