using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class SelectCart
    {
        private SqlDataSource _result;
        private Cart _giohang;
        public SqlDataSource Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Select.SelectCart dulieugiohang = new MOONLY.DataAccess.Select.SelectCart();
            dulieugiohang.Giohang = Giohang;
            Result = dulieugiohang.Laydulieu();
        }
    }
}
