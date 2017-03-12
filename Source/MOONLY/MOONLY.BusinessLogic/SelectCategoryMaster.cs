using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class SelectCategoryMaster
    {
        private SqlDataSource _result;

        public SqlDataSource Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void Thucthi()
        {
            TruyVanDuLieuDanhMucMaster dulieudanhmucsanpham = new TruyVanDuLieuDanhMucMaster();
            Result = dulieudanhmucsanpham.Laydulieu();
        }

    }
}
