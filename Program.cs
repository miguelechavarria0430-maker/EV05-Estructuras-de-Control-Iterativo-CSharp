using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RETO EV05 - ESTRUCTURAS DE CONTROL ITERATIVO");

        Console.WriteLine("\n1. FOR - Numeros del 1 al 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\n\n2. FOREACH - Recorrido de frutas");
        string[] frutas = { "Manzana", "Banano", "Naranja", "Mango" };

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("\n3. WHILE - Contador del 1 al 5");
        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine(contador);
            contador++;
        }

        Console.WriteLine("\n4. DO-WHILE - Ingresa un numero positivo");
        int numero = 0;

        do
        {
            Console.Write("Numero: ");
            string entrada = Console.ReadLine() ?? "";

            if (!int.TryParse(entrada, out numero))
            {
                numero = 0;
                Console.WriteLine("Entrada no valida.");
            }
        }
        while (numero <= 0);

        Console.WriteLine("Ingresaste: " + numero);

        Console.WriteLine("\n5. BREAK - Detener en el numero 6");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                break;
            }

            Console.Write(i + " ");
        }

        Console.WriteLine("\n\n6. CONTINUE - Mostrar numeros pares");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }

            Console.Write(i + " ");
        }

        Console.WriteLine("\n\nPrograma finalizado.");
    }
}
