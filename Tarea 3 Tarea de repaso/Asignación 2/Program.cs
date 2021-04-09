using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepasoAsignacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco prueba = new Banco();
            prueba.Operar();
            prueba.DepositosTotales();
            Console.ReadKey();
        }
    }
}
