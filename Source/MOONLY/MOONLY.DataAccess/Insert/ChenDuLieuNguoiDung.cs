using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Insert
{
   public class ChenDuLieuNguoiDung
    {
        private User _nguoidung;
        public User Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void chendulieunguoidung()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "NguoiDung_Insert";
            sqldata.InsertParameters.Add("HoTen", Nguoidung.Name.ToString());
            sqldata.InsertParameters.Add("TenDangNhap", Nguoidung.Acccount.ToString());
            sqldata.InsertParameters.Add("DiaChi", Nguoidung.Address.ToString());
            sqldata.InsertParameters.Add("MaDienThoai", Nguoidung.Madienthoai.ToString());
            sqldata.InsertParameters.Add("SoDienThoai", Nguoidung.Phone.ToString());
            sqldata.InsertParameters.Add("SoFax", Nguoidung.Sofax.ToString());
            sqldata.InsertParameters.Add("Email", Nguoidung.Email.ToString());
            sqldata.InsertParameters.Add("IDKieuNguoiDung", Nguoidung.IdUserType.ToString());
            sqldata.InsertParameters.Add("MatKhau", Nguoidung.Password.ToString());
            sqldata.Insert();

        }
    }
}
