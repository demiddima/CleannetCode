using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    internal interface ISection
    {
        Guid Id { get; }
        int Volume { get; }
        DateTime dateTimeCreate { get; set; }
        DateTime? dateTimeUpdate { get; set; }
    }
}
