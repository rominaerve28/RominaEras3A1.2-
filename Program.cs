using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasolinera.class1;

namespace gasolinera
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Gasolina gasolina = new Gasolina();
            Console.WriteLine("=======================================");
            Console.WriteLine("\t        Factura        ");
            Console.WriteLine("\t      SURCOMPI SA      ");
            Console.WriteLine("=======================================");
            Console.WriteLine("\t      Datos del cliente ");
            Console.Write("Ingrese su numero de cedula: ");
            cliente.Ncedula = long.Parse(Console.ReadLine());
            Console.Write("Ingrese sus dos nombres: ");
            cliente.Nombres = Console.ReadLine();
            Console.Write("Ingrese sus dos apellidos: ");
            cliente.Apellidos = Console.ReadLine();
            Console.Write("Ingrese su direccion:  ");
            cliente.Direccion = Console.ReadLine();





            Console.WriteLine("\t      Datos de la gasolina            ");
            Console.Write("Ingrese el tipo de la gasolina:  ");
            gasolina.Tipo = Console.ReadLine();
            Console.Write("Cantidad de Galones:   ");
            gasolina.Cgasolina = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de venta:  "+ gasolina.Precioven);
            Console.WriteLine("         ");
            Console.WriteLine("Subtotal:        " + gasolina.Subtotal);
            Console.WriteLine("Iva:             " + gasolina.Iva );
            Console.WriteLine("Total:           "+ gasolina.Total);


            Console.WriteLine("=======================================");

            Console.ReadKey();

        }
    }
}
