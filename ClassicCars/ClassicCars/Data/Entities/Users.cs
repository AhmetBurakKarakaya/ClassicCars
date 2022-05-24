using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; internal set; }
        public string Parola { get; internal set; }
        public string Tumbnail { get; set; }
        public DateTime createDate { get; set; }
        public int Role { get; set; }


    }
}
