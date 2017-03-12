using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
  public  class SelectCart
    {
        private Cart _giohang;
        public Cart Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "GioHang_Select";
            sqldata.SelectParameters.Add("CartGUID", Giohang.Cartguid);
            return sqldata;
        }
    }
}
