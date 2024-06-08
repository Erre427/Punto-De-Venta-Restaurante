internal class Program
{
    private static void Main(string[] args)
    {
        char opc;
        bool ban = true;

        try
        {
            do
            {
                Console.Clear();
                Console.WriteLine("PUNTO DE VENTA RESTAURANTE\n----------------------------------\n1.Consulta Mesas\n"
                +"2.Consulta Meseros\n3.Salir");
                opc = Console.ReadKey().KeyChar;
                switch(opc)
                {
                    case '1':
                    Mesas();
                    break;

                    case '2':
                    Meseros();
                    break;

                    case '3':
                    ban = false;
                    break;

                    default:
                    Console.WriteLine("Opcion Invalida");
                    break;
                }
            } while(ban == true);
        }
        catch (FormatException)
        {
            Console.WriteLine("Se ingreso un dato erroneo");
        }
    }

    static void Meseros()
    {
        char opc;
        bool ban = true;
        do
        {
           Console.Clear();
           Console.WriteLine("SELECCIONE OPCION\n--------------------------\n"+
           "1.Consulta Mesas General\n"+
           "2.Nueva Mesa");
        }while(ban == true);

    }
    static void Mesas()
    {
        
    }
}