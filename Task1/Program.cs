// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}
int ReverseNumber(int numb)
{
    int res = 0;
    while (numb > 0)
    {
        int temp = numb % 10;
        numb = numb / 10;
        res = res * 10 + temp;
    };
    return res;
}
bool CheckPalindrom(int value1, int value2)
{

    if (value1 == value2)
    {
        return true;
    }
    return false;
}
int numb1 = Prompt("Введите число >");
int numb2 = ReverseNumber(numb1);

bool IsPalindrome = CheckPalindrom(numb1, numb2);
if (IsPalindrome)
{
    System.Console.WriteLine($"Число {numb1} -  палиндром");
}
else
{
    System.Console.WriteLine($"Число {numb1} - не палиндром");
}
