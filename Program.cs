using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma1;
            double numero2;
            double juro;
            double dvisor;
            double sinal;       
            
            Console.WriteLine("Máximo Divisor Comum (método iterativo)");
            Console.Write("Número: ");
            soma1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Soma do primeiro + número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if(soma1 == 0 || numero2 ==0)
            Console.WriteLine("Invalido razão valores 0");

            if (soma1>numero2)
            {
              juro = soma1;
              dvisor = numero2;  
            }

            else
            {
               juro = numero2;
               dvisor = soma1;  
            }
            while (juro % dvisor != 0)
            {
                sinal = juro % dvisor;
                juro = dvisor;
                dvisor = sinal;
            }
            Console.WriteLine("Maximo Divisor Comum :" + dvisor);




        }
    }
}