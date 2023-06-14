using System;
using System.Globalization;
public class Hello{
    public static void Main(){
    //zona de declaración
        int num;
        int num2;
        int op, res;
        Entrada obj1=new Entrada();
        num=obj1.leerNum();
        num2=obj1.leerNum();
        Menu obj2 = new Menu();
        op=obj2.menu();
        Controlador obj3 = new Controlador(op,num,num2);
        res=obj3.control();
        Limite obj4 = new Limite();
        obj4.escribir(res,op);
        
    }
}
