using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
    public class SearchProduct
    {
        private SqlDataSource _result;
        public SqlDataSource Result
        {
            get { return _result; }
            set { _result = value; }
        }
        private string _searchString;
        public string SearchString
        {
            get { return _searchString; }
            set { _searchString = value; }
        }
        public void thucthi()
        {
            TruyVanDuLieuTimSanPham timsanpham = new TruyVanDuLieuTimSanPham();
            Result = timsanpham.Laydulieu(SearchString);

        }
    }
}