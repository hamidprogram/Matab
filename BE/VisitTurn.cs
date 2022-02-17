using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VisitTurn
    {
        #region کلاس نوبت دهی
        public int ID { get; set; }//شماره ی هر نوبت
        public int CustomerID { get; set; }//شماره ی هر بیماری که نوبت به او تعلق دارد
        public virtual Customer Customer { get; set; }//ارتباط با کلاس بیمار
        public string DeteTurn { get; set; }//تاریخ هر نوبت
        public string TimeTurn { get; set; }//ساعت هر نوبت
        #endregion
    }
}
