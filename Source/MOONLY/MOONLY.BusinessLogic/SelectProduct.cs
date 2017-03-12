using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class SelectProduct
    {
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Select.SelectProduct dulieusanpham = new MOONLY.DataAccess.Select.SelectProduct();
            Ketqua = dulieusanpham.Laydulieu();
        }
    }
}
