using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursRab
{
    class CListProduct
    {
        public List<СProduct> products;
        //public CAutomatCash Money = new CAutomatCash(50, 0);

        public CListProduct()
        {
            products = new List<СProduct>();
        }

        public void addProduct(params СProduct[] product)
        {
            foreach (СProduct pr in product)
            {
                products.Add(pr);
            }
        }

        public СProduct this[int index]
        {
            get
            {
                foreach (СProduct product in products)
                    if (product.index == index)
                        return product;
               return new СProduct();
            }
        }

        public void Del_product(СProduct del_product)
        {
            products.Remove(del_product);  
        }

        public СProduct Return_Product(int index)
        {
            if (index <= products.Count && index >= 0)
            {
                return products[index];
            }
            else return new СProduct();
        }

    }
}
