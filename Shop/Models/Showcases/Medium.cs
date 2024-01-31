using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models.Showcases
{
    internal class Medium : IShowcase
    {
        public Guid Id { get; }

        public int Volume { get; }

        public DateTime dateTimeCreate { get; set; }
        public DateTime? dateTimeUpdate { get; set; }

        public Medium() 
        {
            Id = Guid.NewGuid();
            Volume = 9;
            dateTimeCreate = DateTime.Now;
        }
    }
}
