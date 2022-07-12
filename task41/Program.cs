/* Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Сколько чисел Вы хотите ввести?");
int numberM = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] numbers = new int[numberM];
for (int i = 0; i < numberM; i++)
{
    Console.WriteLine("Введите число " + (i+1));
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0) count++;
}
Console.WriteLine();
Console.WriteLine("Введено чисел больше нуля: " + count);
