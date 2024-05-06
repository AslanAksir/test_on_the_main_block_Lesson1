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
            if (i == 0 && Convert.ToInt32(inputString[i]) <= Convert.ToInt32('0'))
                break;
            if (Convert.ToInt32(inputString[i]) > Convert.ToInt32('9') || Convert.ToInt32(inputString[i]) < Convert.ToInt32('0'))
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



string[] CreateDifferenceLengthStringArray(int arraySize, int minStringSize, int maxStringSize, string stringSource)//Создание случайного массива строк
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
int amountMemberArrayLessThanThree(string[] array, int Criteria)
{
    int k = 0;
    // int Criteria = 3;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= Criteria)
            k = k + 1;
    return k;

}

//Формирование массива строк длина которых меньше либо равна 3
string[] arrayFiltred(string[] array, int cond, int k)
{
    string[] arrayF = new string[k];
    if (k == 0)
    {
        Console.WriteLine("В массиве нет строк длины меньше либо равно 3");
        return arrayF;
    }

    // int Criteria = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= cond)
        {
            arrayF[j] = array[i];
            j = j + 1;
        }
        else
        {
            array[i] = String.Concat(Enumerable.Repeat(" ", array[i].Length));
        }
    }

    PrintArray(array); // Вывод искомого массива на печать
    Console.WriteLine($"Строки массива, длина которых меньше черырех");

    PrintArray(arrayF); // Вывод искомого массива на печать
    Console.WriteLine($"Строки массива, длина которых меньше либо равна 3");

    return arrayF;
}

int inputArrayMaxStringSize(int minStringSize)//Ввод максимального значения длины строк массива больше либо равного минимальному
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

string[] randomArrayBilding()//Построение  массива строк заданного размера со случаной длиной строк в заданных пределах
{
    string stringSource = "1234567890qwertyuiop[]\asdfghjkl;'zxcvbnm,./!@#$%^&*()_+-=~`"; /* Строка символов из которых 
    случайным образом формируется массив строк для задачи */
    Console.WriteLine("Введите размер массива строк"); int arraySize = anyNumberInput();
    Console.WriteLine("Введите МИНИМАЛЬНО возможную длину строки"); int minStringSize = anyNumberInput();
    int maxStringSize = inputArrayMaxStringSize(minStringSize); //Введение максимально возможной длины строки
    string[] stringArray = CreateDifferenceLengthStringArray(arraySize, minStringSize, maxStringSize, stringSource);/*Создание
     массива с заданными значениями размера массива и максимальной и минимальной длин строк в массиве*/
    Console.WriteLine();
    PrintArray(stringArray); // Вывод массива на консоль 
    Console.WriteLine($" Первоначальный массив строк");
    return stringArray;
}

string[] arrayFiltredBuilding(string[] stringArray, int cond)//Построение массива строк с длинной строк не более трех
{
    int arrayFiltredStringAmount = amountMemberArrayLessThanThree(stringArray, cond); //Вычисление количества строк в массиве длины меньше либо равной 3
    string[] arrayF = arrayFiltred(stringArray, cond, arrayFiltredStringAmount); //Получение искомого массива, содержащего строки длины менее либо равно 3
    // Console.WriteLine($"Строки массива, длина которых меньше либо равна 3");
    // PrintArray(arrayF); // Вывод искомого массива на печать
    return arrayF;
}

//Main program
string[] stringArray = randomArrayBilding();/*Построение случайного массива строк с заданными с консоли длиной массива и случайной
длиной строк из интеравала натуральных чисел*/
string[] arrayFiltredSizeLessThree = arrayFiltredBuilding(stringArray, 3);//Получение массива строк, длина который меньше либо равна 3


