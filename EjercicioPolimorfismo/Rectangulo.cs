using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Rectangulo : Figura
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Calculando área de un rectángulo");
        }
    }
}
