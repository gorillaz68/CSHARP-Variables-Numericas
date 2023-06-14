using System;
using System.Globalization;
public class Limite{
    int result;
    public Limite(){
        result = 0;
    }
    public void escribir(int x,int op){
        this.result=x;
        if(op>0 && op<5){
            Console.WriteLine("el resultado es: "+this.result);
        }else{
            if(op!=5){
                Console.WriteLine("Ingrese un valor valido");
            }
        }
    }
}
