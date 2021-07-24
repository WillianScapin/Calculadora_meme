using System;

namespace Teste
{
    class Program
    {
        public static int resultado;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Operador '+, -, *, / ' ");
            string Operador = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite um valor: ");
            int Valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite Outro valor");
            int Valor2 = Convert.ToInt32(Console.ReadLine());

            if (Operador == "+")
            {
                resultado = Valor1 + Valor2;
            }
            if (Operador == "-")
            {
                resultado = Valor1 - Valor2;
            }
            if (Operador == "*")
            {
                resultado = Valor1 * Valor2;
            }
            if (Operador == "/")
            {
                resultado = Valor1 / Valor2;
            }

            if (resultado > 0)
            {
                Console.WriteLine("O resultado é: " + resultado);
            }
            else
            {
                var uri = "https://www.youtube.com/watch?v=yDphC4Ckmy8&ab_channel=YTAS";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
            }
        }
    }
}
