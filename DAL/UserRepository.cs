using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string filename) : base(filename)
        {
        }

        public override List<User> GetAll()
        {
            List<User> user = new List<User>();

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                       user.Add(Map(line));
                    }
                }
            }

            return user;
        }

        private User Map(string line)
        {
            string[] columns = line.Split(';');
            int Id = int.Parse(columns[0]), perso1 = int.Parse(columns[2]), 
                perso2 = int.Parse(columns[3]), pers3 = int.Parse(columns[4]);
            string Name = columns[1];
            return new User  (Id,Name,perso1,perso2,pers3);
        }
    }
}
