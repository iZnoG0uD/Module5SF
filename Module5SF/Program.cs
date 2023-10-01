namespace Module5SF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            User.Dishes = new string[5];

            Console.Write("\tЗдравствуйте! Введите Ваше имя: ");
            User.Name = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\tВведите Ваше любимое блюдо: ");
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}