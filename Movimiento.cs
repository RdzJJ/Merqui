using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerquiV1
{
    public class Movimiento
    {
        private string CuentaOrigen = "";
        private string CuentaDestino = "";
        private double Valor = 0;
        private string Fecha = "";

        public Movimiento() 
        {
            CuentaOrigen = "";
            CuentaDestino = "";
            Valor = 0;
            Fecha = "";
        }

        public Movimiento(string cuentaOrigen, string cuentaDestino, double valor, string fecha)
        {
            this.CuentaOrigen = cuentaOrigen;
            this.CuentaDestino = cuentaDestino;
            this.Valor = valor;
            this.Fecha = fecha;
        }
    }
}
