using System;
using System.Dynamic;
namespace Acfour;
public class Exercici4
{
    const string Msg = "Introduce una cantidad limite";
    const string Msgsaved = "Escribe un numero real que quiera guardar";
    public static void Main()
    {
        Console.WriteLine(Msg);
        int numLimit = Convert.ToInt32(Console.ReadLine());

        int[] saveNum = new int[numLimit];

        Almacen(saveNum, numLimit);

    }
    public static void Almacen(int[] saveNum, int numLimit)
    {
        for (int i = 0; i < numLimit; i++)
        {
            Console.WriteLine(Msgsaved);
            int numSaved = Convert.ToInt32(Console.ReadLine());
            int? numAssess = EvaluateValue(numSaved);

            if (numAssess.HasValue)
            {
                saveNum[i] = numAssess.Value;
            }
            else
            {
                Console.WriteLine("Intente de nuevo.");
                i--;
            }
        }
        ResultsCounter(saveNum);
        DescendingOrder(saveNum);
    }
    public static int? EvaluateValue(int numSaved)
    {
        if (numSaved > 0)
        {
            Console.WriteLine("Numero añadido correctamente");
            return numSaved;
        }
        else
        {
            Console.WriteLine("Su numero no es un numero real");
            return null;
        }
    }
    public static void ResultsCounter(int[] saveNum)
    {
        string arrayFinish = "";
        for (int i = 0; i < saveNum.Length; i++)
        {
            arrayFinish += saveNum[i];
            if (i < saveNum.Length - 1)
            {
                arrayFinish += ", ";
            }
        }

        Console.WriteLine("Los números son: " + arrayFinish);
    }
    public static void DescendingOrder(int[] saveNum)
    {
        int n = saveNum.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (saveNum[j] < saveNum[j + 1])
                {
                    int temp = saveNum[j];
                    saveNum[j] = saveNum[j + 1];
                    saveNum[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Su numero ordenado de manera descendente es:");
        ResultsCounter(saveNum);
    }
}