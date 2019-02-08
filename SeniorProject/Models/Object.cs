using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Models
{
    public class Object
    {
        public int ObjectId{ get; set; }
  
        public String ScannerType{ get; set; }

        public int weight{ get; set; }

        public String UserId{ get; set; }

        public DateTimeOffset TimeStamp{ get; set; }
    }
}
