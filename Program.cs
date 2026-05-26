using System;

class Program
{
    static void CalcularlosDatos(int[] notas, int n, ref double promedio, ref int mayor, ref int menor)
    {
        int suma = 0;
        mayor = notas[0];
        menor = notas[0];
        for (int i = 0; i < n; i++ )
        {
            suma = suma + notas[i];

            if (notas[i] > mayor)
            {
               mayor = notas[i];
            }

            if (notas[i] < menor)
            {
               menor = notas[i];
            }
        }
        promedio = (double)suma / n;
    }
    static int ContarAprobados(int[] notas, int n)
    {
        int aprobados = 0;
        for (int i = 0; i < n; i++ )
        {
            if (notas[i] >= 12)
            {
             aprobados++;
            }
        }
        return aprobados;
    }
    static void Main()
    {
        int n;
        Console.Write("Cuantas notas desea ingresar: ");
        n = int.Parse(Console.ReadLine() );
        int[] notas = new int[n];
        for (int i = 0; i < n; i++  )
        {
            int nota;
            Console.Write("Ingrese nota " + (i + 1) + ":  ");
            nota = int.Parse(Console.ReadLine());
            while (nota < 0 || nota > 20)
            {
                Console.WriteLine("Nota invalida, ingresa entre 0 y 20");
                Console.Write("Ingrese nota " + (i + 1) + ":   ");
                nota = int.Parse(Console.ReadLine());
            }
            notas[i] = nota;
        }

        double promedio = 0;
        int mayor = 0;
        int menor = 0;

        CalcularlosDatos(notas, n, ref promedio, ref mayor, ref menor);

        int aprobados = ContarAprobados(notas, n);
        int desaprobados = n - aprobados;
        double porcentajeAprobados = (double)aprobados * 100 / n;
        double porcentajeDesaprobados = (double)desaprobados * 100 / n;
        Console.WriteLine();
        Console.WriteLine("REPORTE DEL SALON");
        Console.Write("Notas ingresadas: [");
        for (int i = 0; i < n; i++ )
        {
            Console.Write(notas[i]);
            if (i < n - 1)
            {
            Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota maxima: " + mayor);
        Console.WriteLine("Nota minima: " + menor);
        Console.WriteLine();
        Console.WriteLine("Aprobados: " + aprobados + " (" + porcentajeAprobados.ToString("F2") + "%)");
        Console.WriteLine("Desaprobados: " + desaprobados + " (" + porcentajeDesaprobados.ToString("F2") + "%)");
        if (porcentajeDesaprobados > 75)
        {
            Console.WriteLine();
            Console.WriteLine("ALERTA¡¡¡!!!: Se ha desaprobado mas del 75% del salon!!!");
        }
    }
}