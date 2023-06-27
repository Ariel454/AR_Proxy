using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Proxy
{
    public class Cuenta
    {
        public int idCuenta { get; set; }
        public String usuario { get; set; }
        public double saldoInicial { get; set; }

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {
            this.idCuenta = idCuenta;
            this.usuario = usuario;
            this.saldoInicial = saldoInicial;
        }

    }
}
