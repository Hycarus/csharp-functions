using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
        int userNum = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[userNum];
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Inserisci i numeri: {i + 1}/{array.Length}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array di numeri fornito: ");
        StampaArray(array);

        Console.WriteLine($"Array di numeri fornito elevati al quadrato: ");
        StampaArray(ElevaArrayAlQuadrato(array));

        Console.WriteLine("Array di numeri fornito invariato: ");
        StampaArray(array);

        Console.WriteLine($"Somma di tutti i numeri nell'array: {sommaElementiArray(array)}");

        Console.WriteLine($"Somma di tutti i numeri dell'array elevati al quadrato: {sommaElementiArray(ElevaArrayAlQuadrato(array))}");

        void StampaArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        int Quadrato(int numero)
        {
            int numQuadrato = numero * numero;
            return numQuadrato;
        }

        int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = Quadrato(array[i]);
            }
            return newArray;
        }

        int sommaElementiArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}

