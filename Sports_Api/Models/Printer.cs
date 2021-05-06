using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Printer
    {
        [Key]
        public int PrinterId { get; set; }
        public string PrinterName { get; set; }
        public string FolderToMinitor { get; set; }
        public string OutPutType { get; set; }
        public string FileOutput { get; set; }
        public int MakeId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
