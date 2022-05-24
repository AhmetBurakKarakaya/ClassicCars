using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tumbnail { get; set; }
        public bool IsActive { get; set; }
        public DateTime createTime { get; set; }
    }
}
