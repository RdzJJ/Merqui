namespace MerquiV1
{
    public class Usuario
    {
        public string Nombre = "";
        private string CC = "";
        private string Contrasena = "";
        public string NroCuenta = "";
        private string Celular = "";

        public Usuario()
        {
            Nombre = "";
            CC = "";
            Contrasena = "";
            NroCuenta = "";
            Celular = "";
        }

        public Usuario(string nombre, string cédulaCiudadania, string Contrasena, string celular)
        {
            Random random = new Random();
            this.Nombre = nombre;
            this.CC = cédulaCiudadania;
            this.Contrasena = Contrasena;
            this.NroCuenta = random.Next(0000000000, 999999999).ToString();
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
        public bool ActualizarDatos(string celular, string contrasena)
        {
            if (!this.Celular.Equals(celular))
            {
                this.Celular = celular;
                return true;
            }
            else if (!this.Contrasena.Equals(contrasena))
            {
                this.Contrasena = contrasena;
                return true;
            }
            return false;
        }
        public void CrearCuenta() { }
        public void BorrarCuenta() { }  
    }
}