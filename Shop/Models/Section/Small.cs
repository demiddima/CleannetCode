using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models.Section
{
    internal class Small : ISection
    {
        public Small()
        {
            Id = Guid.NewGuid();
            Volume = 1;
            dateTimeCreate = DateTime.Now;
        }

        public Guid Id { get; }
        public int Volume { get; }
        public DateTime dateTimeCreate { get; set; }
        public DateTime? dateTimeUpdate { get; set; }
    }
}
