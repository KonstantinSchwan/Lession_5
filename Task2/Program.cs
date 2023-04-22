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
    int index = -1;
    for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] == num)
    {
        flag = true;
        index = i;
    }
  }
  if (flag) Console.WriteLine($"Число найдено. Оно стоит на {index + 1} позиции.");
  else Console.WriteLine("Такого числа нет");
}


// Задача 32:   Напишите программу замены элементов массива: положительные элементы 
//              замените на соответствующие отрицательные, и наоборот.
//              [-4, -8, 8, 2] -> [4, 8, -8, -2]

 void Task1()
 {
     int size = 10;
     int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Changenumbers(numbers);
    PrintArray(numbers);
 }
 Task1();
