class Task3
{
    /* Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу определения, попадает ли указанное пользователем число
от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков,
то выводится соответствующее сообщение.*/

    static void Main()
    {
        {
            Console.WriteLine("Please enter the number");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number >= 0 && number <=14)
            {
                Console.WriteLine("You entered the number [0 - 14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("You entered the number [15 - 35]");
            }
            else if (number >=36 && number <= 50)
            {
                Console.WriteLine("You entered the number [36 - 50]");
            }
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("You entered the number [50 - 100]");
            }
            else
            {
                Console.WriteLine("You entered incorrect number");
            }
        }
    }
}
