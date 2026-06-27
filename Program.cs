using System;

class Program
{
    static void Main()
    {
        int[] notas = new int[5];

        Console.WriteLine("Ingrese las 5 notas:");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0;
        int max = notas[0];
        int min = notas[0];

        foreach (int nota in notas)
        {
            suma += nota;

            if (nota > max)
                max = nota;

            if (nota < min)
                min = nota;
        }

        double promedio = (double)suma / notas.Length;

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Nota más alta: {max}");
        Console.WriteLine($"Nota más baja: {min}");

        if (promedio < 70)
            Console.WriteLine("Rendimiento general: Necesita mejorar.");
        else
            Console.WriteLine("Rendimiento general: Buen desempeño.");
    }
}