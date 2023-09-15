namespace MerquiV1
{
    public class Usuario
    {
        public string Nombre = "";
        private string CC = "";
        public string NroCuenta = "";
        private string Celular = "";

        public Usuario()
        {
            Nombre = "";
            CC = "";
            NroCuenta = "";
            Celular = "";
        }

        public Usuario(string nombre, string cédulaCiudadania, string nroCuenta, string celular)
        {
            this.Nombre = nombre;
            this.CC = cédulaCiudadania;
            this.NroCuenta = nroCuenta;
            this.Celular = celular;
        }

        public string getCC()
        {
            return CC;
        }

        public void setCC(string cc)
        {
            this.CC = cc;
        }

        public string getCelular()
        {
            return Celular;
        }

        public void setCelular(string celular)
        {
            this.Celular = celular;
        }
        public void ActualizarDatos() { }
        public void CrearCuenta() { }
        public void BorrarCuenta() { }
    }
}