using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Update;

namespace MOONLY.BusinessLogic
{
   public class UpdateCart
    {
        private Cart _giohang;
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }

        public void Thucthi()
        {
            MOONLY.DataAccess.Update.UpdateCart dulieugiohang = new MOONLY.DataAccess.Update.UpdateCart();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.capnhatdulieu();
        }
    }
}
