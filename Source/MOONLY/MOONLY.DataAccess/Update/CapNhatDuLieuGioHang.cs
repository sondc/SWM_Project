using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Update
{
   public class CapNhatDuLieuGioHang
    {
        private Cart _giohang;
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "GioHang_Update";
            sqldata.UpdateParameters.Add("SoLuong", Giohang.Quanlity.ToString());
            sqldata.UpdateParameters.Add("IDGioHang", Giohang.IdCart.ToString());
            sqldata.Update();
        }
    }
}
