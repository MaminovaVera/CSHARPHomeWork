// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}
void SequenceCubes(int num)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.Write(i * i * i + "  ");
    }

}
int num = Prompt($"Введите число  >");
System.Console.WriteLine($"Таблица кубов от 1 до {num}");
SequenceCubes(num);