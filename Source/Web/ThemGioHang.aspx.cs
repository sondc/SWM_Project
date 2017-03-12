using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MOONLY.BusinessLogic;
using MOONLY.Operational;

public partial class ThemGioHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AddCart xulygiohang = new AddCart();
        MOONLY.Common.Cart giohang = new MOONLY.Common.Cart();
        giohang.IdProduct = int.Parse(Request.QueryString["IDsanpham"]);
        giohang.Cartguid = CartGUID;
        giohang.Quanlity = 1;
        xulygiohang.Cart = giohang;
        
        try
           {
        xulygiohang.Thucthi();
        }
        catch
        {
        Response.Redirect("Trangloi.aspx");
        }
        Response.Redirect("GioHang.aspx");
        }
        private string CartGUID
        {
        get { return TaoCartGUID.LayCartGUID(); }
    }
    }
