//метод заполнения массива нулями и вывод его на экран

int[] mass = new int[8];

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(mass);

//заполнение массива рандомными от 10 до 10

void FillArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine();
}

//метод поиска числа в одномерном массиве
void SearchInt(int[] array)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int length = array.Length;
    int search = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] == a)
        {
            search++;
        }
    }
    if (search > 0)
    {
        Console.WriteLine($"в этом массиве есть искомое число и оно встречается {search} раз");
    }
    else
    {
        Console.WriteLine("нет, искомого числа нет :(");
    }
}

// метод создания и вывода нового двум массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод генерации чисел в заданном масиве
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец 
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 5];

//создание массива + вывод =>заполнение => вывод результата

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


//создание массива с указанием колва строк и столбцов
Console.WriteLine("Введите количество строк массива:");
int sizeLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int sizeColumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[sizeLine, sizeColumn];


// ввод чисел через " пробел " 
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

//создание массива с указанием его размера и вводом элементов через пробел

Console.WriteLine("Введите целое значение — размер массива");
int size = int.Parse(Console.ReadLine());               // спрашиваем длину массива у пользователя
int[] array = new int[size];                            // объявляем массив на size элементов
for (int i=0; i < array.Length; i++) 
    {                  // проходим весь массив от 0 до size - 1
    Console.WriteLine("Введите целое значение — элемент массива");
    array[i] = int.Parse(Console.ReadLine());            // в i-й элемент запрашиваем значение
    }



//Перевернуть строку ! 
string s = "Привет, мир!";           // есть строка
char[] sReverse = s.ToCharArray();   // создаем массив char 
Array.Reverse(sReverse);             // переворачиваем массив
s = new string(sReverse);            // задаем строку из массива заново . ps. проще сразу вкидывать 
                                     //в массив значения(если известно колво элементов)


//метод сортировки по убыванию двумерного массива
void SelectionSort(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])           //по убыванию(замена знака если что)
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}