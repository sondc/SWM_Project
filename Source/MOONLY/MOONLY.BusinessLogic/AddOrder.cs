using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Insert;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
   public class AddOrder
    {
        private Order _donhang;
        public Order Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuDonHang chendulieudonhang = new ChenDuLieuDonHang();
            ChenDuLieuChiTietDonHang chenchitietdonhang = new ChenDuLieuChiTietDonHang();
            chendulieudonhang.Donhang = this.Donhang;
            GridView g = new GridView();
            g.DataSource = chendulieudonhang.chenVaLaydulieu();
            g.DataBind();

            Donhang.IdOrder = int.Parse(g.Rows[0].Cells[0].Text);
            chenchitietdonhang.Chitietdonhang = Donhang.Chitietdonhang;
            for (int i = 0; i < Donhang.Chitietdonhang.Sanpham.Length; i++)
            {
                chenchitietdonhang.Chitietdonhang.IdOrder = Donhang.IdOrder;
                chenchitietdonhang.Chitietdonhang.IdProduct =
                Donhang.Chitietdonhang.Sanpham[i].Idsanpham;
                chenchitietdonhang.Chitietdonhang.Quanlity =
                Donhang.Chitietdonhang.Sanpham[i].Soluong;
                chenchitietdonhang.chendulieuchitiet();
            }
        }
    }
}
