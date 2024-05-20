using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Figura
    {
        public virtual void CalcularArea()
        {
            Console.WriteLine("Calculando área de la figura...");
        }
    }
}
