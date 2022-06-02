class Task2
{
    /* Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу – консольный калькулятор.
Создайте две переменные с именами operand1 и operand2.
Задайте переменным некоторые произвольные значения.
Предложите пользователю ввести знак арифметической операции.
Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
Выведите на экран результат выполнения арифметической операции.
В случае использования операции деления, организуйте проверку попытки деления на ноль.
И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.*/

    static void Main()
    {
        {
            Console.WriteLine("Please enter the first number");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the sign of an arithmetic operation");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        double sum = operand1 + operand2;
                        Console.WriteLine(sum);
                        break;
                    }
                case "-":
                    {
                        double difference = operand1 - operand2;
                        Console.WriteLine(difference);
                        break;
                    }
                case "*":
                    {
                        double product = operand1 * operand2;
                        Console.WriteLine(product);
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                            Console.WriteLine("Please restart the calculator");
                        }
                        else
                        {
                            double quotient = operand1 / operand2;
                            Console.WriteLine(quotient);
                        }
                        break;
                    }
                case "%":
                    {
                        double remainder = operand1 % operand2;
                        Console.WriteLine(remainder);
                        break;
                    }
                
            }
        }
    }
}
