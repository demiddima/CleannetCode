using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models.Showcases
{
    internal class Showcases<T> where T : IShowcase
    {
        List<IShowcase> showcases = new List<IShowcase>();


    }
}
