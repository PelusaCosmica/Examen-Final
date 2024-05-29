using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace L13___Marcela_Nicole___1102124;

public class OperacionesMatrices
{
    public int[,] matrizA = new int[0, 0];
    public int[,] matrizR = new int[1, 1];
    public int CANTfilas = 0, CANTcolumnas = 0;
    public int cero = 0, contador = 0;

    public int[,] ConstruirMatriz()
    {
        Console.WriteLine("Bienvenida Usuario, por favor ingrese la cantidad de filas deseadas para las matrices:");
        CANTfilas= int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese la cantidad de columnas deseadas para las matrices:");
        CANTcolumnas= int.Parse(Console.ReadLine());
        
        matrizA = new int[CANTfilas, CANTcolumnas];

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                Console.WriteLine("Introduce los valores para la matriz A:");
                matrizA[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrizA;
    }

    public void PrintMatriz (int[,] matrizR)
    {
        for (int i = 0; i < matrizR.GetLength(0); i++)
        {
            for (int j = 0; j < matrizR.GetLength(1); j++)
            {
                Console.Write(matrizR[i, j].ToString().PadRight(matrizR.GetLength(1)));
            }
            Console.WriteLine(" ");
        }
    }

    public int[,] MatrizEscalar(int[,] matrizA)
    {
        Console.WriteLine("Ingrese el escalar a operar: " );
        cero = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        int[,] matrizR  = new int[matrizA.GetLength(0),matrizA.GetLength(1)];

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizR[i, j] = matrizA[i, j] * cero;
            }
        }
        return matrizR;
    }

    public int[,] Contador(int[,] matrizA)
    {
        Console.WriteLine("Ingrese el número a evaluar: " );
        cero = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        int[,] matrizR  = new int[matrizA.GetLength(0),2];

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j <matrizA.GetLength(1); j++)
            {
                if (matrizA[i,j] == cero)
                {
                    contador++;
                    matrizR[i, 1] = contador;
                }
            }
            matrizR[i, 0] = i;
            contador = 0;
        }
        return matrizR;
    }

    public int[,] Pares(int[,] matrizA)
    {
        List<int> TotalPares = new List<int>();

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                if (matrizA[i, j] % 2 == 0)
                {
                    TotalPares.Add(matrizA[i, j]);
                }
            }
        }

        int[,] matrizR = new int[1, TotalPares.Count];

        for (int k = 0; k < TotalPares.Count; k++)
        {
            matrizR[0, k] = TotalPares[k];
        }
        return matrizR;
    }
}