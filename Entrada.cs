using System;
using System.Globalization;
public class Entrada  
{
    int num,num2;
    public Entrada(){
        num=0;
        num2=0;
    }
    public int leerNum(){
        
        this.num=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el numero: "+num);
        return num;
    }
  
}
