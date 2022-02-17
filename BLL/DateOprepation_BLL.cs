using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز


using System.Collections.Generic;
using System.Data;
using BE;
using DAL;

#endregion

namespace BLL
{
    public class DateOprepation_BLL
    {
        DateOprepation_DAL dal = new DateOprepation_DAL();

        #region ساخت نوبت

        

        public string Create(DateOprepation opr)
        {
            return dal.Create(opr);
        }
        #endregion

        #region خوندن اطلاعات با شماره

        

        public DateOprepation Read(int id)
        {
            return dal.Read(id);
        }
        #endregion

        #region جست و جو

        

        public List<DateOprepation> SerchByName(string dcos)
        {
            return dal.SerchByName(dcos);
        }
        #endregion

        #region تصحیح اطلاعات

        

        public string Update(int id, DateOprepation onew)
        {
            return dal.Update(id, onew);
        }
        #endregion

        #region حذف اطلاعات

        

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        #endregion

        #region خوند اطلاعات جدول

        

        public DataTable Read()
        {
            return dal.Read();
        }
        #endregion
    }
}
