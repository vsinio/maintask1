Console.WriteLine("Привет, введи количество элементов в массиве:");

int a = Convert.ToInt32(Console.ReadLine());
string[] NewArr = new string[a];



void FillArray(string[] mass) 
{
    int length = mass.Length;
    {
        for (int i = 0; i < length; i++)
        {
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

FillArray(NewArr);
PrintArray(NewArr);

