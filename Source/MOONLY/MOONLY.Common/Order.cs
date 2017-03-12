using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class Order
    {
        private int _idOrder;
        public int IdOrder
        {
            get { return _idOrder; }
            set { _idOrder = value; }
        }
        private int _idUser;
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        private DateTime _ngaytaodonhang;
        public DateTime Ngaytaodonhang
        {
            get { return _ngaytaodonhang; }
            set { _ngaytaodonhang = value; }
        }

        private DateTime _ngayxulydonhang;
        public DateTime Ngayxulydonhang
        {
            get { return _ngayxulydonhang; }
            set { _ngayxulydonhang = value; }
        }

        private int _idtinhtrangdonhang;
        public int Idtinhtrangdonhang
        {
            get { return _idtinhtrangdonhang; }
            set { _idtinhtrangdonhang = value; }
        }
        private string _trackingnumber;
        public string Trackingnumber
        {
            get { return _trackingnumber; }
            set { _trackingnumber = value; }
        }

        private User _nguoidung;
        public User Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }

        private OrderDetail _chitietdonhang;
        public OrderDetail Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        private string _idgiaodich;
        public string Idgiaodich
        {
            get { return _idgiaodich; }
            set { _idgiaodich = value; }
        }
        public Order()
        {
            _chitietdonhang = new OrderDetail();
            _nguoidung = new User();
        }
    }
}
