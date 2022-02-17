using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز



using System.Collections.Generic;
using DAL;
using BE;
#endregion

namespace BLL
{
    public class Customer_BLL
    {
        Customer_DAL dal = new Customer_DAL();

        #region ساخت بیمار

        

        public string Create(Customer cos)
        {
            return dal.Create(cos);
        }
        #endregion

        #region برسی تکراری نبودن اطلاعات

        

        public bool Read(Customer cos)
        {
            return dal.Read(cos);
        }
        #endregion

        #region خوندن اطلاعات جدول

        

        public List<Customer> Read()
        {
            return dal.Read();
        }
        #endregion

        #region خوندن اطلاعات با شماره

        

        public Customer Read(int id)
        {
            return dal.Read(id);
        }
        #endregion

        #region جست و جو

        

        public List<Customer> Serch(string ncos)
        {
            return dal.Serch(ncos);
        }
        #endregion

        #region تصحیح اطلاعات

        

        public string Update(int id, Customer cnew)
        {
            return dal.Update(id, cnew);
        }
        #endregion

        #region حذف اطلاعات

        

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        #endregion
    }
}
