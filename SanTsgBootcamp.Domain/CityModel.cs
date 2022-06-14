using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SanTsgBootcamp.Domain
{
    public class CityModel
    {

        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; } 
    }
}
