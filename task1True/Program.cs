Console.Clear();

Console.WriteLine("Привет, введи количество элементов в массиве:");
int a = Convert.ToInt32(Console.ReadLine());
string[] NewArr = new string[a];

void FillArray(string[] mass) //заполнить массив вводом
{
    int length = mass.Length;
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Введи {i + 1} элемент массива");
            mass[i] = Console.ReadLine();
        }
    }
}

void PrintArray(string[] array) // печать массива
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
        {
            Console.Write($"[{array[i]}], ");
        }
        else
        {
            Console.Write($"[{array[i]}]");
        }
    }
}

int checkqtyelements(string[] array) // выяснить количество элементов массива <=3
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        int strLen = array[i].Length;
        if (strLen <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArrElements(string[] array)
{
    string[] ArrElements = new string[checkqtyelements(array)];
    int length = array.Length;
    {
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            int qtyEl = array[i].Length;
            if (qtyEl <= 3)
            {
                ArrElements[count] = array[i];
                count++;
            }
        }
        return ArrElements;
    }
}

FillArray(NewArr);
Console.WriteLine("Первоначальный массив:");
PrintArray(NewArr);
Console.WriteLine();
checkqtyelements(NewArr);
Console.WriteLine("Массив с кол-вом элементов <= 3");
PrintArray(NewArrElements(NewArr));
