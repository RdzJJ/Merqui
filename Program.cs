namespace MerquiV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                Cuenta cuenta = new Cuenta();
                cuenta.MostrarMovimientos();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}