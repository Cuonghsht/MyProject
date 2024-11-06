using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectData22.Model
{
    public class Bill
    {
         public Guid IdBill { get; set; }
        public DateTime NgayHoanthanh { get; set; } = DateTime.Now;
        public Guid IdUser { get; set; }
        public decimal ToTal { get; set; }
    }
}
