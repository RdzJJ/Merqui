namespace MerquiV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                //Console.WriteLine(menu.ejemplo("1. "));

                Usuario usuario = new Usuario("Julian","15649456194","123456676890","3145203021");
                Console.WriteLine(usuario.getCelular());

                usuario.ActualizarDatos("3146208248");
                Console.WriteLine(usuario.getCelular());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}