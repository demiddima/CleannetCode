using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models.Section
{
    internal class Sections<T> where T : ISection
    {
        List<ISection> sections = new List<ISection>();
    }
}
