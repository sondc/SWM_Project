using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Update;

namespace MOONLY.BusinessLogic
{
   public class UpdateProduct
    {
        private Producct _sanpham;
        public Producct Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Update.UpdateProduct dulieusanpham = new
            MOONLY.DataAccess.Update.UpdateProduct();

            dulieusanpham.Sanpham = this.Sanpham;
            dulieusanpham.CapNhatSanphammoi();
        }
    }
}
