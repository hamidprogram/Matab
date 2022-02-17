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
    public class VisitTurn_BLL
    {
        VisitTurn_DAL dal = new VisitTurn_DAL();

        #region ساخت نوبت



        public string Create(VisitTurn vis)
        {
            return dal.Create(vis);
        }
        #endregion

        #region خوندن اطلاعات با شماره



        public VisitTurn Read(int id)
        {
            return dal.Read(id);
        }
        #endregion

        #region جست جو


        public List<VisitTurn> SerchByName(string vcos)
        {
            return dal.SerchByName(vcos);
        }

        #endregion

        #region تصحیح نوبت

        

        public string Update(int id, VisitTurn vnew)
        {
            return dal.Update(id, vnew);
        }
        #endregion

        #region حذف نوبت

        

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        #endregion

        #region خوندن اطلاعات از جدول

        

        public DataTable Read()
        {
            return dal.Read();
        }
        #endregion
    }
}
