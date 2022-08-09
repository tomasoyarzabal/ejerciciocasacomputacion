using System;

namespace casa_computacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int tf, sueldo;
            Console.WriteLine("ingrese el total facturado");
            tf = int.Parse(Console.ReadLine());
            tf = tf * 5 / 100;
            sueldo = 15000;
            sueldo = tf + sueldo;
            Console.WriteLine("su salario a cobrar es de " + sueldo + "$");
            
                
            

        }
    }
}
