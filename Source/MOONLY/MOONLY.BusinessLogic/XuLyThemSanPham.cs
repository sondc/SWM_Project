using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class XuLyThemSanPham
    {
        private Producct _sanpham;
        public Producct Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuSanPham dulieusanpham = new ChenDuLieuSanPham();
            dulieusanpham.Sanpham = this.Sanpham;
            dulieusanpham.ChenDuLieu();
        }
    }
}
