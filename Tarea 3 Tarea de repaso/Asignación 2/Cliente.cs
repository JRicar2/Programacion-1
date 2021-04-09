using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepasoAsignacion2
{
    class Cliente
    {
        //atributos
        private string nombre;
        private int monto;
        
        //constructor
        public Cliente(string n) 
        {
            nombre = n;
            monto = 0;
        }

        //depositar
        public void Depositar(int m)
        {
            monto = monto + m;
        }

        //extraer
        public void Extraer(int m)
        {
            monto = monto - m;
        }

        //retornar monto
        public int RetornarMonto()
        {
            return monto;
        }

        //Mostrar mensaje
        public void Imprimir()
        {
            Console.WriteLine("Saldo en la cuenta de " +nombre+ ": " + monto);
        }
    }
}
