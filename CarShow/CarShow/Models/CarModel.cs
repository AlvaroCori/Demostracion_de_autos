using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShow.Models
{
    public class CarModel
    {
       ///[Required]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime? Date { get; set; }
        public string Company { get; set; }
        
        public int? Velocity { get; set; }
        public string MainPhoto { get; set; }

        public string Description { get; set; }
    }
}
