using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Data.Entities
{
    public class VideoGallery
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
