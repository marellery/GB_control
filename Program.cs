string[] array = new string[5] {"123", "23", "hello", "world", "res"};

Console.WriteLine("Первоначальный массив");
Console.WriteLine(String.Join("\t", array));
Console.WriteLine();

string[] resultArray = new string[array.Length];



void SecondArrayWithIF(string[] array, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        resultArray[count] = array[i];
        count++;
        }
    }
}



