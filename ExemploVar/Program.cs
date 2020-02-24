using System;

namespace ExemploVar
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel do tipo var pode inferir o tipo de valores
            //é recomendado usar estritamente, pois, o programador pode errar no desenvolvimento
            //ao atribuir valores

            var x = 10; //compilador identificou como int
            var y = 20.0; //compilador identificou como double
            var z = "Maria"; //compilador identificou como string

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
