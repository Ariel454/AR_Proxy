using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Proxy
{
    public class CuentaBancoAIMPL : ICuenta
    {
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.saldoInicial + monto;
            cuenta.saldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: "+cuenta.saldoInicial);
            return cuenta;
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("Saldo actual: " + cuenta.saldoInicial);
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.saldoInicial - monto;
            cuenta.saldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: " + cuenta.saldoInicial);
            return cuenta;
        }
    }
}
