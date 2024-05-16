using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO6
{
    internal class Punto
    {
        int x, y;
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"El valor de X es {x}, el valor de y es {y}");
        }
        public Punto()
        {
            Console.WriteLine("Este es el constructor sin parámetros");
        }
    }
}
