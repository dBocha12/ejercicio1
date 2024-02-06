using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejeercicio1
{
    internal class ClsMenu
    {

        public static int opcion;

        public static void menu(ClsProducto articulo) {

            do
            {
                try
                {
                    Console.WriteLine("====    MENU PRINCIPAL    ====");
                    Console.WriteLine("1) Agregar productos");
                    Console.WriteLine("2) Venta de productos");
                    Console.WriteLine("3) Actualizar productos");
                    Console.WriteLine("4) Actualizar precio");
                    Console.WriteLine("5) Reporte");
                    Console.WriteLine("6) Salir");
                    Console.WriteLine("Digite una opcion...");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            articulo.Agregar();
                            break;
                        case 2:
                            articulo.Venta();
                            break;
                        case 3:
                            articulo.Actualizar();
                            break;
                        case 4:
                            articulo.ActualizarPrecio();
                            break;
                        case 5:
                            articulo.Reporte();
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, digite enter para volver al menu");
                            break;
                    }

                } catch (Exception ex)
                {
                    Console.WriteLine("Error inesperado al buscar la opcion en el menu..");
                    Console.Clear();
                }
            } while (opcion!=6);
        }

    }
}
