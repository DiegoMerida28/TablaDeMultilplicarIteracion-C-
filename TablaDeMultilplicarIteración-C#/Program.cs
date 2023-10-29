using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número para generar la tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del " + numero + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }
    }
}