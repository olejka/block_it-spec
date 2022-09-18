// string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array1 = new string[4] {"1234", "1567", "2", "computer science"};
string[] array2 = new string[array1.Length];
int count = 0;
void SecondArrayWithIF(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);