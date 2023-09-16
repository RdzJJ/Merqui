namespace MerquiV1
{
    public class Menu
    {

        public dynamic ejemplo(string? opciones)
        {
            Console.WriteLine(opciones);
            int answer = int.Parse(Console.ReadLine());
            return answer;
            //string respuesta = "";
            //Console.WriteLine("¡Bienvenido a Merqui JC!\nPara nosotros es un placer atenderte :)\nPor favor, indícanos ¿Qué deseas hacer el día de hoy?\n");
            //Console.WriteLine("1. Retirar.\n2. Transferir.\n3. Consultar saldo.\n4. Consultar movimientos.\n5. Cerrar sesión.\n6. Más opciones.");
            //return respuesta;

                
        }
    }
}