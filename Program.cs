string[] Array = new { "west", "go", "gz5", "do", ":-)" };
string[] FilterArray = new string[];


void FilteringArray(string[] FirstArray, string[] SecondArray)
{
    int k = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[k]=FirstArray[i];
            k++;
        }
    }
}