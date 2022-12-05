namespace Pr_13._n1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[20, 20];
            int i, j, k, max = 0, str = 0, stl = 0;
            Random rnd = new Random();
            while (true)
            {
                 Console.Write("Размерность матрицы: ");
                 k = int.Parse(Console.ReadLine());
                    for (i = 1; i < k + 1; i++)
                    {
                        for (j = 1; j < k + 1; j++)
                        {
                            mass[i, j] = rnd.Next(100 - 8);
                            Console.Write(mass[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    for (i = 1; i < k + 1; i++)
                    {
                        for (j = 1; j < k + 1; j++)
                        {
                            if (mass[i, j] > max)
                            {
                                max = mass[i, j];
                                str = i;
                                stl = j;
                            }
                        }
                    }
                    Console.WriteLine("Строка: {0} \nСтолбец: {1} \nМаксимальный элемент: {2}", str, stl, max);
                    return;
            }
        }
    }
}