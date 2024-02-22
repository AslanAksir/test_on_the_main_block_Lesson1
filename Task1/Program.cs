// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

int anyNumberInput() //Ввод числа с консоли. Проверка представлена ли вводимая строка числом.
{
    while (true)
    {
        Console.WriteLine("Введите натуральное число");
        string inputString = Console.ReadLine()!;

        for (int i = 0; i < inputString.Length; i++)
        {
            if (Convert.ToInt32(inputString[i]) > Convert.ToInt32('9') || Convert.ToInt32(inputString[i]) < Convert.ToInt32('1'))
            {
                break;
            }
            if (i == inputString.Length - 1)
            {
                return Convert.ToInt32(inputString); ;
            }
        }

    }
}



string[] CreateDifferenceLengthStringArray(int arraySize, int minStringSize, int maxStringSize, string stringSource)
{
    string[] array = new string[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        int RandomStrinSize = Convert.ToInt32(rnd.Next(minStringSize, maxStringSize + 1));
        for (int j = 0; j < RandomStrinSize; j++)
        {
            int indexStringSource = Convert.ToInt32(rnd.Next(0, stringSource.Length));
            array[i] += stringSource[indexStringSource];
        }
    }
    return array;
}

//Вывод на печать массива строк
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    // Console.WriteLine();
}

//Вычисление количества строк в массиве длина которых меньше либо равна 3
int amountMemberArrayLessThanThree(string[] array)
{
    int k = 0;
    int Criteria = 3;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= Criteria)
            k = k + 1;
    return k;

}

//Формирование массива строк длина которых меньше либо равна 3
string[] arrayFiltred(string[] array, int k)
{
    string[] arrayFF = new string[1];
    arrayFF[0] = "В массиве нет строк длины меньше либо равно 3";
    if (k == 0)
    {
        return arrayFF;
    }
    string[] arrayF = new string[k];

    int Criteria = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Criteria)
        {
            arrayF[j] = array[i];
            j = j + 1;
        }

    }
    return arrayF;
}

int inputArrayMaxStringSize(int minStringSize)
{
    int MaxStringSize = minStringSize - 1;
    while (minStringSize > MaxStringSize)
    {
        Console.WriteLine("Введите МАКСИМАЛЬНО возможную длину строки больше либо равной МИНИМАЛЬНОЙ длине");
        MaxStringSize = anyNumberInput();
        Console.WriteLine($"Вы ввели число {MaxStringSize}");

    }
    return MaxStringSize;
}

//Main program

string stringSource = "1234567890qwertyuiop[]\asdfghjkl;'zxcvbnm,./!@#$%^&*()_+-=~`"; /* Строка символов из которых случайным образом формируется 
массив строк для задачи */
Console.WriteLine("Введите размер массива строк"); int arraySize = anyNumberInput();
Console.WriteLine("Введите МИНИМАЛЬНО возможную длину строки"); int minStringSize = anyNumberInput();
int maxStringSize = inputArrayMaxStringSize(minStringSize); //Введение максимально возможной длины строки

string[] stringArray = CreateDifferenceLengthStringArray(arraySize, minStringSize, maxStringSize, stringSource);/*Создание
произвольного массива с заданными значениями размера массива максимальной и минимальной длин строк в массиве*/
Console.WriteLine();
PrintArray(stringArray); // Вывод массива на консоль 
Console.WriteLine($" Первоначальный массив строк");
// int arrayFiltredStringAmount = amountMemberArrayLessThanThree(array); //Вычисление количества строк в массиве длины меньше либо равной 3
int arrayFiltredStringAmount = amountMemberArrayLessThanThree(stringArray); //Вычисление количества строк в массиве длины меньше либо равной 3
string[] arrayF = arrayFiltred(stringArray, arrayFiltredStringAmount); //Получение искомого массива, содержащего строки длины менее либо равно 3
PrintArray(arrayF); // Вывод искомого массива на печать
Console.WriteLine($" Строки массива, длина которых меньше либо равна 3");