using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions;

class Program
{
    static void Main(string[] args)
    {
        int userNum;
        Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
        while (int.TryParse(Console.ReadLine(), out userNum) == false)
        {
            Console.WriteLine("Sintassi errata. Insrisci un numero");
        }
        int[] array = new int[userNum];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Inserisci i numeri: {i + 1}/{array.Length}");
            while (int.TryParse(Console.ReadLine(), out array[i]) == false)
            {
                Console.WriteLine($"Sintassi errata. Insrisci un numero: {i + 1}/{array.Length}");
            }
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






        // ESERCIZIO AGGIUNTIVO DEL POMERIGGIO

        double circleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        double userRadius;
        Console.WriteLine("Inserisci il raggio per calcolare l'area del cerchio");
        while (double.TryParse(Console.ReadLine(), out userRadius) == false)
        {
            Console.WriteLine("Sintassi errata. Inserisci un numero");
        }
        Console.WriteLine($"L'area del cerchio è: {circleArea(userRadius)}");



        double convertCelsiusToFarenheit(double celsius)
        {
            double farenheit = (celsius * (9 / 5)) + 32;
            return farenheit;
        }
        double celsius;
        Console.WriteLine("Inserisci i gradi Celsius che vuoi convertire in Farenheit");
        while (double.TryParse(Console.ReadLine(), out celsius) == false)
        {
            Console.WriteLine("Sintassi errata. Inserisci un numero");
        }
        Console.WriteLine($"{convertCelsiusToFarenheit(celsius)}");



        string primeNumber(int num)
        {
            if (num % 2 == 0)
            {
                return "non è un numero primo";
            }
            else
            {
                return "è un numero primo";
            }
        }
        Console.WriteLine("Inserisci un numero per vedere se è un numero primo");
        int num;
        while (int.TryParse(Console.ReadLine(), out num) == false)
        {
            Console.WriteLine("Sintassi errata. Inserisci un numero valido");
        }
        Console.WriteLine($"Il numero che hai inserito {primeNumber(num)}");



        string chaining(string a, string b, string character)
        {
            string chain = a + character + b;
            return chain;
        }
        Console.WriteLine("Inserisci le due parole da concatenare");
        Console.WriteLine("Parola 1");
        string? word1 = Console.ReadLine();
        Console.WriteLine("Parola 2");
        string? word2 = Console.ReadLine();
        Console.WriteLine("Inserisci un carattere per la concatenazione");
        string? character = Console.ReadLine();
        Console.WriteLine($"Ecco cosa viene fuori: {chaining(word1, word2, character)}");



        string palindrome(string a)
        {
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            string reverseWord = new string(b);
            if (Equals(reverseWord, a))
            {
                return "La tua parola è palindroma";
            }
            else
            {
                return "La tua parola non è palindroma";
            }
        }
        Console.WriteLine("Inserisci una parola per vedere se è palindroma");
        string? word = Console.ReadLine();
        Console.WriteLine(palindrome(word));
    }
}

