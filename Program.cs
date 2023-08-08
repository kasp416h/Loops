using System.Diagnostics;

namespace Version_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tabel();
            TheBiggestNumber(new int[] {190, 291, 145, 209, 280, 200});

            Console.WriteLine(TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 200 }));

            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));

            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));

            SieveOfEratosthenes(30).ForEach(prime => Console.Write($"{prime} "));

            Console.WriteLine();

            Console.WriteLine(ExtractString("++##--##++"));

            Console.WriteLine(FullSequenceOfLetters("ds"));

            Console.WriteLine(SumAndAverage(11, 66));

            DrawTriangle();

            Console.WriteLine(ToThePowerOf(5, 5));
        }

        static void Tabel()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($"{i * j} ");
                    }
                    else
                    {
                        Console.Write(i * j);
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        static int TheBiggestNumber(int[] numbers)
        {
            int number = numbers[0];
            foreach (int i in numbers)
            {
                if (i > number) number = i;
            }

            return number;
        }

        static int Two7sNextToEachOther(int[] numbers)
        {
            int numberOfSevens = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 7 && numbers[i - 1] == 7)
                {
                    numberOfSevens++;
                }
            }
            return numberOfSevens;
        }

        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] - 1 == numbers[i - 1] && numbers[i + 1] - 1 == numbers[i])
                {
                    return true;
                }
            }
            return false;
        }

        static List<int> SieveOfEratosthenes(int value)
        {
            List<int> result = new List<int>();

            if (value > 3)
            {
                for (int index = 2; index < value; index++)
                {
                    bool isPrime = true;
                    for (int modulo = 2; modulo <= 7; modulo++)
                    { 
                        if (index % modulo == 0 && index != modulo)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        result.Add(index);
                    }
                }
            }

            return result;
        }

        static string ExtractString(string input)
        {
            string[] SplitInput = input.Split("##");
            if (SplitInput.Length < 3) { return "empty string"; }

            return SplitInput[1];
        }

        static string FullSequenceOfLetters(string input)
        {
            char[] ArrayInput = input.ToCharArray();
            string result = "";

            for (char letter = ArrayInput[0]; letter <= ArrayInput[1]; letter++)
            {
                result += letter;
            }

            return result;
        }

        static string SumAndAverage(int firstNumber, int secondNumber)
        {
            int sum = 0;
            float takes = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum += i;
                takes++;
            }

            return $"Sum: {sum}, Average: {sum / takes}";
        }

        static void DrawTriangle()
        {
            int triangleLength = 19;
            int takes = 10;

            for (int i = 0; i <= takes; i++)
            {
                int starsLength = i * 2 - 1;
                string stars = "";

                for (int star = 0; star < starsLength; star++)
                {
                    stars += "*";
                }

                int spaceLength = ((triangleLength - starsLength) / 2) - 1;
                string space = "";

                for (int x = 0; x <= spaceLength; x++)
                {
                    space += " ";
                }

                Console.WriteLine(space + stars + space);
            }
        }

        static double ToThePowerOf(int firstValue, int secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            return result;
        }
    }
}