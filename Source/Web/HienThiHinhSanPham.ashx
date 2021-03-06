<%@ WebHandler Language="C#" Class="HienThiHinhSanPham" %>

using System;
using System.Web;
using System.Data;
using System.Web.UI;
using MOONLY.Common;
using MOONLY.BusinessLogic;
using System.Web.UI.WebControls;



public class HienThiHinhSanPham : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        Producct sanpham = new Producct();
        sanpham.Idhinhsanpham = int.Parse(context.Request.QueryString["Idhinhsanpham"]);
        SelectProductPic XuLyLayHinh = new SelectProductPic();
        XuLyLayHinh.Sanpham = sanpham;
        XuLyLayHinh.Thucthi();
        SqlDataSource src = new SqlDataSource();
        src = XuLyLayHinh.Ketqua;
        DataView view = (DataView)src.Select(DataSourceSelectArguments.Empty);
        context.Response.BinaryWrite((byte[])view[0]["DuLieuHinhSanPham"]);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}