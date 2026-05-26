using System;

class Program
{
    static void Main()
 {
        int n;

        Console.Write("Cuantas notas desea ingresar: ");
        n = int.Parse(Console.ReadLine());

        int[] notas = new int[n];

        for (int i = 0; i < n;  i++  )
    {
       Console.Write("Ingrese nota " + (i + 1) + ":  ");
        notas[i] = int.Parse(Console.ReadLine());
    }

   Console.WriteLine("Notas guardadas");
  }
}