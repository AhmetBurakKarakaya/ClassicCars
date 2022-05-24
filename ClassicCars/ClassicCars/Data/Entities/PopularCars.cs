using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Entities
{
    public class PopularCars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Tumbnail { get; set; }
        public bool IsActive { get; set; }
    }
}
