using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal num1;
            decimal num2;
            decimal Resultado;

            Console.WriteLine(" Calculadora\n" +
                "\n" +
                " Digite 1 para sumar \n" +
            "  Digite 2 para restar\n " +
           " Digite 3 para multiplicar \n" +
           "Digite 4 para Dividir \n ");
           opcion=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
           

            switch (opcion)
            {

                case 1:
             Console.WriteLine("Digite el primer numero a sumar");
             num1 = Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine("Digite el segundo numero a sumar");
             num2 = Convert.ToDecimal(Console.ReadLine());
                    Resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es : " + Resultado);
                    break;
                case 2:
                    Console.WriteLine("Digite el primer numero a restar");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero a restar");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    Resultado = num1 - num2;
                    Console.WriteLine("El resultado de la sustraccion es : " + Resultado);
                    break;

                case 3:
                    Console.WriteLine("Digite el primer numero a multiplicar");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero a multiplicar");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    Resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es : " + Resultado);
                    break;

                case 4:
                    Console.WriteLine("Digite el primer numero a dividir");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero a dividir");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    Resultado = num1/num2;
                    Console.WriteLine("El resultado de la divicion es : " + Resultado);
                    break;

                default:
                    Console.WriteLine("Operacion Invalida");
                    break;
                    
            }

            Console.ReadKey();


        }
    }
}
