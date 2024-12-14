using System;

class Sana03
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть розмір масиву (N): ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        double sumNegative = 0;
        double minElement = double.MaxValue;
        int maxIndex = 0;
        double maxAbs = 0;
        int sumPositiveIndices = 0;
        int integerCount = 0;

        for (int i = 0; i < n; i++)
        {
            double element = array[i];


            if (element < 0)
            {
                sumNegative += element;
            }

           
            if (element < minElement)
            {
                minElement = element;
            }

            
            if (element > array[maxIndex])
            {
                maxIndex = i;
            }

          
            if (Math.Abs(element) > maxAbs)
            {
                maxAbs = Math.Abs(element);
            }

            
            if (element > 0)
            {
                sumPositiveIndices += i;
            }

          
            if (element == Math.Floor(element))
            {
                integerCount++;
            }
        }

        
        Console.WriteLine("Сума від'ємних елементів: " + sumNegative);
        Console.WriteLine("Мінімальний елемент: " + minElement);
        Console.WriteLine("Індекс максимального елемента: " + maxIndex);
        Console.WriteLine("Максимальний за модулем елемент: " + maxAbs);
        Console.WriteLine("Сума індексів додатних елементів: " + sumPositiveIndices);
        Console.WriteLine("Кількість цілих чисел у масиві: " + integerCount);
    }
}
