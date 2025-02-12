using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_L01.Data
{
    internal class Product
    {
        //Properaties
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //Constactour
        //public int CompareTo(Product? other)
        //{
        //    return this.UnitPrice.CompareTo(other?.UnitPrice);
        //}

        //Override to string
        public override string ToString()
            => $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";
    }
}
