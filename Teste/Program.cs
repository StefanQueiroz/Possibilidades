using Possibilidades;
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Possível p = new Possível("asdfgh",3);

            while (p.hasNext)
            {
                Console.WriteLine(p.getNext());
            }
            
            Console.ReadLine();       
        }
    }
}
