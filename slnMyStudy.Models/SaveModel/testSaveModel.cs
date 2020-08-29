using slnMyStudy.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Models.SaveModel
{
    public class TestSaveModel : test
    {
        public string TxtBox1 { get; set; }
        public string TxtBox2 { get; set; }
        public string TxtArea { get; set; }
        public List<int> TestIdList { get; set; }
        public List<TestViewModel> Test_SaveList { get; set; }
        public string searchClassName { get; set; }
    }
}
