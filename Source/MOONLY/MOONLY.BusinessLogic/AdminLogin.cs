using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.BusinessLogic
{
   public class AdminLogin
    {
        private User _nguoidung;
        public User Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        private bool _isauthenticated;
        public bool IsAuthenticated
        {
            get { return _isauthenticated; }
            set { _isauthenticated = value; }
        }
        public void Thucthi()
        {
            SelectAdminAccesst dangnhapadmin = new
            SelectAdminAccesst();
            dangnhapadmin.Nguoidung = this.Nguoidung;
            Ketqua = dangnhapadmin.Laydulieu();
            GridView grid = new GridView();
            grid.DataSource = Ketqua;
            grid.DataBind();
            if (grid.Rows.Count != 0)
            {
                IsAuthenticated = true;
            }
            else
            {
                IsAuthenticated = false;
            }
        }
    }
}
