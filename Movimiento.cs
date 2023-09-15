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

        public string getCuentaOrigen()
        {
            return CuentaOrigen;
        }

        public void setCuentaOrigen(string CuentaO)
        {
            this.CuentaOrigen = CuentaO;
        }

        public string getCuentaDestino()
        {
            return CuentaDestino;
        }

        public void getCuentaDestino(string CuentaD)
        {
            this.CuentaDestino = CuentaD;
        }

        public double getValor()
        {
            return Valor;
        }

        public void setValor(double valor)
        {
            this.Valor = valor;
        }

        public string getFecha()
        {
            return Fecha;
        }

        public void setFecha(string fecha)
        {
            this.Fecha = fecha;
        }
    }
}
