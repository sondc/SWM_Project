using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class Cart
    {
        private int _idCart;
        private string _cartguid;
        private int _quanlity;
        private int _idProduct;
        private DateTime _ngaytaogiohang;

        public int IdCart
        {
            get { return _idCart; }
            set { _idCart = value; }
        }

        public string Cartguid
        {
            get { return _cartguid; }
            set { _cartguid = value; }
        }
        public int Quanlity
        {
            get { return _quanlity; }
            set { _quanlity = value; }
        }
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        public DateTime Ngaytaogiohang
        {
            get { return _ngaytaogiohang; }
            set { _ngaytaogiohang = value; }
        }
        public Cart()
        {
        }
    }
}
