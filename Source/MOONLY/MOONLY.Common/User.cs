using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class User
    {
        private int _idUser;
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        private int _idUserType;
        public int IdUserType
        {
            get { return _idUserType; }
            set { _idUserType = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _account;
        public string Acccount
        {
            get { return _account; }
            set { _account = value; }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _sofax;
        public string Sofax
        {
            get { return _sofax; }
            set { _sofax = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _madienthoai;
        public string Madienthoai
        {
            get { return _madienthoai; }
            set { _madienthoai = value; }
        }
    }
}
