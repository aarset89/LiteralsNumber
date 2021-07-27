using Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LocationNumAbreviated
    {
        [Required]
        [RegularExpression("^[A-Za-z0-9]+$")]
        public string Input { get; set; }
    }
}
