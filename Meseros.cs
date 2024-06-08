using System.Diagnostics.Contracts;

namespace PuntoDeVenta;

public class Meseros: IDespliega
{
    string[] nombre = {"vacio","vacio","vacio","vacio","vacio"};
    int[] mesa = {0,0,0,0,0,0};

    public string[] Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }
    public int[] NumeroMesa
    {
        get
        {
            return mesa;
        }
        set
        {
            mesa = value;
        }
    }
    public Meseros()
    {

    }

    public void Imprime()
    {
        Console.WriteLine("\tNombre Mesero\tMesa Asignada");
        for(int i = 0; i < Nombre.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}",i+1,Nombre[i],NumeroMesa[i]);
        }
    }

}
