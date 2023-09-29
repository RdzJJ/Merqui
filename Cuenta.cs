using System.Collections;
using System.Numerics;

namespace MerquiV1
{
    public class Cuenta
    {
        public string NroCuenta = "";
        private double Saldo = 0;
        private string Titular = "";
        private string CC = "";
        private List<Movimiento> Movimientos;

        public Cuenta(string nombre)
        {
            NroCuenta = "";
            Saldo = 0;
            Titular = "";
            Movimientos = new List<Movimiento>();
            CC = "";
        }

        public Cuenta(string nroCuenta, double saldo, string titular, string cc)
        {
            NroCuenta = nroCuenta;
            CC = cc;
            Saldo = saldo;
            Titular = titular;
            Movimientos = new List<Movimiento>();
        }

        public string getcc()
        {
            return CC;
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
        public bool Transferir(double valor, String nroCuenta)
        {
            List<Usuario> lista = Mostrar();
            Usuario obj;
            if (this.Saldo >= valor)
            {
                foreach (Usuario usuario in lista)
                {
                    obj = usuario;
                    if (obj.NroCuenta == nroCuenta)
                    {
                        Saldo-=valor;
                        obj.cuenta.Depositar(valor);
                        return true;
                    }

                }
            }
            return false;
        }
        public List<Usuario> Mostrar()
        {
            return UserList.Mostrar();
        }

        public void CerrarSesion() { }
    }
}