using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREGUNTA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = Pantallas.Cabecera();

            if (numero > 300)
            {
                Console.WriteLine("El número de pesos no puede ser mayor a 300.");
                return;
            }

            float[] pesos = new float[numero];
            float sumaPesos = 0;
            int menosDe60Kg = 0;
            int masDe100Kg = 0;

            for (int i = 0; i < numero; i++)
            {
                pesos[i] = Operaciones.getDecimal("Ingrese el peso de la persona #" + (i + 1) + " (en kg): ");
                sumaPesos += pesos[i];

                if (pesos[i] < 60)
                {
                    menosDe60Kg++;
                }
                else if (pesos[i] > 100)
                {
                    masDe100Kg++;
                }
            }
            float promedio = sumaPesos / numero;
            Pantallas.PieDePagina(sumaPesos, menosDe60Kg, masDe100Kg, promedio);
        }
    }
}
