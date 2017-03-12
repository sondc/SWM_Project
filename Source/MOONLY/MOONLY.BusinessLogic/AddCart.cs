using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class AddCart
    {
        private Cart _cart;
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }
        public void Thucthi()
        {
            InsertCart dulieugiohang = new InsertCart();
            dulieugiohang.Giohang = this.Cart;
            dulieugiohang.chendulieugiohang();
        }
    }
}
