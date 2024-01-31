using Shop.Models;
using Shop.Models.Showcases;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Showcases<IShowcase> showcases = new Showcases<IShowcase>();

            showcases.Get();



        }
    }
}
