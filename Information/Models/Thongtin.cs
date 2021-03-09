using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Information.Models
{
    [Table("thongtin")]
    public class Thongtin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Faculty { get; set; }
        public int PhoneNumber { get; set; }
    }
}