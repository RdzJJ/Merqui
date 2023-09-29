namespace MerquiV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ILoggin ejemplo;

                ejemplo.Log("Holi");
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}