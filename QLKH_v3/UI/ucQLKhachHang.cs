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
    public partial class ucQLKhachHang : UserControl
    {
        int _ID_CUSTOMER;
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        DAL.DAL_QLCustomer Dal_Customer = new DAL.DAL_QLCustomer();
        public ucQLKhachHang()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            try
            {
                grcKhachHang.DataSource = Util.ConvertToDataTable(Dal_Customer.Get_List_Customer());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }
        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void grvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = grvKhachHang.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                //if (flag != "add" && flag != "edit")
                //{
                _ID_CUSTOMER = Util.Cnv_Int(row["id"].ToString().Trim());
                Fill_Data_Customer(_ID_CUSTOMER);

                //}
            }
        }

        private void Fill_Data_Customer(int id_customer)
        {
            customer Customer = new customer();
            Customer = Dal_Customer.Get_Customer(id_customer);
            //txt_username.Text = User.UserName.ToString();
            //txt_password.Text = User.PassWord.ToString();
            //txt_fullname_user.Text = String.IsNullOrEmpty(User.FullName) ? User.FullName.ToString() : "";
            //txt_cmnd_user.Text = String.IsNullOrEmpty(User.IdCard) ? User.IdCard.ToString() : "";
        }
    }
}
