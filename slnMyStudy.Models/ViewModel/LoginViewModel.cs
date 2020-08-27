using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Models.ViewModel
{
    public class LoginViewModel
    {
        
        [StringLength(256)]
        [Display(Name = "員工信箱")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "員工帳號")]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "記住我?")]
        public bool RememberMe { get; set; }

        
}
}
