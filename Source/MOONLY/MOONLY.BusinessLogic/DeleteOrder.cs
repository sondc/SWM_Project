using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Delete;

namespace MOONLY.BusinessLogic
{
   public class DeleteOrder
    {
        private Cart _giohang;
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Delete.DeleteOrder dulieugiohang = new MOONLY.DataAccess.Delete.DeleteOrder();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.Xoadulieu();
        }
    }
}
