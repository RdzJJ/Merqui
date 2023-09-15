using System.Collections;

namespace MerquiV1
{
    public class Cuenta
    {
        public string NroCuenta = "";
        private double Saldo = 0;
        private string Titular = "";
        private List<Movimiento> Movimientos;

        public Cuenta()
        {
            NroCuenta = "";
            Saldo = 0;
            Titular = "";
            Movimientos = new List<Movimiento>();
        }

        public Cuenta(string nroCuenta, double saldo, string titular, ArrayList movimientos)
        {
            NroCuenta = nroCuenta;
            Saldo = saldo;
            Titular = titular;
            Movimientos = new List<Movimiento>();
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public string getTitular()
        {
            return Titular;
        }

        public void setTitular(string titular)
        {
            this.Titular = titular;
        }

        public List<Movimiento> getMovimientos()
        {
            return Movimientos;
        }

        public void setMovimientos(List<Movimiento> movimientos)
        {
            Movimientos = movimientos;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        public bool Retirar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir(double valor, Cuenta cuenta)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        public void MostrarMovimientos() { }
        public void CerrarSesion() { }
    }
}