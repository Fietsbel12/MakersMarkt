using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersMarkt.Data
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public DateTime ProductionTime { get; set; }
    }
}
