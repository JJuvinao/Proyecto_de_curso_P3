using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int persoId1 { get; set; }
        public int persoId2 { get; set; }
        public int persoId3 { get;  set; }

        public User(int id, string name, int persoId1, int persoId2, int persoId3)
        {
            Id = id;
            Name = name;
            this.persoId1 = persoId1;
            this.persoId2 = persoId2;
            this.persoId3 = persoId3;
        }

        public override string ToString()
        {
            return $"{Id};{Name};{persoId1};{persoId2};{persoId3}";
        }
    }
}
