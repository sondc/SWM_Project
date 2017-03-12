using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuDangNhapAdmin
    {
        private User _nguoidung;
        public User Nguoidung
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
            sqldata.SelectCommand = "DangNhapAdmin_Select";
            sqldata.SelectParameters.Add("TenDangNhap", Nguoidung.Acccount);
            sqldata.SelectParameters.Add("MatKhau", Nguoidung.Password);
            return sqldata;
        }
    }
}
