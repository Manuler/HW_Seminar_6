using System.Security.Cryptography.X509Certificates;

namespace Task_1
{
    internal class Program
    {
        public static int NumMoreZero(int num)
        {
            int count = 0;
            int temp;
            for (int i = 1; i < num+1; i++)
            {
                Console.WriteLine($"Введите {i}е число");
                temp = Convert.ToInt32((Console.ReadLine()));
                if (temp > 0) { count++; }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цифр: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество чисел больше нуля: " + NumMoreZero(num));
        }
    }
}