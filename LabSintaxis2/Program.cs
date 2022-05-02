using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese una palabra: ");
            String inputText = Console.ReadLine();
            if (inputText != null) {
                Console.WriteLine("1_Mostrar Mayuscula \n2-Mostrar minuscula \n3-cantidad de letras");
                ConsoleKeyInfo opcion = Console.ReadKey();
                
                if (opcion.KeyChar == '1')
                {
                    Console.WriteLine("\n" + inputText.ToUpper());
                    Console.ReadKey();
                }
                else if (opcion.KeyChar == '2')
                {
                    Console.WriteLine("\n" + inputText.ToLower());
                }else if(opcion.KeyChar == '3')
                {
                    Console.WriteLine("\n" + inputText.Length);
                }
            }
            else {
                Console.WriteLine("No se ingreso ninguna palabra");
            }
            Console.ReadKey();
        }
    }
}
