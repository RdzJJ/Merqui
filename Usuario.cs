using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerquiV1
{
    public class Usuario
    {
        string Nombre = "";
        string CédulaCiudadania = "";
        string NroCuenta = "";
        string Celular = "";

        public Usuario()
        {
            Nombre="";
            CédulaCiudadania="";
            NroCuenta = "";
            Celular = "";
        }

        public Usuario(string nombre, string cédulaCiudadania, string nroCuenta, string celular)
        {
            this.Nombre = nombre;
            this.CédulaCiudadania = cédulaCiudadania;
            this.NroCuenta = nroCuenta;
            this.Celular = celular;
        }

        public void ActualizarDatos() { }
        public void CrearCuenta() { }
        public void BorrarCuenta() { }
    }
}