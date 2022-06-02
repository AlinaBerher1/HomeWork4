class Task5
{
    /* Задание 5
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке,
а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение,
что такого слова нет.*/
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Пожалуйста введите слово, которое требуется перевести");
        string word = Console.ReadLine();

        if (word == "солнце")
        {
            Console.WriteLine("sun");
        }
        else if (word == "дождь")
        {
            Console.WriteLine("rain");
        }
        else if (word == "снег")
        {
            Console.WriteLine("snow");
        }
        else if (word == "мороз")
        {
            Console.WriteLine("frost");
        }
        else if (word == "жарко")
        {
            Console.WriteLine("hot");
        }
        else if (word == "холодно")
        {
            Console.WriteLine("cold");
        }
        else if (word == "туман")
        {
            Console.WriteLine("fog");
        }
        else if (word == "гроза")
        {
            Console.WriteLine("storm");
        }
        else if (word == "ветер")
        {
            Console.WriteLine("wind");
        }
        else if (word == "град")
        {
            Console.WriteLine("hail");
        }
        else
        {
            Console.WriteLine("Нет перевода для данного слова");
        }
    }
}