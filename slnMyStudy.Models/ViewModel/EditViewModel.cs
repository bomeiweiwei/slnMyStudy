using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Models.ViewModel
{
    public class EditViewModel : RegisterViewModel
    {
        [DataType(DataType.Password)]
        public string Newpwd { get; set; }
    }
}
