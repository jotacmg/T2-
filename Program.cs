using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Cuantas notas desea ingresar: ");
        n = int.Parse(Console.ReadLine());

        int[] notas = new int[n];

        for (int i = 0; i < n; i++  )
        {
            int nota;
            Console.Write("Ingrese nota " + (i + 1) + ":  ");
            nota = int.Parse(Console.ReadLine());
            while (nota < 0 || nota > 20)
            {
                Console.WriteLine("Nota invalida, ingresa entre 0 y 20");
                Console.Write("Ingrese nota " + (i + 1) + ": ");
                nota = int.Parse(Console.ReadLine());
            }
          notas[i] = nota;
        }
      Console.WriteLine("Notas guardadas");
    }
}