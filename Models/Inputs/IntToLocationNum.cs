using Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IntToLocationNum
    {
        [Required]
        [RegularExpression("^[0-9]+$")]
        public int input { get; set; }
    }
}
