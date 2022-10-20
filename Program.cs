/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/

int[] CreatParse(string stringArr)
{
    stringArr = stringArr.Replace(" ", "");
    int[] arr = stringArr.Split(',').Select(int.Parse).ToArray();
    return arr;
}

void PrintArray(string stringArr)
{
    Console.Write("[{0}]", string.Join(", ", CreatParse(stringArr)));
}

Console.WriteLine($"Введите массив через запятую: ");
string stringArr = (Console.ReadLine() ?? "");

PrintArray(stringArr);
