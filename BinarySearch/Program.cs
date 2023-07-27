using System;

int TwoCrystallBall(bool[] breaks)
{
    var jmpAmount =(int) Math.Floor(Math.Sqrt(breaks.Length)) ;

    int i = jmpAmount;
    for (; i < breaks.Length; i += jmpAmount)
    {
        if (breaks[i])
        {
            break;
        }
    }
    i -= jmpAmount;
    for (int j = 0; j <= jmpAmount && i<breaks.Length;++i, ++j)
    {
        if (breaks[i])
        {
            return i;
        }
    }


    return -1;
}
Utility.TimeCalculator.Calculate(() =>
{
    Console.Write(TwoCrystallBall(BinarySearch.Data.BooleanData)+"\n");
},"Binary Search");
