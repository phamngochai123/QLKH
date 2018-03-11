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
        public uc_Category()
        {
            InitializeComponent();
        }

        private void uc_Category_Load(object sender, EventArgs e)
        {
            try
            {
                grcCategory.DataSource = Util.ConvertToDataTable(DAL_QLCategory.Get_List_Category());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
               
            }
           
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
        
    }
}
