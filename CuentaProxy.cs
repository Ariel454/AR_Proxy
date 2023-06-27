using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AR_Proxy
{
    public class CuentaProxy : ICuenta
    {
        public CuentaBancoAIMPL cuentaReal;

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAIMPL();
                return cuentaReal.depositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAIMPL();
                cuentaReal.mostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.mostrarSaldo(cuenta);
            }
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAIMPL();
                return cuentaReal.retirarDinero(cuenta, monto);
            }
            else 
            {
                return cuentaReal.retirarDinero(cuenta, monto);
            }
        }
    }
}
