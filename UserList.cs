using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerquiV1
{
    public class UserList
    {
        private static List<Usuario> baseList = new List<Usuario>();

        public static void Agregar(Usuario obj)
        {
            baseList.Add(obj);
        }
        public static void Eliminar(int posicion)
        {
            baseList.RemoveAt(posicion);
        }
        public static List<Usuario> Mostrar()
        {
            return baseList;
        }
    }
}