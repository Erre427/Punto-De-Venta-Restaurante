using PuntoDeVenta;

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
                +"2.Consulta Meseros\n3.Consulta Platillos\n4.Salir");
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
                    Platillos();
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
    }
    static void Mesas()
    {
        char opc;
        int opc2;
        bool ban = true;
        Mesas RestMesas = new Mesas();
        do
        {


           Console.Clear();
           Console.WriteLine("SELECCIONE OPCION\n--------------------------\n"+
           "1.Consulta Mesas General\n"+
           "2.Nueva Mesa\n");
           opc = Console.ReadKey().KeyChar;
           switch(opc)
           {
            case '1':
                Console.Clear();
                RestMesas.Imprime();
                Console.ReadKey();
            break;

            case '2':
                Console.Clear();
                Console.WriteLine("ELIJA UNA MESA A TOMAR\n---------------------");
                RestMesas.Imprime();
                opc2 = int.Parse(Console.ReadLine());
                if (opc2 >= 1 && opc2 < RestMesas.Mes.Length)
                {
                    Console.WriteLine("Ingrese el mesero a cargo");
                    RestMesas.Mes[opc2-1] = Console.ReadLine();
                }
            break;

            default:
                Console.WriteLine("Opcion Incorrecta");
                Console.ReadLine();
            break;
           }
        }while(ban == true);

    }
    static void Platillos()
    {
        char opc;
        bool ban = true;
        do
        {
            Console.Clear();

        }while(ban == true);
    }
}