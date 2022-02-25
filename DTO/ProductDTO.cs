using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDay11.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }

        public string ProductName {get;set;}
        public string Manufacture {get; set;}
        public int CategoryID { get; set; }
    }
}