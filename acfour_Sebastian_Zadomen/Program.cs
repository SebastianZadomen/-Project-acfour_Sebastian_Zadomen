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
