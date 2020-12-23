using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia, mes;
            int diaInt, mesInt;

            InterpretadorSigno interpretadorSigno = new InterpretadorSigno();

            Console.WriteLine("Dia de nascimento");
            dia = Console.ReadLine();
            Console.WriteLine("Mês de nascimento");
            mes = Console.ReadLine();

            diaInt = Convert.ToInt32(dia);
            mesInt = Convert.ToInt32(mes);

            Signo signo = interpretadorSigno.Interpretar(diaInt, mesInt);
            if (signo != null)
            {
                Console.WriteLine($"Seu signo é {signo.nome}\nCaracteristica: {signo.caracteristicas}");
            } else
            {
                Console.WriteLine("Data invalidas");
            }
            Console.ReadKey();
        }
    }
}
