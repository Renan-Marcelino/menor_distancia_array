using System;

class Programa
{
    static void Main()
    {
        int[] matriz1 = { -1, 5, 10, 15, 20, 25, 30, 35, 40, 45 };
        int[] matriz2 = { 26, 6, 11, 16, 21, 26, 31, 36, 41, 46 };

        int distanciaMinima = int.MaxValue;

        foreach (int numero1 in matriz1)
        {
            foreach (int numero2 in matriz2)
            {
                int distancia = Math.Abs(numero1 - numero2);
                if (distancia < distanciaMinima)
                {
                    distanciaMinima = distancia;
                }
            }
        }

        Console.WriteLine("A distância mínima entre as duas matrizes é: " + distanciaMinima);
    }
}
