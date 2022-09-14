// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] GetRandomArray(int size) // метод создает, заполняет случайными числами от 100 до 999 и возвращает массив заданной длины
{
    int [] array = new int [size];
    for (int  i = 0 ; i < size; i++)
    {
        array [i] =  new Random().Next(100, 1000);
    }
    return array;
}

int ShowEevenNnumbers(int [] array) // метод, считающий количество четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[ i ]%2 == 0)
        {
            count = count+1;
        }
    }
    System.Console.WriteLine( "массив, заполненный случайными целыми трехзначными числами:");
    for (int i = 0; i < array.Length; i++) System.Console.Write($" {array[i]} "); System.Console.WriteLine("");
    return count;
}


System.Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine("Input integer array size");
int arraysize =Convert.ToInt32(Console.ReadLine());
int [] array = GetRandomArray(arraysize);
System.Console.WriteLine(" ");
System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine($"количество чётных чисел в массиве =  {ShowEevenNnumbers(array)}");
System.Console.WriteLine(" ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int GetSumOnOddPositions (int []  array) // метод для подсчета суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i=1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}
// Массив задается в предыдущем коде в задаче 34. для задания массива используется уже реализованный метод GetRandomArray(arraysize)
System.Console.WriteLine("Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
//[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0");
System.Console.WriteLine($"сумма элементов, стоящих на нечётных позициях =  {GetSumOnOddPositions(array)}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3    [6 7 3 6] -> 36 21

// Массив задается в предыдущем коде в задаче 34. для задания массива используется уже реализованный метод GetRandomArray(arraysize)

// задача решена без нового метода, решение в теле
System.Console.WriteLine(" ");
System.Console.WriteLine("Задача 37 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");

int newArraySize = 0;

if (array.Length % 2 == 0)    newArraySize = array.Length/2;
else                          newArraySize = array.Length/2+1;

int [] newArray =new int[newArraySize];

for (int n=0; n < array.Length / 2 ; n++)
{
    newArray[n] = array[n]*array[array.Length - n-1];
    System.Console.WriteLine($"пара чисел: {array[n]}  {array[array.Length-n - 1]}  произведение = {newArray[n]}" ); // вывод пары чисел для наглядности, можно удалить
}

if (array.Length % 2 != 0) newArray[newArraySize -1] = array [array.Length / 2]; // задание среднего элемента равного среднему исходного массива в случае, если размер исходного массива нечетный

System.Console.WriteLine($"размер нового массива   {newArraySize}: ");
for (int i = 0; i < newArraySize; i++) System.Console.Write($" {newArray[i]} "); 


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
// в 1-й задаче у нас уже задан массив вещественных (целые положительные случайные трехзначные ) чисел array  с заданной длиной
System.Console.WriteLine(" ");
System.Console.WriteLine(" ");
System.Console.WriteLine("Задача 38:  Найдите разницу между максимальным и минимальным элементов массива.");
int min = array[0];
int max = array[0];
for ( int i=1 ; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
System.Console.WriteLine($" min = {min}, max={max}   max-min= {max-min}");




