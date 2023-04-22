void FillArray(int[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}

int GetNegativeSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sum += numbers[i];
    }
    return sum;
}

void Changenumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

void Findnumbers(int[] numbers, int num)
{
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] == num)
    {
        flag = true;
    }
  }
  if (flag) Console.WriteLine($"Число найдено. Оно стоит на {index + 1} позиции.");
  else Console.WriteLine("Такого числа нет");
}

//Задача 31: Задайте массив из 12 элементов, заполненный случайными
//числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// void Task0()
// {
//     int size = 10;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     PrintArray(numbers);
//     GetPositiveSum(numbers);
//     GetNegativeSum(numbers);
//     Console.WriteLine($"Сумма положительных элементов равна {GetPositiveSum(numbers)}");
//     Console.WriteLine($"Сумма отрицательных элементов равна {GetNegativeSum(numbers)}");
// }

//     методы
// процедуры (не возвращают значение)   функции (возвращают значение)

// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void Task1()
// {
//     int size = 10;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     PrintArray(numbers);
//     Changenumbers(numbers);
//     PrintArray(numbers);
// }
// Task1();

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void Task2()
 {
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите число: ");
    int currentNumber = Convert.ToInt32(Console.ReadLine());
    Findnumbers(numbers, currentNumber);
 }
 Task2();