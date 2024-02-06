using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejeercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ClsProducto articulo = new ClsProducto(); 
            ClsMenu.menu(articulo);

            Console.Read();
        }
    }
}
