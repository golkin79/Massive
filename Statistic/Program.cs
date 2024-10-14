using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("\nДальнейшие операции:\n" +
                                "1. Вывести весь массив\n" +
                                "2. Статистика массива\n" +
                                "3. Сортировка массива\n" +
                                "4. Поиск по массиву\n" +
                                "5. Выход");

                int oper = int.Parse(Console.ReadLine());

                switch (oper)
                {
                    case 1:
                        Console.WriteLine("\nЧисла в массиве:\n" + String.Join(", ", numbers) + "\n" );
                        break;

                    case 2:
                        Console.WriteLine($"\nДлина массива: { numbers.Length}");
                        Console.WriteLine($"Сумма всех чисел массива: {MassSum(numbers)}");
                        Console.WriteLine($"Максимальное значение в массиве: {MassMax(numbers)}");
                        Console.WriteLine($"Минимальное значение в массиве: {MassMin(numbers)}");
                        break;

                    case 3:
                        
                        Console.Write("\n1. От большего к меньшему\n" +
                                "2. От меньшего к большому\n" +
                                "Выберите порядок сортировки: ");
                        string sort = Console.ReadLine();

                        if (sort == "1")
                        {
                            Array.Sort(numbers);
                            Array.Reverse(numbers);
                            Console.WriteLine("\nЧисла в порядке убывания:\n" + String.Join(", ", numbers) + "\n");
                        }
                        else if (sort == "2")
                        {
                            Array.Sort(numbers);
                            Console.WriteLine("\nЧисла в порядке возрастания:\n" + String.Join(", ", numbers) + "\n");
                        }
                        break;

                    case 4:
                        int num;
                        int numT;
                        Console.Write("\n1. Больше\n" +
                                "2. Меньше\n" +
                                "3. Равно\n" +
                                "4. Диапозон\n" +
                                "Выберите параметр поиска: ");
                        int search = int.Parse(Console.ReadLine());

                        if (search == 1)
                        {
                            Console.Write("Числа больше чем ");
                            num = int.Parse(Console.ReadLine());

                            string result = "";
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] > num)
                                {
                                    if (result != "")
                                    {
                                        result += ", ";
                                    }
                                    result += numbers[i];
                                }
                            }
                            Console.WriteLine(result);
                        }

                        else if (search == 2)
                        {
                            Console.Write("Числа меньше чем ");
                            num = int.Parse(Console.ReadLine());

                            string result = "";
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] < num)
                                {
                                    if (result != "")
                                    {
                                        result += ", ";
                                    }
                                    result += numbers[i];
                                }
                            }
                            Console.WriteLine(result);
                        }

                        else if (search == 3)
                        {
                            Console.Write("Числа равные ");
                            num = int.Parse(Console.ReadLine());

                            string result = "";
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] == num)
                                {
                                    if (result != "")
                                    {
                                        result += ", ";
                                    }
                                    result += numbers[i];
                                }
                            }
                            Console.WriteLine(result);
                        }
                        
                        else if (search == 4)
                        {
                            Console.Write("Числа больше чем ");
                            num = int.Parse(Console.ReadLine());

                            Console.Write("И числа меньше чем ");
                            numT = int.Parse(Console.ReadLine());

                            string result = "";
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if ((numbers[i] > num) && (numbers[i] < numT))
                                {
                                    if (result != "")
                                    {
                                        result += ", ";
                                    }
                                    result += numbers[i];
                                }
                            }
                            Console.WriteLine(result);
                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }
        }

        static int MassSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static int MassMax(int[] numbers)
        {
            return numbers.OrderByDescending(x => x).First();
        }

        static int MassMin(int[] numbers)
        {
            return numbers.OrderByDescending(x => x).Last();
        }
    }
}
