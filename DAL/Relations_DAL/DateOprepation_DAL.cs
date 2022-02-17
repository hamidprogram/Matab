using System;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BE;
#endregion

namespace DAL
{
    public class DateOprepation_DAL
    {
        DB db = new DB();
        #region ساخت زمان جراحی عمل
        public string Create(DateOprepation dat)
        {
            db.Oprepations.Add(dat);
            db.SaveChanges();
            return "ثبت اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region خوند اطلاعات با شماره جدول
        public DateOprepation Read(int id)
        {
            return db.Oprepations.Where(i => i.ID == id).Single();
        }
        #endregion

        #region جست و جو با نام بیمار
        public List<DateOprepation> SerchByName(string dcos)
        {
            int n = db.Customers.Single(i => i.Name == dcos).ID;
            return (from i in (new DB()).Oprepations where i.CustomerID == n select i).ToList();
        }
        #endregion

        #region تصحیح نوبت عمل
        public string Update(int id, DateOprepation onew)
        {
            DateOprepation opr = new DateOprepation();
            opr = Read(id);
            opr.CustomerID = onew.CustomerID;
            opr.DateOfOprepation = onew.DateOfOprepation;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region حذف نوبت عمل

        

        public string Delete(int id)
        {
            DateOprepation k = Read(id);
            db.Oprepations.Remove(k);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region خوندن اطلاعات از جدول
        public DataTable Read()
        {
            var select = "SELECT dbo.DateOprepations.ID, dbo.DateOprepations.CustomerID, dbo.Customers.Name, dbo.DateOprepations.DateOfOprepation FROM dbo.DateOprepations INNER JOIN dbo.Customers ON dbo.DateOprepations.CustomerID = dbo.Customers.ID";
            var c = new SqlConnection("Data Source=(local);Initial Catalog=DBMatab;Integrated Security=true");
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds.Tables[0];
        }
        #endregion
    }
}
