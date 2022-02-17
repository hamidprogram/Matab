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
    public class VisitTurn_DAL
    {
        DB db = new DB();

        #region ساخت نوبت ویزیت

        

        public string Create(VisitTurn vis)
        {
            if (!Read(vis))
            {
                db.VisitTurns.Add(vis);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";
            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        #endregion

        #region برسی تکراری بودن اطلاعات

        

        public bool Read(VisitTurn k)
        {
            return db.VisitTurns.Any(i => i.TimeTurn == k.TimeTurn && i.DeteTurn == k.DeteTurn);
        }
        #endregion

        #region خودن اطلاعات با شماره

        

        public VisitTurn Read(int id)
        {
            return db.VisitTurns.Where(i => i.ID == id).Single();
        }
        #endregion

        #region جیت و جو با نام بیمار

        

        public List<VisitTurn> SerchByName(string vcos)
        {
            int n = db.Customers.Single(i => i.Name == vcos).ID;
            return (from i in (new DB()).VisitTurns where i.CustomerID == n select i).ToList();
        }
        #endregion

        #region تصحیح نوبت ویزیت

        

        public string Update(int id, VisitTurn vnew)
        {
            VisitTurn v = new VisitTurn();
            v = Read(id);
            v.CustomerID = vnew.CustomerID;
            v.DeteTurn = vnew.DeteTurn;
            v.TimeTurn = vnew.TimeTurn;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region حذف نوبت ویزیت

        

        public string Delete(int id)
        {
            VisitTurn k = Read(id);
            db.VisitTurns.Remove(k);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region خوندن اطلاعات جدول

        

        public DataTable Read()
        {
            var select = "SELECT dbo.VisitTurns.ID, dbo.VisitTurns.CustomerID, dbo.Customers.Name, dbo.VisitTurns.DeteTurn, dbo.VisitTurns.TimeTurn FROM dbo.VisitTurns INNER JOIN dbo.Customers ON dbo.VisitTurns.CustomerID = dbo.Customers.ID";
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
