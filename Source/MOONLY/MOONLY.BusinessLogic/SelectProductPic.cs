using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class SelectProductPic
    {
        private Producct _sanpham;
        public Producct Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            SelectPictureByID chonhinhsanpham = new
            SelectPictureByID();
            chonhinhsanpham.Sanpham = this.Sanpham;
            Ketqua = chonhinhsanpham.Laydulieu();
        }
    }
}
