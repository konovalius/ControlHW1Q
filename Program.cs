string[] Array = { "west", "go", "gz5", "door", ":-)" };
string[] FilterArray = new string [Array.Length];

FilteringArray(Array, FilterArray);
PrintArray(FilterArray);

void FilteringArray(string[] FirstArray, string[] SecondArray)
{
    int k = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[k] = FirstArray[i];
            k++;
        }
    }
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
    Console.WriteLine();
}