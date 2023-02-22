using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            int select=0;        
            System.Console.WriteLine("1)Suma y resta   2)Multiplicacion    3)Division  4)Desviacion estandar del promedio");
            Console.WriteLine("Seleccione que tipo de incerteza desea utilizar");
            select=Convert.ToInt32(Console.ReadLine());
            Calculos incerteza=new Calculos();            
            switch(select){
                case 1:
                incerteza.sumayresta();
                break;
               case 2:
                incerteza.multiplicacion();
               break;
               case 3:
                incerteza.division();
               break;
               case 4:
               incerteza.desvest();
               break;
               default:
               System.Console.WriteLine("Opcion solo disponible en Ohio");
               break;
            }
            }
            catch(Exception){
            System.Console.WriteLine("Parece que estas opciones solo estan disponibles en Ohio");
            }
            Console.ReadKey();
        }
    }
}