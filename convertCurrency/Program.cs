using System.Globalization;

using convertCurrency;
internal class Program
{
    public static bool continuar;
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        do {
            Console.WriteLine("Ingrese la cantidad de pesos colombianos que desea convertir: ");
            string input = Console.ReadLine();
            double moneda;

            Console.WriteLine("Seleccione la moneda a la cual desea convertir: \n a. Dolar \n b. Euro \n c. Yen \n x. Salir \n");
            string opcion = string.Empty;
            switch (((ConsoleKeyInfo)Console.ReadKey()).Key)
            {
                case ConsoleKey.A:
                 if (double.TryParse(input, out moneda))
                 {
                    //Tasa de Cambio
                    double dolar = 4280.0;
                    //Conversión
                    double dolares = moneda / dolar;
                    Console.WriteLine($"El valor convertido es:{dolares.ToString("c3", new CultureInfo("en-US"))}");
                 }
                break;
                
                case ConsoleKey.B:
                if (double.TryParse(input, out moneda))
                 {
                    //Tasa de Cambio
                    double euro = 4920.0;
                    //Conversión
                    double euros = moneda / euro;
                    Console.WriteLine($"El valor convertido es:{euros.ToString("C", new CultureInfo("fr-FR"))}");
                 }
                break;

                case ConsoleKey.C:
                if (double.TryParse(input, out moneda))
                 {
                    //Tasa de Cambio
                    double yen = 30.54;
                    //Conversión
                    double yenes = moneda / yen;
                    Console.WriteLine($"El valor convertido es:{yenes.ToString("C", new CultureInfo("ja-JP"))}");
                 }
                break;

                case ConsoleKey.X:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("¿Desea continuar? (S/N)");
            continuar = Utilidades.LeerTecla();

        } while (continuar);
    }
}
