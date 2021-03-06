using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class PurchaseRequestModel
    {
        public int MovieId { get; set; }
        public Guid PurchaseNumber { get; } =Guid.NewGuid();
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; } =DateTime.Now;
    }
}
