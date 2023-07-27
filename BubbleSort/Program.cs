
Utility.TimeCalculator.Calculate(() =>
{
    Sort(BubbleSort.Data.arr);
},"BubbleSort");

//print purpose
// sorted.ToList().ForEach(Console.WriteLine);

void Sort(int[] arr)
{
    int length = arr.Length;
    for (int i = 0;  i< length; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                //swap
                (arr[j],arr[j + 1]) = (arr[j + 1],arr[j]);
                /*
                int tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;*/
            }
        }
    }

    // return arr;
}
