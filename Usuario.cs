namespace MerquiV1
{
    public class Usuario
    {
        public string Nombre = "";
        private string CC = "";
        public string NroCuenta = "";
        private string Contrasena = "";
        private string Celular = "";
        private double Saldo = 0;
        public Cuenta cuenta;

        public Usuario()
        {
            Nombre = "";
            CC = "";
            Saldo = 0;
            Contrasena = "";
            NroCuenta = "";
            Celular = "";
        }

        public Usuario(string nombre, string cc, string Contrasena, string celular, double saldo)
        {
            Random random = new Random();
            this.Nombre = nombre;
            this.CC = cc;
            this.Contrasena = Contrasena;
            this.Saldo = saldo;
            this.NroCuenta = random.Next(0000000000, 999999999).ToString();
            this.Celular = celular;
            this.cuenta = new Cuenta(NroCuenta, cc, nombre, saldo);
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

        public string getContrasena()
        {
            return Contrasena;
        }

        public void setContrasena(string contrasena)
        {
            Contrasena = contrasena;
        }

        public static Cuenta GetCuenta(string cuenta)
        {
            List<Usuario> lista = Mostrar();
            Usuario obj;
            foreach (Usuario usuario in lista)
            {
                if (usuario.CC.Equals(cuenta))
                {
                    return usuario.cuenta;
                }
            }
            return null;
        }

        public static int VerificarUsuario(string usuario)
        {
            List<Usuario> lista = Mostrar();
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CC.Equals(usuario))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int VerificarInicio(string usuario, string contrasena)
        {
            List<Usuario> lista = Mostrar();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CC.Equals(usuario) && lista[i].CC.Equals(contrasena))
                {
                    return i;
                }
            }
            return -1;
        }

        public static List<Usuario> Mostrar()
        {
            return UserList.Mostrar();
        }
    }
}