using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class AddNewProduct
    {
        private Producct _product;
        public Producct Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuSanPham dulieusanpham = new ChenDuLieuSanPham();
            dulieusanpham.Sanpham = this.Product;
            dulieusanpham.ChenDuLieu();
        }
    }
}
