using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز



using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
#endregion

namespace Matab3
{
    public partial class BackUp : UserControl
    {
        #region رشته ی اتصال

        

        private string BackUpConString = @"data source=(local);initial catalog=DBMatab;integrated security=True;multipleactiveresultsets=True";//Connection String baraye Dastyabi be Data base Asli
        private string ReStoreConString = "Data Source=(local);Initial Catalog=master;Integrated Security=True";//Connection String baraye dastresi be data base Master
        #endregion
        public BackUp()
        {
            InitializeComponent();
        }

        public void BtnBackup_Click(object sender, EventArgs e)
        {
            #region گرفتن پشتیبانی از اطلاعات

            

            using (SqlConnection con = new SqlConnection(BackUpConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = "DBMatab";//Bayad ham nam ba Data base barname tanzim shavad
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "BackUp File|*.DBMatab";
                        sfd.FileName = "BackUp_" + (DateTime.Now.ToShortDateString().Replace('/', '.'));
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(sfd.FileName, DeviceType.File);
                            bkpDatabase.Devices.Add(bkpDevice);
                            bkpDatabase.SqlBackup(srvr);
                            MessageBox.Show("فایل پشتیبان با موفقیت ذخیره شده", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception s) { MessageBox.Show("لطفا فایل بک آپ را در درایوی غیر از درایو ویندوز ذخیره کنید"); }
                }
            }
            #endregion
        }

        public void BtnRestore_Click(object sender, EventArgs e)
        {
            #region بازیابی اطلاعات

            

            if (MessageBox.Show("ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند!!! \n اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "DataBase ReStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection.ClearAllPools();
                using (SqlConnection con = new SqlConnection(ReStoreConString))
                {
                    ServerConnection srvConn = new ServerConnection(con);
                    Server srvr = new Server(srvConn);
                    srvr.KillAllProcesses("DBMatab");
                    if (srvr != null)
                    {
                        try
                        {

                            Restore rstDatabase = new Restore();
                            rstDatabase.Action = RestoreActionType.Database;
                            rstDatabase.Database = "DBMatab";//Bayad ham nam ba Data base barname tanzim shavad
                            OpenFileDialog opfd = new OpenFileDialog();
                            opfd.Filter = "BackUp File|*.DBMatab";
                            if (opfd.ShowDialog() == DialogResult.OK)
                            {

                                BackupDeviceItem bkpDevice = new BackupDeviceItem(opfd.FileName, DeviceType.File);
                                rstDatabase.Devices.Add(bkpDevice);

                                rstDatabase.ReplaceDatabase = true;
                                rstDatabase.SqlRestore(srvr);
                                MessageBox.Show("اطلاعات با موفقیت بازیابی شد", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            #endregion
        }
    }
}
