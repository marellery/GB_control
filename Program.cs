string[] array = new string[6] { "раз", "пять", "восемь", "два", "шесть", "три" };

Console.WriteLine("Первоначальный массив");
Console.WriteLine(String.Join("\t", array));
Console.WriteLine();

string[] resultArray = new string[array.Length];



void ArrayLess3(string[] array, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
}


ArrayLess3(array, resultArray);

Console.WriteLine("Итоговый массив");
Console.WriteLine(String.Join("\t", resultArray));
