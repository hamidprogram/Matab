using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز
using System.Data.Entity;//استفاده از ان تی یی
using BE;//استفاده از لایه ی بیزینس ان تی تی
#endregion

namespace DAL
{
    #region ساخت جدول در sql server
    public class DB:DbContext//وراثت از dbcontext
    {
        public DB(): base("name=con") { }//برای شناسی رشته ی اتصال
        //در خط بالا جلوی name نام رشته ی اتصال قرار میگیرد
        #region صدا زدن و ساختن جدول ها
        public DbSet<Customer> Customers { get; set; }//صدا زدن و ساختن جدول بیمار ها
        public DbSet<VisitTurn> VisitTurns { get; set; }//صدا زدن و ساختن جدول نوبت دهی
        public DbSet<DateOprepation> Oprepations { get; set; }//صدا زدن و ساختن جدول تاریخ عمل
        public DbSet<User> Users { get; set; }//صدا زدن و ساختن جدول کاربر ها
        #endregion
    }
    #endregion
}
