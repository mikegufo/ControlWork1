string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array1.Length;)
    {
        Console.Write("[" + string.Join(", ", array) + "]");
        break;
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);