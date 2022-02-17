using System;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز
using System.Collections.Generic;//برای استفاده از کلاس ها واجب است
using System.Linq;//برای کوئری نوشتن
using BE;//استفاده از لایه ی کلاس ها
#endregion

namespace DAL
{
    public class Customer_DAL
    {
        DB db = new DB();//نمونه گیری از کلاس db در این لایه
        #region تمام تابع ها
        #region تابع برای ساخت بیمار
        /// <summary>
        /// ساخت بیمار
        /// </summary>
        /// <param name="cos">یک کلاس از نوع بیمار</param>
        /// <returns></returns>
        public string Create(Customer cos)
        {
            if (!Read(cos))
            {
                if ((cos.Codemely.Length > 9) && (cos.PhoneNumber.Length > 10))
                {
                    db.Customers.Add(cos);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "کد ملی یا شماره تلفن نا معتبر است";
                }
            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        #endregion
        #region برای چک کردن اینکه اطلاعات وارد شده تکراری نباشد
        public bool Read(Customer k)
        {
            return db.Customers.Any(i => i.Name == k.Name && i.Codemely == k.Codemely);
        }
        #endregion
        #region تابع نمایش جدول بیمار ها
        /// <summary>
        /// تابع نمایش کل جدول
        /// </summary>
        /// <returns></returns>
        public List<Customer> Read()
        {
            return db.Customers.ToList();
        }
        #endregion
        #region تابع برای گرفتن شماره به منظور تصحیح و حذف
        /// <summary>
        /// تابع برای کشیدن بیرون اطلاعات از جدول بیمار ها
        /// </summary>
        /// <param name="id">شماره ی بیمار مورد نظر</param>
        /// <returns></returns>
        public Customer Read(int id)
        {
            return db.Customers.Where(i => i.ID == id).Single();
        }
        #endregion
        #region تابع جست و جوی بیمار
        /// <summary>
        /// تابع برای جست جوی بیمار
        /// </summary>
        /// <param name="ncos">نام بیمار</param>
        /// <returns></returns>
        public List<Customer> Serch(string ncos)
        {
            return (from i in (new DB()).Customers where i.Name.Contains(ncos) select i).ToList();
        }
        #endregion
        #region تابع برای تصحیح بیمار
        /// <summary>
        /// تابع تصحیح بیمار
        /// </summary>
        /// <param name="id">شماره ی بیمار مورد نظر</param>
        /// <param name="cnew">یک کلاس از نوع بیمار</param>
        /// <returns></returns>
        public string Update(int id, Customer cnew)
        {
            Customer c = new Customer();
            c = Read(id);
            c.Name = cnew.Name;
            c.Codemely = cnew.Codemely;
            c.Age = cnew.Age;
            c.PhoneNumber = cnew.PhoneNumber;
            c.Sick = cnew.Sick;
            c.LastSick = cnew.LastSick;
            c.Description = cnew.Description;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        #endregion
        #region تابع حذف بیمار
        /// <summary>
        /// تابع حذف بیمار
        /// </summary>
        /// <param name="id">شماره ی بیمار مورد نظر</param>
        /// <returns></returns>
        public string Delete(int id)
        {
            Customer k = Read(id);
            db.Customers.Remove(k);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        #endregion
        #endregion
    }
}
