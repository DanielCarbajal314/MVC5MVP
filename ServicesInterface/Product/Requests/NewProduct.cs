using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterface.Product.Requests
{
    public class NewProduct
    {
        public int Stock { get; set; }
        public string Name { get; set; }
    }
}
