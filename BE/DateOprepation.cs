using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DateOprepation
    {
        #region کلاس نوبت عمل
        public int ID { get; set; }//شماره ی هر نوبت عمل
        public int CustomerID { get; set; }//شماره ی بیمار که این نوبت مطعلق به او است
        public virtual Customer Customer { get; set; }//ارتباط بین این کلاس و کلاس بیمار
        public string DateOfOprepation { get; set; }//تاریخ عمل
        #endregion
    }
}
