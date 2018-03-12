using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{

    class DAL_QLUser
    {

        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        public List<user> Get_List_User()
        {
            List<user> lst_User = new List<user>();
            try
            {
                lst_User = (from data in _db.user
                                where (data.Status == true)
                                select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_User;
        }
        public user Get_User(int id_User)
        {
            user User = new user();
            try
            {
                User = (from data in _db.user
                            where (data.Status == true && data.id == id_User)
                            select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return User;
        }
        /// <summary>
        ///  function insert and update and delete User
        /// </summary>
        /// <param name="ctgr"></param>         model User
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>
        public bool Add_and_Edit_User(user ctgr, int action_status)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(ctgr.id.ToString()) > 0)
                {
                    user data_edit = new user();
                    data_edit = Get_User(ctgr.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        data_edit.UserName = ctgr.UserName;
                        data_edit.PassWord = ctgr.PassWord;
                        data_edit.Note = ctgr.Note;
                        data_edit.UpdatedAt = DateTime.Now;
                    }
                    else if (action_status == Variable.action_status.is_delete)         // delete data
                    {
                        data_edit.Status = ctgr.Status;
                    }
                }
                else
                {
                    _db.user.Add(ctgr);                                           // add data
                }
                _db.SaveChanges();
                check = true;
            }
            catch (Exception)
            {
                return check;
            }
            return check;
        }
    }
}
