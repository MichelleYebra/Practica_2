﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, ciudad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola \n" + nombre + " Bienvenido a " + ciudad);
        }
    }
}
