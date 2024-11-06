using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectData22.Model
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public string NameProduct { get; set; }
        public decimal PriceProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public bool Status { get; set; } = false;
        public string Image { get; set; }


    }
}
