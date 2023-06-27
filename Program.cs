// See https://aka.ms/new-console-template for more information
using AR_Proxy;

Cuenta c = new Cuenta(1, "ariel", 100);

ICuenta cuentaProxy = new CuentaProxy();
cuentaProxy.mostrarSaldo(c);

c = cuentaProxy.depositarDinero(c, 50);
c = cuentaProxy.retirarDinero(c, 20);
cuentaProxy.mostrarSaldo(c);
