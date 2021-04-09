using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepasoAsignacion2
{
    class Banco
    {
        //atributos de los 3 clientes
        private Cliente cliente1, cliente2, cliente3;

        //constructor
        public Banco()
        {
            cliente1 = new Cliente("Ricardo");
            cliente2 = new Cliente("Madeline");
            cliente3 = new Cliente("Rafael");
        }

        //operaciones
        public void Operar()
        {
            cliente1.Depositar(300);
            cliente1.Extraer(50);
            cliente2.Depositar(100);
            cliente2.Extraer(25);
            cliente3.Depositar(500);
            cliente3.Extraer(150);
        }

        //depositostotales
        public void DepositosTotales()
        {
            int depositototal = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
            Console.WriteLine("Saldo total depositado: " + depositototal);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
    }
}
