using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
  public  class SelectOrderDetail
    {
        private OrderDetail _chitietdonhang;
        public OrderDetail Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Select.SelectOrderDetail truyvanchitietdonhang = new
            MOONLY.DataAccess.Select.SelectOrderDetail();

            truyvanchitietdonhang.Chitietdonhang = this.Chitietdonhang;
            Ketqua = truyvanchitietdonhang.Laydulieu();
        }
    }
}
