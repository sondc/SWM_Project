using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class AddNewUser
    {
        private User _nguoidung;
        public User Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuNguoiDung nguoidungdata = new ChenDuLieuNguoiDung();
            nguoidungdata.Nguoidung = this.Nguoidung;
            nguoidungdata.chendulieunguoidung();
            this.Nguoidung.IdUser = nguoidungdata.Nguoidung.IdUser;
        }
    }
}
