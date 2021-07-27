using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    public partial class CommonOut
    {
        public string Message { get; set; }
        public Result Result { get; set; }
    }

    public enum Result{
        success,
        error,


    }
}
