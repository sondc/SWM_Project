using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class UserType
    {
        private int _idUserType;
        public int IdUserType
        {
            get { return _idUserType; }
            set { _idUserType = value; }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public UserType()
        {
        }
    }
}
