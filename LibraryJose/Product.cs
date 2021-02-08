using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryJose
{
    public class Product
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public int ProductID { get; set; }

        public string ProductModel { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubcategory { get; set; }

        public string PrincipalInfo
        {
            get
            {
                return $"{ Name } { Description } ";
            }
        }

        public override string ToString()
        {
            //return $"{ ProductModel } | { Description } ";
            return $"{ Name }   |   { Description } ";
        }

    }
}
