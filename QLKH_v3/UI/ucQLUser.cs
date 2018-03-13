using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.UI
{
    public partial class ucQLUser : UserControl
    {
        int _ID_USER;
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        DAL.DAL_QLUser Dal_User = new DAL.DAL_QLUser();
        public ucQLUser()
        {
            InitializeComponent();
            
        }
        private void Load_Data()
        {
            try
            {
                grcUser.DataSource = Util.ConvertToDataTable(Dal_User.Get_List_User());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }
        private void ucQLUser_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void grvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = grvUser.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                //if (flag != "add" && flag != "edit")
                //{
                Form form = new Form();
                form.ShowDialog(this);
                _ID_USER = Util.Cnv_Int(row["id"].ToString().Trim());
                Fill_Data_User(_ID_USER);

                //}
            }
        }

        private void Fill_Data_User(int id_user)
        {
            user User = new user();
            User = Dal_User.Get_User(id_user);
            txt_username.Text = User.UserName.ToString();
            txt_password.Text = User.PassWord.ToString();
            //txt_fullname_user.Text = String.IsNullOrEmpty(User.FullName) ? User.FullName.ToString() : "";
            //txt_cmnd_user.Text = String.IsNullOrEmpty(User.IdCard) ? User.IdCard.ToString() : "";
        }

        private void grcUser_Click(object sender, EventArgs e)
        {

        }

    }
}
