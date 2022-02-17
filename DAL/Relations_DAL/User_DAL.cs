using System;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز
using System.Collections.Generic;
using System.Linq;
using BE;
#endregion

namespace DAL
{
    public class User_DAL
    {
        DB db = new DB();

        #region ساخت کاربر

        

        public string Create(User usr)
        {
            if (!Read(usr))
            {
                db.Users.Add(usr);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";
            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        #endregion

        #region برسی تکراری بودن اطلاعات وارد شده

        

        public bool Read(User usr)
        {
            return db.Users.Any(i => i.UserName ==usr.UserName  && i.Password == usr.Password);
        }
        #endregion

        #region خوند اطلاعات از جدول کاربر ها

        

        public List<User> Read()
        {
            return db.Users.ToList();
        }
        #endregion

        #region خوند اطلاعات کاربر با شماره

        

        public User Read(int id)
        {
            return db.Users.Where(i => i.ID == id).Single();
        }
        #endregion

        #region تصحیح اطلاعات کاربر

        

        public string Update(int id, User unew)
        {
            User u = new User();
            u = Read(id);
            u.UserName = unew.UserName;
            u.Password = unew.Password;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region حذف اطلاعات کاربر

        

        public string Delete(int id)
        {
            User u = Read(id);
            db.Users.Remove(u);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        #endregion

        #region برسی صحیح بودن رمز و نام کاربری هنگام ورود کاربر

        

        public byte Regester(string username, string password)
        {
            if (db.Users.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.Users.Any(i => i.UserName == username && i.Password == password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        #endregion

        #region برسی اولین بار ورود کاربر

        

        public byte CheckNull()
        {
            if(db.Users.Count() == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        #endregion
    }
}
