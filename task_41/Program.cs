// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите несколько чисел через пробел: ");
int[] array = GetArray(Console.ReadLine()!);
int positiveNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumber++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {positiveNumber}");


int[] GetArray(string input)
{
    int count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] array = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ' ')
        {
        if (i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        array[index] = Convert.ToInt32(temp);
        index++;
    }
    return array;
}