using System;

namespace Solucion
{
    //Crear loop que vaya de 0 a 227
    //Ejercicio de Foo - Bar - FooBar

    class MainClass
    {
        public static void Main(string[] args)
        {
            int fooDiv = 3;
            int barDiv = 5;
            int limit = 227;

            for(int i = 0; i < limit; i++)
            {
                string resultado = "";
                if(i % fooDiv == 0)
                {
                    resultado += "Foo";
                }
                if(i % barDiv == 0)
                {
                    resultado += "Bar";
                }
                Console.WriteLine(i + "  " + resultado);
            }
        }
    }
}
