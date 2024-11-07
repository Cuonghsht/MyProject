using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectData.Model
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public string NameProduct { get; set; }
        public decimal PriceProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public bool Status { get; set; } = false;
        public string Image { get; set; }
        public  ICollection<CartDetail> CartDetail { get; set; } = new List<CartDetail>();
        public ICollection<BillDetail> BillDetais { get;set; } = new List<BillDetail>();

    }
}
