using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Group1.Models
{
    [Serializable]// sắp xếp theo thứ tự
    public class LoginModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập UserName!")]
        public string Account { set; get; }

        [Required(ErrorMessage = "Bạn chưa nhập Password!")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}