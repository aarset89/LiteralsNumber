using Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LocationNumIn
    {
        [Required]
        [RegularExpression("^[A-Za-z]+$")]
        public string input { get; set; }
    }
}
