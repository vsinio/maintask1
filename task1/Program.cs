Console.Clear();

Console.WriteLine("Привет, введи количество элементов в массиве:");
int a = Convert.ToInt32(Console.ReadLine());
string[] NewArr = new string[a];



void FillArray(string[] mass) 
{
    int length = mass.Length;
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Введи {i+1} элемент массива");
            mass[i] = Console.ReadLine();
        }
    }
}

void PrintArray(string[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (i< length-1)
        {
            Console.Write($"[{array[i]}], ");
        }
        else 
        {
            Console.Write($"[{array[i]}]");
        }
        
    }
}

void checkqty(string[] array)
{
    int lengtharr = array.Length;

    for (int i = 0; i < lengtharr; i++)
    {
        int strLen = array[i].Length;
        if (strLen <= 3)
        {
            Console.Write($"[{array[i]}]");
        }
    }

}



FillArray(NewArr);
Console.WriteLine("Заданный массив:");
PrintArray(NewArr);
Console.WriteLine();
Console.WriteLine("Массив с 3 или меньшим кол-вом элементов:");
checkqty(NewArr);

