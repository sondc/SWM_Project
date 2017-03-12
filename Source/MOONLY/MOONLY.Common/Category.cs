using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class Category
    {
        private int _idCategory;
        public int IdCategory
        {
            get { return _idCategory; }
            set { _idCategory = value; }
        }
        private string _categoryName;
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
        public Category()
        {
        }
    }
}
