using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
  public  class SelectOrder
    {
        private User _nguoidung;
        public User Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Select.SelectOrder donhangchon = new MOONLY.DataAccess.Select.SelectOrder();
            donhangchon.NguoiDung = this.Nguoidung;
            Ketqua = donhangchon.Laydulieu();
        }
    }
}