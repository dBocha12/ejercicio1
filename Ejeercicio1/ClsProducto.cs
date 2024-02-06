using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ejeercicio1
{
    internal class ClsProducto
    {
        // Atributos
        public int Codigo;
        public string Descripcion;
        public int Existencia;
        public int Minimo;
        public float Precio;

        // Lista de productos
        private List<ClsProducto> lista = new List<ClsProducto>();

        // Constructor
        public ClsProducto(int codigo, string descripcion, int existencia, int minimo, float precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Minimo = minimo;
            Precio = precio;
        }

        // Constructor vacío
        public ClsProducto() { }

        public void Agregar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Digite el codigo");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Descripcion");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Digite La existencia");
            int existencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el minimo para restock");
            int minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite precio");
            float precio = float.Parse(Console.ReadLine());

            lista.Add(new ClsProducto(cod, descripcion, existencia, minimo, precio));

            Console.WriteLine("Elementos de la lista");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + " " + item.Descripcion);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-");
            }
            Console.WriteLine("......");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

        }

        public void Venta()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("====    INVENTARIO    ====");
            Console.WriteLine("");
            Console.WriteLine("Digite el ID del producto a vender,");
            Console.WriteLine("Productos disponibles:");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + " " + item.Descripcion);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-");
            }
            Console.WriteLine("....");
            int opcion = int.Parse(Console.ReadLine());

            bool encontrado = false;
            foreach (var producto in lista)
            {
                if (producto.Codigo == opcion)
                {
                    Console.WriteLine($"Producto encontrado: {producto.Descripcion}, Precio: {producto.Precio}, Unidades disponibles: {producto.Existencia}");
                    encontrado = true;

                    Console.WriteLine("Cuantas unidades desea vender?");
                    int unidadVenta = int.Parse(Console.ReadLine());

                    if (unidadVenta <= producto.Existencia)
                    {
                        producto.Existencia -= unidadVenta;
                        Console.WriteLine($"Venta realizada. Unidades restantes: {producto.Existencia}");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficientes unidades disponibles para la venta.");
                    }

                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún producto con ese ID.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void Actualizar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("====    INVENTARIO    ====");
            Console.WriteLine("");
            Console.WriteLine("Digite el ID del producto a actualizar,");
            Console.WriteLine("Productos disponibles:");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + " " + item.Descripcion);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-");
            }
            Console.WriteLine("....");
            int opcion = int.Parse(Console.ReadLine());

            bool encontrado = false;
            foreach (var producto in lista)
            {
                if (producto.Codigo == opcion)
                {
                    Console.WriteLine($"Producto encontrado: {producto.Descripcion}, Precio: {producto.Precio}, Unidades disponibles: {producto.Existencia}, Unidades minimas para restock: {producto.Minimo}");
                    encontrado = true;

                    try
                    {
                        Console.WriteLine("Digite el nuevo codigo");
                        int cod;
                        try
                        {
                            cod = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Entrada no válida para el código. Por favor, ingrese un número entero.");
                            continue;
                        }

                        if (cod != producto.Codigo)
                        {
                            producto.Codigo = cod;
                        }

                        Console.WriteLine("Digite la nueva descripcion");
                        string descripcion = Console.ReadLine();

                        if (descripcion != producto.Descripcion)
                        {
                            producto.Descripcion = descripcion;
                        }

                        Console.WriteLine("Digite la nueva existencia ");
                        int existencia;
                        try
                        {
                            existencia = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Entrada no válida para la existencia. Por favor, ingrese un número entero.");
                            continue;
                        }

                        if (existencia != producto.Existencia)
                        {
                            producto.Existencia = existencia;
                        }

                        Console.WriteLine("Digite el nuevo minimo para restock.");
                        int minimo;
                        try
                        {
                            minimo = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Entrada no válida para el restock. Por favor, ingrese un número entero.");
                            continue;
                        }

                        if (minimo != producto.Minimo)
                        {
                            producto.Minimo = minimo;
                        }

                        Console.WriteLine("Digite el nuevo precio:");
                        float precio;
                        try
                        {
                            precio = float.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Entrada no válida para el precio. Por favor, ingrese un número válido.");
                            continue;
                        }

                        if (precio != producto.Precio)
                        {
                            producto.Precio = precio;
                        }

                        Console.WriteLine("Producto actualizado con éxito, nuevos valores:");
                        Console.WriteLine(" ");
                        Console.WriteLine($"   {producto.Descripcion}");
                        Console.WriteLine($"ID>  {producto.Codigo}");
                        Console.WriteLine($"Descripcion> {producto.Descripcion}");
                        Console.WriteLine($"Existencia> {producto.Existencia}");
                        Console.WriteLine($"Minimo para restock> {producto.Minimo}");
                        Console.WriteLine($"Precio> {producto.Precio}");
                        Console.WriteLine("....");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tuvimos un error al momento de actualizar este producto, intente de nuevo en unos segundos...");
                    }
                    break;
                }
            }

        }


        public void Reporte() 
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("====    INVENTARIO    ====");
            Console.WriteLine("");
            Console.WriteLine("Productos disponibles:");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + ") " + item.Descripcion + ", $" + item.Precio + " Exis:" + item.Existencia + " Rs:" + item.Minimo);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ActualizarPrecio()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("====    INVENTARIO    ====");
            Console.WriteLine("");
            Console.WriteLine("Digite el ID del producto al cual desees actualizar el precio,");
            Console.WriteLine("Productos disponibles:");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + " " + item.Descripcion);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-");
            }
            Console.WriteLine("....");
            int opcion = int.Parse(Console.ReadLine());

            bool encontrado = false;
            foreach (var producto in lista)
            {
                if (producto.Codigo == opcion)
                {
                    Console.WriteLine($"Producto encontrado: {producto.Descripcion}, Precio: {producto.Precio}");
                    encontrado = true;

                    try
                    {

                        Console.WriteLine("Digite el nuevo precio:");
                        float precio;
                        try
                        {
                            precio = float.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Entrada no válida para el precio. Por favor, ingrese un número válido.");
                            continue;
                        }

                        if (precio != producto.Precio)
                        {
                            producto.Precio = precio;
                        }

                        Console.WriteLine("Producto actualizado con éxito, nuevos valores:");
                        Console.WriteLine(" ");
                        Console.WriteLine($"   {producto.Descripcion}");
                        Console.WriteLine($"ID>  {producto.Codigo}");
                        Console.WriteLine($"Precio> {producto.Precio}");
                        Console.WriteLine("....");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tuvimos un error al momento de actualizar el precio de este producto, intente de nuevo en unos segundos...");
                    }
                    break;
                }
            }

        }

    }
}
