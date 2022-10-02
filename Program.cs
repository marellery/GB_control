int size = 8;
int [] array = new int [size];

Console.WriteLine("Первоначальный массив");
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10000);
    Console.Write(array[i] + "\t");
}
Console.WriteLine();




