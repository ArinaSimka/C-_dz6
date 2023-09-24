// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int m = GetNumber("сколько чисел вы хотите проверить?");
int[] GetArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = GetNumber("");
    }
    return array;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { Console.Write($"   {arr[i]} "); }
    Console.WriteLine();
}
int[] array = GetArray(m);
Print(array);

int Pol(int[] arr)
{
    int rez = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
          // Console.WriteLine($"чисто{arr[i]}>0");
            rez = rez + 1;
        }
    }
    return rez;
}
Console.Write($"Количество введенных чисел больше 0: {Pol(array)} "); 



