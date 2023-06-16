using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string? VehicleType { get; set; }

        public string? VehicleColor { get; set;}
    }
}
