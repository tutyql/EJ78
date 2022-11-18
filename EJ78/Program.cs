using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ78
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dicc_ing_esp = new Hashtable(250000);
            dicc_ing_esp.Add("hello", "hola");
            dicc_ing_esp.Add("bye", "adios");
            dicc_ing_esp.Add("blue", "azul");
            dicc_ing_esp.Add("year", "año");
            dicc_ing_esp.Add("apple", "manzana");

            if (dicc_ing_esp.Contains("hello")) ;
            Console.WriteLine("La traduccion de hello es:");
            Console.WriteLine(dicc_ing_esp["hello"]);

            if (dicc_ing_esp.Contains("bye")) ;
            Console.WriteLine("La traduccion de bye es:");
            Console.WriteLine(dicc_ing_esp["bye"]);

            if (dicc_ing_esp.Contains("blue")) ;
            Console.WriteLine("La traduccion de blue es:");
            Console.WriteLine(dicc_ing_esp["blue"]);

            if (dicc_ing_esp.Contains("year")) ;
            Console.WriteLine("La traduccion de year es:");
            Console.WriteLine(dicc_ing_esp["year"]);

            if (dicc_ing_esp.Contains("apple")) ;
            Console.WriteLine("La traduccion de apple es:");
            Console.WriteLine(dicc_ing_esp["apple"]);



            Console.ReadKey();
        }
    }
}
