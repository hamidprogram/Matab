using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Customer
    {
        #region کلاس هر بیمار
        public int ID { get; set; }//شماره ی هر بیمار
        public string Name { get; set; }//نام هر بیمار
        public string Codemely { get; set; }//کد ملی هر بیمار
        public byte Age { get; set; }//سن هر بیمار
        public string PhoneNumber { get; set; }//شماره تماس هر بیمار
        public string Sick { get; set; }//نوع بیماری هر بیمار
        public string LastSick { get; set; }//بیماری های زمینه ای هر بیمار
        public string Description { get; set; }//توضیحات هر بیمار
        #endregion
    }
}
