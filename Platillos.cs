namespace PuntoDeVenta;

public class Platillos: IDespliega
{
    // Atributos de la clase
    string[] Nombre;
    double[] Precio;

    // Propiedades de los atributos
    public string[] Nom
    {
        get
        {
            return Nombre;
        }
        set
        {
            Nombre = value;
        }
    }
    public double[] Prec
    {
        get
        {
            return Precio;
        }
        set
        {
            Precio = value;
        }
    }

    // Constructor
    public Platillos()
    {

    }

    // Metodo de la clase
    public void Imprime()
    {
        Console.Clear();
        Console.WriteLine("Platillo\tPrecio");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}-{1}\t{2:C2}",i+1,Nom[i],Prec[i]);
        }
        Console.ReadKey();
    }
}
