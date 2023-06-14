using System;
using System.Globalization;
public class Menu{
    int opc;
    public Menu(){
        opc=0;
    }
    public int menu(){
    //zona de declaración
        Console.WriteLine("1.-Sumar");
        Console.WriteLine("2.-Restar");
        Console.WriteLine("3.-Multiplicar");
        Console.WriteLine("4.-Dividir");
        Console.WriteLine("5.-Salir");
        
        opc=int.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione la opcion:"+opc);
        return this.opc;
    }
}
