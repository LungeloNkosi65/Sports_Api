using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Make
    {
        [Key]

        public int MakeId { get; set; }
        public string PrinterMake { get; set; }
    }
}
