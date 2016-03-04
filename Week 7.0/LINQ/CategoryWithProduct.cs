using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class CategoryWithProduct
    {
        private string categoryName;
        private List<string> productsName;
        private int categoryID;

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }

        public List<string> ProductsName
        {
            get
            {
                return productsName;
            }

            set
            {
                productsName = value;
            }
        }

        public int CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public CategoryWithProduct(string categoryName, List<string> productsName, int categoryID)
        {
            CategoryName = categoryName;
            ProductsName = productsName;
            CategoryID = categoryID;
        }
    }
}
