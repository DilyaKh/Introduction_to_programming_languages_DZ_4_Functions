// -----------------------------------------------------------------------
// ЗАДАЧА 1

// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

Console.Clear();

// Функция возвращает True, если пользователь ввёл число, 
// сумма цифр которого чётная, иначе - False:
bool CheckIfSumIsEven(int N)
{
    int DigitSum = 0; 

    while (N > 0)
    {
        DigitSum += N % 10;
        N /= 10;
    }

    if (DigitSum % 2 == 0)
        return true;
    
    return false;
}


// Функция возвращает True если пользователь ввёл символ ‘q’
// или пользователь ввёл число, сумма цифр которого чётная, иначе - False:
bool CheckInput(string x)
{
    if (x == "q" || CheckIfSumIsEven(Convert.ToInt32(x)))
        return true;
    
    return false;
}


// Функция запрашивает ввод целого числа, 
// и если пользователь ввёл символ ‘q’ или пользователь ввёл число, 
// сумма цифр которого чётная, выводится сообщение "STOP",
// и работа программы завершается:
void ReadNumbers()
{
    while (true)
        {
            Console.Write("Введите целое число: ");
            string Input = Console.ReadLine();

            if (CheckInput(Input) == true)
            {
                Console.Write("STOP");
                break;
            }
        }
}


// Вызов функции ReadNumbers():
ReadNumbers();

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 2

// Задайте массив, заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

Console.Clear();

// Функция заполняет массив случайными трёхзначными числами 
// (в качестве аргумента - массив):
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); //[100;999]
}


// Функция возвращает True если число чётное, иначе - False:
bool CheckIsEven(int x)
{
    if (x % 2 == 0)
        return true;
    else    
        return false;
}


// Функция выводит количество чётных чисел в массиве:
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CheckIsEven(array[i]))
            count ++;
    return count;
}


Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

// Вызовы функций InputArray() и ReleaseArray():
InputArray(array);
Console.WriteLine($"[{string.Join(" ", array)}] = > {ReleaseArray(array)}");

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 3

// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

Console.Clear();

// Функция задает массив, который заполняется 
// случайными числами (в качестве аргумента - массив):
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000); //[1;999]
}


// Функция задает массив, который заполняется 
// элементами из другого массива, но в обратном порядке:
void ReversedArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        // Меняем местами элементы
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

    Console.WriteLine($"[{string.Join(" ", array)}]");
}

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array2 = new int[n];

// Вызовы функций InputArray() и ReversedArray():
InputArray(array);

Console.WriteLine($"[{string.Join(" ", array)}] =>");

ReversedArray(array);
// // -----------------------------------------------------------------------
// // -----------------------------------------------------------------------