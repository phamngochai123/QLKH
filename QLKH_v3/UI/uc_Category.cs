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
    public partial class uc_Category : UserControl
    {
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public uc_Category()
        {
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            bool check = true;
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            return check;
        }
        private void Load_Data(){
             try
            {
                grcCategory.DataSource = Util.ConvertToDataTable(DAL_QLCategory.Get_List_Category());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }
        private void uc_Category_Load(object sender, EventArgs e)
        {
           Load_Data();
        }

        private void grvCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = grvCategory.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                //if (flag != "add" && flag != "edit")
                //{
                int id_category = Util.Cnv_Int(row["id"].ToString().Trim());
                Fill_Data_Category(id_category);

                //}
            }
        }
        private void Fill_Data_Category(int id_category)
        {
            category Category = new category();
            Category = DAL_QLCategory.Get_Category(id_category);

            txt_name_category.Text = Category.Name.ToString();
            txt_ghi_chu.Text = Category.Note.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            category ctgr = new category();
            try
            {
                if (CheckValidate() == true)
                {
                    ctgr.Name = txt_name_category.Text.Trim();
                    ctgr.Note = txt_name_category.Text.Trim();
                    ctgr.CreatedAt = DateTime.Now;
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.Status = true;

                    bool check = DAL_QLCategory.Add_Category(ctgr);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_add_data);
                        Load_Data();
                    }
                    else {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }

    }
}
