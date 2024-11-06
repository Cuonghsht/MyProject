using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectData22.Model
{
    public class CartDetail
    {
        public int IdCartDetail { get; set; }
        public Guid IdCart { get; set; }
        public int Quantity { get; set;}
        public decimal Total { get; set;}
        public DateTime NgayThemVao { get; set; }

    }
}
