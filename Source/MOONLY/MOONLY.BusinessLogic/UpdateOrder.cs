using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Update;

namespace MOONLY.BusinessLogic
{
   public class UpdateOrder
    {
        private Order _donhang;
        public Order Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Update.UpdateOrder donhangupdate = new MOONLY.DataAccess.Update.UpdateOrder();
            donhangupdate.Donhang = this.Donhang;
            donhangupdate.capnhatdulieu();
        }
    }
}
