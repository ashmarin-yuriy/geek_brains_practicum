// Напишите программу, которая на вход
// принимает число и выдает его квадрат (число умноженное на само себя).

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

//Квадрат входного числа
int result = number * number;

// Вывод результата
Console.WriteLine($"Квадрат входного числа: {result}");