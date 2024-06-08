namespace PuntoDeVenta;

public class Platillos
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
        
    }
}
