using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_QLCategory
    {
        QLKHEntities _db = new QLKHEntities();
        public List<category> Get_List_Category()
        {
            List<category> lst_Category = new List<category>();
            try
            {
                lst_Category = (from data in _db.categories
                               where (data.Status== true)
                               select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_Category;
        }
        public category Get_Category(int id_category)
        {
            category Category = new category();
            try
            {
                Category = (from data in _db.categories
                            where (data.Status == true && data.id == id_category)
                            select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return Category;
        }
        public bool Add_Category(category ctgr) {
            bool is_update = false;
            try
            {
                _db.categories.Add(ctgr);
                _db.SaveChanges();
                is_update = true;
            }
            catch (Exception)
            {
                return is_update;
            }
            return is_update;
        }
    }
}
