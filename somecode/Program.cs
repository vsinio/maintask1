// hello, test fold
int [] arr = new int[5];

int checkqty(int[] array)
{
    int lengtharr = array.Length;
    int count = 0;
    for (int i = 0; i < lengtharr; i++)
    {
        int strLen = array[i].Length;
        if (strLen <= 3)
        {
            count++;
        }
    return count;
    }

}

Console.Write(checkqty(arr));