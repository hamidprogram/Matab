using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region رفرنس های مورد نیاز



using System.Collections.Generic;
using BE;
using DAL;
#endregion

namespace BLL
{
    public class User_BLL
    {
        User_DAL dal = new User_DAL();

        #region ساخت کاربر

        

        public string Create(User usr)
        {
            return dal.Create(usr);
        }
        #endregion

        #region خوندن اطلاعات جدول


        public List<User> Read()
        {
            return dal.Read();
        }
        #endregion

        #region خوندن اطلاعات با شماره


        public User Read(int id)
        {
            return dal.Read(id);
        }
        #endregion

        #region تصحیح اطلاعات

        

        public string Update(int id, User unew)
        {
            return dal.Update(id, unew);
        }
        #endregion

        #region حذف اطلاعات

        

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        #endregion

        #region برسی موجود بودن کاربر هنگام ورود به برنامه

        

        public byte Regester(string username, string password)
        {
            return dal.Regester(username, password);
        }
        #endregion

        #region برسی اولین ورود

        

        public byte CheckNull()
        {
            return dal.CheckNull();
        }
        #endregion
    }
}
