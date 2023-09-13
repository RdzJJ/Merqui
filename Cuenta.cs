using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerquiV1
{
    public class Cuenta
    {
        string NroCuenta = "";
        double Saldo = 0;
        string Titular = "";
        ArrayList Movimientos;

        public Cuenta()
        {
            NroCuenta = "";
            Saldo = 0;
            Titular = "";
            Movimientos = new ArrayList();
        }

        public Cuenta(string nroCuenta, double saldo, string titular, ArrayList movimientos)
        {
            NroCuenta = nroCuenta;
            Saldo = saldo;
            Titular = titular;
            Movimientos = movimientos;
        }

        public void Depositar() { }
        public void Retirar() { }
        public void Transferir() { }
        public void MostrarMovimientos() { }
        public void CerrarSesion() { }
    }
}