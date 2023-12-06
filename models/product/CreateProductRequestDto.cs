using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.models.product
{
    public class CreateProductRequestDto
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
