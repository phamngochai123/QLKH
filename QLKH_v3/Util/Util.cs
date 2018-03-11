using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.Util
{
    class Util
    {
        public void Show_Message_Error(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Show_Message_Notification(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool Show_Message_YesNo(string title, string message)
        {
            bool check = false;
            DialogResult dialogResult = MessageBox.Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                check = true;
                return check;
            }
            else if (dialogResult == DialogResult.No)
            {
                check = false;
                return check;
            }
            return check;
        }
        public int Cnv_Int(string val)
        {
            int dtrt = 0;
            try
            {
                dtrt =  int.Parse(val.Trim().ToLower());
            }
            catch (Exception)
            {
                dtrt = 0;
            }
            return dtrt;
        }
        public DataTable ToDataTable(List<> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
