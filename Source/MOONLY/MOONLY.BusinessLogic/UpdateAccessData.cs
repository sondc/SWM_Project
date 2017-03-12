using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Update;

namespace MOONLY.BusinessLogic
{
   public class UpdateAccessData
    {
       public void Thucthi()
       {
           UpdateDataAccess dulieuthongketruycap = new UpdateDataAccess();
           dulieuthongketruycap.Capnhatdulieu();
       }
    }
}
