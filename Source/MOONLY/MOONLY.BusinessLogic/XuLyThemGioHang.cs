using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class XuLyThemGioHang
    {
        private Cart _giohang;
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuGioHang dulieugiohang = new ChenDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.chendulieugiohang();
        }
    }
}
