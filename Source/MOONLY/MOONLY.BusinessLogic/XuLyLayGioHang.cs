using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class XuLyLayGioHang
    {
        private SqlDataSource _ketqua;
        private Cart _giohang;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuGioHang dulieugiohang = new TruyVanDuLieuGioHang();
            dulieugiohang.Giohang = Giohang;
            Ketqua = dulieugiohang.Laydulieu();
        }
    }
}
