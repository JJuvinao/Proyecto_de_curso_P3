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
        public string Contra { get; set; }
        public int PersoId1 { get; set; }
        public int PersoId2 { get; set; }
        public int PersoId3 { get;  set; }
        public string Rol { get; set; }

        public User(int id, string name, string contra, int persoId1, int persoId2, int persoId3, string rol)
        {
            Id = id;
            Name = name;
            PersoId1 = persoId1;
            PersoId2 = persoId2;
            PersoId3 = persoId3;
            Contra = contra;
            Rol = rol;
        }

        public override string ToString()
        {
            return $"{Id};{Name};{PersoId1};{PersoId2};{PersoId3};{Contra};{Rol}";
        }
    }
}
