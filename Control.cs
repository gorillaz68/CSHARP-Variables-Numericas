using System;
using System.Globalization;
public class Controlador{
    int op,a,b,res;
    public Controlador(int x,int y,int z){
        op=x;
        a=y;
        b=z;
    }
    public int control(){
    //zona de declaración
        switch(op){
            case 1:
                res=a+b;
                break;
            case 2:
                res=a-b;
                break;
            case 3:
                res=a*b;
                break;
            case 4:
                this.division();//Console.WriteLine("el resultado es "+res);
                break;
            case 5:
                Console.WriteLine("Salida del programa");
                break;
            default:
                //Console.WriteLine("Ingrese una opcion válida");
                break;
        }
        return this.res;
    }
    void division(){
        
        if(this.b == 0){
            Console.WriteLine("Division por Zero-el denominador no puede ser Cero");
            System.Environment.Exit(0);
        }
        else{
            this.res=a/b;
        }
    }
}
