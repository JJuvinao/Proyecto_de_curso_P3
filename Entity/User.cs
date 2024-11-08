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
        public string Rol { get; set; }

        public User() { }

        public User(int id, string name, string contra, string rol)
        {
            Id = id;
            Name = name;
            Contra = contra;
            Rol = rol;
        }

        public override string ToString()
        {
            return $"{Id};{Name};{Contra};{Rol}";
        }
    }
}
