using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREGUNTA1
{
    public class Pantallas
    {
        public static void PieDePagina(float sumaPesos, int menosDe60Kg, int masDe100Kg, double promedio)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Procesando...");
            Console.WriteLine("=============================================");
            Console.WriteLine("La suma de todos los pesos es: " + sumaPesos + " kg");
            Console.WriteLine("El promedio de todos los pesos es: " + promedio.ToString("F1") + " kg");
            Console.WriteLine("==============================================");
            Console.WriteLine("Menos de 60 kg: " + menosDe60Kg);
            Console.WriteLine("Mas de 100 kg: " + masDe100Kg);
            Console.ReadKey();
        }

        public static int Cabecera()
        {
            Console.WriteLine("=================================");
            int numero = Operaciones.getEntero("Ingrese el número de pesos a analizar: ");
            return numero;
        }
    }
}
