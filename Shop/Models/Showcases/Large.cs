using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models.Showcases
{
    internal class Large : IShowcase
    {
        public Guid Id { get; }

        public int Volume { get; }

        public DateTime dateTimeCreate { get; set; }
        public DateTime? dateTimeUpdate { get; set; }

        public Large()
        {
            Id = Guid.NewGuid();
            Volume = 18;
            dateTimeCreate = DateTime.Now;
        }
    }
}
