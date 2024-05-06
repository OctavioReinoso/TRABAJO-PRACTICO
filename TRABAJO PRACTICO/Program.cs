using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_PRACTICO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El programa debe mostrar un mensaje de bienvenida y solicitar al usuario que ingrese: nombre, dni, edad, destino, clase de vuelo en formato
            //numérico(Económica: 1, Ejecutiva: 2, Primera Clase: 3). si posee equipaje de mano(Sí: 1, No: 0), si tiene el equipaje en bodega facturado(Sí: 1, No: 0),
            //y si viaja con un perro de servicio

            String nombre;
            int dni;
            int edad;
            String destino;
            int claseVuelo; //if
            int equipajeMano; //if
            int equipajeBodega;
            String viajePerro;


            Console.WriteLine("Bienvenido");

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su DNI: ");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su destino");
            destino = Console.ReadLine();

            Console.WriteLine("Indique la clase del vuelo (1, 2 o 3) 1. Económica 2. Ejecutiva 3. Primera clase: ");
            claseVuelo = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique si posee equipaje de mano (1 o 2): 1. Si 2. No: ");
            equipajeMano = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique si tiene equipaje en bodega facturado(1 o 2): 1. Si 2. No: ");
            equipajeBodega = int.Parse(Console.ReadLine());

            Console.WriteLine("Viaja con perro? (1 o 2) 1. Si 2. No: ");
            viajePerro = Console.ReadLine();
        }
    }
}
