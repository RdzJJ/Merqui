namespace MerquiV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                menu.opciones();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}