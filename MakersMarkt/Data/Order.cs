using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersMarkt.Data
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int BuyerId { get; set; }
        public int ProductId { get; set; }
        public string status { get; set; }
        public string StatusDescription { get; set; }
    }
}
