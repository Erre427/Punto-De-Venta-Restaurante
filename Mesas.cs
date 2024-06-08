using System.Data.Common;
using System.Diagnostics.Contracts;

namespace PuntoDeVenta;

public class Mesas: IDespliega
{
    // Atrubutos de la clase
    string[] mesero = {"vacio","vacio","vacio","vacio","vacio"};
    int[] nmesa = {1,2,3,4,5};
    
    public string[] Mes
    {
        get
        {
            return mesero;
        }
        set
        {
            mesero = value;
        }
    }
    public int[] Nmes 
    {
        get
        {
            return nmesa;
        }
        set
        {
            nmesa = value;
        }
    }
    public Mesas()
    {

    }
    
    public void Imprime()
    {
        Console.WriteLine("# Mesa\tMesero");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}\t{1}",Nmes[i],Mes[i]);
        }
    }
}
