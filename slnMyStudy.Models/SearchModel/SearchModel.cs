using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Models
{
    public class SearchModel
    {
        public string SearchInfo { get; set; }

        public int? id { get; set; }
    }

    public class ApiSearchModel 
    {
        public string searchTitle { get; set; }
        public string searchTest_time { get; set; }
        public string searchStart_time { get; set; }
        public string searchEnd_time { get; set; }
        public string[] searchClassName { get; set; }
    }
}
