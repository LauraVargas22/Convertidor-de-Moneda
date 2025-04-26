namespace convertCurrency;
public class Utilidades
{
    public static bool LeerTecla()
    {
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
            char respuesta = char.ToUpper(tecla.KeyChar);
            switch (respuesta)
            {
                case 'S':
                    return true;
                case 'N':
                    return false;
                default:
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' o 'n'.");
                    break;
            }
        }
    }
}