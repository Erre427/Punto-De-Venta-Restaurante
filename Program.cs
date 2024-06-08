using PuntoDeVenta;

internal class Program
{
    private static void Main(string[] args)
    {
        char opc;
        char opc2;
        char opc3;
        int opc4;
        int opc5;
        bool ban = true;
        bool ban2 = true;
        bool ban3 = true;
        
        Mesas RestMesas = new Mesas();
        Meseros RestMeseros = new Meseros();

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
                    
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("CONSULTA MESAS\n--------------------------\n"+
                        "1.Consulta Mesas General\n"+
                        "2.Nueva Mesa\n"+
                        "3.Salir");
                        opc2 = Console.ReadKey().KeyChar;
                        switch(opc2)
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
                                Console.WriteLine("Ingrese el numero y de ENTER");
                                opc4 = int.Parse(Console.ReadLine());
                                if (opc4 >= 1 && opc4 < RestMesas.Mes.Length)
                                {
                                    Console.WriteLine("Ingrese el mesero a cargo");

                                    RestMesas.Mes[opc4-1] = Console.ReadLine();
                                }
                            break;

                            case '3':
                                ban2 = false;
                            break;
                            
                            default:
                                Console.WriteLine("Opcion Incorrecta");
                                Console.ReadLine();
                            break;
                        }
                    }while(ban2== true);
                            
                    break;

                    case '2':
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("CONSULTA MESEROS\n----------------------\n"+
                            "1.Consulta Meseros General\n"+
                            "2.Registrar Nuevo Mesero\n"+
                            "3.Salir");
                            opc3 = Console.ReadKey().KeyChar;
                            switch(opc3)
                            {
                                case '1':
                                    Console.Clear();
                                    RestMeseros.Imprime();
                                    Console.ReadKey();
                                break;

                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("SELECCIONE SLOT A CARGAR\n-------------------------");
                                    RestMeseros.Imprime();
                                    opc5 = int.Parse(Console.ReadLine());
                                    if(opc5 >= 1 && opc5 < RestMeseros.Nombre.Length)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Ingrese Nombre");
                                        RestMeseros.Nombre[opc5-1] = Console.ReadLine();
                                        Console.WriteLine("Se registro exitosamente al mesero");
                                        Console.ReadKey();
                                    }
                                break;

                                case '3':
                                ban3 = false;
                                break;

                                default:
                                Console.WriteLine("Opcion Incorrecta");
                                Console.ReadKey();
                                break;
                            }
                        }while(ban3 == true);
                    break;

                    case '3':
                    break;
                    
                    case '4':
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
    
}