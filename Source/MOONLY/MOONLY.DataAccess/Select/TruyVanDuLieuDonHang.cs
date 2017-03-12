using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuDonHang
    {
        private User _nguoidung;
        public User NguoiDung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHang_Select";
            sqldata.SelectParameters.Add("IdNguoiDung", NguoiDung.IdUser.ToString());
            return sqldata;
        }
    }
}
