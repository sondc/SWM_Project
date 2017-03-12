using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
    public class OrderDetail
    {
        private int _idOrderDetail;
        public int IdOrderDetail
        {
            get { return _idOrderDetail; }
            set { _idOrderDetail = value; }
        }
        private int _idOrder;
        public int IdOrder
        {
            get { return _idOrder; }
            set { _idOrder = value; }
        }

        private int _idProduct;
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }

        private int _quanlity;
        public int Quanlity
        {
            get { return _quanlity; }
            set { _quanlity = value; }
        }
        private Producct[] _sanpham;
        public Producct[] Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public OrderDetail()
        {
        }
    }
}
