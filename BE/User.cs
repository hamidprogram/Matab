using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        #region کلاس کاربر ها
        public int ID { get; set; }//شماه ی هر کاربر
        public string UserName { get; set; }//نام کاربری
        public string Password { get; set; }//رمز عبور
        #endregion
    }
}
