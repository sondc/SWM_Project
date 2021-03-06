using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.BusinessLogic
{
   public class SelectOrderByID
    {
        private Order _donhang;
        public Order Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        private SqlDataSource _result;
        public SqlDataSource Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public void Thucthi()
        {
            MOONLY.DataAccess.Select.SelectOrderByID donhangbyid = new
            MOONLY.DataAccess.Select.SelectOrderByID();
            donhangbyid.Donhang = this.Donhang;
            Result = donhangbyid.Laydulieu();

            GridView grid = new GridView();
            grid.DataSource = Result;
            grid.DataBind();
            if (grid.Rows.Count > 0)
            {
                if (grid.Rows[0].Cells[1].Text.ToString() != "&nbsp;")
                //grid.Rows[0].Cells[1]phu thuoc cau truy van, lay cot ngay xu ly don hang
                {
                    Donhang.Ngayxulydonhang =
                    Convert.ToDateTime(grid.Rows[0].Cells[1].Text.ToString());
                }
                Donhang.Trackingnumber =
                grid.Rows[0].Cells[3].Text.ToString().Replace("&nbsp;", "");
                Donhang.Idtinhtrangdonhang = int.Parse(grid.Rows[0].Cells[2].Text.ToString());

            }
        }
    }
}
